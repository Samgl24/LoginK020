using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginK020.datos
{
    internal class UsuariosDao  
    {
        private const string ConnString = "server=(localdb)\\MSSQLLocalDB;database=proyectok20;Trusted_Connection=True";
        private const string sqlLogin = "select * from usuarios where Username = @nombreUsuario;";
        public Usuario buscarUsuarioPorUsername(string username, string password)
        {
            Usuario user = null;
            using (SqlConnection connection = new SqlConnection() )
            {
                connection.ConnectionString = ConnString;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sqlLogin;
                SqlParameter usernameParameter = new SqlParameter("@nombreUsuario", username);
                command.Parameters.Add(usernameParameter);  
                SqlDataReader dr = command.ExecuteReader();
                Console.WriteLine("Se encontraron registro " + dr.HasRows);

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (password == dr.GetString("password"))
                        {
                            user = new Usuario();
                            user.Id = dr.GetInt32("id");
                            user.Username = username;
                            user.Password = dr.GetString("password");
                            user.NombreCompleto = dr.GetString(4);
                            break;
                        }   
                    }
                }

            }
            return user; 
        }
    } 
}
