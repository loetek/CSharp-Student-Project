using System;
using System.Collections.Generic;

namespace StudentProject
{
  public class Instructors
    {
        public string InstFirstName {get; set;}
        public string InstLastName {get; set;}
        public string InstSlackHandle {get; set;}
        public Cohort InstCohort { get; set; }

        public Instructors ( string firstName, string lastName, string slackHandle, Cohort cohort)
        {
            InstFirstName = firstName;
            InstLastName = lastName;
            InstSlackHandle = slackHandle;
            InstCohort = cohort;
        }

        public void AddingExercises(Exercises addedExercise, Students student){

            student.StuExercise.Add(addedExercise);
            Console.WriteLine($"Instructor {InstFirstName} {InstLastName} added {addedExercise.ExerciseName} to {student.StuFirstName} {student.StuLastName}");

        }

    }
}
