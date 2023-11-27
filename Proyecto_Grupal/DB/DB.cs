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
        /// <summary>
        /// Ejecuta una consulta SQL en la base de datos y muestra el número de filas afectadas.
        /// </summary>
        /// <param name="query">Consulta SQL a ejecutar.</param>
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
        /// <summary>
        /// Obtiene y devuelve todos los usuarios de la base de datos en un formato JSON personalizado.
        /// </summary>
        /// <returns>Objeto JsonUsuariosFormato con listas separadas para Administradores, Estudiantes y Profesores.</returns>
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
                            if (tipoEntidad == "Profesores")
                            {
                                var telefono = Convert.ToInt32(reader["Telefono"]);
                                var direccion = reader["Direccion"].ToString();
                                var especialidad = reader["Especializacion"].ToString();

                                jsonNuevo.Profesores.Add(new Profesores(id, nombre, apellido,
                                    dni, especialidad, clave, correo, telefono));
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
        /// <summary>
        /// Obtiene y devuelve una lista de todos los cursos desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Cursos que representan la información de los cursos.</returns>
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
        /// <summary>
        /// Obtiene y devuelve una lista de todos los registros de estudiantes por curso desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos EstudiantePorCurso que representan la información de la relación entre estudiantes y cursos.</returns>
        public List<ProfesorEnCurso> ReturnAllProfesoresPorCurso()
        {

            var listaProfesoresPorCurso = new List<ProfesorEnCurso>();

            try
            {
                conexion.Open();

                var query = "SELECT * FROM ProfesorEnCurso";
                comando.CommandText = query;

                using (var reader = comando.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            var nombreProfesor = reader["nombreProfesor"].ToString();
                            var apellidoProfesor = reader["apellidoProfesor"].ToString();
                            var codigoProfesor = Convert.ToInt32(reader["codigoProfesor"]);
                            var nombreCurso = reader["nombreCurso"].ToString();
                            var diaSemana = reader["diaSemana"].ToString();
                            var codigoCurso = Convert.ToInt32(reader["codigoCurso"]);
                            var aula = reader["aula"].ToString();
                            var turno = reader["turno"].ToString();

                            listaProfesoresPorCurso.Add(new ProfesorEnCurso(codigoProfesor,
                                nombreProfesor, apellidoProfesor, codigoCurso, nombreCurso, diaSemana,
                                turno, aula));

                        }
                    }
                    else
                    {
                        return listaProfesoresPorCurso;
                    }
                }
            }
            catch (Exception ex)
            {
                return listaProfesoresPorCurso;
            }
            finally { conexion.Close(); }

            return listaProfesoresPorCurso;
        }
        /// <summary>
        /// Obtiene y devuelve una lista de todos los registros de pagos de estudiantes desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos PagoDeEstudiante que representan la información de los pagos realizados por los estudiantes.</returns>
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
        /// <summary>
        /// Obtiene y devuelve una lista de todos los requisitos de cursos desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos RequisitosCurso que representan la información de los requisitos para cada curso.</returns>
        public List<RequisitosCurso> ReturnAllRequisitosDelCurso()
        {
            var listaRequisitos= new List<RequisitosCurso>();

            try
            {
                conexion.Open();

                var query = "SELECT * FROM RequisitosCurso";
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
        /// <summary>
        /// Obtiene y devuelve una lista de todos los registros de estudiantes en lista de espera desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos EstudiantePorCurso que representan la información de los estudiantes en lista de espera.</returns>
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
        /// <summary>
        /// Crea un nuevo registro de estudiante en la base de datos.
        /// </summary>
        /// <param name="nuevoEstudiante">Objeto Estudiantes con la información del nuevo estudiante.</param>
        /// <param name="ultimoId">ID del último registro en la tabla Usuarios.</param>
        /// <param name="claveConHash">Contraseña del estudiante con hash.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task CrearEstudiante(Estudiantes nuevEstudiante, int ultimoId, string claveConHash)
        {
            var query = "INSERT INTO Usuarios (TipoEntidad, ID, Nombre, Apellido, Dni, Telefono, Direccion, Clave, Correo, Fecha)" +
                      $"VALUES ('Estudiantes', '{ultimoId}', '{nuevEstudiante.Nombre}'," +
                      $" '{nuevEstudiante.Apellido}', '{nuevEstudiante.Dni}', '{nuevEstudiante.Telefono}', '{nuevEstudiante.Direccion}'," +
                      $" '{claveConHash}', '{nuevEstudiante.Correo}', '{DateTime.Now}');";

            Guardar(query);
        }
        /// <summary>
        /// Crea un nuevo registro de profesor en la base de datos.
        /// </summary>
        /// <param name="nuevoProfesor">Objeto Profesores con la información del nuevo profesor.</param>
        /// <param name="ultimoId">ID del último registro en la tabla Usuarios.</param>
        /// <param name="claveConHash">Contraseña del profesor con hash.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task CrearProfesor(Profesores nuevProfesor, int ultimoId, string claveConHash)
        {
            var query = "INSERT INTO Usuarios (TipoEntidad, ID, Nombre, Apellido, Dni, Telefono, Especializacion, Clave, Correo, Fecha)" +
                      $"VALUES ('Profesores', '{ultimoId}', '{nuevProfesor.Nombre}'," +
                      $" '{nuevProfesor.Apellido}', '{nuevProfesor.Dni}', '{nuevProfesor.Telefono}', '{nuevProfesor.Especializacion}'," +
                      $" '{claveConHash}', '{nuevProfesor.Correo}', '{DateTime.Now}');";

            Guardar(query);
        }
        /// <summary>
        /// Crea un nuevo registro de curso en la base de datos.
        /// </summary>
        /// <param name="curso">Objeto Cursos con la información del nuevo curso.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task CrearCurso(Cursos curso)
        {
            var query = "INSERT INTO Cursos (Codigo, Nombre, Descripcion, CupoMaximo, DiaSemana, Aula, Turno)" +
                   $"VALUES ('{curso.Codigo}', '{curso.Nombre}', '{curso.Descripcion}', '{curso.CupoMaximo}'," +
                   $" '{curso.DiaSemana}', '{curso.Aula}', '{curso.Turno}');";

            Guardar(query);
        }
        /// <summary>
        /// Modifica un registro de curso en la base de datos y actualiza la información relacionada en la tabla EstudiantePorCurso.
        /// </summary>
        /// <param name="curso">Objeto Cursos con la nueva información del curso.</param>
        /// <param name="codigoAnteriorParseado">Código anterior del curso a modificar.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task ModificarCurso(Cursos curso, int codigoAnteriorParseado)
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
        /// <summary>
        /// Elimina un curso y sus asociaciones en la base de datos.
        /// </summary>
        /// <param name="codigo">Código del curso a eliminar.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task EliminarCurso(int codigo)
        {
            var query = "DELETE FROM Cursos " +
                       $"WHERE Codigo = {codigo}; ";

            Guardar(query);
        }
        /// <summary>
        /// Elimina un estudiante de la lista de espera en la base de datos.
        /// </summary>
        /// <param name="codigo">Código del estudiante a eliminar de la lista de espera.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task EliminarEstudianteEnListaDeEspera(int codigo)
        {
            var query = "DELETE FROM ListaDeEspera " +
                       $"WHERE CodigoEstudiante = {codigo}; ";

            Guardar(query);
        }
        /// <summary>
        /// Agrega un estudiante a un curso en la base de datos.
        /// </summary>
        /// <param name="estudiante">Objeto EstudianteEnCursos con la información del estudiante.</param>
        /// <param name="cursoEnQueSeAgrega">Objeto CursosEnEstudiantes con la información del curso al que se agrega el estudiante.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task AgregarAlumnoAlCurso(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            var query = "INSERT INTO EstudiantePorCurso (CodigoEstudiante, NombreEstudiante, ApellidoEstudiante," +
                        " CodigoCurso, NombreCurso, DiaSemana, Aula, Turno, Fecha)" +
                        $"VALUES ('{estudiante.Id}', '{estudiante.Nombre}', '{estudiante.Apellido}', '{cursoEnQueSeAgrega.Codigo}'," +
                        $" '{cursoEnQueSeAgrega.Nombre}', '{cursoEnQueSeAgrega.DiaSemana}', '{cursoEnQueSeAgrega.Aula}', '{cursoEnQueSeAgrega.Turno}', '{DateTime.Now}');";

            Guardar(query);
        }
        /// <summary>
        /// Agrega un profesor a un curso en la base de datos.
        /// </summary>
        /// <param name="profesor">Objeto Profesores con la información del profesor.</param>
        /// <param name="cursoEnQueSeAgrega">Objeto CursosEnEstudiantes con la información del curso al que se agrega el profesor.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task AgregarProfesorAlCurso(Profesores profesor, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            var query = "INSERT INTO ProfesorEnCurso (codigoProfesor, nombreProfesor, apellidoProfesor," +
                        " codigoCurso, nombreCurso, diaSemana, aula, turno)" +
                        $"VALUES ('{profesor.Id}', '{profesor.Nombre}', '{profesor.Apellido}', '{cursoEnQueSeAgrega.Codigo}'," +
                        $" '{cursoEnQueSeAgrega.Nombre}', '{cursoEnQueSeAgrega.DiaSemana}', '{cursoEnQueSeAgrega.Aula}', '{cursoEnQueSeAgrega.Turno}');";

            Guardar(query);
        }
        /// <summary>
        /// Agrega un estudiante a la lista de espera en la base de datos.
        /// </summary>
        /// <param name="estudiante">Objeto EstudianteEnCursos con la información del estudiante.</param>
        /// <param name="cursoEnQueSeAgrega">Objeto CursosEnEstudiantes con la información del curso al que se intenta agregar el estudiante.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task AgregarAlumnoAListaDeEspera(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            var query = "INSERT INTO ListaDeEspera (CodigoEstudiante, NombreEstudiante, ApellidoEstudiante," +
                        " CodigoCurso, NombreCurso, DiaSemana, Aula, Turno, Fecha)" +
                        $"VALUES ('{estudiante.Id}', '{estudiante.Nombre}', '{estudiante.Apellido}', '{cursoEnQueSeAgrega.Codigo}'," +
                        $" '{cursoEnQueSeAgrega.Nombre}', '{cursoEnQueSeAgrega.DiaSemana}', '{cursoEnQueSeAgrega.Aula}', '{cursoEnQueSeAgrega.Turno}', '{DateTime.Now}');";

            Guardar(query);
        }
        /// <summary>
        /// Crea un nuevo registro de pago de estudiante en la base de datos.
        /// </summary>
        /// <param name="pagoDeEstudiante">Objeto PagoDeEstudiante con la información del nuevo pago.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task CrearPago(PagoDeEstudiante pagoDeEstudiante)
        {
            var query = "INSERT INTO PagosDeEstudiantes (monto, nombre, apellido, idEstudiante, fecha, Conseptos)" +
                  $"VALUES ('{pagoDeEstudiante.Monto}', '{pagoDeEstudiante.Nombre}', '{pagoDeEstudiante.Apellido}'," +
                  $" '{pagoDeEstudiante.IdEstudiante}'," +
                  $" '{pagoDeEstudiante.Fecha}', '{pagoDeEstudiante.Consepto}');";

            Guardar(query);
        }
        /// <summary>
        /// Modifica un requisito de curso en la base de datos.
        /// </summary>
        /// <param name="requisito">Objeto RequisitosCurso con la información del requisito a modificar.</param>
        /// <param name="existe">Indica si el requisito ya existe en la base de datos.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task ModificarRequisito(RequisitosCurso requisito, bool existe)
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
        /// <summary>
        /// Modifica un registro de profesor en la base de datos.
        /// </summary>
        /// <param name="profesor">Objeto Profesores con la nueva información del profesor.</param>
        /// <param name="codigoAnteriorParseado">Código anterior del profesor a modificar.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task ModificarProfesor(Profesores profesor, int codigoAnteriorParseado)
        {
            var query = $"DELETE FROM Usuarios \n" +
                      $"WHERE ID = {codigoAnteriorParseado} AND TipoEntidad = 'Profesores';" +
                        "INSERT INTO Usuarios (TipoEntidad, ID, Nombre, Apellido, Dni, Telefono, Especializacion, Clave, Correo, Fecha)" +
                      $"VALUES ('Profesores', '{codigoAnteriorParseado}', '{profesor.Nombre}'," +
                      $" '{profesor.Apellido}', '{profesor.Dni}', '{profesor.Telefono}', '{profesor.Especializacion}'," +
                      $" '{profesor}', '{profesor.Correo}', '{DateTime.Now}');\n";

            Guardar(query);
        }
        /// <summary>
        /// Elimina un profesor de la base de datos.
        /// </summary>
        /// <param name="correo">Correo del profesor a eliminar.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async Task EliminarProfesor(string correo)
        {
            var query = "DELETE FROM Usuarios " +
                       $"WHERE Correo = '{correo}'; ";

            Guardar(query);
        }
    }
}   

