using DevFlow.DataAccess;
using DevFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFlow.Services
{
    public class CompanyService
    {
        public void CreateCompany(Company newCompany)
        {
            using var db = new JobOffersDbContext();
        }
    }
}
