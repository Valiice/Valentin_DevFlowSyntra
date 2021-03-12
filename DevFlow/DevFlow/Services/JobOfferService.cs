using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFlow.DataAccess;
using DevFlow.Models;
using DevFlow.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DevFlow.Services
{
    public class JobOfferService : IJobOfferService
    {
        public void CreateJobOffer(JobOffer newJobOffer)
        {
            using var db = new JobOffersDbContext();
            db.JobOffers.Add(newJobOffer);
            db.SaveChanges();
        }
        public JobOffer GetJobOffer(int idJobOffer)
        {
            using var db = new JobOffersDbContext();
            var jobOffer = db.JobOffers
                .Include(x => x.Company).ToList()
                .FirstOrDefault(x => x.Id == idJobOffer);
            if (jobOffer != null)
                return jobOffer;
            else
                throw new KeyNotFoundException("JobOffer doesn't exist");
        }
        public List<JobOffer> GetAllJobOffers()
        {
            using var db = new JobOffersDbContext();
            var jobOffers = db.JobOffers
                .Include(x => x.Company).ToList();
            if (jobOffers != null)
                return jobOffers;
            else
                throw new KeyNotFoundException("JobOffers don't exist");
        }
        public void UpdateJobOfferById(int idJobOfferToChange, JobOffer newJobOfferValues)
        {
            using var db = new JobOffersDbContext();
            var jobOffer = db.JobOffers.FirstOrDefault(x => x.Id == idJobOfferToChange);
            if (jobOffer != null)
            {
                jobOffer.Name = newJobOfferValues.Name;
                jobOffer.CompanyId = newJobOfferValues.CompanyId;
                jobOffer.CreatedAt = newJobOfferValues.CreatedAt;
                db.JobOffers.Update(jobOffer);
                db.SaveChanges();
            }
            else
                throw new KeyNotFoundException("JobOffers don't exist");
        }
        public void DeleteJobOfferById(int idJobOfferToDelete)
        {
            using var db = new JobOffersDbContext();
            var jobOffer = db.JobOffers.FirstOrDefault(x => x.Id == idJobOfferToDelete);
            if (jobOffer != null)
            {
                db.JobOffers.Remove(jobOffer);
                db.SaveChanges();
            }
            else
                throw new KeyNotFoundException("JobOffers don't exist");
        }
    }
}
