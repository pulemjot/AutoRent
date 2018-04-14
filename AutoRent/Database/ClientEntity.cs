using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent.Database
{
    class ClientEntity
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, RegularExpression(@"\d{6}-\d{5}")]
        public string PersonalNumber { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        [NotMapped]
        public int ActiveRentCount { get; set; }
        public ICollection<CarRent> Rents { get; set; }
    }
}
