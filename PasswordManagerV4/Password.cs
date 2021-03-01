using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerV4
{
    public class Password
    {
        //Fields
        public string website { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string keySalt { get; set; }

        //Constructor
        public Password(string site,string email,string password)
        {
            this.website = site;
            this.email = email;
            this.password = password;
            keySalt = Account.CreateSalt(20);
        }
        // Password generaten
        public static string GeneratePassword(decimal length, bool useLowerCase, bool useUpperCase, bool useNumbers, bool useSpecialChar)
        {
            Random r = new Random();

            string password = null;
            string charToUse = null;

            string letters = "abcdefghijklmnopqrstuvwxyz";
            string lettersCapital = letters.ToUpper();
            string specialChars = "!@#$%^&*";
            string numbers = "0123456789";

            // Als er minimaal een optie is gekozen + lengte groter dan 0 =
            if ((useLowerCase || useUpperCase || useNumbers || useSpecialChar  ) &length > 0)
            {
            if (useLowerCase) charToUse += letters;
            if (useUpperCase) charToUse += lettersCapital;
            if (useNumbers) charToUse += numbers;
            if (useSpecialChar) charToUse += specialChars;

            for (int i = 0; i < length; i++)
            {

                char characther = charToUse[r.Next(charToUse.Length)];
                password += characther;
            }
            return password;
            }
            else
            {
                return null;
            }
        }
    }
}
