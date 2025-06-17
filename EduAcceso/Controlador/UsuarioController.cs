using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using EduAcceso.Modelo;

namespace EduAcceso.Controlador
{
    public class UsuarioController
    {
        private string connectionString = "Data Source=eduaccesobd.db;Version=3;";

        public Usuario VerificarLogin(string correo, string clave)
        {
            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Usuarios WHERE correo = @correo AND clave = @clave";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@clave", clave);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Usuario
                            {
                                idUsuario = Convert.ToInt32(lector["IdUsuario"]),
                                nombre = lector["nombre"].ToString(),
                                correo = lector["correo"].ToString(),
                                telefono = Convert.ToInt32(lector["telefono"]),
                                clave = lector["clave"].ToString(),
                                rol = lector["rol"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
