using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent.Database {
    class CarEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ID { get; set; }
        [Required(ErrorMessage = "Registration number is required")]
        [RegularExpression(@"\w{2}-\d{1,4}", ErrorMessage = "Registration number must be in format XY-0000")]
        public String RegNumber { get; set; } // add, update
        [Required]
        public String Vendor { get; set; } // add
        [Required]
        public String Model { get; set; } // add
        public Int32 Year { get; set; }
        public GearUnitType GearUnitType { get; set; } // add
        public Double RentPricePerDay { get; set; } // add, update
        public Int32? ClientID { get; set; }
        [ForeignKey(nameof(ClientID))]
        public ClientEntity CurrentClient { get; set; }

        public override Boolean Equals(Object obj) {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj is CarEntity other && Equals(other);
        }
        protected Boolean Equals(CarEntity other) {
            return ID == other.ID;
        }
        public override Int32 GetHashCode() {
            return ID;
        }
    }
}
