using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
namespace DAL
{
    public class DAL_Usuario
    {
        private static DAL_Usuario _current = null;
        public static DAL_Usuario Current
        {
            get
            {
                if (_current == null)
                    _current = new DAL_Usuario();
                return _current;
            }
        }

        protected DAL_Usuario() { }

        public static string ConnectionStringGlobal = ConfigurationManager.ConnectionStrings["Connection_Developer"].ConnectionString;

        public static void ListUsuario()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection_Developer"].ConnectionString;
            string queryString = "select * from usuario";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }
            }
        }


        public static void Listar()
        {
            string queryString = "select * from usuario";
            using (var connection = new SqlConnection(ConnectionStringGlobal))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }
            }

        }
        public static void Inserir(string nome,string pass) {
            using (var connection = new SqlConnection(ConnectionStringGlobal))
            {

                string queryString = "insert into usuario(nm_usuario,pass_usuario)values(@param1,@param2)";
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@param1", nome);
                command.Parameters.AddWithValue("@param2", pass);
                command.ExecuteNonQuery();
            }
        }


        public static void UpdateUsuario(string nome, string pass, Int32 id)
        {
            using (var connection = new SqlConnection(ConnectionStringGlobal))
            {
                //update usuario set nm_usuario = 't',pass_usuario = 'kkk' where id_usuario = 1
//                string queryString = update usuario set nm_usuario = 't',pass_usuario = 'kkk' where id_usuario = 1";

                string queryString = "update  usuario set nm_usuario = @param1,pass_usuario = @param2 where id_usuario = @param3";

                var command = new SqlCommand(queryString, connection);
                connection.Open();
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@param1", nome);
                command.Parameters.AddWithValue("@param2", pass);
                command.Parameters.AddWithValue("@param3", id);
                command.ExecuteNonQuery();
            }
        }



    }
}
