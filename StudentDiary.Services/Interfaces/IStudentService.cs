using System.Collections.Generic;
using System.Threading.Tasks;
using StudentDiary.Infrastructure.Models;

namespace StudentDiary.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<User>> GetAllStudentsAsync();
        Task<User> GetStudentByIdAsync(int id);
        Task AddStudentAsync(User student);
        Task UpdateStudentAsync(User student);
        Task DeleteStudentAsync(int id);
    }
}
