using Proiect_v2.Database;
using Proiect_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetAll()
        {
            return FakeDB.students.Count>0 ? FakeDB.students:null;
        }
        public void Add(Student s)
        {
            s.Id = Guid.NewGuid();
            FakeDB.students.Add(s);
        }
        public Student GetByUsername(string _username)
        {
            return FakeDB.students.FirstOrDefault(x => x.Username == _username);
        }

        public Student GetById(Guid _id)
        {
            return FakeDB.students.FirstOrDefault(x => x.Id == _id);
        }

        public void Delete(Student s)
        {
            FakeDB.students.Remove(s);
        }

        public bool verifyPassword(Student student, string password)
        {
            SHA256 sha = SHA256.Create();
            var studenttoverify = FakeDB.students.FirstOrDefault(x => x.Username == student.Username);
            var data = studenttoverify.Salt + password + studenttoverify.Salt;
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(data));
            var stringbuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                stringbuilder.Append(bytes[i].ToString("x2"));
            }
            var hash = stringbuilder.ToString();
            if (!hash.Equals(studenttoverify.Hash))
            {
                return false;
            }
            return true;
        }

        public void ModifyList(List<Student> ls)
        {
            FakeDB.students = ls;
        }
    }
}
