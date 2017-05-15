using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.Helpers
{
    class Ninja
    {
        readonly IWeapon weapon;

        public Ninja(object ninjaWeapon)
        {
            this.weapon = ninjaWeapon as IWeapon;
        }
       

        public void Attack(string target)
        {
            this.weapon.Attack(target);
        }         
           
    }
}
