using Proiect_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Database
{
    public static class FakeDB
    {
        public static List<Admin> admins = new List<Admin>()
        {
            new Admin("test")
            {
                Id=Guid.NewGuid(),
                FirstName="Test",
                LastName="Admin",
                Username="test"
            }
        };
        public static List<Student> students = new List<Student>()
        {
            new Student("test2")
            {
                Id=Guid.NewGuid(),
                FirstName="test",
                LastName="Student",
                Username="test2",
                Group =1100
            }
        };
        public static List<Subject> subjects = new List<Subject>()
        {
            new Subject()
            {
                Id=Guid.NewGuid(),
                Name="Windows Applications Programming",
                Semester=4
            },
            new Subject()
            {
                Id=Guid.NewGuid(),
                Name="Data Structures",
                Degree=DegreeType.Bachelor,
                Semester=4
            },
            new Subject()
            {
                Id=Guid.NewGuid(),
                Name="Evolutive Programming and Genetic Algorithms",
                Degree=DegreeType.Bachelor,
                Semester=4
            },
            new Subject()
            {
                Id=Guid.NewGuid(),
                Name="Object Oriented Programming",
                Degree=DegreeType.Bachelor,
                Semester=3
            },
            new Subject()
            {
                Id=Guid.NewGuid(),
                Name="Computer Operating Systems",
                Degree=DegreeType.Bachelor,
                Semester=2
            }
        };
        public static List<Fee> fees = new List<Fee>()
        {
            new Fee()
            {
                Id=Guid.NewGuid(),
                Value=120,
                StudentId=students.FirstOrDefault(x => x.Username=="test2").Id,
                SubjectId= subjects.FirstOrDefault(x => x.Name.Equals("Object Oriented Programming")).Id,
                IsPayed=true
            },
            new Fee()
            {
                Id=Guid.NewGuid(),
                Value=110,
                StudentId=students.FirstOrDefault(x => x.Username=="test2").Id,
                SubjectId= subjects.FirstOrDefault(x => x.Name.Equals("Computer Operating Systems")).Id,
                IsPayed=false
            }
        };
    }
}
