using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment12_Fast_food_order_system
{
    class Item
    {
        private string itemCode;
        private string name;
        private double price;

        public Item(string itemCode,string name,double price)
        {
            this.itemCode = itemCode;
            this.name = name;
            this.price = price;
        }
        public string getItemCode()
        {
            return itemCode;
        }
        public string getName()
        {
            return name;
        }
        public double getPrice()
        {
            return price;
        }
    }
}
