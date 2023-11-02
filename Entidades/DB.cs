using Azure.Core;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enums;

namespace Entidades
{/*
    public class DB
    {
        private static SqlConnection conexion;
        private static string cadenaConexion;
        private static SqlCommand comando;

        static DB()
        {
            cadenaConexion = @"Server=DESKTOP-SB7OU3P\SQLEXPRESS;Database=SysAcad;Trusted_Connection=True;TrustServerCertificate=True;";
            conexion = new SqlConnection(cadenaConexion);

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;

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
                        var curso = new Cursos("asd",2,"123",1,"1","2","1");
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

        public static void Guardar(string texto)
        {
            try
            {
                conexion.Open();
                //var query = $"INSERT INTO asdasd (nombre) VALUES ('{texto}')";
                var query = $"INSERT INTO asdasd (nombre) VALUES (@0)";

                comando.CommandText = query;

                comando.Parameters.AddWithValue("@0", texto);

                var filasAfectadas = comando.ExecuteNonQuery();

                Console.WriteLine("Filas afectadas " + filasAfectadas);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally { conexion.Close(); }
        }

    }*/
}
