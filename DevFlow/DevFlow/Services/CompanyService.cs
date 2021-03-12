using DevFlow.DataAccess;
using DevFlow.Models;
using DevFlow.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFlow.Services
{
    public class CompanyService : ICompanyService
    {
        public void CreateCompany(Company newCompany)
        {
            using var db = new JobOffersDbContext();
            db.Companies.Add(newCompany);
            db.SaveChanges();
        }
        public Company GetCompany(int idCompany)
        {
            using var db = new JobOffersDbContext();
            var company = db.Companies
                .Include(x => x.JobOffers).ToList()
                .FirstOrDefault(company => company.Id == idCompany);
            if (company != null)
                return company;
            else
                throw new KeyNotFoundException("Company doesn't exist");
        }
        public List<Company> GetAllCompanies()
        {
            using var db = new JobOffersDbContext();
            var companies = db.Companies
                .Include(x => x.JobOffers).ToList();
            if (companies != null)
                return companies;
            else
                throw new KeyNotFoundException("Companies don't exist");
        }
        public void UpdateCompanyById(int idCompanyToChange, Company newCompanyValues)
        {
            using var db = new JobOffersDbContext();
            var company = db.Companies.FirstOrDefault(x => x.Id == idCompanyToChange);
            if (company != null)
            {
                company.Name = newCompanyValues.Name;
                company.Street = newCompanyValues.Street;
                company.Postal = newCompanyValues.Postal;
                company.Town = newCompanyValues.Town;
                db.Companies.Update(company);
                db.SaveChanges();
            }
            else
                throw new KeyNotFoundException("Company doesn't exist");
        }
        public void DeleteCompanyById(int idCompanyToDelete)
        {
            using var db = new JobOffersDbContext();
            var company = db.Companies.FirstOrDefault(x => x.Id == idCompanyToDelete);
            if (company != null)
            {
                db.Companies.Remove(company);
                db.SaveChanges();
            }
            else
                throw new KeyNotFoundException("Company doesn't exist");
        }
    }
}
