using System;


namespace Domain
{
    public enum grade {A, B, C, D, F}
    public class Assessment
    {
        public int Assess_ID {get; set;}
        public string Assess_Title {get; set;}
        public grade? grade {get; set;} 
        public string CourseID {get; set;}
        public int StudentID {get; set;}

        public virtual Course Course {get; set;}
        public virtual Student Student {get; set;}
    }
}
