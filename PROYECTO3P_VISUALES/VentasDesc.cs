using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace PROYECTO3P_VISUALES
{
    class VentasDesc
    {
        private MySqlConnection _connection = new MySqlConnection("Server=localhost; Port=3306; Database=abarrotes; User ID=root; Password=root;");
        private DataSet ds;
        public DataTable selectProductos()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }
        public DataTable selectNoAlfa()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` order by `nombre` desc ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }
        public DataTable selectPrecio()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` order by `precio` desc ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }
        public DataTable selectExistencia()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` order by `existencia` desc ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }
        public DataTable selectVentas()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` order by `ventas` desc ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }
        public DataTable selectPocos()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` where `existencia` < 10 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }

    }
}
