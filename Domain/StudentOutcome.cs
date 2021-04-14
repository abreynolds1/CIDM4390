using System;

namespace Domain
{
    public class StudentOutcome
    {
        public int SO_ID {get; set;}
        public string SO_Description {get; set;}
        public Course CourseID {get; set;}
        public CourseLearningOutcome CLO_ID {get; set;}
    }
}