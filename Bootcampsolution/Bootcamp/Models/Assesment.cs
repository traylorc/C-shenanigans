using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bootcamp.Models
{
    public class Assesment
    {
        public Assesment()
        { }
        
        
        
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Topic { get; set; }
        public int NumberofQuestions { get; set; }
        public int MaxPoints { get; set; }


        public virtual List<AssesmentScore> AssesmentScores { get; set; }

    }
}
