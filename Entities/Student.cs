using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2.Entities
{
    
    [Serializable]
    public class Student
    {
        private readonly string _salt;
        private string _hash;
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Salt { get => _salt; }
        public string Hash { get => _hash; }
        public int Group { get; set; }
        public Student(string password)
        {
            this._salt = RandomString(16);
            setPassword(password);
        }
        static string RandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }
        public void setPassword (string password)
        {
            SHA256 sha = SHA256.Create();
            var data = _salt + password + _salt;
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(data));
            var stringbuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                stringbuilder.Append(bytes[i].ToString("x2"));
            }
            this._hash = stringbuilder.ToString();
        }
    }
}
