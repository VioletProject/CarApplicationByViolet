using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;

namespace BusinessLayer
{
    public class CompanyBusiness
    {
        private CompanyRepository companyRepository;


        public CompanyBusiness()
        {
            this.companyRepository = new CompanyRepository();
        }


        public List<Car> GetAllCars()
        {
            return this.companyRepository.GetAllCars();
        }


        public int InsertCars(Car ic)
        {
            return this.companyRepository.InsertCars(ic);
        }
        

        public int UpdateCars(Car uc)
        {
            return this.companyRepository.UpdateCars(uc);
        }

        
        public int DeleteCars(Car dc)
        {
            return this.companyRepository.DeleteCars(dc);
        }


    }
}
