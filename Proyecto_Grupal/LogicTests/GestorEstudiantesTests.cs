using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Moq;

namespace Logic.Tests
{
    [TestClass()]
    public class GestorEstudiantesTests
    {
        [TestMethod()]
        public void ValidadorEmailTest()
        {
           // arrange

            var gestor = new GestorEstudiantes();
            string pruebaMail = "pruebamail@gmail.com";
            //act

            bool respuesta = gestor.ValidarEmail(pruebaMail);

            // Assert
            Assert.IsTrue(respuesta);

        }
        [TestMethod()]
        public void ValidadorEmailTestError()
        {
            // arrange

            var gestor = new GestorEstudiantes();
            string pruebaMail = "pruebamailgmail.com";
            //act

            bool respuesta = gestor.ValidarEmail(pruebaMail);

            // Assert
            Assert.IsFalse(respuesta);

        }
        [TestMethod()]
        public void ValidadorEstudianteTest()
        {
            // Arrange
            var estudiante = new EstudianteAValidar
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Calle 123",
                Clave = "clave123",
                Telefono = "123456789",
                Dni = "98765432",
                Correo = "juan@example.com"
            };

            var gestor = new GestorEstudiantes();
            // Act
            var resultado = gestor.ValidadorEstudiante(estudiante);

            // Assert
            Assert.IsTrue(resultado);
        }
        [TestMethod()]
        public void ValidadorEstudianteTestError()
        {
            // Arrange
            var estudiante = new EstudianteAValidar
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Calle 123",
                Clave = "clave123",
                Telefono = "asd",
                Dni = "123123",
                Correo = "juan@example.com"
            };

            var gestor = new GestorEstudiantes();
            // Act
            var resultado = gestor.ValidadorEstudiante(estudiante);

            // Assert
            Assert.IsFalse(resultado);
        }

    }
}