using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent.Database
{
    class CarRent
    {
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
