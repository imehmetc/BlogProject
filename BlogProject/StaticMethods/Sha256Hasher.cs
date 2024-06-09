using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.StaticMethods
{
    public static class Sha256Hasher
    {
        public static string ComputeSha256Hash(string pass)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass)); // girilen metni UTF8 formatında byte dizisine dönüştürüp bu dizinin SHA256 hash sonucunu hesaplar.

                StringBuilder builder = new StringBuilder(); // hash sonucunu string'e çevirmek için kullanılır
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Hash sonucunu oluşturan byte dizisini dolaşır ve her bir byte'ı hexadecimal (onaltılık) formatta stringe ekler. x2 formatı, her byte'ı iki karakterli hexadecimal string olarak formatlar.
                }
                return builder.ToString();
            }
        }
    }
}
