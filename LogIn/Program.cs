using System;

namespace LogIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage kasutajatunnus:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sisestage parool:");
            string Password = Console.ReadLine();

            if (UserName != "admin" || Password != "admin1234")
            {
                Console.WriteLine("Sisselogimine ebaõnnestus. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }





        }
    }
}
