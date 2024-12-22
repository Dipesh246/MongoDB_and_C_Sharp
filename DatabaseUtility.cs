using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityApp
{
    public class DatabaseUtility
    {
        const string connectionUri = "mongodb://localhost:27017";
        public static List<string> GetDatabaseNames(){
            try
            {

                MongoClient dbClient = new MongoClient(connectionUri);
                var dbList = dbClient.ListDatabaseNames().ToList();

                return dbList;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<string>();
            }
            
        }
        public static List<string> GetCollections(string databaseName)
        {
            try
            {
                MongoClient dbClient = new MongoClient(connectionUri);
                var database = dbClient.GetDatabase(databaseName);
                var collections = database.ListCollectionNames().ToList();
                return collections;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<string>();
            }
        }
    }   
}
