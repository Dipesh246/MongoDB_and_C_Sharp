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

        public static void CreateCollection(string databaseName, string collectionName)
        {
            try
            {
                MongoClient dbClient = new MongoClient(connectionUri);
                var database = dbClient.GetDatabase(databaseName);
                database.CreateCollection(collectionName);
                Console.WriteLine($"Collection'{collectionName}' created sucessfully in database '{databaseName}'.");

            }
            catch(MongoCommandException ex) when (ex.CodeName == "NamespaceExists") 
            {
                Console.WriteLine($"Collection '{collectionName}' already exists in database '{databaseName}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }

        public static void DeleteCollection(string databaseName, string collectionName)
        {
            try
            {
                MongoClient dbClient = new MongoClient(connectionUri);
                var database = dbClient.GetDatabase(databaseName);

                database.DropCollection(collectionName);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete collection '{collectionName}': {ex.Message}");
            }
        }
    }   
}
