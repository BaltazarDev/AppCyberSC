using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class FormReparacion : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormReparacion()
        {
            InitializeComponent();
        }

        private void FormReparacion_Load(object sender, EventArgs e)
        {
            //Formato de fecha de los dateTimePicker
            dateTimePickerFRecepcion.Format = DateTimePickerFormat.Custom;
            dateTimePickerFRecepcion.CustomFormat = "yyyy-MM-dd";

            dateTimePickerFEntrega.Format = DateTimePickerFormat.Custom;
            dateTimePickerFEntrega.CustomFormat = "yyyy-MM-dd";
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into Reparaciones (Propietario, Celular, Equipo, Modelo, Descripcion, CostoR, GTotal, FRecepcion, FEntrega) values (@Propietario, @Celular, @Equipo, @Modelo, @Descripcion, @CostoR, @GTotal, @FRecepcion, @FEntrega)", Conexion);

                comando.Parameters.AddWithValue("@Propietario", txtPropietario.Text);
                comando.Parameters.AddWithValue("@Celular", maskedTxtCelular.Text);
                comando.Parameters.AddWithValue("@Equipo", txtEquipo.Text);
                comando.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                comando.Parameters.AddWithValue("@CostoR", decimal.Parse(txtCReparacion.Text));
                comando.Parameters.AddWithValue("@GTotal", decimal.Parse(txtGanancia.Text));
                comando.Parameters.AddWithValue("@FRecepcion", dateTimePickerFRecepcion.Text);
                comando.Parameters.AddWithValue("@FEntrega", dateTimePickerFEntrega.Text);


                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpia los cuadros de texto despúes de insertar.
                txtPropietario.Clear();
                maskedTxtCelular.Clear();
                txtEquipo.Clear();
                txtModelo.Clear();
                txtDescripcion.Clear();
                txtCReparacion.Clear();
                txtGanancia.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }
        }
    }
}
