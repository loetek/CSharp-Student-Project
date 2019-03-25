using System;
using System.Collections.Generic;

namespace StudentProject
{
    class Program
    {
        static void Main(string[] args)
        {

           // Create 4, or more, exercises.

            Exercises Lists = new Exercises(
                "Lists",
                "C#"
            );
            Exercises Dictionaries = new Exercises(
                "Dictionaries",
                ".net"
            );
            Exercises Sets = new Exercises(
                "Sets",
                "C#"
            );
            Exercises Classes = new Exercises(
                "Unique Classes",
                "Javascript, C#, .Net"
            );

            Console.WriteLine("______________");
            Console.WriteLine("Exercises");

            Console.WriteLine(Lists.ExerciseLang);
            Console.WriteLine(Lists.ExerciseName);


            //Create 3 or more Cohorts

            Cohort TwentyEight = new Cohort("Cohort 28");
            Cohort TwentyNine = new Cohort("Cohort 29");
            Cohort Thirty = new Cohort("Cohort 30");

            Console.WriteLine("______________");
            Console.WriteLine("Cohort");
            Console.WriteLine(Thirty.CohortName);


            // Create 4, or more, students and assign them to one of the cohorts.

            Students John = new Students(
                "John",
                "Neumonic",
                "jonny5@slack",
                TwentyNine
            );
            Students Jill = new Students(
                "Jill",
                "Valentine",
                "JV@slack",
                TwentyNine
            );
            Students Morpheus = new Students(
                "Morpheus",
                "Fishburne",
                "sandman@slack",
                TwentyEight
            );
            Students Mila = new Students(
                "Mila",
                "Killian",
                "ghost@slack",
                Thirty
            );

            Console.WriteLine("______________");
            Console.WriteLine("Student");
            Console.WriteLine($"Hello {Mila.StuFirstName} {Mila.StuLastName} are you enjoying {Mila.StuCohort} ?");

            List<Students> CohortsStudents = new List<Students>();
            TwentyNine.CohortsStudents.Add(John);
            TwentyNine.CohortsStudents.Add(Jill);
            TwentyEight.CohortsStudents.Add(Morpheus);
            Thirty.CohortsStudents.Add(Mila);

            Console.WriteLine("______________");
            Console.WriteLine("Cohort Students");

            TwentyNine.CohortsStudents.ForEach(stu => Console.WriteLine(stu.StuFirstName));

            Instructors Splinter = new Instructors(
                "Splinter",
                "Rat",
                "tmntTeacher@slack",
                TwentyEight
            );
             Instructors Miyagi = new Instructors(
                "Mr",
                "Miyagi",
                "okinawaSensei@slack",
                TwentyNine
            );
            Instructors Roshi = new Instructors(
                "Master",
                "Roshi",
                "justSayin@slack",
                Thirty
            );

            Console.WriteLine("______________");
            Console.WriteLine("Instructor");
            Console.WriteLine($"Hello {Miyagi.InstFirstName} {Miyagi.InstLastName} are you enjoying cohort {Miyagi.InstCohort} ?");

            TwentyEight.CohortsInstructors.Add(Splinter);
            TwentyNine.CohortsInstructors.Add(Miyagi);
            Thirty.CohortsInstructors.Add(Roshi);

            // Thirty.CohortsInstructors.ForEach(inst => Console.WriteLine(inst.InstFirstName));
            // TwentyEight.CohortsInstructors.ForEach(inst => Console.WriteLine(inst.InstFirstName));
            // TwentyNine.CohortsInstructors.ForEach(inst => Console.WriteLine(inst.InstFirstName));

            // make sure you say "who" is adding before calling the method. You don't need the class name it is recognized via the namespace.
            Console.WriteLine("<><><><><><><><>");

            Splinter.AddingExercises(Lists, John);
            Splinter.AddingExercises(Lists, Mila);
            Miyagi.AddingExercises(Sets, Morpheus);
            Miyagi.AddingExercises(Classes, Jill);
            Roshi.AddingExercises(Dictionaries, John);
            Roshi.AddingExercises(Dictionaries, Morpheus);


    List<Students> students = new List<Students>() {

    };

    List<Exercises> exercises = new List<Exercises>() {
        OverlyExcited,
        SolarSystem,
        CarLot,
        DynamicCards
    };






    List<StudentProject> StudentsIn27 =
    StudentList.Where(stu => stu.Cohort.Name == "Cohort 27");
    StudentsIn27.ForEach(StudentProject => ConsoleWriteline());
   






        }
    }
}
