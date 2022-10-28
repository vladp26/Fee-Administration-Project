using Proiect_v2.Database;
using Proiect_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Repositories
{
    public class FeesRepository : IFeesRepository
    {
        public void Add(Fee s)
        {
            s.Id = Guid.NewGuid();
            FakeDB.fees.Add(s);
        }

        public void Delete(Fee s)
        {
            FakeDB.fees.Remove(s);
        }

        public void ModifyList(List<Fee> lf)
        {
            FakeDB.fees = lf;
        }

        public void DeleteAllByStudentId(Guid _studentid)
        {
           FakeDB.fees.RemoveAll(fee => fee.StudentId == _studentid);
        }

        public List<Fee> GetAll()
        {
            return FakeDB.fees;
        }

        public List<SubjectFee> GetAllByStudentId(Guid _studentid)
        {
            List<Fee> temp= FakeDB.fees.Where(x => x.StudentId == _studentid).ToList();
            List<SubjectFee> result= new List<SubjectFee>();
            foreach(Fee f in temp)
            {
                var upfee = new SubjectFee();
                upfee.Id = f.Id;
                upfee.Value = f.Value;
                upfee.IsPayed = f.IsPayed;
                upfee.Subject = FakeDB.subjects.FirstOrDefault(y => y.Id == f.SubjectId).Name;
                result.Add(upfee);
            }
            return result;
        }

        public List<DetailedFee> GetAllWithDetails()
        {
            List<Fee> temp = FakeDB.fees;
            List<DetailedFee> result = new List<DetailedFee>();
            foreach (Fee f in temp)
            {
                var upfee = new DetailedFee();
                upfee.Id = f.Id;
                upfee.Value = f.Value;
                upfee.IsPayed = f.IsPayed;
                upfee.Subject = FakeDB.subjects.FirstOrDefault(y => y.Id == f.SubjectId).Name;
                upfee.Username = FakeDB.students.FirstOrDefault(y => y.Id == f.StudentId).Username;
                upfee.StudentName = FakeDB.students.FirstOrDefault(y => y.Id == f.StudentId).FirstName+ " "
                    + FakeDB.students.FirstOrDefault(y => y.Id == f.StudentId).LastName;
                result.Add(upfee);
            }
            return result;
        }

        public Fee GetById(Guid _feeId)
        {
            return FakeDB.fees.FirstOrDefault(x => x.Id == _feeId);
        }
    }
}
