using System;
using System.IO;

namespace Assignment12_Fast_food_order_system
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            StreamReader fileReader = new StreamReader("food.csv");
            while ((fileReader.ReadLine()) != null)
            {                
                length++;
            }

            
            fileReader = new StreamReader("food.csv");
            string line = fileReader.ReadLine();
            Item[] items = new Item[length-1];
            int count = 0;
            while ((line = fileReader.ReadLine())!= null)
            {
                string[] cells = line.Split(",");
                string Code = cells[0];
                string name = cells[1];
                double price = Convert.ToDouble(cells[2]);
                items[count] = new Item(Code, name, price);
                count++;
                
            }


            /*
            Item[] items = new Item[]
            {
                new Item("D1","Coke",12),
                new Item("F1","Burger",30),
                new Item("D2","Water",7),
                new Item("F2","Fries",19)

            };
            */
            string code;
            string code1;
            string order = "";
            int quantity = 0;
            Payment P1 = new Payment();
            Menu(items);
            while(order != "end")
            {
                Console.WriteLine("Please place an order");
                
                order = Console.ReadLine();
                if(order == "end")
                {
                    break;
                }
                Console.WriteLine("Please write the quantity you want");
               if( int.TryParse(Console.ReadLine(), out quantity) == false)
                {
                    continue;
                }
                Console.WriteLine("Type end to submit the order");

                for (int i = 0;i < items.Length;i++)
                {
                    if(items[i].getName()== order)
                    {
                        code = items[i].getItemCode();
                        code1 = code.Substring(0, 1);
                        if(code1 == "F")
                        {
                            P1.addFood(new FoodItem(code, quantity));
                        }
                        else if(code1 == "D")
                        {
                            P1.addDrink(new DrinkItem(code, quantity));
                        }
                    }
                }
                
            }

            Console.WriteLine("Your bill is " + P1.CalBill(items) + "$");
            
        }
        public static  void Menu(Item[] items)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("{0,10}{1,1}{2,12}","ITEM","\t","PRICE");
            for(int i = 0; i < items.Length;i++)
            {
                Console.WriteLine("{0,10} {1,1} {2,10}",
                items[i].getName(),"\t", items[i].getPrice());
            }
            
        }
    }
}
