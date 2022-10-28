using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Entities
{
    public class SubjectFee
    {
        public Guid Id { get; set; }
        public int Value { get; set; }
        public string Subject { get; set; }
        public bool IsPayed { get; set; }
    }
}
