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
            CreateMap<CreateJobOfferDTO, JobOffer>().ReverseMap();
            CreateMap<ResponseJobOfferDTO, JobOffer>().ReverseMap();
            CreateMap<ResponseJobOfferWithCompanyDTO, JobOffer>().ReverseMap();
            CreateMap<JobOffer, ResponseJobOfferWithPostal>()
                .ForMember(x=>x.Postal, opt => opt.MapFrom(src => src.Company.Postal))
                //.ForMember(x => x.Company, opt => opt.MapFrom(src => src.Postal))
                .ReverseMap();
        }
    }
}
