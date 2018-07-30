using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeperApp
{
    public class Elephant : Critter
    {

        //public Elephant() : this("yellow", 10)
        //{

        //}
        private string Colour;
        private int Age;

        public Elephant(String colour, int age)
        {
            this.Colour = colour;
            this.Age = age;
        }
        public override void Eats()
        {
            Console.WriteLine("eats grass");
        }

        public override void Movement()
        {
            Console.WriteLine("slow");
        }

        public override string ToString()
        {
            return $"Elephant (Age={Age} , Colour={Colour})";
        }
    }

}
