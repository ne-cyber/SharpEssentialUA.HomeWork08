using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            while (true)
            {
                Console.Write("Введіть день народження: ");
                DateTime birthday;  // Date
                birthday = DateTime.Parse(Console.ReadLine());
                birthday = birthday.Date;


                DateTime now = DateTime.Now.Date; // Date

                int nextBirthdayYear;
                if (now.Month > birthday.Month || (now.Month == birthday.Month && now.Day >= birthday.Day))
                    nextBirthdayYear = now.Year + 1;
                else
                    nextBirthdayYear = now.Year;


                // Перевірка чи високосний рік наступного дня народження
                DateTime nextBirthday;
                if (nextBirthdayYear % 4 == 0)
                    nextBirthday = new DateTime(nextBirthdayYear, birthday.Month, birthday.Day);
                else if(nextBirthdayYear % 4 != 0 && birthday.Month == 2 && birthday.Day == 29)
                    nextBirthday = new DateTime(nextBirthdayYear, 3, 1);
                else
                    nextBirthday = new DateTime(nextBirthdayYear, birthday.Month, birthday.Day);

                //Введіть день народження: 29.2.2020
                //залишилось днів: 172
                //------------------------------
                //Введіть день народження: 1.3.2021
                //залишилось днів: 172
                //------------------------------


                TimeSpan daysLeft = nextBirthday - now;

                Console.WriteLine("залишилось днів: {0}", daysLeft.TotalDays);
                Console.WriteLine(new string('-', 30));
            }

            Console.ReadKey();

        }
    }
}
