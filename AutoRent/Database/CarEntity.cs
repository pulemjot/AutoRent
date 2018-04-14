using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent.Database
{
    class CarEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required()]
        public string RegNumber { get; set; }
        [Required]
        public string Vendor { get; set; }
        [Required]
        public string Model { get; set; }
        public int Year { get; set; }
        public GearUnitType GearUnitType { get; set; }
        public double RentPricePerDay { get; set; }
        public int? ClientID { get; set; }
        [ForeignKey(nameof(ClientID))]
        public ClientEntity CurrentClient { get; set; }
    }
}
