using System;
using System.Collections.Generic;
using System.Text;

namespace Millonarie
{
    public class Pregunta
    {
        private String[] questions = {

            "¿Cuál es la capital de Venezuela? ",
            "¿Dónde se encuentra la emblemática Torre Eiffel?",
            "¿Quién es el autor de el Don Quijote de la Mancha",
            "¿Según la Biblia, quién traicionó a Jesús?",
            "¿A quién le crecía la nariz cuando mentía?",
            "¿A qué personas se las conoce como carioca?",
               "¿A cuánto equivale el número pi?",
                "¿Dónde se encuentra la famosa Casa Blanca?",
                "¿Cuál es tercer planeta del sistema solar?",
            "¿Quién fue el primer hombre en pisar la luna?",
            "¿Cuándo acabó la Segunda Guerra Mundial?",
               "¿Cuál es el nombre del fundador de Facebook?",
                "¿Quién escribió ‘El Principito’?",
               "¿Cuál es el himno nacional de Francia?",
                "¿Qué nombre científico recibe el detector de mentiras?",
                "¿Cuál es conocida como la ciudad de los rascacielos?",
                "¿Quién dijo “yo sólo sé que no se nada”?",
                "¿Quién fue la primera mujer en ir al espacio?",
                "¿Cuál es la lengua más hablada en el mundo?",
           "¿Qué rama de la Biología se encarga del estudio de los animales?" ,
               "¿Cuál es el edificio más alto del mundo?" ,
               "¿En qué país se encuentra el Wembley Arena?",
               "¿Cómo se llama el triángulo que tiene sus tres lados iguales ?",
               "¿Quién es el dirigente en Corea del Norte?",
               "¿Qué tipo de animal es la ballena?"

        };
    
        private int[] claves= { 3, 4, 1, 1, 2, 1, 4, 2, 3, 4, 1, 2, 3, 1, 2, 4, 1, 2, 1, 3, 3, 2, 3, 4, 2 };

        public Pregunta()
        {
        }
        //getter and setter
        public String[] Questions
        {
            get { return questions; }
            set { questions = value; }
        }
        public int[] Claves
        {
            get { return claves; }
            set { claves = value; }
        }
    }
}
