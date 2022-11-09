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
    class VentasSQL
    {
        private MySqlConnection _connection = new MySqlConnection("Server=localhost; Port=3306; Database=abarrotes; User ID=root; Password=root;");

        public int inventarioSabritas()
        {

            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT existencia  FROM `abarrotes`.`Producto` where `codigo` = 1 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int existencia = int.Parse(dr.GetValue(dr.GetOrdinal("existencia")).ToString());
            _connection.Close();
            return existencia;
        }
        public int inventarioCoca()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT existencia  FROM `abarrotes`.`Producto` where `codigo` = 2 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int existencia = int.Parse(dr.GetValue(dr.GetOrdinal("existencia")).ToString());
            _connection.Close();
            return existencia;
        }
        public int inventarioDoritos()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT existencia  FROM `abarrotes`.`Producto` where `codigo` = 3 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int existencia = int.Parse(dr.GetValue(dr.GetOrdinal("existencia")).ToString());
            _connection.Close();
            return existencia;
        }
        public int inventarioFritos()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT existencia  FROM `abarrotes`.`Producto` where `codigo` = 4 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int existencia = int.Parse(dr.GetValue(dr.GetOrdinal("existencia")).ToString());
            _connection.Close();
            return existencia;
        }
        public int inventarioSprite()
        {
            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT existencia  FROM `abarrotes`.`Producto` where `codigo` = 5 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int existencia = int.Parse(dr.GetValue(dr.GetOrdinal("existencia")).ToString());
            _connection.Close();
            return existencia;
        }
        public double precioSabritas()
        {

            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT precio  FROM `abarrotes`.`Producto` where `codigo` = 1 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            double existencia = double.Parse(dr.GetValue(dr.GetOrdinal("precio")).ToString());
            _connection.Close();
            return existencia;
        }
        public double precioCoca()
        {

            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT precio  FROM `abarrotes`.`Producto` where `codigo` = 2 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            double existencia = double.Parse(dr.GetValue(dr.GetOrdinal("precio")).ToString());
            _connection.Close();
            return existencia;
        }
        public double precioDoritos()
        {

            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT precio  FROM `abarrotes`.`Producto` where `codigo` = 3 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            double existencia = double.Parse(dr.GetValue(dr.GetOrdinal("precio")).ToString());
            _connection.Close();
            return existencia;
        }
        public double precioFritos()
        {

            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT precio  FROM `abarrotes`.`Producto` where `codigo` = 4 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            double existencia = double.Parse(dr.GetValue(dr.GetOrdinal("precio")).ToString());
            _connection.Close();
            return existencia;
        }
        public double precioSprite()
        {

            _connection.Open();
            //instrucciones
            MySqlCommand cmd = new MySqlCommand("SELECT precio  FROM `abarrotes`.`Producto` where `codigo` = 5 ", _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            double existencia = double.Parse(dr.GetValue(dr.GetOrdinal("precio")).ToString());
            _connection.Close();
            return existencia;
        }
        public bool modificarSabritas(int existencia)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `existencia`= '{existencia }' WHERE `codigo` = 1 ", _connection);
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
        public bool modificarCoca(int existencia)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `existencia`= '{existencia }' WHERE `codigo` = 2 ", _connection);
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
        public bool modificarDoritos(int existencia)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `existencia`= '{existencia }' WHERE `codigo` = 3 ", _connection);
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
        public bool modificarFritos(int existencia)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `existencia`= '{existencia }' WHERE `codigo` = 4 ", _connection);
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
        public bool modificarSprite(int existencia)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `existencia`= '{existencia }' WHERE `codigo` = 5 ", _connection);
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
        public bool ventaSabritas(int ventas)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `ventas`= '{ventas }' WHERE `codigo` = 1 ", _connection);
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
        public bool ventaCoca(int ventas)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `ventas`= '{ventas }' WHERE `codigo` = 2 ", _connection);
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
        public bool ventaDoritos(int ventas)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `ventas`= '{ventas }' WHERE `codigo` = 3 ", _connection);
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
        public bool ventaFritos(int ventas)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `ventas`= '{ventas }' WHERE `codigo` = 4 ", _connection);
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
        public bool ventaSprite(int ventas)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `abarrotes`.`Producto` SET `ventas`= '{ventas }' WHERE `codigo` = 5 ", _connection);
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
