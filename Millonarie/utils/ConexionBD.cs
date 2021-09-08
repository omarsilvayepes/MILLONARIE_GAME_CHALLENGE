using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Millonarie.utils
{
    public class ConexionBD
        
    {
        public static string MONGO_URI = "mongodb+srv://admin:mongoDB@proyectos.v5ovr.mongodb.net/millonarie_Game?retryWrites=true&w=majority";
        public static string MONGO_DB = "millonarie_Game";
        public IMongoCollection<Jugador> connect()
        {
            var settings = MongoClientSettings.FromConnectionString(MONGO_URI);
            var client = new MongoClient(settings);
            var database = client.GetDatabase(MONGO_DB);
            var collection = database.GetCollection<Jugador>("jugadores");
            return collection;
        }

        public void guardarJugador(Jugador jugador)
        {
            var collectionDb = connect();
            collectionDb.InsertOne(jugador);
        }



    }
}
