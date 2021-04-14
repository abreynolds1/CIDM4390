using System;

namespace Domain
{
    public enum Measure {E, G, S, U}
    public class CourseLearningOutcome
    {
        public int CLO_ID {get; set;}
        public string CLO_Description {get; set;}
        public Measure Measure {get; set;}
        public Course CourseID {get; set;}
        public StudentOutcome SO_ID {get; set;}
    }
}