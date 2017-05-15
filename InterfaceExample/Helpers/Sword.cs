using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.Helpers
{
    public class Sword : IWeapon
    {
        public void Attack(string target)
        {
            Console.WriteLine("Attacking {0} with sword!", target);
        }
    }
}
