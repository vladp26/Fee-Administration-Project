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
    class AdminRepository : IAdminRepository
    {
        public Admin GetByUsername(string _username)
        {
            return FakeDB.admins.FirstOrDefault(x => x.Username == _username);
        }
        public bool verifyPassword(Admin admin, string password)
        {
            SHA256 sha = SHA256.Create();
            var admintoverify = FakeDB.admins.FirstOrDefault(x => x.Username == admin.Username);
            var data = admintoverify.Salt + password + admintoverify.Salt;
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(data));
            var stringbuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                stringbuilder.Append(bytes[i].ToString("x2"));
            }
            var hash = stringbuilder.ToString();
            if (!hash.Equals(admintoverify.Hash))
            {
                return false;
            }
            return true;
        }
    }
}
