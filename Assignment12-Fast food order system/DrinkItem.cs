using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment12_Fast_food_order_system
{
    class DrinkItem
    {
        private string itemCode;
        private int quantity;

        public DrinkItem(string itemCode, int quantity)
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
