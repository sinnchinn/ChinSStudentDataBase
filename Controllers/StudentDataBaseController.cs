using ChinSStudentDataBase.Data;
using ChinSStudentDataBase.Models;
using ChinSStudentDataBase.Services.StudentDataBase;
using Microsoft.AspNetCore.Mvc;

namespace ChinSStudentDataBase.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentDataBaseController : ControllerBase
{
    private readonly IStudentDataBaseService _studentDataBaseService;

    public StudentDataBaseController(IStudentDataBaseService studentDataBaseService)
    {
        _studentDataBaseService = studentDataBaseService;
    }
    

    [HttpGet] 
    [Route("GetStudents")]
    public List<Student> GetStudents()
    {
        return _studentDataBaseService.GetStudents();
    }

    [HttpPost] 
    [Route("AddStudent/{firstName}/{lastName}/{hobby}")]
    public List<Student> AddStudent(string firstName, string lastName, string hobby)
    {
        return _studentDataBaseService.AddStudent(firstName, lastName, hobby);
    }

    [HttpDelete] 
    [Route("DeleteStudent/{firstName}")]
    public List<Student> DeleteStudent(string firstName)
    {
        return _studentDataBaseService.DeleteStudent(firstName);

    }

}
