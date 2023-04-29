using StepMediaTest.Models;
using StepMediaTest.Repositories;
using StepMediaTest.Repositories.Interfaces;
using StepMediaTest.Services.Interfaces;

namespace StepMediaTest.Services
{
    public class Services : IServices
    {
        private readonly IRepositories _repositories;
        public Services(IRepositories repositories) {
            _repositories = repositories;
        }
        public async Task AddStudents(List<Student> students)
        {
            await _repositories.InsertStudent(students);
        }

        public async Task AddTeachers(List<Teacher> teachers)
        {
            await _repositories.InsertTeacher(teachers);
        }

        public async Task GetViewModels(Param param)
        {
            await _repositories.GetViewModels(param);
        }
    }
}
