using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.BusinessLogic
{
    public class CompanyManagement : DatabaseManagement
    {
        public CompanyManagement(WorkFlowDbContext db) : base(db) { }

        public List<Company> GetAllCompanies()
        {
            return this.Db.Companies.ToList();
        }

        public Company GetCompanyById(int id)
        {
            return this.Db.Companies.Where(x => x.Id == id).FirstOrDefault();
        }  
        
        public void CreateCompany(Company company)
        {
            this.Db.Companies.Add(company);
            this.Db.SaveChanges();
        }

        public void UpdateCompany(int id, Company company)
        {
            var item = this.Db.Companies.Where(x => x.Id == id).FirstOrDefault();

            item.Name = company.Name;
            item.Adress = company.Adress;
            item.Telephone = company.Telephone;

            this.Db.SaveChanges();
        }

        public Company DeleteCompany(int id)
        {
            var company = this.Db.Companies.Where(x => x.Id == id).FirstOrDefault();
            this.Db.Remove(company);
            this.Db.SaveChanges();

            return company;
        }
    }
}
