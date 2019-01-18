namespace LinqInnerJoin
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            var itemList = new List<Item_mast>
            {
                new Item_mast { ItemId = 1, ItemDesc = "Biscuit"},
                new Item_mast { ItemId = 2, ItemDesc = "Chocolate" },
                new Item_mast { ItemId = 3, ItemDesc = "Butter" },
                new Item_mast { ItemId = 4, ItemDesc = "Brade" },
                new Item_mast { ItemId = 5, ItemDesc = "Honey" }
            };

            var purchList = new List<Purchase>
            {
                new Purchase { InvNo = 100, ItemId = 3,  PurQty = 800 },
                new Purchase { InvNo = 101, ItemId = 2,  PurQty = 650 },
                new Purchase { InvNo = 102, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo = 103, ItemId = 4,  PurQty = 700 },
                new Purchase { InvNo = 104, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo = 105, ItemId = 4,  PurQty = 650 },
                new Purchase { InvNo = 106, ItemId = 1,  PurQty = 458 }
            };

            Console.Write("\nLINQ : Generate an Inner Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in itemList)
            {
                Console.WriteLine(
                "Item Id: {0}, Description: {1}",
                item.ItemId,
                item.ItemDesc);
            }

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            foreach (var item in purchList)
            {
                Console.WriteLine(
                "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                item.InvNo,
                item.ItemId,
                item.PurQty);
            }

            Console.Write("\nHere is the list after joining  : \n\n");

            var innerJoin = from e in itemList
                            join d in purchList
                            on e.ItemId equals d.ItemId
                            select new
                            {
                                itId = e.ItemId, 
                                itDesc = e.ItemDesc,
                                prQty = d.PurQty
                            };

            Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var data in innerJoin)
            {
                Console.WriteLine(data.itId + "\t\t" + data.itDesc + "\t\t" + data.prQty);
            }

            Console.ReadKey();
        }
    }

    class Item_mast
    {
        public int ItemId { get; set; }
        public string ItemDesc { get; set; }
    }

    class Purchase
    {
        public int InvNo { get; set; }

        public int ItemId { get; set; }

        public int PurQty { get; set; }
    }
}