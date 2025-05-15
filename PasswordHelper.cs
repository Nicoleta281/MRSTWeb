using System;
using System.Security.Cryptography;
using System.Text;

namespace eUseControl.Helpers
{
     public static class PasswordHelper
     {
          public static string HashPassword(string password)
          {
               using (SHA256 sha256 = SHA256.Create())
               {
                    byte[] input = Encoding.UTF8.GetBytes(password);
                    byte[] hash = sha256.ComputeHash(input);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
               }
          }
     }
}
