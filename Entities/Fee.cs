using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Entities
{
    [Serializable]
    public class Fee
    {
        public Guid Id { get; set; }
        public int Value { get; set; }
        public Guid SubjectId { get; set; }
        public Guid StudentId { get; set; }
        public bool IsPayed { get; set; }
    }
}
