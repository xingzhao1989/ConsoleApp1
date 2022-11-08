using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.SymbolStore;

Console.WriteLine("Huvudmeny!Ni trycker Program1 Program2 Program3 for olika funktioner ");

namespace exercise2
{
    class switchchoice
    {
        public static void Main()
        {
            Console.WriteLine("four choice 0 1 2 3 4");
            Consile.Write("your choice");
            string s = Console.Readline();
            int n = int.Parse(s);
            switch(n)
            {
                case 0:
                    Console.WriteLine("det är felaktig input");
                    break;
                case 1:
                    Program1;
                case 2:
                    Program2;
                case 3;
                    Program3;
                case 4:
                    Program4;
            }
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("din ålder i siffror");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }
            else if (num > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många vi är som ska gå på bio");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int t = 0;
            int sum = 0;
            for (; i<= num;)
            {
                i++;
                if (num < 20)
                {
                    t=80;
                }
                else if (num > 64)
                {
                    t=90;
                }
                else
                {
                    t=120;
                }

                sum = sum + t;
                 }
                
             Console.WriteLine("total kostnad="+sum);
            
            }
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            string meningen = Console.ReadLine();
            int num = 1;
            for (; num <= 10;)
            {
                Console.WriteLine(meningen);
                num++;
            }
        }
    }
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("anger en mening med minst 3 ord");
            string words = Console.ReadLine();
            string[] split = words.Split(new char[] {' '});
            foreach (string s in split)
            {
                Console.WriteLine(s + "\n");
            }
        }
    }
}