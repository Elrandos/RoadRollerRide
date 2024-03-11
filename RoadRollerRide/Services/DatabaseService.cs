using RoadRollerRide.Models;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System;
using RoadRollerRide.Models.Cars;
using System.Collections.Generic;
using System.Linq;
using RoadRollerRide.Enums;
using System.Text;
using System.Reflection;
using RoadRollerRide.Models.Maps;

namespace RoadRollerRide.Services
{
    public class DatabaseService
    {
        private string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RoadRollerRide");
        string DatabaseFilePath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RoadRollerRide"), "database.json");

        public Database LoadDatabase()
        {
            if (File.Exists(DatabaseFilePath))
            {
                string json = File.ReadAllText(DatabaseFilePath);
                return JsonConvert.DeserializeObject<Database>(json);
            }
            else
            {
                string resourcesFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
                string initialDatabaseFilePath = Path.Combine(resourcesFolderPath, "InitialDatabaseDirtRally2.0.json");


                string json = File.ReadAllText(initialDatabaseFilePath);
                var initialDataBase = JsonConvert.DeserializeObject<Database>(json);
                SaveDatabase(initialDataBase);
                return initialDataBase;
            }
        }

        public void SaveDatabase(Database database)
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            string json = JsonConvert.SerializeObject(database);
            File.WriteAllText(DatabaseFilePath, json);
        }

        public List<Car> GetAllCarsForDirtRally(Database database)
        {
            return database.Cars.Where(w=> w.Game == Games.DirtRally2).ToList();
        }
        public List<Map> GetAllMapsForDirtRally(Database database)
        {
            return database.Maps.Where(w => w.Game == Games.DirtRally2).ToList();
        }
    }
}
