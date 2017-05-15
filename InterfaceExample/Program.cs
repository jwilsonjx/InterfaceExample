using System;
using InterfaceExample.Helpers;

namespace InterfaceExample
{
    class Program
    {
       
        static void Main(string[] args)
        {            
            Ninja warrior = new Ninja(new Nunchaku());
            warrior.Attack("GI Joe");            
        }
    }
}