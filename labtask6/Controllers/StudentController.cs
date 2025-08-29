using Microsoft.AspNetCore.Mvc;
using labtask6.Models;

namespace labtask6.Controllers;

public class StudentController : Controller
{
    public IActionResult Details()
    {
        Student s1 = new Student()
        {
            Id = 1,
            Name = "Abu Sufian",
            Email = "abusufian202262@gmail.com"
        };
        return View(s1);
    }

    public IActionResult StudentList()
    {
        List<Student> students = new List<Student>()
        {
            new Student { 
                Id = 1, 
                Name = "Abu Sufian", 
                Email = "abusufian202262@gmail.com", 
                Grade = 85 
            },
            new Student { 
                Id = 2, 
                Name = "Faria Lara", 
                Email = "faria.lara@gmail.com", 
                Grade = 42 
            },
            new Student { 
                Id = 3, 
                Name = "Nafees Islam", 
                Email = "nafees.islam@gmail.com", 
                Grade = 67 
            }
        };
        return View(students);
    }
}