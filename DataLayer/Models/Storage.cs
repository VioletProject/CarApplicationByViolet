using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Storage
    {
        private int IdStorage;
        private string CityStorage;
        private string AddressStorage;
        private string PhoneStorage;


        public int GetSetIdStorage
        {
            get { return IdStorage; }
            set { IdStorage = value; }
        }

        public string GetSetCityStorage
        {
            get { return CityStorage; }
            set { CityStorage = value; }
        }

        public string GetSetAddressStorage
        {
            get { return AddressStorage; }
            set { AddressStorage = value; }
        }

        public string GetSetPhoneStorage
        {
            get { return PhoneStorage; }
            set { PhoneStorage = value; }
        }
    }
}
