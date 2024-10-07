using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        enum Post : int
        {
            Director = 12,
            Mededger = 12,
            Buhalter = 8
        }

        static class Accountant
        {
            public static bool AskForBonus(Post worker, int hours)
            {
                if(hours > (int)worker) 
                    return true;
                else
                    return false;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Посада {0:g} ({0:d} годин), відпрацював {1} годин, премія {2}", Post.Mededger, 14, Accountant.AskForBonus(Post.Mededger, 14));
            Console.WriteLine("Посада {0:g} ({0:d} годин), відпрацював {1} годин, премія {2}", Post.Buhalter, 2, Accountant.AskForBonus(Post.Buhalter, 2));

            Console.ReadKey();
        }
    }
}
