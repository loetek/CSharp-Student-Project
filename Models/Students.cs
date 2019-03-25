using System;
using System.Collections.Generic;

namespace StudentProject
{
   public class Students
    {

        public string StuFirstName {get; set;}
        public string StuLastName {get; set;}
        public string StuSlackHandle {get; set;}
        public Cohort StuCohort { get; set; }
        public List <Exercises> StuExercise { get; set;}

        public Students (string firstName, string lastName, string slackHandle, Cohort cohort)
        {
            StuFirstName = firstName;
            StuLastName = lastName;
            StuSlackHandle = slackHandle;
            StuCohort = cohort;

            StuExercise = new List<Exercises>();
        }


    }
}
