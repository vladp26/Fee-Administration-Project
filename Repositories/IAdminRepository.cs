using Proiect_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Repositories
{
    interface IAdminRepository
    {
        Admin GetByUsername(string _username);
         bool verifyPassword(Admin admin, string password);
    }
}
