namespace LinqInnerJoin
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specifc arguments.</param>
        public static void Main(string[] args)
        {
            var itemList = new List<ItemMast>
            {
                new ItemMast { ItemId = 1, ItemDesc = "Biscuit"},
                new ItemMast { ItemId = 2, ItemDesc = "Chocolate" },
                new ItemMast { ItemId = 3, ItemDesc = "Butter" },
                new ItemMast { ItemId = 4, ItemDesc = "Brade" },
                new ItemMast { ItemId = 5, ItemDesc = "Honey" },
            };

            var purchList = new List<Purchase>
            {
                new Purchase { InvNo = 100, ItemId = 3,  PurQty = 800 },
                new Purchase { InvNo = 101, ItemId = 2,  PurQty = 650 },
                new Purchase { InvNo = 102, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo = 103, ItemId = 4,  PurQty = 700 },
                new Purchase { InvNo = 104, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo = 105, ItemId = 4,  PurQty = 650 },
                new Purchase { InvNo = 106, ItemId = 1,  PurQty = 458 },
            };

            Console.Write("\nLINQ : Generate an Inner Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item Master List : ");
            Console.Write("\n-------------------------\n");

            PrintItemList(itemList);

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            PrintPurchaseList(purchList);

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

        private static void PrintPurchaseList(List<Purchase> purchList)
        {
            foreach (var item in purchList)
            {
                Console.WriteLine(
                "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                item.InvNo,
                item.ItemId,
                item.PurQty);
            }
        }

        private static void PrintItemList(List<ItemMast> itemList)
        {
            foreach (var item in itemList)
            {
                Console.WriteLine(
                "Item Id: {0}, Description: {1}",
                item.ItemId,
                item.ItemDesc);
            }
        }
    }
}