using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Utility
{
  public  class Utility
    {


        private Utility()
        {

        }


        public static string MD5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
                return Encoding.ASCII.GetString(result);
            }
        }

        public static bool IsPasswordMatched(string pass, string input)
        {
            return MD5Hash(pass).Equals(input);
        }
    }
}
