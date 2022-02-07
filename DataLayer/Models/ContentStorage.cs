using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ContentStorage
    {
        private int QuantityStorage;
        private int IdStorage;
        private int IdCar;

        
        public int GetSetQuantityStorage
        {
            get { return QuantityStorage; }
            set { QuantityStorage = value; }
        }

        public int GetSetIdStorage
        {
            get { return IdStorage; }
            set { IdStorage = value; }
        }

        public int GetSetIdCar
        {
            get { return IdCar; }
            set { IdCar = value; }
        }
    }
}
