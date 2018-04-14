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
        public string RegNumber { get; set; } // add, update
        [Required]
        public string Vendor { get; set; } // add
        [Required]
        public string Model { get; set; } // add
        public int Year { get; set; }
        public GearUnitType GearUnitType { get; set; } // add
        public double RentPricePerDay { get; set; } // add, update
        public int? ClientID { get; set; }
        [ForeignKey(nameof(ClientID))]
        public ClientEntity CurrentClient { get; set; }
    }
}
