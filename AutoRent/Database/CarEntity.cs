using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent.Database {
    class CarEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Registration number is required")]
        [RegularExpression(@"\w{2}-\d{1,4}", ErrorMessage = "Registration number must be in format XY-0000")]
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

        public override Boolean Equals(Object obj) {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj is CarEntity other && Equals(other);
        }
        protected bool Equals(CarEntity other) {
            return ID == other.ID;
        }
        public override int GetHashCode() {
            return ID;
        }
    }
}
