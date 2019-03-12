using System;

namespace StudentProject
{
    public class Exercises
    {
        public string ExerciseName { get; set; }
        public string ExerciseLang { get; set; }

        public Exercises( string exerciseName, string exerciseLang )
        {
            ExerciseName = exerciseName;
            ExerciseLang = exerciseLang;
        }
    }
}
