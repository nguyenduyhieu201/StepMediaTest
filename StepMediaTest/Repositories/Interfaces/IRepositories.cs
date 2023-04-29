using StepMediaTest.Dto;
using StepMediaTest.Models;

namespace StepMediaTest.Repositories.Interfaces
{
    public interface IRepositories
    {
        public Task InsertStudent(List<Student> students);
        public Task InsertTeacher(List<Teacher> teacher);
        public Task<Viewmodel> GetViewModels(Param param)

    }
}
