using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Worker
    {
        private int IdWorker;
        private string NameWorker;
        private string SurnameWorker;
        private string WorkplaceWorker;
        private int IdShop;
        private int IdStorage;


        public int GetSetIdWorker
        {
            get { return IdWorker; }
            set { IdWorker = value; }
        }

        public string GetSetNameWorker
        {
            get { return NameWorker; }
            set { NameWorker = value; }
        }

        public string GetSetSurnameWorker
        {
            get { return SurnameWorker; }
            set { SurnameWorker = value; }
        }

        public string GetSetWorkplaceWorker
        {
            get { return WorkplaceWorker; }
            set { WorkplaceWorker = value; }
        }

        public int GetSetIdShop
        {
            get { return IdShop; }
            set { IdShop = value; }
        }

        public int GetSetIdStorage
        {
            get { return IdStorage; }
            set { IdStorage = value; }
        }
    }
}
