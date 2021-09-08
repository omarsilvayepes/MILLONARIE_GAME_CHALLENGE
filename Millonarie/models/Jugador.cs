using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Millonarie
{
    public class Jugador
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private String id;
        private String nombre;
        private int puntaje;
        private int ronda;
        public Jugador(string id,string nombre, int puntaje, int ronda)
        {
            this.id = id;
            this.nombre = nombre;
            this.puntaje = puntaje;
            this.ronda = ronda;
            
        }
        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }
        public int Ronda
        {
            get { return ronda; }
            set { ronda = value; }
        }

        public void pasarNivel()
        {
                this.ronda++;    
        }
        public void addPuntos(int ronda)
        {
            this.puntaje+=5*ronda;
        }
    }
}
