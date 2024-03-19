using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep19
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int stock { get; set; }
        public float price { get; set; }

        public Product(int ID, string Name, string Description, int stock, float price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.stock = stock;
            this.price = price;
        }
        // -- This is Overload Constructor does not have a description -- //
        public Product(int ID, string Name, int stock, float price)
        {
            this.ID=ID;
            this.Name = Name;
            this.stock=stock;
            this.price = price;
        }
        public Product(string Name, string Description, int stock, float price)
        {
            this.ID = ID;
            this.Name = Name;
            this.stock = stock;
            this.price = price;
        }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(ID.ToString()))
                // -- This will print Product 3 -- //
                return $"Name: {Name}\nPrice: {price}\nStock : {stock}\nPrice : {price}";
         
            else if (string.IsNullOrEmpty(Description))
                // -- This will print the Product2 -- //
                return $"ID: {ID}\nName: {Name}\nPrice: {price}\nStock : {stock}\nPrice : {price}";
            else
                // -- This will print the Product1 -- //
                return $"ID: {ID}\nName : {Name}\nDescription : {Description}\nStock: {stock}\nPrice: {price}";
   
            }
        }
}
