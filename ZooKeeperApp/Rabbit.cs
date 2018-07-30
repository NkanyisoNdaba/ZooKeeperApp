using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeperApp
{
    public class Rabbit : Critter
    {
        //public Rabbit() : this("White", 5)
        //{

        //}
        private string Colour;
        private int Age;

        public Rabbit(String colour, int age)
        {
            this.Colour = colour;
            this.Age = age;
        }
        public override void Eats()
        {
            Console.WriteLine("eats leaves");
        }

        public override void Movement()
        {
            Console.WriteLine("jump");
        }

        public override string ToString()
        {
            return $"Rabbit (Age={Age} , Colour={Colour})";
        }
    }

}
