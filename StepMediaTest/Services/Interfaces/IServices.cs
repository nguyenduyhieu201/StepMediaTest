using StepMediaTest.Models;

namespace StepMediaTest.Services.Interfaces
{
    public interface IServices
    {
        public Task AddStudents(List<Student> students);
        public Task AddTeachers(List<Teacher> teachers);
        public Task GetViewModels(Param param);
    }
}
