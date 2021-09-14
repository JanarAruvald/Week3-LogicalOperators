using System;

namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus
            //programm küsib kasutajal sisestada parool
            //programm kontrollib, kas mõlemad, nii kasutajatunnus kui ka parool on õiged
            //kui on õiged, siis programm kuvab konsoolis "tere tulemast!"
            //kui on valed, siis programm kuvab sisselogimine ebaõnnestus.Prooviuuesti."
            //kt: admin, pr: admin1234

            Console.WriteLine("Sisestage kasutajatunnus:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sisestage parool:");
            string Password = Console.ReadLine();

            if (UserName == "admin" && Password == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Sisselogimine ebaõnnestus. Proovi uuesti.");
            }


            


        }
    }
}
