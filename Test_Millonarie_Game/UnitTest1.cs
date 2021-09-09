using Microsoft.VisualStudio.TestTools.UnitTesting;
using Millonarie;
using System;

namespace Test_Millonarie_Game
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSeleccionarPregunta()
        {
            //Arrange
            int ronda = 1;
            var resultEsperado = 3;
            Program program = new Program();

            //Act
            var result = program.seleccionarPregunta(ronda);
            
            //Assert
            Assert.AreEqual(resultEsperado,result);
            
        }
       
        [TestMethod]
        public void TestMethodPasarNivel()
        {
            //Arrange
            string id = "1";
            string nombre = "omar silva";
            int puntaje = 5;
            int ronda = 2;
            var resultEsperado = 3;
            Jugador jugador= new Jugador(id,nombre,puntaje,ronda);

            //Act
            jugador.pasarNivel();
            var result = jugador.Ronda;

            //Assert
            Assert.AreEqual(resultEsperado, result);

        }
        [TestMethod]
        public void TestMethodaddPuntos()
        {
            //Arrange
            string id = "1";
            string nombre = "omar silva";
            int puntaje = 5;
            int ronda = 2;
            var resultEsperado = 15;
            Jugador jugador = new Jugador(id, nombre, puntaje, ronda);

            //Act
            jugador.addPuntos(ronda);
            var result = jugador.Puntaje;

            //Assert
            Assert.AreEqual(resultEsperado, result);

        }

        [TestMethod]
        public void TestMethodcrearNombre()
        {
            //Arrange
            string id = "1";
            string nombre = "Pepito perez";
            int puntaje = 5;
            int ronda = 2;
            var resultEsperado = "PEPITO PEREZ";
            Jugador jugador = new Jugador(id, nombre, puntaje, ronda);

            //Act
            jugador.crearNombre();
            var result = jugador.Nombre;

            //Assert
            Assert.AreEqual(resultEsperado, result);

        }
    }
}
