using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent.Database {
    class Operator {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ID { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String HashedPassword { get; set; }
    }
}
