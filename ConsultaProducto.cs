using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class ConsultaProducto : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public ConsultaProducto()
        {
            InitializeComponent();

            //Cambia a Disabled la propiedad AutoValidate
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            dataGridViewConsultaProductos.DataSource = Instancia_SQLite.CargarTablaProductos();
        }

        private void TxtIDProductoUpdate_TextChanged(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Productos donde la columna IDProducto es igual al text box txtIDProducto.
            //Esto hace que inmediatamente que se escriba en el text box del IDProducto, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Productos Where IDProducto = @IDProducto", Conexion);
            comando.Parameters.AddWithValue("@IDProducto", txtIDProductoUpdate.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtNombreProductoUpdate.Text = registro["Nombre"].ToString();
                txtDescripcionProductoUpdate.Text = registro["Descripcion"].ToString();
                txtPrecioProductoUpdate.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void ButtonUpdateProductos_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update Productos Set Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio Where IDProducto = @IDProducto", Conexion);
                comando.Parameters.AddWithValue("@IDProducto", int.Parse(txtIDProductoUpdate.Text));
                comando.Parameters.AddWithValue("@Nombre", txtNombreProductoUpdate.Text);
                comando.Parameters.AddWithValue("@Descripcion", txtDescripcionProductoUpdate.Text);
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecioProductoUpdate.Text));

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Actualizados Correctamente!!", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Actualizar!!", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Update los textBox se limpian.
                txtIDProductoUpdate.Clear();
                txtNombreProductoUpdate.Clear();
                txtDescripcionProductoUpdate.Clear();
                txtPrecioProductoUpdate.Clear();

                //Carga la tabla Ventas
                dataGridViewConsultaProductos.DataSource = Instancia_SQLite.CargarTablaProductos();
            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }
        }

        //*****************************************************************************
        //Validación de campos vaciós
        private void TxtIDProductoUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (txtIDProductoUpdate.Text == "")
            {
                e.Cancel = true;
                txtIDProductoUpdate.Select(0, txtIDProductoUpdate.Text.Length);
                errorProviderProductosUpdate.SetError(txtIDProductoUpdate, "Escriba el ID del producto que desea actualizar.");
            }
        }

        private void TxtIDProductoUpdate_Validated(object sender, EventArgs e)
        {
            errorProviderProductosUpdate.SetError(txtIDProductoUpdate, "");
        }

        private void TxtNombreProductoUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombreProductoUpdate.Text == "")
            {
                e.Cancel = true;
                txtNombreProductoUpdate.Select(0, txtNombreProductoUpdate.Text.Length);
                errorProviderProductosUpdate.SetError(txtNombreProductoUpdate, "El campo no puede estar vació.");
            }
        }

        private void TxtNombreProductoUpdate_Validated(object sender, EventArgs e)
        {
            errorProviderProductosUpdate.SetError(txtNombreProductoUpdate, "");
        }

        private void TxtDescripcionProductoUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescripcionProductoUpdate.Text == "")
            {
                e.Cancel = true;
                txtDescripcionProductoUpdate.Select(0, txtDescripcionProductoUpdate.Text.Length);
                errorProviderProductosUpdate.SetError(txtDescripcionProductoUpdate, "El campo no puede estar vació.");
            }
        }

        private void TxtDescripcionProductoUpdate_Validated(object sender, EventArgs e)
        {
            errorProviderProductosUpdate.SetError(txtDescripcionProductoUpdate, "");
        }

        private void TxtPrecioProductoUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrecioProductoUpdate.Text == "")
            {
                e.Cancel = true;
                txtPrecioProductoUpdate.Select(0, txtPrecioProductoUpdate.Text.Length);
                errorProviderProductosUpdate.SetError(txtPrecioProductoUpdate, "El campo no puede estar vació.");
            }
        }

        private void TxtPrecioProductoUpdate_Validated(object sender, EventArgs e)
        {
            errorProviderProductosUpdate.SetError(txtPrecioProductoUpdate, "");
        }
    }
    //**************************************************************************************
}
