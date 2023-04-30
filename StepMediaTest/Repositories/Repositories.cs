using Microsoft.EntityFrameworkCore;
using StepMediaTest.Dto;
using StepMediaTest.Models;
using StepMediaTest.Repositories.Interfaces;

namespace StepMediaTest.Repositories
{
    public class Repositories : IRepositories
    {
        private readonly StepMediaDbContext _context;

        public Repositories(StepMediaDbContext context) 
        {
            _context = context; 
        }
        public async Task<List<Viewmodel>> GetViewModels(Param param)
        {
            var students = _context.Students.Include(t => t.Teacher);
            var viewmodel = students.Select(o => new Viewmodel
            {
                TeacherName = o.Teacher.TeacherName,
                StudentName = o.StudentName,
                StudentAge = o.DateOfBirth
            });

            if (param.StudentSearch != null)
            {
                viewmodel = viewmodel.Where(v => v.StudentName.Contains(param.StudentSearch));
            }
            if (param.TeacherSearch != null)
            {
                viewmodel = viewmodel.Where(v => v.TeacherName.Contains(param.StudentSearch));
            }
            viewmodel = viewmodel.OrderBy(t => t.TeacherName).ThenBy(t => t.StudentAge);
            return await viewmodel.ToListAsync();

        }

        public async Task InsertStudent(List<Student> students)
        {
            if (students.Count < 30)
            {
                throw new ArgumentException("the number of instance must be at least 30");
            }
            else
            {
                foreach(Student student in students)
                {
                    await _context.Students.AddAsync(student);
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task InsertTeacher(List<Teacher> teachers)
        {
            if (teachers.Count < 30)
            {
                throw new ArgumentException("the number of instance must be at least 2");
            }
            else
            {
                foreach (Teacher teacher in teachers)
                {
                    await _context.Teachers.AddAsync(teacher);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
