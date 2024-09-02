using Moq;
using StudentApi.Models;

namespace StudentApiTests
{
    public class StudentServiceTests
    {
        private readonly Mock<DatabaseContext> _mockContext;
        private readonly StudentService _studentService;

        public StudentServiceTests()
        {
            _mockContext = new Mock<DatabaseContext>();
            _studentService = new StudentService(_mockContext.Object);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}