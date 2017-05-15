using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.Helpers
{
    public class Nunchaku : IWeapon
    {
        public void Attack(string target)
        {
            Console.WriteLine("Attacking {0} with Nunchaku!", target);
        }

    }
}
