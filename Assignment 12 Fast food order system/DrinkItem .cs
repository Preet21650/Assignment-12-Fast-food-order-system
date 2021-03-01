using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_food_order_system
{
    class DrinkItem
    {
        private string code;
        private int quantity;


        public DrinkItem(string code, int quantity)
        {
            this.code = code;
            this.quantity = quantity;

        }

        public string GetCode() 
        {
            return code;
        }

        public int GetQuantity()
        {
            return quantity;
        }


    }
}
