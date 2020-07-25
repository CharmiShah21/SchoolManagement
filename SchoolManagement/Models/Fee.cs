using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Fee
    {
        [Key]
        public int FeeId { get; set; }
        public int FeeAmount { get; set; }
        public string Currency { get; set; }
    }
}
