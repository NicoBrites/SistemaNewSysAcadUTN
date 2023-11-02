using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DB
    {
        public static SqlConnection conexion;
        private static string cadenaConexion;
        private static SqlCommand comando;

        static DB()
        {
            cadenaConexion = @"Server=DESKTOP-SB7OU3P\SQLEXPRESS;Database=SysAcad;Trusted_Connection=True;TrustServerCertificate=True;";
            conexion = new SqlConnection(cadenaConexion);

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

        }


        public static Cursos MapCurso(IDataRecord reader)
        {
            var nombre = reader["Nombre"].ToString();
            var id = Convert.ToInt32(reader["id"]);

            //Cursos curso2 = (Cursos)reader;
            var curso = new Cursos("asd", 2, "123", 1, "1", "2", "1");
            return curso;
        }
        public static void Query()
        {
            Console.WriteLine("asd");

            var cursos = new List<Cursos>();
            try
            {
                conexion.Open();

                var query = "SELECT * FROM Cursos";
                comando.CommandText = query;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var nombre = reader["Nombre"].ToString();
                        var id = Convert.ToInt32(reader["id"]);

                        //Cursos curso2 = (Cursos)reader;
                        var curso = new Cursos("asd", 2, "123", 1, "1", "2", "1");
                        cursos.Add(curso);
                    }
                }
                //return cursos;

                //comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally { conexion.Close(); }
        }

        public static void Guardar(string query)
        {
            try
            {
                conexion.Open();
                //var query = $"INSERT INTO asdasd (nombre) VALUES ('{texto}')";
                //var query = $"INSERT INTO asdasd (nombre) VALUES (@0)";

                comando.CommandText = query;

                //comando.Parameters.AddWithValue("@0", texto);

                var filasAfectadas = comando.ExecuteNonQuery();

                Console.WriteLine("Filas afectadas " + filasAfectadas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conexion.Close(); }
        }

        public static JsonUsuariosFormato ReturnAllUsers()
        {
            Console.WriteLine("asd");

            JsonUsuariosFormato jsonNuevo = new JsonUsuariosFormato
            {
                Administradores = new List<Administrador> { },
                Estudiantes = new List<Estudiantes> { },
                Profesores = new List<Profesores> { }
            };
            try
            {
                conexion.Open();

                var query = "SELECT * FROM Usuarios";
                comando.CommandText = query;

                using (var reader = comando.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            var nombre = reader["Nombre"].ToString();
                            var apellido = reader["Apellido"].ToString();
                            var dni = Convert.ToInt32(reader["Dni"]);
                            var telefono = Convert.ToInt32(reader["Telefono"]);
                            var direccion = reader["Direccion"].ToString();
                            var nivel = Convert.ToInt32(reader["Nivel"]);
                            var correo = reader["Correo"].ToString();
                            var clave = reader["Clave"].ToString();
                            var id = Convert.ToInt32(reader["ID"]);
                            var tipoEntidad = reader["TipoEntidad"].ToString();
                            
                            if (tipoEntidad == "Administrador")
                            {
                                jsonNuevo.Administradores.Add(new Administrador(id, nombre, apellido, nivel, clave, correo));
                            }
                            if (tipoEntidad == "Estudiante")
                            {
                                jsonNuevo.Estudiantes.Add(new Estudiantes(id,nombre,apellido,dni,telefono,direccion,clave,correo));
                            }
                        }
                    }
                    else
                    {
                        return jsonNuevo;
                    }
                }
                //comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally { conexion.Close(); }

            return jsonNuevo;
        }
    }
}
