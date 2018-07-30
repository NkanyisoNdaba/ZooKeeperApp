using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeperApp
{
    public class Zebra : Critter
    {
        //public Zebra() : this("black and white", 7)
        //{

        //}
        private string Colour;
        private int Age;

        public Zebra(String colour, int age)
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
            Console.WriteLine("run");
        }

        public override string ToString()
        {
            return $"Zebra (Age={Age} , Colour={Colour})";
        }
    }

}
