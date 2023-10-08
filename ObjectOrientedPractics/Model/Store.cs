using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
	internal class Store
	{
		private List<Item> _items;
		private List<Customer> _customers;

		public List<Item> Items
		{
			get
			{
				return _items;
			}
			set
			{
				_items = value;
			}
		}

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

		public Store()
		{
			Items = new List<Item>();
			Customers = new List<Customer>();
		}

    }
}
