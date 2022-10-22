using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Blazor_Control_Work.Data;

namespace Blazor_Control_Work
{
    public class MongoExamples
    {
        public static User Find(string name) // Returns a document
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DB");
            var collection = database.GetCollection<User>("Users");
            var document = collection.Find(x => x.Name == name).FirstOrDefault();
            return document;
        }

        public static void SaveValues(string name, User unit) // Replaces the document
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DB");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Name == name, unit);
        }

        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DB");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);

        }
    }
}
