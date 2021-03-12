using DevFlow.DTO.CompanyDTO;
using DevFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFlow.DTO.JobOfferDTO
{
    public class ResponseJobOfferWithCompanyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public ResponseCompanyDTO Company { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
