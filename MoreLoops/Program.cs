﻿using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kastajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admind1234";
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti.";

            Console.WriteLine("Sisesta kastajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            //AND (&&) või OR

            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            //"admin1" AND "admin12345" --> false


            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }

            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna, proovi uuesti.");
            }
        }
    }
}
