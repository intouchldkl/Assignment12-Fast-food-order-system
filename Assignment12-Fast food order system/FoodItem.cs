using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment12_Fast_food_order_system
{
    class FoodItem
    {
        private string itemCode;
        private int quantity;

        public FoodItem(string itemCode,int quantity)
        {
            this.itemCode = itemCode;
            this.quantity = quantity;
        }
        public string getItemCode()
        {
            return itemCode;
        }
        public int getQuantity()
        {
            return quantity;
        }
    }
}
