using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Farm;

namespace Farm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Bark();
            dog.Eat();
        }
    }
}
