using AutoMapper;
using DevFlow.DTO.JobOfferDTO;
using DevFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFlow.Profiles
{
    public class JobOfferProfile : Profile
    {
        public JobOfferProfile()
        {
            CreateMap<ResponseJobOfferDTO, JobOffer>().ReverseMap();
            CreateMap<ResponseJobOfferWithCompanyDTO, JobOffer>().ReverseMap();
            CreateMap<CreateJobOfferDTO, JobOffer>().ReverseMap();
        }
    }
}
