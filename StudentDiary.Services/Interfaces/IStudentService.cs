using System.Collections.Generic;
using System.Threading.Tasks;
using StudentDiary.Domain.Entities; // assuming you already have this in Domain project

namespace StudentDiary.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task AddStudentAsync(Student student);
        Task UpdateStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
    }
}
