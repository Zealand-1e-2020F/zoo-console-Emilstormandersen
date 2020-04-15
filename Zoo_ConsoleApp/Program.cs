using System;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Zoo!");

            Dyr Elefant = new Dyr("Elefant");
            Dyr Stankelben = new Insekt("Stankelben");


            Console.WriteLine(Elefant.DyreNavn);
            Console.WriteLine(Stankelben.DyreNavn);


        }
    }
}
