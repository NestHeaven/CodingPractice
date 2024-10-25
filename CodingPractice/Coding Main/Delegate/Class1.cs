using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Main.Delegate
{
    public delegate void DelegateDelegate(string value);
    public static class Class1
    {
        public static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        public static string FuncGenericDelegate()
        {
            return String.Empty;
        }
    }


    public class A
    {
        static A()
        {
            Console.WriteLine("Static A");
        }

        public A()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        static B()
        {
            Console.WriteLine("Static B");
        }
        public B()
        {
            Console.WriteLine("B");
        }
    }

    public class C : B
    {
        public C()
        {
            Console.WriteLine("Static C");
        }

        static C()
        {
            Console.WriteLine("C");
        }
    }
}
