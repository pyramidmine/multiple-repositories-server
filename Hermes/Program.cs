using MannaPlanet.Networks;
using System;

namespace MannaPlanet.Hermes
{
    class Program
    {
        static void Main(string[] args)
        {
            Networks.Person john = new Networks.Person { Name = "John", Age = 50 };
            Console.WriteLine(john.GetInfo());

            Networks.Person jane = new Networks.Person { Name = "Jane", Age = 0 };
            Console.WriteLine(jane.GetInfo());
        }
    }
}
