using Proiect_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Repositories
{
    public interface ISubjectRepository
    {
        Subject GetSubjectById(Guid _id);
        void Add(Subject s);
        List<Subject> GetAll();
        void ModifyList(List<Subject> ls);
    }
}
