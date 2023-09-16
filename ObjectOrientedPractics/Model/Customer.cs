using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Customer
{
	public class Customer
	{
		private readonly int _id;
		private string _fullname;
		private string _address;

		public Customer(string fullname, string address)
		{
			_id = IdGenerator.GetNextId();
			Fullname = fullname;
			Address = address;
        }

		public int Id
		{
			get { return _id;}
		}

		public string Fullname
		{ 
			get { return _fullname;}

			set
			{
				if(value.Length <= 200)
				{
					_fullname = value;
				}
				else
				{
					throw new ArgumentException("Не более 200 символов!!");
				}
			}
		}

		public string Address
		{
			get { return _address;}

			set
			{
				if(value.Length <= 500)
				{
					_address = value;
				}
				else
				{
					throw new ArgumentException("Не более 500 символов");
				}
			}
		}









    }
}
