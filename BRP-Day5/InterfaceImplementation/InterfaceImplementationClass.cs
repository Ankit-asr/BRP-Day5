using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceImplementation
{
    class InterfaceImplementationClass : IInteface2 , IInteface1
    {
        public void Method()
        {
            Console.WriteLine("Interfaces Method Implemented in Child Class through Multiple Inheritance");
        }
        public void Add(int number1 , int number2)
        {
            Console.WriteLine("Sum is : " + (number1 + number2));
        }
        public void Subtract(int number1, int number2)
        {
            Console.WriteLine("Difference is : " + (number1 - number2));
        }
        static void Main()
        {
            InterfaceImplementationClass obj = new InterfaceImplementationClass();
            IInteface2 i = obj;
            i.Add(100, 50);
            i.Subtract(100, 60);
            obj.Method();
        }
    }
    interface IInteface1
    {
        void Add(int number1, int number2);
    }
    interface IInteface2 : IInteface1
    {
        void Subtract(int number1, int number2);
    }
    interface IIntefaceForMultipleInheritance1
    {
        void Method();
    }
    interface IIntefaceForMultipleInheritance2
    {
        void Method();
    }
}
