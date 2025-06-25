using BSM_Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM_DataService
{
    class DBDataService : IBikeDataServiceForDB
    {
        static string connectionString
       = "Data Source =MSI\\SQLEXPRESS; Initial Catalog = BSM; Integrated Security = True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

        public DBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public bool AddBike(Bikeparts bike)
        {
            var insertStatement = "INSERT INTO BikeInfo VALUES (@BikeType, @Brand, @Price, @Frameset, @Groupset, @Wheelset)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@BikeType", bike.BikeType);
            insertCommand.Parameters.AddWithValue("@Brand", bike.Brand);
            insertCommand.Parameters.AddWithValue("@Price", bike.Price);
            insertCommand.Parameters.AddWithValue("@Frameset", bike.Frameset);
            insertCommand.Parameters.AddWithValue("@Groupset", bike.Groupset);
            insertCommand.Parameters.AddWithValue("@Wheelset", bike.Wheelset);
            sqlConnection.Open();

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return true;
        }

        public bool DeleteBike(Bikeparts bike)
        {
            sqlConnection.Open();

            var deleteStatement = $"DELETE FROM BikeInfo WHERE Frameset = @Frameset";
            SqlCommand updateCommand = new SqlCommand(deleteStatement, sqlConnection);
            updateCommand.Parameters.AddWithValue("@Frameset", bike.Frameset);

            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return true;
        }

        

        public List<Bikeparts> GetAllBikes()
        {
            string selectStatement = "SELECT BikeType, Brand, Price, Frameset, Groupset,Wheelset FROM BikeInfo";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            var Bikeinfo = new List<Bikeparts>();

            while (reader.Read())
            {
               

                Bikeparts bikespecs = new Bikeparts();
                bikespecs.BikeType = reader["BikeType"].ToString();
                bikespecs.Brand = reader["Brand"].ToString();
                bikespecs.Price = (int)Convert.ToDouble(reader["Price"].ToString());
                bikespecs.Frameset = reader["Frameset"].ToString();
                bikespecs.Groupset = reader["Groupset"].ToString();
                bikespecs.Wheelset = reader["Wheelset"].ToString();

                Bikeinfo.Add(bikespecs);
            }
            sqlConnection.Close();
            return Bikeinfo; ;
        }

        public void UpdateBike(Bikeparts bike)
        {
            sqlConnection.Open();

            var updateStatement = $"UPDATE BikeInfo SET BikeType = @BikeType, Brand = @Brand, Price = @Price, Frameset=@Frameset, Groupset=@Groupset, WheelSet=@Wheelset WHERE Brand = @Brand";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@BikeType", bike.BikeType);
            updateCommand.Parameters.AddWithValue("@Brand", bike.Brand);
            updateCommand.Parameters.AddWithValue("@Price", bike.Price);
            updateCommand.Parameters.AddWithValue("@Frameset", bike.Frameset);
            updateCommand.Parameters.AddWithValue("@Groupset", bike.Groupset);
            updateCommand.Parameters.AddWithValue("@Wheelset", bike.Wheelset);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
