using BSM_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BSM_DataService
{
    public class JsonFileDataService : IBikeDataService
    {
        string jsonFilePath = "BikeInfo.json";
        List<Bikeparts> BikeInfo = new List<Bikeparts>();
        public JsonFileDataService() 
        {
            ReadJsonDataFromFile();
        }
        private void ReadJsonDataFromFile()
        {
            string jsonText = File.ReadAllText(jsonFilePath);
            BikeInfo = JsonSerializer.Deserialize<List<Bikeparts>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
        private void WriteJsonDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(BikeInfo, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonFilePath, jsonString);
        }
 
        public List<Bikeparts> GetAllBikes()
        {
            return BikeInfo;
        }

        public bool AddBike(Bikeparts bike)
        {
            BikeInfo.Add(bike);
            WriteJsonDataToFile();
            return true;
        }
        public void UpdateBike(int index, Bikeparts bike)
        {
            if (index >= 0 && index < BikeInfo.Count)
            {
                BikeInfo[index].Price = bike.Price;
                BikeInfo[index].Frameset = bike.Frameset;
                BikeInfo[index].Groupset = bike.Groupset;
                BikeInfo[index].Wheelset = bike.Wheelset;

                WriteJsonDataToFile();
            }
        }
        public bool DeleteBike(int index, Bikeparts bike)
        {
            if (index >= 0 && index < BikeInfo.Count)
            {
                BikeInfo.RemoveAt(index);
                WriteJsonDataToFile();
            }
            return true;
        }
       
    }
}
