using DevFlow.Models;
using System.Collections.Generic;

namespace DevFlow.Services.Interfaces
{
    public interface IJobOfferService
    {
        void CreateJobOffer(JobOffer newJobOffer);
        void DeleteJobOfferById(int idJobOfferToDelete);
        List<JobOffer> GetAllJobOffers();
        JobOffer GetJobOffer(int idJobOffer);
        void UpdateJobOfferById(int idJobOfferToChange, JobOffer newJobOfferValues);
        List<JobOffer> GetLast3PostedJobOffers();
        List<JobOffer> GetJobOffersOnPostal(string postal);
    }
}