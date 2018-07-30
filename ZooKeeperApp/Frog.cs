using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeperApp
{
    public class Frog : Critter
    {
        //public Frog() : this("Brown", 4)
        //{

        //}
        private string Colour;
        private int Age;

        public Frog(String colour, int age)
        {
            this.Colour = colour;
            this.Age = age;
        }
        public override void Eats()
        {
            Console.WriteLine("eats flies");
        }

        public override void Movement()
        {
            Console.WriteLine("hops and swims around");
        }

        public override string ToString()
        {
            return $"Frog (Age={Age} , Colour={Colour})";
        }
    }

}
