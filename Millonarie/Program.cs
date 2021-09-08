using Millonarie.utils;
using System;
namespace Millonarie
{
    public class Program
    {
        public static Pregunta pregunta = new Pregunta();
        public static Respuesta respuesta = new Respuesta();
        public static Jugador jugador = new Jugador(null,"", 0, 1);
        public static Boolean juego = true;
        public static ConexionBD conexionBD = new ConexionBD();
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese  Nombre: ");
            string name = Console.ReadLine();
            jugador.Nombre = name.ToUpper();
            Console.WriteLine("------------------------Bienvenido " + jugador.Nombre + " A Quien Quiere Ser Millonario------------------------");
            int i = 1;
            while (i<=5 && juego==true)
            {
                Console.WriteLine("Ronda Numero : " + i+" -->> Puntos en Juego: "+i*5);
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                seleccionarPregunta(i);
                i++;
            }
        }
        public static int seleccionarPregunta(int ronda)
        {
            switch (ronda)
            {
                case 1:
                    int randomNumber = new Random().Next(0, 5);
                    Console.WriteLine(pregunta.Questions[randomNumber]);
                    mostrarOpciones(randomNumber);
                    elegirRespuesta(randomNumber);
                    return randomNumber;
                case 2:
                    randomNumber = new Random().Next(6, 10);
                    Console.WriteLine(pregunta.Questions[randomNumber]);
                    mostrarOpciones(randomNumber);
                    elegirRespuesta(randomNumber);
                    return randomNumber;
                case 3:
                    randomNumber = new Random().Next(11, 15);
                    Console.WriteLine(pregunta.Questions[randomNumber]);
                    mostrarOpciones(randomNumber);
                    elegirRespuesta(randomNumber);
                    return randomNumber;
                case 4:
                    randomNumber = new Random().Next(16, 20);
                    Console.WriteLine(pregunta.Questions[randomNumber]);
                    mostrarOpciones(randomNumber);
                    elegirRespuesta(randomNumber);
                    return randomNumber;
                default:
                    randomNumber = new Random().Next(21, 25);
                    Console.WriteLine(pregunta.Questions[randomNumber]);
                    mostrarOpciones(randomNumber);
                    elegirRespuesta(randomNumber);
                    return randomNumber;
            }
        }
        public static void mostrarOpciones(int randonNumber)
        {
            for (int i = 0; i <respuesta.Answers.GetLength(0) ; i++)
            {
                for (int j = 0; j < respuesta.Answers.GetLength(1); j++)
                {
                    if (i==randonNumber)
                    {
                        Console.WriteLine("Opcion "+(j+1)+"--> "+respuesta.Answers[i, j]);
                    }
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine(" ¿ Desea Retirarse del Juego ? ,presione la tecla -> s/S : ");
            string opcion = Console.ReadLine().ToLower();
            if (opcion.Equals("s")){
                juego = false;
                Console.WriteLine(" Te has Retirado,Juego Finalizado!,Puntos Acomulados: " +jugador.Puntaje);
                conexionBD.guardarJugador(jugador);
                Console.ReadLine();
                
            }
        }
        public static void elegirRespuesta(int randomNumber)
        {
            Console.WriteLine("Ingrese la opcion Elegida: ");
            int opcion=Convert.ToInt16( Console.ReadLine());
            if (pregunta.Claves[randomNumber]==opcion){
                jugador.addPuntos(jugador.Ronda);
                jugador.pasarNivel();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("!Respuesta Correcta¡,Puntos Acomulados: "+jugador.Puntaje);
                Console.ResetColor();
                if (jugador.Ronda==6){
                    jugador.Ronda = 5;
                    conexionBD.guardarJugador(jugador);
                    Console.WriteLine("!!!Juego Finalizado¡!!,---------FELICIDADES,GANASTE EL PREMIO MAYOR----------");
                }
            }
            else{
                juego = false;
                jugador.Puntaje = 0;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("!Respuesta Incorrecta¡,Puntos Acomulados: " +0+" Juego Finalizado!");
                Console.ResetColor();
                conexionBD.guardarJugador(jugador);
            }
        }
    }
}
