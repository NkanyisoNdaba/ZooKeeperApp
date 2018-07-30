using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeperApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChooseAnimal();

            int selection = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            do
            {
                if (selection == 1)
                {
                    Console.WriteLine("Enter Colour");
                    var colour = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    var age = int.Parse(Console.ReadLine());
                    var frog = new Frog(colour, age);

                    Console.WriteLine("The Zoo Contains:\n" + frog.ToString());
                    frog.Eats();
                    frog.Movement();
                    Console.WriteLine("\n");
                    ChooseAnimal();
                    Console.Read();


                }
                else if (selection == 2)
                {

                    Console.WriteLine("Enter Colour");
                    var colour = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    var age = int.Parse(Console.ReadLine());
                    var zebra = new Zebra(colour, age);

                    Console.WriteLine("The Zoo Contains:\n" + zebra.ToString());
                    zebra.Eats();
                    zebra.Movement();
                    Console.WriteLine("\n");
                    ChooseAnimal();
                    Console.Read();
                }

                else if (selection == 3)
                {

                    Console.WriteLine("Enter Colour");
                    var colour = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    var age = int.Parse(Console.ReadLine());
                    var rabbit = new Rabbit(colour, age);

                    Console.WriteLine("The Zoo Contains:\n" + rabbit.ToString());
                    rabbit.Eats();
                    rabbit.Movement();
                    Console.WriteLine("\n");
                    ChooseAnimal();
                    Console.Read();
                }
                else if (selection == 4)
                {
                    Console.WriteLine("Enter Colour");
                    var colour = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    var age = int.Parse(Console.ReadLine());
                    var elephant = new Elephant(colour, age);

                    Console.WriteLine("The Zoo Contains:\n" + elephant.ToString());
                    elephant.Eats();
                    elephant.Movement();
                    Console.WriteLine("\n");
                    ChooseAnimal();
                    Console.Read();
                }

                else if (selection == 5)
                {
                    Environment.Exit(0);
                }


            } while (selection!=5);
           




        }

        private static void ChooseAnimal()
        {
            Console.WriteLine("Enter an animal you wish to create \n Enter 1 for Frog \n Enter 2 for Zebra \n Enter 3 for Rabbit \n Enter 4 for Elephant \n Enter 5 for Exit");
        }
    }
}
