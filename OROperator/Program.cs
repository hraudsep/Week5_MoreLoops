using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kastajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admind1234";
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti.";

            //OR (või) || (pipes)

            //true || true --> true
            //false || true --> true
            //true || false --> true
            //false || false --> false

            Console.WriteLine("Sisesta kastajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool, proovi uuesti.");
            }

            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            //"admin1" != "admin" || "admin1234" != "admin1234" --> true || false
            //"admin" != "admin" || "admin123" != "admin1234" --> false || true
            //"admin1" != "admin" || "admin123" != "admin1234" --> true || true
            //"admin" != "admin" || "admin1234" != "admin1234" --> false || false
        }
    }
}
