using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFlow.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
