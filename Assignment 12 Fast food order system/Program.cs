using System;

namespace Assignment_12_Fast_food_order_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] pl = new Item[]
            {
                new Item("D1","Coke",1.99),
                new Item("D2","Pepsi",1.23),
                new Item("F1","Burger",1.50),
                new Item("F2","Chips",1.20),
                new Item("F3","Pizza",5.99),
            };

            Payment preetslunch = new Payment();

            preetslunch.AddFood("F3", 2);
            preetslunch.AddDrink("D2", 4);


            //gfggfh
        }
    }
}
