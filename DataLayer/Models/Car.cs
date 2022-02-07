using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Car
    {
        private int IdCar;
        private string NameCar;
        private string TypeCar;
        private int PriceCar;


        public int GetSetIdCar
        {
            get { return IdCar; }
            set { IdCar = value; }
        }

        public string GetSetNameCar
        {
            get { return NameCar; }
            set { NameCar = value; }
        }

        public string GetSetTypeCar
        {
            get { return TypeCar; }
            set { TypeCar = value; }
        }

        public int GetSetPriceCar
        {
            get { return PriceCar; }
            set { PriceCar = value; }
        }
    }
}
