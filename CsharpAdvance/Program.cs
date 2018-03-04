﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    class A
    {
        public virtual void Display() { Console.WriteLine("A::Display()"); }
    }

    class B : A
    {
        public override void Display() { Console.WriteLine("B::Display()"); }
    }

    class C : B
    {
        public override void Display() { Console.WriteLine("C::Display()"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Display();
            b.Display();
            c.Display();

            a = new B();
            a.Display(); 

            b = new C();
            b.Display(); 

            Console.ReadKey();
            // we and use new and virtual keyword togather
        }
    }
}