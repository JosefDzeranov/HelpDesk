using System.Security.Cryptography;
using System.Text;
using System;

namespace HelpDesk.Common
{
    public class Methods
    {
        public static string GetHashMD5(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
