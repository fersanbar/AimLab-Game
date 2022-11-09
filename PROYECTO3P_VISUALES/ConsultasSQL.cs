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
    class ConsultasSQL
    {
        private MySqlConnection conexion = new MySqlConnection("Server=localhost; Port=3306; Database=abarrotes; User ID=root; Password=root;");

        public bool ingresa_gerente(string usuario, string contraseña)
        {
            string comprueba = "";
            conexion.Open();
            //INSTRUCCIONES
            MySqlCommand cmd = new MySqlCommand("select*from `abarrotes`.`gerente` where `usuario`='" + usuario + "' and `contraseña`='" + contraseña + "'", conexion);
            //int filasafectadas = cmd.ExecuteNonQuery();
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                comprueba = rdr.GetValue(rdr.GetOrdinal("usuario")).ToString();
                conexion.Close();
                return (comprueba.Equals(usuario));
            }
            if (rdr.Read())
            {
                comprueba = rdr.GetValue(rdr.GetOrdinal("contraseña")).ToString();
                conexion.Close();
                return (comprueba.Equals(contraseña));
            }
            conexion.Close();
            return false;
        }
        public bool ingresa_logistica(string usuario, string contraseña)
        {
            string comprueba = "";
            conexion.Open();
            //INSTRUCCIONES
            MySqlCommand cmd = new MySqlCommand("select*from `abarrotes`.`Inventario` where `usuario`='" + usuario + "' and `contraseña`='" + contraseña + "'", conexion);
            //int filasafectadas = cmd.ExecuteNonQuery();
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                comprueba = rdr.GetValue(rdr.GetOrdinal("usuario")).ToString();
                conexion.Close();
                return (comprueba.Equals(usuario));
            }
            if (rdr.Read())
            {
                comprueba = rdr.GetValue(rdr.GetOrdinal("contraseña")).ToString();
                conexion.Close();
                return (comprueba.Equals(contraseña));
            }
            conexion.Close();
            return false;
        }
        public bool ingresa_vendedor(string usuario, string contraseña)
        {
            string comprueba = "";
            conexion.Open();
            //INSTRUCCIONES
            MySqlCommand cmd = new MySqlCommand("select*from `abarrotes`.`Ventas` where `usuario`='" + usuario + "' and `contraseña`='" + contraseña + "'", conexion);
            //int filasafectadas = cmd.ExecuteNonQuery();
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                comprueba = rdr.GetValue(rdr.GetOrdinal("usuario")).ToString();
                conexion.Close();
                return (comprueba.Equals(usuario));
            }
            if (rdr.Read())
            {
                comprueba = rdr.GetValue(rdr.GetOrdinal("contraseña")).ToString();
                conexion.Close();
                return (comprueba.Equals(contraseña));
            }
            conexion.Close();
            return false;
        }
    }
}