using ChinSStudentDataBase.Models;

namespace ChinSStudentDataBase.Services.StudentDataBase;

public interface IStudentDataBaseService
{
    List<Student> GetStudents();
    List<Student> AddStudent(string firstName, string lastName, string hobby);
    List<Student> DeleteStudent(string firstName);
}
