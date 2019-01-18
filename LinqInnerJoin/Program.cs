namespace LinqInnerJoin
{
    using System.Collections.Generic;

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