using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            A a1 = new A();
            A a2 = new A();

            B b1 = new B();
            B b2 = new B();

            C c1 = new C();

            b1.a = b2;
            b2.a = a2;

            c1.a = a1;
            c1.b = b1;
          
        }
    }

    public class A
    {

    }

    public class B : A
    {
        public Object a;
    }

    public class C : B
    {
        public Object b;
    }
}
