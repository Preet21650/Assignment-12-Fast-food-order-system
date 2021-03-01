using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_food_order_system
{
    class Item
    {
        private string code;
        private string name;
        private double price;


        public Item(string code, string name, double price) {
            this.code = code;
            this.name = name;
            this.price = price;
        }

        public String GetCode()
        {
            return code;
        }

        public double GetPrice() 
        {
            return price;
        }


    }  
}
