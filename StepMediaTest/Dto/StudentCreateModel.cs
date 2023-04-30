namespace StepMediaTest.Dto
{
    public class StudentCreateModel : CreateModel
    {
        public DateTime DateOfBirth { get; set; }
        public int TeacherId { get;set; }
    }
}
