using System.Security.Cryptography;
using System.Text;

namespace Codr.Core.Classes
{
    public static class ClassCryptography
    {
        /// <summary>
        /// Generates a SHA512 string for passwords
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string GenerateSHA512String(string pwd)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(pwd);
            byte[] computeHash = sha512.ComputeHash(bytes);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var hash in computeHash)
            {
                stringBuilder.Append(hash.ToString("X2"));
            }
            return stringBuilder.ToString();
        }
    }
}
