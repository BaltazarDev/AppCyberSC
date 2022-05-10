using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class FormVenta : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormVenta()
        {
            InitializeComponent();

            //Agrega la fecha en el txtFCreacion.
            txtFCreacion.Text = DateTime.Now.ToString("yyyy-MM-dd");

            //Cambia a Disabled la propiedad AutoValidate
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
        }

        private void ButtonInsertVenta_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                //Realiza el calculo y lo muestra en el txtTotal
                //Convierte el textbox txtCantidad de texto a entero (int)
                //Convierte el textbo txtPrecio de texto a decimal y al mismo tiempo realiza la multiplicación entre los textbox.
                txtTotal.Text = (Convert.ToInt32(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text)).ToString();

                //Realiza el calculo y lo muestra en el txtTotal y convierte de texto a entero (int) los textbox Cantidad y Precio.
                //txtTotal.Text = (Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(txtPrecio.Text)).ToString();

                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into Ventas (Producto, Descripcion, Cantidad, Precio, GTotal, FCreacion, FModificacion) values (@Producto,@Descripcion,@Cantidad,@Precio,@GTotal,@FCreacion,@FModificacion)", Conexion);

                comando.Parameters.AddWithValue("@Producto", txtProducto.Text);
                comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));
                comando.Parameters.AddWithValue("@GTotal", decimal.Parse(txtTotal.Text));
                comando.Parameters.AddWithValue("@FCreacion", (txtFCreacion.Text));
                comando.Parameters.AddWithValue("@FModificacion", "0000-00-00");

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpia los cuadros de texto despúes de insertar.
                txtProducto.Clear();
                txtDescripcion.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();
                txtTotal.Clear();

            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Productos donde la columna IDProducto es igual 1 que es el id del producto que representa el boton.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Productos Where IDProducto = 1", Conexion);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtProducto.Text = registro["Nombre"].ToString();
                txtDescripcion.Text = registro["Descripcion"].ToString();
                txtPrecio.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Productos donde la columna IDProducto es igual 1 que es el id del producto que representa el boton.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Productos Where IDProducto = 2", Conexion);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtProducto.Text = registro["Nombre"].ToString();
                txtDescripcion.Text = registro["Descripcion"].ToString();
                txtPrecio.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Productos donde la columna IDProducto es igual 1 que es el id del producto que representa el boton.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Productos Where IDProducto = 3", Conexion);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtProducto.Text = registro["Nombre"].ToString();
                txtDescripcion.Text = registro["Descripcion"].ToString();
                txtPrecio.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Productos donde la columna IDProducto es igual 1 que es el id del producto que representa el boton.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Productos Where IDProducto = 4", Conexion);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtProducto.Text = registro["Nombre"].ToString();
                txtDescripcion.Text = registro["Descripcion"].ToString();
                txtPrecio.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Productos donde la columna IDProducto es igual 1 que es el id del producto que representa el boton.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Productos Where IDProducto = 5", Conexion);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtProducto.Text = registro["Nombre"].ToString();
                txtDescripcion.Text = registro["Descripcion"].ToString();
                txtPrecio.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Productos donde la columna IDProducto es igual 1 que es el id del producto que representa el boton.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Productos Where IDProducto = 6", Conexion);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtProducto.Text = registro["Nombre"].ToString();
                txtDescripcion.Text = registro["Descripcion"].ToString();
                txtPrecio.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Productos donde la columna IDProducto es igual 1 que es el id del producto que representa el boton.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From Productos Where IDProducto = 7", Conexion);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtProducto.Text = registro["Nombre"].ToString();
                txtDescripcion.Text = registro["Descripcion"].ToString();
                txtPrecio.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            txtProducto.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
        }

        //***********************************************************************
        //Validación de campos vacíos
        private void TxtProducto_Validating(object sender, CancelEventArgs e)
        {
            if (txtProducto.Text == "")
            {
                e.Cancel = true;
                txtProducto.Select(0, txtProducto.Text.Length);
                errorProviderVenta.SetError(txtProducto, "Ingrese el Producto");
            }
        }

        private void TxtProducto_Validated(object sender, EventArgs e)
        {
            errorProviderVenta.SetError(txtProducto, "");
        }

        private void TxtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                e.Cancel = true;
                txtDescripcion.Select(0, txtDescripcion.Text.Length);
                errorProviderVenta.SetError(txtDescripcion, "Ingrese una Descripción");
            }
        }

        private void TxtDescripcion_Validated(object sender, EventArgs e)
        {
            errorProviderVenta.SetError(txtDescripcion, "");
        }

        private void TxtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                e.Cancel = true;
                txtCantidad.Select(0, txtCantidad.Text.Length);
                errorProviderVenta.SetError(txtCantidad, "Ingrese la Cantidad de compra");
            }
        }

        private void TxtCantidad_Validated(object sender, EventArgs e)
        {
            errorProviderVenta.SetError(txtCantidad, "");
        }

        private void TxtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                e.Cancel = true;
                txtPrecio.Select(0, txtPrecio.Text.Length);
                errorProviderVenta.SetError(txtPrecio, "Ingrese el Precio");
            }
        }

        private void TxtPrecio_Validated(object sender, EventArgs e)
        {
            errorProviderVenta.SetError(txtPrecio, "");
        }
        //***********************************************************************

        //***********************************************************************
        //Validación de Letras y Números en los campos.
        //Se manda llamar la clase ValidarCampos.
        private void TxtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ValidarCampos.ValidarSoloLetras(e);
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ValidarCampos.ValidarSoloLetras(e);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCampos.ValidarSoloNumeros(e);
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCampos.ValidarSoloNumerosDecimales(e);
        }
        //***********************************************************************

    }
}
