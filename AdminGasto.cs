using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class AdminGasto : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public AdminGasto()
        {
            InitializeComponent();
        }

        private void AdminGasto_Load(object sender, EventArgs e)
        {
            //Carga la tabla cuando se abre el Form
            dataGridViewGastos.DataSource = Instancia_SQLite.CargarTablaGastos();

            //Formato de fecha de los dateTimePicker
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonCargarTablaGastos_Click(object sender, EventArgs e)
        {
            dataGridViewGastos.DataSource = Instancia_SQLite.CargarTablaGastos();

            //Borra el contenido de los textbox
            txtIDGasto.Clear();
            txtServicio.Clear();
            txtProveedor.Clear();
            //Resetea el dateTimePicker en la fecha del día
            dateTimePickerFecha.Value = DateTime.Now;
            txtCosto.Clear();

            txtIDGastoDelete.Clear();
        }

        private void txtIDGasto_TextChanged(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Gastos donde la columna IDGasto es igual al text box txtIDGasto.
            //Esto hace que inmediatamente que se escriba en el text box del IDGasto, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Gastos Where IDGasto = @IDGasto", Conexion);
            comando.Parameters.AddWithValue("@IDGasto", txtIDGasto.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtServicio.Text = registro["Servicio"].ToString();
                txtProveedor.Text = registro["Proveedor"].ToString();
                dateTimePickerFecha.Text = registro["Fecha"].ToString();
                txtCosto.Text = registro["Costo"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void btnGastoUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update Gastos Set Servicio=@Servicio, Proveedor=@Proveedor, Fecha=@Fecha, Costo=@Costo Where IDGasto = @IDGasto", Conexion);
                comando.Parameters.AddWithValue("@IDGasto", int.Parse(txtIDGasto.Text));
                comando.Parameters.AddWithValue("@Servicio", txtServicio.Text);
                comando.Parameters.AddWithValue("@Proveedor", txtProveedor.Text);
                comando.Parameters.AddWithValue("@Fecha", dateTimePickerFecha.Text);
                comando.Parameters.AddWithValue("@Costo", txtCosto.Text);

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Actualizados Correctamente!!", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Actualizar!!", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Update los textBox se limpian.
                txtIDGasto.Clear();
                txtServicio.Clear();
                txtProveedor.Clear();
                //Resetea el dateTimePickerFecha con la fecha actual.
                dateTimePickerFecha.Value = DateTime.Now;
                txtCosto.Clear();

                //Carga la tabla Ventas
                dataGridViewGastos.DataSource = Instancia_SQLite.CargarTablaGastos();

            }
            catch (Exception)
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }
        }

        private void btnGastoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Delete from Gastos Where IDGasto=@IDGasto", Conexion);
                comando.Parameters.AddWithValue("@IDGasto", int.Parse(txtIDGastoDelete.Text));
                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Registro Eliminado Correctamente!!", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Eliminar!!", "Error al Eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Detele del registro se limpia el textBox.
                txtIDGastoDelete.Clear();

                //Carga la tabla Ventas
                dataGridViewGastos.DataSource = Instancia_SQLite.CargarTablaGastos();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Escriba el ID del gasto que eliminará.");
            }
        }
    }
}
