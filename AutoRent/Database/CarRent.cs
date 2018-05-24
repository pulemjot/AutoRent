using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent.Database {
    class CarRent {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ID { get; set; }
        public Int32 CarID { get; set; }
        [ForeignKey(nameof(CarID))]
        public CarEntity Car { get; set; }
        public Int32 ClientID { get; set; }
        [ForeignKey(nameof(ClientID))]
        public ClientEntity Client { get; set; }
        public DateTime LeaseStarted { get; set; }
        public DateTime? LeaseEnded { get; set; }
    }
}
