using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSM_Common;

namespace BSM_DataService
{
    public class TextFileDataService : IBikeDataService
    {
        string filepath = "BikeInfo.txt";
        List<Bikeparts> BikeInfo = new List<Bikeparts>();
        public TextFileDataService()
        {
           GetDataFromFile();
        }
        private void GetDataFromFile()
        {
            var lines = File.ReadAllLines(filepath);
            
            foreach(var line in lines)
            {
                var parts = line.Split('|');

                BikeInfo.Add(new Bikeparts {
                    BikeType = parts[0],
                    Brand = parts[1],
                    Price =(int)Convert.ToDouble(parts[2]),
                    Frameset = parts[3],
                    Groupset = parts[4],
                    Wheelset = parts[5]
                });
               
            }

        }
        private void WriteDataToFile()
        {
            var lines = new string[BikeInfo.Count];
            for (int i = 0; i < BikeInfo.Count; i++)
            {
                lines[i] = $"{BikeInfo[i].BikeType}|{BikeInfo[i].Brand}|{BikeInfo[i].Price}|{BikeInfo[i].Frameset}|{BikeInfo[i].Groupset}|{BikeInfo[i].Wheelset}";
            }
            File.WriteAllLines(filepath, lines);
        }
        public int FindIndex(Bikeparts bike)
        {
            
            for (int i = 0; i < BikeInfo.Count; i++)
            {
                if (BikeInfo[i].BikeType == bike.BikeType && BikeInfo[i].Brand == bike.Brand)
                {
                    return i;

                }
            }
            return -1;
        }
        public List<Bikeparts> GetAllBikes()
        {
            return BikeInfo;
        }

        public void AddBike(Bikeparts bike)
        {
            var newLine = $"{bike.BikeType}|{bike.Brand}|{bike.Price}|{bike.Frameset}|{bike.Groupset}|{bike.Wheelset}";

            File.AppendAllText(filepath, newLine);
        }
        public void UpdateBike(int index,Bikeparts bike)
        {
            index = FindIndex(bike);


         
            BikeInfo[index].Price = bike.Price;
            BikeInfo[index].Frameset = bike.Frameset;
            BikeInfo[index].Groupset = bike.Groupset;
            BikeInfo[index].Wheelset = bike.Wheelset;
           
         WriteDataToFile();
        }
        public void DeleteBike(int index,Bikeparts bike)
        {
            index = -1;
            for (int i = 0; i < BikeInfo.Count; i++)
            {
                if (BikeInfo[i].BikeType == bike.BikeType && BikeInfo[i].Brand == bike.Brand)
                {
                    index = i;
                    
                }
            }
            BikeInfo.RemoveAt(index);

            WriteDataToFile();
        }
    }
}
