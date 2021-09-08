using System;
using System.Collections.Generic;
using System.Text;

namespace Millonarie
{
    public class Respuesta
    {
        private String[,] answers = new String[25, 4] {
            {"tokio","colombia","caracas","bogota"},{"medellin","cali","bogota","paris"},
            { "miguel de cervantes", "carlos","camilo","Julian" },{"judas","francisco","nadie","armando" },
            { "el chavo", "pinocho","don ramon","goku" },{"brasileños","urugayos","chilenos","caleños" },
            {"4","3.50","3.21","3.14" },{"nariño","usa","alemania","bogota" },
            {"venus","marte","tierra","sol"},{"Epa colombia","nick Arsmtrong ","alvaro uribe","neil Arsmtrong" },
            {"1945","1935","1944","1916" },{ " Mark thompson ", " Mark Zuckerberg","Steve JOBS","Mark clan" },
            {"mario","abad","Antoine","allende" },{"marsellesa","maesl","maseel","marsellesel" },
            {"poligrafeno","poligrafo","boligrafo","poligrafito" },{"amsterdam","Tokio","Being jin","New York"},
            { "socrates", "perseo","aristoteles","platon" } ,{"kathie Tereshkova","Valentina Tereshkova","maria Tereshkova","mia Tereshkova" },
            {"mandarin","ingles","frances","español" },{"paleontologia","botanica","zoologia","ontologia" },
            {"Empire State","Torre trump","Burj Khalifa","emirates"},{ "Niza", "Londres","Manchester","Belgica" } ,
            {"igualdad","equivalente","equilatero","equilado" },{"Jong-un-kim"," Jong-nun-kim","Kim Jong-um","Kim Jong-un" },
            {"reptil","mamimero","crustaceo","anfibio" }
        };

        public Respuesta()
        {
        }
        //getter and setter
        public String[,] Answers
        {
            get { return answers; }
            set { answers = value; }
        }
    }
}
