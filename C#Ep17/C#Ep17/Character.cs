using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep17
{
    internal class Character
    {
        public string name, dialog, stats;
        public int hp, mp, lvl;

        #region -- Constructor --
        // -- Constructor --
        public Character(string name, string dialog, int hp, int mp, int lvl, string stats)
        {
            this.name = name;
            this.dialog = dialog;
            this.hp = hp;
            this.mp = mp;
            this.lvl = lvl;
        }
        #endregion


        #region -- Methods -- 
        // -- Methods --
        public void introduce()
        {
            Console.WriteLine($"Hi my name is : {name}");
        }
        public void sayDialog()
        {
            Console.WriteLine($"{name} : {dialog} ");
        }
        public void health()
        {
            Console.WriteLine($"Health : {hp}");
        }
        public void manaPower()
        {
            Console.WriteLine($"Mana Power : {mp}");
        }
        public void level()
        {
            Console.WriteLine($"Level : {lvl}");
        }
        #endregion

        #region -- Using return type --
        /* -- Using return type --
        public string checkStats()
        {
            return $"{stats}";
     
        }
        */
        #endregion



    }
}
