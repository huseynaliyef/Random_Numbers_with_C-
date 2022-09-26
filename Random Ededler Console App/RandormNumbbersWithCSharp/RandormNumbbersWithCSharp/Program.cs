using System;

namespace RandomNumbers
{
    class RandomNum
    {
        static void Main(string[] args)
        {
            RandomNum num = new RandomNum();
            num.menu1();
        }



        void func_random()
        {
            Random random_eded = new Random();
            int rnd_eded = random_eded.Next(100);

            Console.WriteLine("\t\t\t\tRandom Ededler Oyunumuza Xos Gelmisiniz.");
            Console.WriteLine();

            bool sert = true;
            do
            {
                Console.Write("Random Ededi yazin: ");
                int eded = Convert.ToInt32(Console.ReadLine());
                if (eded > rnd_eded)
                {
                    Console.WriteLine("Daxil Etdiyiniz Eded Random Edetden Boyukdur!");
                }
                else if (eded < rnd_eded)
                {
                    Console.WriteLine("Daxil Etdiyiniz Eded Random Edetden Kicikdir!");
                }
                else
                {
                    Console.WriteLine("                   Random Ededi Dogru Tapdiniz Tebrikler!!!\n\n");
                    break;
                }
            } while (sert);
            RandomNum obj = new RandomNum();
            obj.menu2();
            
        }


        void menu1()
        {
            Console.WriteLine("                   Oyuna Daxil Olmaq Isteyirsinizse  -'1'-  Duymesine Basin.");
            Console.WriteLine("                   Oyundan Cixmaq Isteyirsinizse     -'0'-  Duymesine Basin.");
            Console.Write("\n\tSeciminizi Edin: ");
            int duyme = Convert.ToInt32(Console.ReadLine());
            if(duyme  == 1)
            {
                RandomNum obj = new RandomNum();
                obj.func_random();
            }
            else if(duyme == 0)
            {
               System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Duzgun Secim Etmediniz!...");
                RandomNum obj = new RandomNum();
                obj.menu1();
            }

        }

        void menu2()
        {
            Console.WriteLine("                   Yeniden Oynamaq isteyirsiniz ? Isteyirsinizse YES yazin.");
            Console.WriteLine("                   Oyundan Cixmaq Isteyirsinizse NO Yazin.");
            string soz = Console.ReadLine();
            if(soz == "YES")
            {
                RandomNum obj = new RandomNum();
                obj.func_random();
            }
            else if(soz == "NO")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Duzgun Secim Etmediniz!...");
                RandomNum obj = new RandomNum();
                obj.menu2();
            }
        }

    }
}