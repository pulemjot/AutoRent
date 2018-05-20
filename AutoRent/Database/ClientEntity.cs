using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent.Database {
    class ClientEntity {
        public Int32 ID { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required, RegularExpression(@"\d{6}-\d{5}")]
        public String PersonalNumber { get; set; }
        [Phone]
        public String PhoneNumber { get; set; }
        [EmailAddress]
        public String Email { get; set; }
        public String Address { get; set; }
        [NotMapped]
        public Int32 ActiveRentCount { get; set; }
        public ICollection<CarRent> Rents { get; set; }

        public override Boolean Equals(Object obj) {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj is ClientEntity other && Equals(other);
        }
        protected Boolean Equals(ClientEntity other) {
            return ID == other.ID;
        }
        public override Int32 GetHashCode() {
            return ID;
        }
    }
}
