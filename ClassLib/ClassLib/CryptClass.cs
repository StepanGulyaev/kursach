using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
    {
    public class CryptClass
        {
        public static string GetMD5(string input)
            {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                    {
                    sb.Append(hashBytes[i].ToString("X2"));
                    }
                return sb.ToString();
                }
            }
        public static string GetSHA256(string input)
            {
            using (SHA256 sha256Hash = SHA256.Create())
                {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
 
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    {
                    builder.Append(bytes[i].ToString("x2"));
                    }
                return builder.ToString();
                }
            }
        }
    }
