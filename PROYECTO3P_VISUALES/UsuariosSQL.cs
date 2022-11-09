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
    class UsuariosSQL
    {
        private MySqlConnection _connection = new MySqlConnection("Server=localhost; Port=3306; Database=abarrotes; User ID=root; Password=root;");
        private DataSet ds;
        public DataTable selectLogistica()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Inventario`", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }
        public DataTable selectVendedor()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `abarrotes`.`Ventas`", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "tabla");
            _connection.Close();
            return ds.Tables["tabla"];
        }
        public bool nuevoUsuarioLogistica(string nombre, string usuario, string contraseña)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `abarrotes`.`Inventario` (`nombre`, `usuario`, `contraseña`) VALUES ('{nombre}','{usuario}','{contraseña}')", _connection);
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
        public bool nuevoUsuarioVendedor(string nombre, string usuario, string contraseña)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `abarrotes`.`Ventas` (`nombre`, `usuario`, `contraseña`) VALUES ('{nombre}','{usuario}','{contraseña}')", _connection);
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
        public bool eliminarCuentaVendedor(string usuario)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"DELETE FROM `abarrotes`.`Ventas`  where `usuario` = '{usuario}'", _connection);
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
        public bool eliminarCuentaLogistica(string usuario)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"DELETE FROM `abarrotes`.`Inventario`  where `usuario` = '{usuario}'", _connection);
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
    }
}
