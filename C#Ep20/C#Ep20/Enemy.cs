using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep20
{
    // -- Derived Class -- //
    internal class Enemy
    {
        public string name { get; set; }
        public int health { get; set; }
        
        // -- Constructor -- //
        public Enemy(string name, int health)
        {
            this.name = name;
            this.health = health;   
        }

        public void attack()
        {
            Console.WriteLine();
            Console.WriteLine("Attacking!");

        }
        public void dead()
        {
            Console.WriteLine("Died!"); 
        }
    }
}
