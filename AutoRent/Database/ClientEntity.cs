using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent.Database {
    class ClientEntity {
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

        public override Boolean Equals(Object obj) {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj is ClientEntity other && Equals(other);
        }
        protected bool Equals(ClientEntity other) {
            return ID == other.ID;
        }
        public override int GetHashCode() {
            return ID;
        }
    }
}
