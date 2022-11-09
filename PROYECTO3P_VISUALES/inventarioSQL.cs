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
    class inventarioSQL
    {
        private MySqlConnection _connection = new MySqlConnection("Server=localhost; Port=3306; Database=abarrotes; User ID=root; Password=root;");
        private DataSet ds;
        public DataTable selectProductos()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto`", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }
        public DataTable selectAlfabetica()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` order by `nombre`", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }

        public bool eliminarProducto(string nombre)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"DELETE FROM `abarrotes`.`Producto`  where `nombre` = '{nombre}'", _connection);
                int filasAfectadas = cmd.ExecuteNonQuery();
                _connection.Close();
                return (filasAfectadas > 0);
            }
            catch
            {
                _connection.Close();
                return false;
            }
        }
        public bool nuevoProducto(string nombre, double precio, int existencia)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `abarrotes`.`Producto` (`nombre`, `precio`, `existencia`) VALUES ('{nombre}','{precio}','{existencia}')", _connection);
                int filasAfectadas = cmd.ExecuteNonQuery();
                _connection.Close();
                return (filasAfectadas > 0);
            }
            catch
            {
                _connection.Close();
                return false;
            }
        }
        public bool actualizarPrecio(double precio, string nombre)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `precio`= '{precio }' WHERE `nombre` ='{nombre }'", _connection);
                int filasAfectadas = cmd.ExecuteNonQuery();
                _connection.Close();
                return (filasAfectadas > 0);
            }
            catch
            {
                _connection.Close();
                return false;
            }
        }
        public bool actualizarExistencia(int existencia, string nombre)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `existencia`= '{existencia }' WHERE `nombre` ='{nombre }'", _connection);
                int filasAfectadas = cmd.ExecuteNonQuery();
                _connection.Close();
                return (filasAfectadas > 0);
            }
            catch
            {
                _connection.Close();
                return false;
            }
        }
        public bool actualizarAmbos(int existencia, double precio, string nombre)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `existencia`= '{existencia }' WHERE `nombre` ='{nombre }'", _connection);
                int filasAfectadas = cmd.ExecuteNonQuery();
                MySqlCommand cnd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `precio`= '{precio }' WHERE `nombre` ='{nombre }'", _connection);
                filasAfectadas = cnd.ExecuteNonQuery();
                _connection.Close();
                return (filasAfectadas > 0);
            }
            catch
            {
                _connection.Close();
                return false;
            }
        }
        public DataTable selectPrecio()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` order by `precio` asc ", _connection);
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
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` order by `existencia` asc ", _connection);
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
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Producto` order by `ventas` asc ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }

    }
}
