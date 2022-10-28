using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Entities
{
    [Serializable]
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name {get; set;}
        public DegreeType Degree { get; set; }
        public int Semester { get; set; }

    }
}
