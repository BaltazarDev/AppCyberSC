using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class ConsultaVenta : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public ConsultaVenta()
        {
            InitializeComponent();
            //Agrega la fecha en el txtConsultFCreacion
            txtConsulFCreacion.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void BuscarVentas_Load(object sender, EventArgs e)
        {
            //Formato de fecha de los dateTimePicker
            dateTimePickerFechaInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaInicio.CustomFormat = "yyyy-MM-dd";

            dateTimePickerFechaFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaFin.CustomFormat = "yyyy-MM-dd";

            //Carga la tabla cuando se abre el Form
            dataGridViewConsultaVentas.DataSource = Instancia_SQLite.CargarTablaVentas();
            //****************************************************************************************Pendiente para verificar su funcionalidad
            //Establece la fecha de día en el DateTimePicker
            dateTimePickerFechaInicio.Value = DateTime.Now;
            dateTimePickerFechaFin.Value = DateTime.Now;
            //**************************************************************************************************
        }

        private void btnCargarTablaAdminVentas_Click(object sender, EventArgs e)
        {
            dataGridViewConsultaVentas.DataSource = Instancia_SQLite.CargarTablaVentas();
            txtSuma.Clear();
            dateTimePickerFechaInicio.Value = DateTime.Now;
            dateTimePickerFechaFin.Value = DateTime.Now;
        }

        private void buttonBuscarMes_Click(object sender, EventArgs e)
        {
            dateTimePickerFechaInicio.Text = DateTime.Now.ToString("yyyy-MM-01");
            dateTimePickerFechaFin.Text = DateTime.Now.ToString("yyyy-MM-31");

            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            string consulta = "Select IDVenta, Producto, Descripcion, Cantidad, Precio, GTotal, FCreacion, FModificacion FROM Ventas WHERE FCreacion BETWEEN @FechaInicio AND @FechaFin ORDER BY FCreacion";
            //string consulta = "SELECT datetime(FCreacion) as FCreacion FROM  Ventas;";

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
            dataGridViewConsultaVentas.DataSource = dt;

            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dataGridViewConsultaVentas.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["GTotal"].Value);
            //Mostrar resultado
            txtSuma.Text = totalMonto.ToString("N2");

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void buttonBuscardeFechaAFecha_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            string consulta = "Select IDVenta, Producto, Descripcion, Cantidad, Precio, GTotal, FCreacion, FModificacion FROM Ventas WHERE FCreacion BETWEEN @FechaInicio AND @FechaFin ORDER BY FCreacion";
            //string consulta = "SELECT datetime(FCreacion) as FCreacion FROM  Ventas;";

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
            dataGridViewConsultaVentas.DataSource = dt;

            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dataGridViewConsultaVentas.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["GTotal"].Value);
            //Mostrar resultado
            txtSuma.Text = totalMonto.ToString("N2");

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }
    }
}
