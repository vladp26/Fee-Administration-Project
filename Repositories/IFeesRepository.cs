using Proiect_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Repositories
{
    public interface IFeesRepository
    {
        List<SubjectFee> GetAllByStudentId(Guid _studentid);
        List<DetailedFee> GetAllWithDetails();
        void DeleteAllByStudentId(Guid _studentid);
        void Add(Fee s);
        void Delete(Fee s);
        Fee GetById(Guid _feeId);
       List<Fee> GetAll();
        void ModifyList(List<Fee> lf);
    }
}
