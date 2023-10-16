using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    class Cart
    {
        private List<Item> items;
        public Cart()
        {
            items = new List<Item>();
        }

        public List<Item> Items 
        { 
            get 
            { 
                return items; 
            } 
        }

        public double Amount
        {
            get
            {
                if (items == null || items.Count == 0)
                {
                    return 0.0;
                }
               
                double totalAmount = 0.0;
                foreach (Item item in items)
                {
                    totalAmount += item.Cost;
                }

                return totalAmount;
                
            }
        }
        
        
        
    }
}
