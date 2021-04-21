using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkcijaKaoForPetlja
{
    class Program
    {
        static void Main(string[] args)
        {
            Petlja(5);
            Console.ReadKey();
        }
        public static bool Petlja(int i) {
            //ovaj deo koda bi se izvrsavao tacno npr 5 puta kao u nekoj for petlji npr
            //************************************************************************
            Console.WriteLine(i);
            //************************************************************************
            if (i == 1) return true;
            i--;
            return Petlja(i);
        }
    }
}
