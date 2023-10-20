using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Skriv in förnamn och efternamn på samma rad");

            string namn = Console.ReadLine();
            int mellanslagsindex = namn.IndexOf(" ");

            string förnamn = namn[..mellanslagsindex];
            string efternamn = namn[(mellanslagsindex + 1)..];

            if (förnamn.CompareTo(efternamn) < 0)
            {
                Console.WriteLine("Ditt förnamn är först i bokstavsordning");
            }
            else if (förnamn.CompareTo(efternamn) > 0)
            {
                Console.WriteLine("Ditt efternamn är först i bokstavsordning");
            }
            else
            {
                Console.WriteLine("Du har samma förnamn som efternamn");
            }

        }

    }
}