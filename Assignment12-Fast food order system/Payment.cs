using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment12_Fast_food_order_system
{
    class Payment
    {
        private FoodItem[] fi;
        private DrinkItem[] di;
        private int fiCount;
        private int diCount;

        public Payment()
        {
            fi = new FoodItem[100];
            di = new DrinkItem[100];
            fiCount = 0;
            diCount = 0;
        }
        public FoodItem getFood(int i)
        {
            return fi[i];
        }
        public DrinkItem getDrink(int i)
        {
            return di[i];
        }
        public void addFood(FoodItem food)
        {
            fi[fiCount] = food;
            fiCount++;
        }
        public void addDrink(DrinkItem drink)
        {
            di[diCount] = drink;
            diCount++;
        }
        public double FindPrice(Item[] priceList,string code)
        {
            double price = 0;
            for(int i = 0; i < priceList.Length;i++)
            {
                if(priceList[i] != null)
                {
                    if(priceList[i].getItemCode() == code)
                    {
                        price = priceList[i].getPrice();
                    }
                }
            }
            return price;
        }
        public double CalBill(Item[] priceList)
        {
            double total = 0;
            string code;
            int q;
            double price;

            for(int i = 0;i < fiCount;i++)
            {
                code = fi[i].getItemCode();
                q = fi[i].getQuantity();
                price = FindPrice(priceList, code);
                total = total + (price * q);

            }
            for (int i = 0; i < diCount; i++)
            {
                code = di[i].getItemCode();
                q = di[i].getQuantity();
                price = FindPrice(priceList, code);
                total = total + (price * q);

            }
            return total;
        }


    }
}
