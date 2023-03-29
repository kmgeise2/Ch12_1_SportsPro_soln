using System.Collections.Generic;

namespace Ch12_1_SportsPro_soln.Models
{
    public class IncidentListViewModel
    {
        public string Filter { get; set; }
        public IEnumerable<Incident> Incidents { get; set; }
    }
}
