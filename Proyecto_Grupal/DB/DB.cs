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
        private SqlConnection conexion;
        private string cadenaConexion;
        private SqlCommand comando;

        public DB()
        {
            cadenaConexion = @"Server=DESKTOP-SB7OU3P\SQLEXPRESS;Database=SysAcad;Trusted_Connection=True;TrustServerCertificate=True;";
            conexion = new SqlConnection(cadenaConexion);

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public void Guardar(string query)
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

        public JsonUsuariosFormato ReturnAllUsers()
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
        public List<Cursos> ReturnAllCursos()
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
        public List<EstudiantePorCurso> ReturnAllEstudiantesPorCurso()
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
        public List<PagoDeEstudiante> ReturnAllPagoDeEstudiante()
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

        public List<RequisitosCurso> ReturnAllRequisitosDelCurso()
        {
            var listaRequisitos= new List<RequisitosCurso>();

            try
            {
                conexion.Open();

                var query = "SELECT * FROM RequisitosDelCurso";
                comando.CommandText = query;

                using (var reader = comando.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            var nombre = reader["Nombre"].ToString();
                            var codigo = Convert.ToInt32(reader["Codigo"]);
                            var cursosPreRequisito = reader["CursosPreRequisito"].ToString();
                            var creditosAcumulados = Convert.ToInt32(reader["CreditosAcumulados"]);
                            var promedioAcademico = Convert.ToInt32(reader["PromedioAcademico"]);

                            listaRequisitos.Add(new RequisitosCurso(nombre, codigo, cursosPreRequisito,
                                creditosAcumulados, promedioAcademico));
                        }
                    }
                    else
                    {
                        return listaRequisitos;
                    }
                }
            }
            catch (Exception ex)
            {
                return listaRequisitos;
            }
            finally { conexion.Close(); }

            return listaRequisitos;
        }
        public List<EstudiantePorCurso> ReturnAllEstudiantesEnListaEspera()
        {

            var listaEstudiantesPorCurso = new List<EstudiantePorCurso>();

            try
            {
                conexion.Open();

                var query = "SELECT * FROM ListaDeEspera " +
                    "ORDER BY Fecha";
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
                                nombreEstudiante, apellidoEstudiante, codigoCurso, nombreCurso, diaSemana,
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

        public void CrearEstudiante(Estudiantes nuevEstudiante, int ultimoId, string claveConHash)
        {
            var query = "INSERT INTO Usuarios (TipoEntidad, ID, Nombre, Apellido, Dni, Telefono, Direccion, Clave, Correo, Fecha)" +
                      $"VALUES ('Estudiantes', '{ultimoId}', '{nuevEstudiante.Nombre}'," +
                      $" '{nuevEstudiante.Apellido}', '{nuevEstudiante.Dni}', '{nuevEstudiante.Telefono}', '{nuevEstudiante.Direccion}'," +
                      $" '{claveConHash}', '{nuevEstudiante.Correo}', '{DateTime.Now}');";

            Guardar(query);
        }

        public void CrearCurso(Cursos curso)
        {
            var query = "INSERT INTO Cursos (Codigo, Nombre, Descripcion, CupoMaximo, DiaSemana, Aula, Turno)" +
                   $"VALUES ('{curso.Codigo}', '{curso.Nombre}', '{curso.Descripcion}', '{curso.CupoMaximo}'," +
                   $" '{curso.DiaSemana}', '{curso.Aula}', '{curso.Turno}');";

            Guardar(query);
        }
        public void ModificarCurso(Cursos curso, int codigoAnteriorParseado)
        {
            var query = "UPDATE Cursos " +
              $"SET Nombre = '{curso.Nombre}', Descripcion = '{curso.Descripcion}', Codigo = '{curso.Codigo}'," +
              $" CupoMaximo = '{curso.CupoMaximo}', DiaSemana = '{curso.DiaSemana}', Aula = '{curso.Aula}', Turno = '{curso.Turno}'" +
              $"WHERE Codigo = {codigoAnteriorParseado};" +
              $"UPDATE EstudiantePorCurso " +
              $"SET NombreCurso = '{curso.Nombre}', CodigoCurso = '{curso.Codigo}'," +  // PARTE NUEVA AGREGADO PARA EL SEG PARCIAL
              $"  DiaSemana = '{curso.DiaSemana}', Aula = '{curso.Aula}', Turno = '{curso.Turno}'" +
              $"WHERE CodigoCurso = {codigoAnteriorParseado}";

            Guardar(query);
        }

        public void EliminarCurso(int codigo)
        {
            var query = "DELETE FROM Cursos " +
                       $"WHERE Codigo = {codigo}; ";

            Guardar(query);
        }

        public void EliminarEstudianteEnListaDeEspera(int codigo)
        {
            var query = "DELETE FROM Cursos " +
                       $"WHERE Codigo = {codigo}; ";

            Guardar(query);
        }

        public void AgregarAlumnoAlCurso(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            var query = "INSERT INTO EstudiantePorCurso (CodigoEstudiante, NombreEstudiante, ApellidoEstudiante," +
                        " CodigoCurso, NombreCurso, DiaSemana, Aula, Turno, Fecha)" +
                        $"VALUES ('{estudiante.Id}', '{estudiante.Nombre}', '{estudiante.Apellido}', '{cursoEnQueSeAgrega.Codigo}'," +
                        $" '{cursoEnQueSeAgrega.Nombre}', '{cursoEnQueSeAgrega.DiaSemana}', '{cursoEnQueSeAgrega.Aula}', '{cursoEnQueSeAgrega.Turno}', '{DateTime.Now}');";

            Guardar(query);
        }

        public void AgregarAlumnoAListaDeEspera(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            var query = "INSERT INTO ListaDeEspera (CodigoEstudiante, NombreEstudiante, ApellidoEstudiante," +
                        " CodigoCurso, NombreCurso, DiaSemana, Aula, Turno, Fecha)" +
                        $"VALUES ('{estudiante.Id}', '{estudiante.Nombre}', '{estudiante.Apellido}', '{cursoEnQueSeAgrega.Codigo}'," +
                        $" '{cursoEnQueSeAgrega.Nombre}', '{cursoEnQueSeAgrega.DiaSemana}', '{cursoEnQueSeAgrega.Aula}', '{cursoEnQueSeAgrega.Turno}', '{DateTime.Now}');";

            Guardar(query);
        }

        public void CrearPago(PagoDeEstudiante pagoDeEstudiante)
        {
            var query = "INSERT INTO PagosDeEstudiantes (monto, nombre, apellido, idEstudiante, fecha, Conseptos)" +
                  $"VALUES ('{pagoDeEstudiante.Monto}', '{pagoDeEstudiante.Nombre}', '{pagoDeEstudiante.Apellido}'," +
                  $" '{pagoDeEstudiante.IdEstudiante}'," +
                  $" '{pagoDeEstudiante.Fecha}', '{pagoDeEstudiante.Consepto}');";

            Guardar(query);
        }

        public void ModificarRequisito(RequisitosCurso requisito, bool existe)
        {
            if (existe == false) 
            {
               var  query = "INSERT INTO RequisitosCurso (Nombre, Codigo, CursosPreRequisito, CreditosAcumulados, PromedioAcademico)" +
                 $"VALUES ('{requisito.Nombre}', '{requisito.Codigo}', '{requisito.CursosPreRequisito}'," +
                 $" '{requisito.CreditosAcumulados}'," +
                 $" '{requisito.PromedioAcademico}');";
                Guardar(query);

            }
            else
            {
               var  query = "UPDATE RequisitosCurso " +
                  $"SET CursosPreRequisito = '{requisito.CursosPreRequisito}'," +
                  $" CreditosAcumulados = '{requisito.CreditosAcumulados}'," +
                  $" PromedioAcademico = '{requisito.PromedioAcademico}'" +
                  $"WHERE Codigo = {requisito.Codigo};";
                Guardar(query);
            }
            
        }
    }    
}   

