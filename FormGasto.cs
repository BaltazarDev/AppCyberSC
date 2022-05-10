using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class FormGasto : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormGasto()
        {
            InitializeComponent();
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            //Formato de fecha de los dateTimePicker
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void btnRegistrarG_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into Gastos (Servicio, Proveedor, Fecha, Costo) values (@Servicio,@Proveedor,@Fecha,@Costo)", Conexion);

                comando.Parameters.AddWithValue("@Servicio", txtServicio.Text);
                comando.Parameters.AddWithValue("@Proveedor", txtProveedor.Text);
                comando.Parameters.AddWithValue("@Fecha", dateTimePickerFecha.Text);
                comando.Parameters.AddWithValue("@Costo", decimal.Parse(txtCosto.Text));

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpia los cuadros de texto despúes de insertar.
                txtServicio.Clear();
                txtProveedor.Clear();
                txtCosto.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }
        }
    }
}
