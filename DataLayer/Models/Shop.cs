using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Shop
    {
        private int IdShop;
        private string NameShop;
        private string CityShop;
        private string AddressShop;
        private string PhoneShop;


        public int GetSetIdShop
        {
            get { return IdShop; }
            set { IdShop = value; }
        }

        public string GetSetNameShop
        {
            get { return NameShop; }
            set { NameShop = value; }
        }

        public string GetSetCityShop
        {
            get { return CityShop; }
            set { CityShop = value; }
        }

        public string GetSetAddressShop
        {
            get { return AddressShop; }
            set { AddressShop = value; }
        }

        public string GetSetPhoneShop
        {
            get { return PhoneShop; }
            set { PhoneShop = value; }
        }
    }
}
