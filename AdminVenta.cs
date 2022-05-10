using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class AdminVenta : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public AdminVenta()
        {
            InitializeComponent();
            //Agrega la fecha en el txtFModificacion.
            txtFModificacion.Text = DateTime.Now.ToString("yyyy-MM-dd");

            //Cambia a Disabled la propiedad AutoValidate
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
        }

        private void AdminVenta_Load(object sender, EventArgs e)
        {
            //Carga la tabla cuando se abre el Form
            dataGridViewVentas.DataSource = Instancia_SQLite.CargarTablaVentas();
        }

        private void TxtIDVentaUpdate_TextChanged(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Ventas donde la columna IDVenta es igual al text box txtIDVenta.
            //Esto hace que inmediatamente que se escriba en el text box del IDVenta, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Ventas Where IDVenta = @IDVenta", Conexion);
            comando.Parameters.AddWithValue("@IDVenta", txtIDVentaUpdate.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtProductoVentaUpdate.Text = registro["Producto"].ToString();
                txtDescripcionVentaUpdate.Text = registro["Descripcion"].ToString();
                txtCantidadVentaUpdate.Text = registro["Cantidad"].ToString();
                txtPrecioVentaUpdate.Text = registro["Precio"].ToString();
                txtTotalVentaUpdate.Text = registro["GTotal"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void ButtonUpdateVenta_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                //Realiza el calculo y lo muestra en el txtTotal
                //Convierte el textbox txtCantidad de texto a entero (int)
                //Convierte el textbo txtPrecio de texto a decimal y al mismo tiempo realiza la multiplicación entre los textbox.
                txtTotalVentaUpdate.Text = (Convert.ToInt32(txtCantidadVentaUpdate.Text) * Convert.ToDecimal(txtPrecioVentaUpdate.Text)).ToString();

                //Realiza el calculo y lo muestra en el txtTotal y convierte de texto a entero (int) los textbox Cantidad y Precio.
                //txtTotal.Text = (Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(txtPrecio.Text)).ToString();

                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update Ventas Set Producto=@Producto, Descripcion=@Descripcion, Cantidad=@Cantidad, Precio=@Precio, GTotal=@GTotal, FModificacion=@FModificacion Where IDVenta = @IDVenta", Conexion);
                comando.Parameters.AddWithValue("@IDVenta", int.Parse(txtIDVentaUpdate.Text));
                comando.Parameters.AddWithValue("@Producto", txtProductoVentaUpdate.Text);
                comando.Parameters.AddWithValue("@Descripcion", txtDescripcionVentaUpdate.Text);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidadVentaUpdate.Text));
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecioVentaUpdate.Text));
                comando.Parameters.AddWithValue("@GTotal", decimal.Parse(txtTotalVentaUpdate.Text));
                comando.Parameters.AddWithValue("@FModificacion", txtFModificacion.Text);

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Actualizados Correctamente!!", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Actualizar!!", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Update los textBox se limpian.
                txtIDVentaUpdate.Clear();
                txtProductoVentaUpdate.Clear();
                txtDescripcionVentaUpdate.Clear();
                txtCantidadVentaUpdate.Clear();
                txtPrecioVentaUpdate.Clear();
                txtTotalVentaUpdate.Clear();

                //Carga la tabla Ventas
                dataGridViewVentas.DataSource = Instancia_SQLite.CargarTablaVentas();

            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }
        }

        private void ButtonDeleteVenta_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Delete from Ventas Where IDVenta=@IDVenta", Conexion);
                comando.Parameters.AddWithValue("@IDVenta", int.Parse(txtIDVentaDelete.Text));
                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Registro Eliminado Correctamente!!", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Eliminar!!", "Error al Eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Detele del registro se limpia el textBox.
                txtIDVentaDelete.Clear();

                //Carga la tabla Ventas
                dataGridViewVentas.DataSource = Instancia_SQLite.CargarTablaVentas();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Escriba el ID de venta que eliminará.");
            }
        }

        private void buttonCargarTablaVentas_Click(object sender, EventArgs e)
        {
            dataGridViewVentas.DataSource = Instancia_SQLite.CargarTablaVentas();
        }
        //*****************************************************************************
        //Validación de campos vacíos.
        private void TxtIDVentaUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (txtIDVentaUpdate.Text == "")
            {
                e.Cancel = true;
                txtIDVentaUpdate.Select(0, txtIDVentaUpdate.Text.Length);
                errorProviderConsultaVentas.SetError(txtIDVentaUpdate, "Escriba el ID de venta que desea actualizar.");
            }
        }

        private void TxtIDVentaUpdate_Validated(object sender, EventArgs e)
        {
            errorProviderConsultaVentas.SetError(txtIDVentaUpdate, "");
        }

        private void TxtProductoVentaUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (txtProductoVentaUpdate.Text == "")
            {
                e.Cancel = true;
                txtProductoVentaUpdate.Select(0, txtProductoVentaUpdate.Text.Length);
                errorProviderConsultaVentas.SetError(txtProductoVentaUpdate, "El campo no puede estar vació.");
            }
        }

        private void TxtProductoVentaUpdate_Validated(object sender, EventArgs e)
        {
            errorProviderConsultaVentas.SetError(txtProductoVentaUpdate, "");
        }

        private void TxtDescripcionVentaUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescripcionVentaUpdate.Text == "")
            {
                e.Cancel = true;
                txtDescripcionVentaUpdate.Select(0, txtDescripcionVentaUpdate.Text.Length);
                errorProviderConsultaVentas.SetError(txtDescripcionVentaUpdate, "El campo no puede estar vació.");
            }
        }

        private void TxtDescripcionVentaUpdate_Validated(object sender, EventArgs e)
        {
            errorProviderConsultaVentas.SetError(txtDescripcionVentaUpdate, "");
        }

        private void TxtCantidadVentaUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidadVentaUpdate.Text == "")
            {
                e.Cancel = true;
                txtCantidadVentaUpdate.Select(0, txtCantidadVentaUpdate.Text.Length);
                errorProviderConsultaVentas.SetError(txtCantidadVentaUpdate, "El campo no puede estar vació.");
            }
        }

        private void TxtCantidadVentaUpdate_Validated(object sender, EventArgs e)
        {
            errorProviderConsultaVentas.SetError(txtCantidadVentaUpdate, "");
        }

        private void TxtPrecioVentaUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrecioVentaUpdate.Text == "")
            {
                e.Cancel = true;
                txtPrecioVentaUpdate.Select(0, txtPrecioVentaUpdate.Text.Length);
                errorProviderConsultaVentas.SetError(txtPrecioVentaUpdate, "El campo no puede estar vació.");
            }
        }

        private void TxtPrecioVentaUpdate_Validated(object sender, EventArgs e)
        {
            errorProviderConsultaVentas.SetError(txtPrecioVentaUpdate, "");
        }

        private void TxtTotalVentaUpdate_Validating(object sender, CancelEventArgs e)
        {
            /*if (txtTotalVentaUpdate.Text == "")
            {
                e.Cancel = true;
                txtTotalVentaUpdate.Select(0, txtTotalVentaUpdate.Text.Length);
                errorProviderConsultaVentas.SetError(txtTotalVentaUpdate, "El campo no puede estar vació.");
            }*/
        }

        private void TxtTotalVentaUpdate_Validated(object sender, EventArgs e)
        {
            //errorProviderConsultaVentas.SetError(txtTotalVentaUpdate, "");
        }
        //********************************************************************************
    }
}
