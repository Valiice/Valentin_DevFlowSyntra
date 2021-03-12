using AutoMapper;
using DevFlow.DTO.CompanyDTO;
using DevFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFlow.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<CreateCompanyDTO, Company>().ReverseMap();
            CreateMap<ResponseCompanyDTO, Company>().ReverseMap();
            CreateMap<ResponseCompanyWithJobOffersDTO, Company>().ReverseMap();
        }
    }
}
