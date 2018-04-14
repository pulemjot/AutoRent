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
        public int ID { get; set; }
        public int CarID { get; set; }
        [ForeignKey(nameof(CarID))]
        public CarEntity Car { get; set; }
        public int ClientID { get; set; }
        [ForeignKey(nameof(ClientID))]
        public ClientEntity Client { get; set; }
        public DateTime LeaseStarted { get; set; }
        public DateTime? LeaseEnded { get; set; }
    }
}
