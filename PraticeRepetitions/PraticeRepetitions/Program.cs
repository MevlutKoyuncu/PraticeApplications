using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PraticeRepetitions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UserValidation
            UserValidation a = new UserValidation();


            int denemeHakki = 2;
            while (denemeHakki >= 0)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
                string username = Console.ReadLine();
                string boslukz = a.BoslukSil(username);

                a.UserLogin(boslukz);
                if (denemeHakki == 0)
                {
                    Console.WriteLine("Hakkınız bitmiştir.");
                }
                denemeHakki--;
            }

            #endregion

            #region Palindrom Words

            //PalindromWords b = new PalindromWords();
            //bool devam = true;
            //while (devam)
            //{
            //    Console.WriteLine("Kelimeyi giriniz = ");
            //    string word = Console.ReadLine();
            //    b.WordCheck(word);
            //    Console.WriteLine("Devam edilsin mi = e/h ");
            //    string cevap = Console.ReadLine();
            //    if(cevap == "")
            //    {
            //        devam = false;
            //    }
            //}


            #endregion



        }
    }
}
