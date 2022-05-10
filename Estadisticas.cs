using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            lblFechaInicio.Text = DateTime.Now.ToString("yyyy-MM-01");
            lblFechaFin.Text = DateTime.Now.ToString("yyyy-MM-31");

            Ventas();
            Reparaciones();
            Gastos();
            Suma();
        }

        private void Ventas()
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            string consulta = "Select IDVenta, Producto, Descripcion, Cantidad, Precio, GTotal, FCreacion, FModificacion FROM Ventas WHERE FCreacion BETWEEN @FechaInicio AND @FechaFin ORDER BY FCreacion";
            //string consulta = "SELECT datetime(FCreacion) as FCreacion FROM  Ventas;";

            // Adaptador de datos, DataSet y tabla
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
            db.SelectCommand.Parameters.AddWithValue("@FechaInicio", lblFechaInicio.Text);
            db.SelectCommand.Parameters.AddWithValue("@FechaFin", lblFechaFin.Text);

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            //Asigna al DataTable la primer tabla ventas
            // y la mostramos en el DataGridView
            dt = ds.Tables[0];
            dataGridViewConsultaVentasM.DataSource = dt;

            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dataGridViewConsultaVentasM.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["GTotal"].Value);
            //Mostrar resultado
            txtTotalVentas.Text = totalMonto.ToString("N2");

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void Reparaciones()
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            string consulta = "Select IDRe, Propietario, Celular, Equipo, Modelo, Descripcion, CostoR, GTotal, FRecepcion, FEntrega FROM Reparaciones WHERE FRecepcion BETWEEN @FechaInicio AND @FechaFin ORDER BY FRecepcion";

            // Adaptador de datos, DataSet y tabla
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
            db.SelectCommand.Parameters.AddWithValue("@FechaInicio", lblFechaInicio.Text);
            db.SelectCommand.Parameters.AddWithValue("@FechaFin", lblFechaFin.Text);

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            //Asigna al DataTable la primer tabla ventas
            // y la mostramos en el DataGridView
            dt = ds.Tables[0];
            dataGridViewConsultaReparacionesM.DataSource = dt;

            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dataGridViewConsultaReparacionesM.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["Gtotal"].Value);
            //Mostrar resultado
            txtTotalReparaciones.Text = totalMonto.ToString("N2");

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void Gastos()
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            string consulta = "Select IDGasto, Servicio, Proveedor, Fecha, Costo FROM Gastos WHERE Fecha BETWEEN @FechaInicio AND @FechaFin ORDER BY Fecha";

            // Adaptador de datos, DataSet y tabla
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
            db.SelectCommand.Parameters.AddWithValue("@FechaInicio", lblFechaInicio.Text);
            db.SelectCommand.Parameters.AddWithValue("@FechaFin", lblFechaFin.Text);

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            //Asigna al DataTable la primer tabla ventas
            // y la mostramos en el DataGridView
            dt = ds.Tables[0];
            dataGridViewConsultaGastosM.DataSource = dt;

            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dataGridViewConsultaGastosM.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["Costo"].Value);
            //Mostrar resultado
            txtTotalGastos.Text = totalMonto.ToString("N2");

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void Suma()
        {
            double total;

            total = double.Parse(txtTotalVentas.Text) + double.Parse(txtTotalReparaciones.Text) - double.Parse(txtTotalGastos.Text);
            txtGananciaTotal.Text = total.ToString();
        }
    }
}
