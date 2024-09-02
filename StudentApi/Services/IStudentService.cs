using StudentApi.Models;

namespace StudentApi.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudentsAsync();
        Task AddStudentAsync(Student student);
        Task DeleteStudentAsync(int studentId);
    }
}
