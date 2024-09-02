using Microsoft.EntityFrameworkCore;
using StudentApi.Models;

namespace StudentApi.Services
{

    public class StudentService : IStudentService
    {
        private readonly DatabaseContext _context;
        public StudentService(DatabaseContext context) { 
            _context = context;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            var students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task AddStudentAsync(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(int studentId)
        {
            var student = await _context.Students.FirstOrDefaultAsync(x => x.Id == studentId);
            if (student == null)
                throw new KeyNotFoundException($"Student with ID {studentId} not found.");

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }
}
