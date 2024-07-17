using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PraticeRepetitions
{
    internal class UserValidation
    {
        public void UserLogin(string username)
        {

            if (username == "admin")
            {

                Console.WriteLine("Şifrenizi Giriniz: ");
                string password = Console.ReadLine();
                string bosluksuzSifre = BoslukSil(password);
                UserLoginPassword(bosluksuzSifre);

                return;

            }
            else
            {
                Console.WriteLine("Kullanıcı Adı Yanlış");

                return;
            }
        }

        public void UserLoginPassword(string password)
        {
            if (password == "1234")
            {

                Console.WriteLine("Giriş Başarılı!");
                return;
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");

                return;
            }

        }
        public string BoslukSil(string metin)
        {
            int index = -1;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != ' ')
                {
                    index = i;
                    break;

                }
            }
            string yenimetin = "";
            for (int i = index; i < metin.Length; i++)
            {
                yenimetin += metin[i];
            }
            return yenimetin;
        }

      
    }
}
