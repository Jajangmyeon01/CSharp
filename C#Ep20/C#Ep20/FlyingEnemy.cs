using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep20
{
    // -- Base Class -- // 
    internal class FlyingEnemy : Enemy
    {
        public int flySpeed { get; set; }

        public FlyingEnemy(string name, int health, int flySpeed) : base (name, health)
        {
            this.flySpeed = flySpeed;
        }
        public void attack()
        {
            base.attack();
            Console.WriteLine("MosquitoFly was Attacking on the Air!");
        }
        public void flying()
        {
            Console.WriteLine("Flying");
        }


    }
}
