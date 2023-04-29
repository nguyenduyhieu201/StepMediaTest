namespace StepMediaTest.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int TeacherId { set; get; }
        public string StudentName { get; set;}
        public DateTime DateOfBirth { get; set;}
        public virtual Teacher Teacher { get; set; }
    }
}
