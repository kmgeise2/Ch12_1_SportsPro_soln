using System.ComponentModel.DataAnnotations;

namespace Ch12_1_SportsPro_soln.Models
{
    public class Registration
    {
        [Required]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int ProductID { get; set; }
        public Product Product { get; set; }

    }
}
