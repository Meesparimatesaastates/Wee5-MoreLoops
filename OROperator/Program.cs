using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisesetada kasutajatunnus ja salasõna;
            //kui sisestaja kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna");
            string userPassword = Console.ReadLine();
            //OR või || (pipes)
            //true || true --> true
            //false|| true --> false
            //true || false --> false
            //false || false --> false
            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale ksutajatunnus või vale salasõna, proovi uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
            //"admin1" != "admin" || "admin1234" !="admin1234"--> true || false --> true
            //"admin" != "admin" || "admin123" !="admin1234" --> false|| true --> true
            //"admin1" !="admin"|| "admin123" !="admin1234" -->true||true--> true
            //"admin" != "admin"||"admin1234" !="admin1234" -->false||false--false
        }
    }
}
