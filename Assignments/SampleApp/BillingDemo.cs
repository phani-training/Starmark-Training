using System;
using System.Collections.Generic;
using DataLayer;
using System.Linq;
namespace BillingExample
{
    class Bill
    {
        static int no = 0;
        public Bill()
        {
            BillNo = ++no;
        }
        public HashSet<Item> AllItems { get; private set; } = new HashSet<Item>();
        public int BillNo { get; private set; }
        public string CustomerName { get; set; }
        public DateTime BillDate => DateTime.Now;
        public int BillAmount { get; internal set; }
        public void AddItem(Item item)
        {
            
            if (!AllItems.Add(item))
            {
                foreach(var element in AllItems)
                {
                    if (item.ItemNo == element.ItemNo)
                    {
                        element.Quantity += item.Quantity;
                    }
                    else continue;
                }
            }
        }
        public void ComputeBill()
        {
            int amount = 0;
            foreach(var item in AllItems)
            {
                amount += item.Quantity * item.UnitPrice;
            }
            BillAmount = amount;
        }
    }

    class Item
    {
        static int no = 0;
        public Item()
        {
            ItemNo = ++no;
        }
        public int ItemNo { get; private set; }
        public string  Perticulars { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; } = 1;
        public override int GetHashCode() => ItemNo.GetHashCode();
        public override bool Equals(object obj) => ItemNo.Equals(((Item)obj).ItemNo);
        public override string ToString()
        {
            return $"{ItemNo}-{Perticulars}-{UnitPrice:c}";
        }

    }
    class MainClass
    {
        static HashSet<Item> items = null;
        //Using static constructor to initialize the items
        static MainClass()
        {
            items = new HashSet<Item>();
            items.Add(new Item { Perticulars = "Sugar 5 Kgs", UnitPrice = 150 });
            items.Add(new Item { Perticulars = "Rice 5 Kgs", UnitPrice = 220 });
            items.Add(new Item { Perticulars = "Rice 30 Kgs", UnitPrice = 1500 });
            items.Add(new Item { Perticulars = "Toor dhal", UnitPrice = 120 });
            items.Add(new Item { Perticulars = "Maggie Hot and Sweet", UnitPrice = 210 });
            items.Add(new Item { Perticulars = "Maggie Noodles", UnitPrice = 120 });
            items.Add(new Item { Perticulars = "MTR Idly Rava", UnitPrice = 70 });
            items.Add(new Item { Perticulars = "MTR Rasam Powder", UnitPrice = 80 });
            items.Add(new Item { Perticulars = "Priya Avakai Pickles", UnitPrice = 200 });
            items.Add(new Item { Perticulars = "Jaggery", UnitPrice = 50 });
            items.Add(new Item { Perticulars = "Tamarind", UnitPrice = 45 });

        }

        static Item FindItem(int id)
        {
            foreach(var item in items)
            {
                if (item.ItemNo == id)
                    return item;
            }
            throw new Exception("Item not found");
        }

        static void displayItems()
        {
            foreach (var item in items) Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            Bill bill = new Bill();
            bill.CustomerName = Utilities.Prompt("Enter the Customer Name");
            int choice = 1;
            do
            {
                Item item = createItem();
                bill.AddItem(item);
                choice = Utilities.GetNumber("Press 1 to Add new item, else any other no!!!");
            } while (choice == 1);

            displayBill(bill);


        }
        private static void displayRow(object data)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(data);
            Console.WriteLine("---------------------------------------------------------");
        }
        private static void displayBill(Bill bill)
        {
            bill.ComputeBill();
            Console.Clear();
            displayRow(bill.BillDate.ToShortDateString());
            displayRow(bill.CustomerName);
            displayRow(bill.BillNo);
            int SlNo = 1;
            displayRow($"SlNo.\tPerticulars\t\tUnit Price\t\tQuantity\t\tAmount");
            foreach(var item in bill.AllItems)
            {
                Console.WriteLine($"{SlNo}\t{item.Perticulars}\t\t{item.UnitPrice:C}\t\t{item.Quantity}\t\t{(item.Quantity * item.UnitPrice):c}");
                SlNo++;
            }
            displayRow("The total Bill: " + bill.BillAmount);
        }

        private static Item createItem()
        {
            displayItems();
            TRYAGAIN:
            int id = Utilities.GetNumber("Enter the Item ID from the list Above to Add");
            int quantity = Utilities.GetNumber("Enter the Quantity of the Items");
            try
            {
                var item = FindItem(id);
                item.Quantity = quantity;
                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                goto TRYAGAIN;
            }
        }
    }
}
