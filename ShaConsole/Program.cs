using System;
using System.Security.Cryptography;
using System.Text;

namespace ShaConsole
{
    public static class SHAExtensions
    {
        public static string Sha256(this string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                return Convert.ToBase64String(sha.ComputeHash(bytes));
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            Console.WriteLine(password.Sha256());
            Console.ReadKey();
        }
    }
}
