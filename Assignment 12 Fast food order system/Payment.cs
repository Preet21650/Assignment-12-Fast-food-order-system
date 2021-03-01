using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_food_order_system
{
    class Payment
    {
        private FoodItem[] fi;
        private DrinkItem[] di;
        private int fiCount;
        private int diCount;

        public Payment() 
        {
            fiCount = 0;
            diCount = 0;
            fi = new FoodItem[100];
            di = new DrinkItem[100];
        }

        public void AddFood(String code, int quantity) 
        {
            fi[fiCount] = new FoodItem(code,quantity);
            fiCount++;
        }

        public void AddDrink(String code, int quantity) 
        {
            di[diCount] = new DrinkItem(code, quantity);
            diCount++;
        }

        public FoodItem GetFood(int i) 
        {
            return fi[i];
        }

        public DrinkItem GetDrink(int i) 
        {
            return di[i];
        }

        public double FindPrice(Item[] pl, string code) 
        {
            for (int i = 0; i < pl.Length; i++) 
            {
                if (pl[i] != null && pl[i].GetCode() == code)
                {
                    return pl[i].GetPrice();

                }
                else
                {
                    Console.WriteLine(" Couldnt find the price");
                }

            }
            return 0;
        }

        public double CalcBill(Item[] pl) 
        {
            double Total = 0;
            for (int i = 0; i < fi.Length; i++) 
            {
                if (fi[i] != null) 
                {
                    double price = FindPrice(pl, fi[i].GetCode());
                    int quantity = fi[i].GetQuantity();
                    double SubTotal = price * quantity;
                    Total = Total + SubTotal; 
                }
                

            }
            for (int i = 0; i < di.Length; i++)
            {
                if (di[i] != null)
                {
                    double price = FindPrice(pl, di[i].GetCode());
                    int quantity = di[i].GetQuantity();
                    double SubTotal = price * quantity;
                    Total = Total + SubTotal;
                }


            }

            return Total;
        }




    }
}
