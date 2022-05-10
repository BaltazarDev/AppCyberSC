using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class AdminReparacion : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public AdminReparacion()
        {
            InitializeComponent();
            //Agrega la fecha en el txtFModificacion.
            txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void AdminReparacion_Load(object sender, EventArgs e)
        {
            //Carga la tabla cuando se abre el Form
            dataGridViewReparaciones.DataSource = Instancia_SQLite.CargarTablaReparaciones();

            //Formato de fecha de los dateTimePicker
            dateTimePickerFRecepcion.Format = DateTimePickerFormat.Custom;
            dateTimePickerFRecepcion.CustomFormat = "yyyy-MM-dd";

            dateTimePickerFEntrega.Format = DateTimePickerFormat.Custom;
            dateTimePickerFEntrega.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonCargarTablaVentas_Click(object sender, EventArgs e)
        {
            dataGridViewReparaciones.DataSource = Instancia_SQLite.CargarTablaReparaciones();

            //Borra el contenido de los textbox
            txtIDRe.Clear();
            txtPropietario.Clear();
            maskedTxtCelular.Clear();
            txtEquipo.Clear();
            txtModelo.Clear();
            txtDescripcion.Clear();
            txtCostoR.Clear();
            txtGTotal.Clear();
            //Resetea el dateTimePicker en la fecha del día
            dateTimePickerFRecepcion.Value = DateTime.Now;
            dateTimePickerFEntrega.Value = DateTime.Now;

            txtIDReDelete.Clear();
        }

        private void txtIDRe_TextChanged(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Reparaciones donde la columna IDRe es igual al text box txtIDRe.
            //Esto hace que inmediatamente que se escriba en el text box del IDRe, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Reparaciones Where IDRe = @IDRe", Conexion);
            comando.Parameters.AddWithValue("@IDRe", txtIDRe.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtPropietario.Text = registro["Propietario"].ToString();
                maskedTxtCelular.Text = registro["Celular"].ToString();
                txtEquipo.Text = registro["Equipo"].ToString();
                txtModelo.Text = registro["Modelo"].ToString();
                txtDescripcion.Text = registro["Descripcion"].ToString();
                txtCostoR.Text = registro["CostoR"].ToString();
                txtGTotal.Text = registro["GTotal"].ToString();
                dateTimePickerFRecepcion.Text = registro["FRecepcion"].ToString();
                dateTimePickerFEntrega.Text = registro["FEntrega"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void btnUpdateRe_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update Reparaciones Set Propietario=@Propietario, Celular=@Celular, Equipo=@Equipo, Modelo=@Modelo, Descripcion=@Descripcion, CostoR=@CostoR, GTotal=@GTotal, FRecepcion=@FRecepcion, FEntrega=@FEntrega Where IDRe = @IDRe", Conexion);
                comando.Parameters.AddWithValue("@IDRe", int.Parse(txtIDRe.Text));
                comando.Parameters.AddWithValue("@Propietario", txtPropietario.Text);
                comando.Parameters.AddWithValue("@Celular", maskedTxtCelular.Text);
                comando.Parameters.AddWithValue("@Equipo", txtEquipo.Text);
                comando.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                comando.Parameters.AddWithValue("@CostoR", decimal.Parse(txtCostoR.Text));
                comando.Parameters.AddWithValue("@GTotal", decimal.Parse(txtGTotal.Text));
                comando.Parameters.AddWithValue("@FRecepcion", dateTimePickerFRecepcion.Text);
                comando.Parameters.AddWithValue("@FEntrega", dateTimePickerFEntrega.Text);

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Actualizados Correctamente!!", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Actualizar!!", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Update los textBox se limpian.
                txtIDRe.Clear();
                txtPropietario.Clear();
                maskedTxtCelular.Clear();
                txtEquipo.Clear();
                txtModelo.Clear();
                txtDescripcion.Clear();
                txtCostoR.Clear();
                txtGTotal.Clear();
                dateTimePickerFRecepcion.Value = DateTime.Now;
                dateTimePickerFEntrega.Value = DateTime.Now;

                //Carga la tabla Ventas
                dataGridViewReparaciones.DataSource = Instancia_SQLite.CargarTablaReparaciones();

            }
            catch (Exception)
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }
        }

        private void btnDeleteRe_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Delete from Reparaciones Where IDRe=@IDRe", Conexion);
                comando.Parameters.AddWithValue("@IDRe", int.Parse(txtIDReDelete.Text));
                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Registro Eliminado Correctamente!!", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Eliminar!!", "Error al Eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Detele del registro se limpia el textBox.
                txtIDReDelete.Clear();

                //Carga la tabla Ventas
                dataGridViewReparaciones.DataSource = Instancia_SQLite.CargarTablaReparaciones();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Escriba el ID de reparacion que eliminará.");
            }
        }
    }
}
