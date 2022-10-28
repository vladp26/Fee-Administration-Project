using Proiect_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetByUsername(string _username);
        Student GetById(Guid _id);
        void Add(Student s);
        void Delete(Student s);
        bool verifyPassword(Student student, string password);
        void ModifyList(List<Student> ls);
    }
}
