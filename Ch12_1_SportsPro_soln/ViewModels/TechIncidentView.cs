using System.Collections.Generic;

namespace Ch12_1_SportsPro_soln.Models
{
    public class TechIncidentViewModel
    {
        public Technician Technician { get; set; }
        public Incident Incident { get; set; }
        public IEnumerable<Incident> Incidents { get; set; }
    }
}
