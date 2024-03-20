using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep20
{
    // -- Base Class -- //
    internal class BasicEnemy : Enemy
    {
        public int speed { get; set; }

        public BasicEnemy(string name, int health, int speed) : base (name, health)
        {
            this.speed = speed;
        }
        public void attack()
        {
            base.attack();
            Console.WriteLine("BaldMan was Attacking on the Ground!");

        }
        public void walking()
        {
            Console.WriteLine("Walking");
        }

    }
}
