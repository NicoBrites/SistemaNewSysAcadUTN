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

                comando.CommandText = query;

                var filasAfectadas = comando.ExecuteNonQuery();

                Console.WriteLine("Filas afectadas " + filasAfectadas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { conexion.Close(); }
        }

        public static JsonUsuariosFormato ReturnAllUsers()
        {

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
                            var correo = reader["Correo"].ToString();
                            var clave = reader["Clave"].ToString();
                            var id = Convert.ToInt32(reader["ID"]);
                            var tipoEntidad = reader["TipoEntidad"].ToString();
                            
                            if (tipoEntidad == "Administradores")
                            {
                                var nivel = Convert.ToInt32(reader["Nivel"]);

                                jsonNuevo.Administradores.Add(new Administrador(id, nombre,
                                    apellido, nivel, clave, correo));
                            }
                            if (tipoEntidad == "Estudiantes")
                            {
                                var telefono = Convert.ToInt32(reader["Telefono"]);
                                var direccion = reader["Direccion"].ToString();

                                jsonNuevo.Estudiantes.Add(new Estudiantes(id,nombre,apellido,
                                    dni,telefono,direccion,clave,correo, DateTime.Now));
                            }
                        }
                    }
                    else
                    {
                        return jsonNuevo;
                    }
                }
            }
            catch (Exception ex)
            {
                return jsonNuevo;
            }
            finally { conexion.Close(); }

            return jsonNuevo;
        }

        public static List<Cursos> ReturnAllCursos()
        {

            var listaCursos = new List<Cursos>();

            try
            {
                conexion.Open();

                var query = "SELECT * FROM Cursos";
                comando.CommandText = query;

                using (var reader = comando.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            var nombre = reader["Nombre"].ToString();
                            var descripcion = reader["Descripcion"].ToString();
                            var codigo = Convert.ToInt32(reader["Codigo"]);
                            var diaSemana = reader["DiaSemana"].ToString();
                            var aula = reader["Aula"].ToString();
                            var cupoMaximo = Convert.ToInt32(reader["CupoMaximo"]);
                            var turno = reader["Turno"].ToString();

                            listaCursos.Add(new Cursos(nombre, codigo, descripcion, 
                                cupoMaximo, diaSemana, aula, turno));

                        }
                    }
                    else
                    {
                        return listaCursos;
                    }
                }
            }
            catch (Exception ex)
            {
                return listaCursos;
            }
            finally { conexion.Close(); }

            return listaCursos;
        }

        public static List<EstudiantePorCurso> ReturnAllEstudiantesPorCurso()
        {

            var listaEstudiantesPorCurso = new List<EstudiantePorCurso>();

            try
            {
                conexion.Open();

                var query = "SELECT * FROM EstudiantePorCurso";
                comando.CommandText = query;

                using (var reader = comando.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            var nombreEstudiante = reader["NombreEstudiante"].ToString();
                            var apellidoEstudiante = reader["ApellidoEstudiante"].ToString();
                            var codigoEstudiante = Convert.ToInt32(reader["CodigoEstudiante"]);
                            var nombreCurso = reader["NombreCurso"].ToString();
                            var diaSemana = reader["DiaSemana"].ToString();
                            var codigoCurso = Convert.ToInt32(reader["CodigoCurso"]);
                            var aula = reader["Aula"].ToString();
                            var turno = reader["Turno"].ToString();

                            listaEstudiantesPorCurso.Add(new EstudiantePorCurso(codigoEstudiante,
                                nombreEstudiante,apellidoEstudiante,codigoCurso,nombreCurso, diaSemana,
                                turno, aula, DateTime.Now));

                        }
                    }
                    else
                    {
                        return listaEstudiantesPorCurso;
                    }
                }
            }
            catch (Exception ex)
            {
                return listaEstudiantesPorCurso;
            }
            finally { conexion.Close(); }

            return listaEstudiantesPorCurso;
        }
        public static List<PagoDeEstudiante> ReturnAllPagoDeEstudiante()
        {

            var listaPagoDeEstudiante = new List<PagoDeEstudiante>();

            try
            {
                conexion.Open();

                var query = "SELECT * FROM PagosDeEstudiantes";
                comando.CommandText = query;

                using (var reader = comando.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            var consepto = reader["Conseptos"].ToString();
                            var nombre = reader["nombre"].ToString();
                            var monto = Convert.ToInt32(reader["monto"]);
                            var apellido = reader["apellido"].ToString();
                            var idPago = Convert.ToInt32(reader["monto"]);
                            var idEstudiante = Convert.ToInt32(reader["idEstudiante"]);
                            var fecha = reader.GetDateTime(reader.GetOrdinal("fecha"));

                            listaPagoDeEstudiante.Add(new PagoDeEstudiante(consepto,monto,nombre,apellido,idEstudiante,fecha));

                        }
                    }
                    else
                    {
                        return listaPagoDeEstudiante;
                    }
                }
            }
            catch (Exception ex)
            {
                return listaPagoDeEstudiante;
            }
            finally { conexion.Close(); }

            return listaPagoDeEstudiante;
        }


    }

    
}   

