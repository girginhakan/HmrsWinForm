using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmrsDeneme.Entity
{
    [Table("Patients")]
    public class Patient
    {
        public int PatientId { get; set; }

        public int UserId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Job { get; set; }
        public string EducationStatus { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
