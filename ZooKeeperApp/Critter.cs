using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeperApp
{
    public abstract class Critter
    {
        //public string Colour { get;set; }
        //public int Age { get;set; }
        public abstract void Eats();
        public abstract void Movement();
        public abstract override string ToString();

        //public Critter() : this("", 0)
        //{

        //}

        //public Critter(String colour, int age)
        //{
        //    this.Colour = colour;
        //    this.Age = age;
        //}

        //public virtual void Eats()
        //{
        //    Console.WriteLine("never eats");
        //}

        //public virtual void Movement()
        //{
        //    Console.WriteLine("stationary");
        //}

        //public override string ToString()
        //{
        //    return $"Any animal (Age={Age} , Colour={Colour})";

        //}

    }

}
