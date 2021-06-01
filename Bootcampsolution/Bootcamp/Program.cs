using Bootcamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BootcampContext();



            //var charlie = new Student()
            //{
            //    Firstname = "Charlie",
            //    Lastname = "Traylor",
            //    TargetSalary = 100000,
            //    InBootcamp = true
            //};
            //context.Students.Add(charlie);
            //if (context.SaveChanges() != 1)
            //{
            //    throw new Exception("Insert student failed");
            //}

            //var gitassesment = new Assesment()
            //{
            //    Topic = "Git",
            //    NumberofQuestions = 6,
            //    MaxPoints = 120
            //};
            //var sqlassesment = new Assesment()
            //{
            //    Topic = "SQL",
            //    NumberofQuestions = 12,
            //    MaxPoints = 120
            //};
            //var Csharpassesment = new Assesment()
            //{
            //    Topic = "C#",
            //    NumberofQuestions = 11,
            //    MaxPoints = 110
            //};
            //var javaaassesment = new Assesment()
            //{
            //    Topic = "Javascript",
            //    NumberofQuestions = 11,
            //    MaxPoints = 110
            //};
            //var angularassesment = new Assesment()
            //{
            //    Topic = "Angular",
            //    NumberofQuestions = 11,
            //    MaxPoints = 110
            //};
            //context.Assesments.AddRange(gitassesment, sqlassesment, Csharpassesment, javaaassesment, angularassesment);
            //var rowsaffected = context.SaveChanges();


            //var gitscore = new AssesmentScore()
            //{
            //    StudentId = charlie.Id,
            //    AssesmentId = gitassesment.Id,
            //    ActualScore = 90
            //};
            //var sqlscore = new AssesmentScore()
            //{
            //    StudentId = charlie.Id,
            //    AssesmentId = sqlassesment.Id,
            //    ActualScore = 90
            //};
            //context.AssesmentScores.AddRange(gitscore, sqlscore);
            //var rowsaffected1 = context.SaveChanges();

            var avgpoints = (from asc in context.AssesmentScores
                             select new { asc.ActualScore })
                             .Average(avgpoints => avgpoints.ActualScore);
            Console.WriteLine(avgpoints);

            



        }
    }
}
