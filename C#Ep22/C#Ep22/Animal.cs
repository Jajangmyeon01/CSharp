using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep22
{
    abstract class Animal
    {
        // -- This is a hide abstraction -- // 
       public string name { get; set; }
       public string Description { get; set; }
       public int qty { get; set; }
       public float price { get; set; }

       public Animal()
        {
            this.name = name;
            this.Description = Description;
            this.qty = qty;
            this.price = price;
        }

        protected Animal(string name, string description, int qty, float price)
        {
            this.name = name;
            Description = description;
            this.qty = qty;
            this.price = price;
        }

        public abstract void makeSound();
        public abstract void eat();
    }
  
}
