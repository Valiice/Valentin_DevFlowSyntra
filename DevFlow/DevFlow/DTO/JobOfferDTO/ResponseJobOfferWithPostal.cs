using DevFlow.DTO.CompanyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFlow.DTO.JobOfferDTO
{
    public class ResponseJobOfferWithPostal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime CreatedAt { get; set; }
        public string Postal { get; set; }
        public ResponseCompanyDTO Company { get; set; }
    }
}
