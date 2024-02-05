using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    public class ShoppingItem
    {

        public string ItemName { get; set; }

        public ShoppingItem(string itemName) 
        { 
            ItemName = itemName; 
        }

        //public ShoppingItem() { }

        public override string ToString()
        {
            return ItemName;
        }
    }
}
