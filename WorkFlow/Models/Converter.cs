using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class Converter
    {
        public Company ToCompany(CompanyDto companyD)
        {
            Company company = new Company()
            {
                Name = companyD.Name,
                Adress = companyD.Adress,
                Telephone = companyD.Telephone
            };

            return company;
        }
    }
}
