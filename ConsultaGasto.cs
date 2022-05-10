using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class ConsultaGasto : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public ConsultaGasto()
        {
            InitializeComponent();
            //Agrega la fecha en el txtConsulFRecepcion.
            txtFechaH.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void ConsultaGasto_Load(object sender, EventArgs e)
        {
            dataGridViewConsultaGasto.DataSource = Instancia_SQLite.CargarTablaGastos();

            //Formato de fecha de los dateTimePicker
            dateTimePickerFechaInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaInicio.CustomFormat = "yyyy-MM-dd";

            dateTimePickerFechaFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaFin.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonBuscarMes_Click(object sender, EventArgs e)
        {
            dateTimePickerFechaInicio.Text = DateTime.Now.ToString("yyyy-MM-01");
            dateTimePickerFechaFin.Text = DateTime.Now.ToString("yyyy-MM-31");

            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            string consulta = "Select IDGasto, Servicio, Proveedor, Fecha, Costo FROM Gastos WHERE Fecha BETWEEN @FechaInicio AND @FechaFin ORDER BY Fecha";

            // Adaptador de datos, DataSet y tabla
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
            db.SelectCommand.Parameters.AddWithValue("@FechaInicio", dateTimePickerFechaInicio.Text);
            db.SelectCommand.Parameters.AddWithValue("@FechaFin", dateTimePickerFechaFin.Text);

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            //Asigna al DataTable la primer tabla ventas
            // y la mostramos en el DataGridView
            dt = ds.Tables[0];
            dataGridViewConsultaGasto.DataSource = dt;

            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dataGridViewConsultaGasto.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["Costo"].Value);
            //Mostrar resultado
            txtSuma.Text = totalMonto.ToString("N2");

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void buttonBuscardeFechaAFecha_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            string consulta = "Select IDGasto, Servicio, Proveedor, Fecha, Costo FROM Gastos WHERE Fecha BETWEEN @FechaInicio AND @FechaFin ORDER BY Fecha";

            // Adaptador de datos, DataSet y tabla
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
            db.SelectCommand.Parameters.AddWithValue("@FechaInicio", dateTimePickerFechaInicio.Text);
            db.SelectCommand.Parameters.AddWithValue("@FechaFin", dateTimePickerFechaFin.Text);

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            //Asigna al DataTable la primer tabla ventas
            // y la mostramos en el DataGridView
            dt = ds.Tables[0];
            dataGridViewConsultaGasto.DataSource = dt;

            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dataGridViewConsultaGasto.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["Costo"].Value);
            //Mostrar resultado
            txtSuma.Text = totalMonto.ToString("N2");

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void btnCargarTablaAdminVentas_Click(object sender, EventArgs e)
        {
            dataGridViewConsultaGasto.DataSource = Instancia_SQLite.CargarTablaGastos();

            //Restablece la fecha de los dataTimePicker
            dateTimePickerFechaInicio.Value = DateTime.Now;
            dateTimePickerFechaFin.Value = DateTime.Now;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
