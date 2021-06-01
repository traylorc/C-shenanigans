using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bootcamp.Models
{
    public class Student
    {
        public Student() { }




        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Firstname { get; set; }
        [Required, StringLength(50)]
        public string Lastname { get; set; }
        [Column(TypeName = "Decimal (11,2)")]
        public decimal TargetSalary { get; set; }        
        public bool? InBootcamp { get; set; }



        public virtual List<AssesmentScore> AssesmentScores { get; set; }




    }
}
