namespace exercise2
{
    class Program
    {
        public static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Huvudmeny!Ni trycker Program1 Program2 Program3 for olika funktioner ");
                Console.WriteLine("four choice 0 1 2 3 4");
                Console.Write("your choice");
                string s = Console.ReadLine();
                int n = int.Parse(s);
                switch (n)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        TicketPrice();
                        Console.ReadLine();
                        break;
                    case 2:
                        GroupTicketPrice();
                        Console.ReadLine();
                        break;
                    case 3:
                        RepeatTen();
                        Console.ReadLine();
                        break;
                    case 4:
                        FindThirdWord();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Felaktig input");
                        break;
                }

            } while (true);

        }



        static void TicketPrice()
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
        static void GroupTicketPrice()
        {

            Console.WriteLine("Hur många vi är som ska gå på bio");
            int numberOfTickets = Convert.ToInt32(Console.ReadLine());

            int t = 0;
            int sum = 0;
            for (var i = 0; i < numberOfTickets; i++)
            {
                Console.WriteLine($"Ålder på besökare nr. {i + 1}");
                var age = Convert.ToInt32(Console.ReadLine());

                if (age < 20)
                {
                    t = 80;
                }
                else if (age > 64)
                {
                    t = 90;
                }
                else
                {
                    t = 120;
                }

                sum = sum + t;
            }

            Console.WriteLine("total kostnad=" + sum);

        }
        static void RepeatTen()
        {

            string meningen = Console.ReadLine();
            int num = 1;
            for (; num <= 10;)
            {
                Console.WriteLine(meningen);
                num++;
            }

        }
        static void FindThirdWord()
        {

            Console.WriteLine("anger en mening med minst 3 ord");
            string words = Console.ReadLine();
            string[] split = words.Split(new char[] { ' ' });
            foreach (string s in split)
            {
                Console.WriteLine(s + "\n");
            }

        }


    }


}

