using Proiect_v2.Database;
using Proiect_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        public void Add(Subject s)
        {
            FakeDB.subjects.Add(s);
        }

        public List<Subject> GetAll()
        {
            return FakeDB.subjects;
        }

        public Subject GetSubjectById(Guid _id)
        {
            return FakeDB.subjects.FirstOrDefault(x => x.Id == _id);
        }

        public void ModifyList(List<Subject> ls)
        {
            FakeDB.subjects = ls;
        }
    }
}
