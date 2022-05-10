using System;
using System.Data;
using System.Data.SQLite;

namespace AppCyberSC
{
    class ConexionSQLite
    {
        SQLiteConnection Conexion;

        public static SQLiteConnection ObtenerConexion()
        {
            SQLiteConnection Conn = new SQLiteConnection("Data Source= F:\\balta\\Documents\\Visual Studio Proyectos\\AppCyberSC\\DB_CyberVSC.db3;Version=3");
            //SQLiteConnection Conn = new SQLiteConnection("Data Source= D:\\AppCyberSC\\DB_CyberVSC.db3;Version=3");
            Conn.Open();
            return Conn;
        }

        public void AbrirConexion()
        {
            Conexion = new SQLiteConnection("Data Source= F:\\balta\\Documents\\Visual Studio Proyectos\\AppCyberSC\\DB_CyberVSC.db3; Version = 3");
            //Conexion = new SQLiteConnection("Data Source= D:\\AppCyberSC\\DB_CyberVSC.db3;Version=3");
            Conexion.Open();
        }

        public void Desconectar()
        {
            Conexion.Close();
        }

        public void CrearBaseDatos()
        {
            this.AbrirConexion();

            try
            {
                String comando = "Create Table Venta (" +
                    "Producto VARCHAR(30), Cantidad INTEGER" + ")";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);

                int error = SQLiteComando.ExecuteNonQuery();
            }
            catch (Exception) { }

            this.Desconectar();
        }

        public DataTable CargarTablaVentas()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from Ventas ORDER BY IDVenta DESC";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;

        }

        public DataTable CargarTablaProductos()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from Productos";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;
        }

        public DataTable CargarTablaReparaciones()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from Reparaciones";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;
        }

        public DataTable CargarTablaGastos()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from Gastos";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;
        }
    }
}
