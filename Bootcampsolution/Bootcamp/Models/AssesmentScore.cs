using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp.Models
{
    public class AssesmentScore
    {
        public AssesmentScore()
        { }


        public int Id { get; set; }
        public int ActualScore { get; set; }
       //virtual add to connect the foreign key to the correct primary key
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int AssesmentId { get; set; }
        public virtual Assesment Assesment { get; set; }


    }
}
