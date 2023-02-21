using System;
using System.Security.Cryptography;
using System.Text;

namespace ShaConsole
{
    public static class SHAExtensions
    {
        public static string Sha256(this string input)
        {
            using (SHA256 sHA = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                return Convert.ToBase64String(sHA.ComputeHash(bytes));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string password = "secret";
            Console.WriteLine(password.Sha256());
        }
    }
}
