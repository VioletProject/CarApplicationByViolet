using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ContentShop
    {
        private int QuantityShops;
        private int IdShop;
        private int IdCar;


        public int GetSetQuantityShops
        {
            get { return QuantityShops; }
            set { QuantityShops = value; }
        }

        public int GetSetIdShop
        {
            get { return IdShop; }
            set { IdShop = value; }
        }

        public int GetSetIdCar
        {
            get { return IdCar; }
            set { IdCar = value; }
        }
    }
}
