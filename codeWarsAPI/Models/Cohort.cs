using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codeWarsAPI.Models
{
    public class Cohort
    {
        public int CohortId { get; set; }
        public string Year { get; set; }
        public DateTime Created { get; set; }
    }
}
