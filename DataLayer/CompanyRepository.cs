using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class CompanyRepository
    {
        public List<Car> GetAllCars()
        {
            List<Car> listToReturn = new List<Car>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.ConnectionString))
            {
                dataConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Cars";

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Car c = new Car();
                    c.GetSetIdCar = dataReader.GetInt32(0);
                    c.GetSetNameCar = dataReader.GetString(1);
                    c.GetSetTypeCar = dataReader.GetString(2);
                    c.GetSetPriceCar = dataReader.GetInt32(3);
                    listToReturn.Add(c);
                }
            }
            return listToReturn;
        }
    

        public int InsertCars(Car ic)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.ConnectionString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "INSERT INTO Cars VALUES('" + ic.GetSetNameCar + "', '" + ic.GetSetTypeCar + "', '" + ic.GetSetPriceCar + "')";

                return command.ExecuteNonQuery();
            }
        }


        public int UpdateCars(Car uc)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.ConnectionString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = @"UPDATE Cars SET NameCar = '" + uc.GetSetNameCar + "', TypeCar = '" + uc.GetSetTypeCar + "', PriceCar = '" + uc.GetSetPriceCar + "' WHERE IdCar =" + uc.GetSetIdCar + "";

                return command.ExecuteNonQuery();
            }
        }


        public int DeleteCars(Car dc)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.ConnectionString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "DELETE FROM Cars WHERE IdCar = '" + dc.GetSetIdCar + "' ";

                return command.ExecuteNonQuery();
            }
        }


    }
}
