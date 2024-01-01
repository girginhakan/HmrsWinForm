using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmrsDeneme.Entity
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string WorkingUnit { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
