using DevFlow.DTO.JobOfferDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFlow.DTO.CompanyDTO
{
    public class ResponseCompanyWithJobOffersDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Postal { get; set; }
        public string Town { get; set; }
        public List<ResponseJobOfferDTO> JobOffers { get; set; }
    }
}
