using System;

namespace Domain
{
    public class Course
    {
        public string CourseID {get; set;}
        public string Title {get; set;}
        public DateTime Year {get; set;}
        public string Term {get; set;}
        public  Professor ProfID {get; set;}

        public override string ToString()
        {
            return $"Course ID: {this.CourseID}";
        }
    }
}