using System;
using System.Collections.Generic;

namespace StudentProject
{
    public class Cohort
    {
            public string CohortName { get; set;}
            public List<Students> CohortsStudents { get; set; }
            public List<Instructors> CohortsInstructors { get; set; }

            public Cohort (string cohortName){
                CohortName = cohortName;
                CohortsStudents = new List<Students>();
                CohortsInstructors = new List<Instructors>();

            }
    }
}
