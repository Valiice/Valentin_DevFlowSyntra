using DevFlow.Models;
using System.Collections.Generic;

namespace DevFlow.Services.Interfaces
{
    public interface ICompanyService
    {
        void CreateCompany(Company newCompany);
        void DeleteCompanyById(int idCompanyToDelete);
        List<Company> GetAllCompanies();
        Company GetCompany(int idCompany);
        void UpdateCompanyById(int idCompanyToChange, Company newCompanyValues);
    }
}