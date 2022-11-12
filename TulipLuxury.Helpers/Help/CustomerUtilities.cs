using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TulipLuxury.Helpers.Contracts;

namespace TulipLuxuryCore.Helpers
{
    public class CustomerUtilities : ICustomerUtilities
    {
        /// <summary>
        /// Generate radom number
        /// </summary>
        /// <param name="length"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public string GenerateRandomNumber(int length, string prefix)
        {
            var random = new Random();
            string str = "";
            for (int i = 0; i < length; i++)
                str = String.Concat(str, random.Next(length).ToString());
            return prefix + str;
        }


        /// <summary>
        /// hashes password
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        public string PasswordHash(string Password)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Password));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        /// <summary>
        /// Generates user id
        /// </summary>
        /// <returns></returns>
        public string GenerateCustomerId()
        {
            return GenerateRandomNumber(4, "CUS");
        }

        public string RemoveDigits(string str)
        {
            string chars = new String(str.Where(x => x != '_' && (x < '0' || x > '9')).ToArray());
            return chars;
        }
        //Changes the removed digits to a title case
        public string ChangeToTitle(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);

        }

    }
}

