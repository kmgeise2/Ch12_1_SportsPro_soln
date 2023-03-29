using System.Collections.Generic;

namespace Ch12_1_SportsPro_soln.Models
{
    public class RegistrationViewModel
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Registration> Registrations { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
