using System;

/// <summary>
/// Summary description for Item
/// </summary>
public class Item
{
	private readonly int _id;
	private string _name;
	private string _info;
	private double _cost;

	public Item(string name,string info,double cost)
	{
		_id = IdGenerator.GetNextId();
		Name = name;
		Info = info;
		Cost = cost;
	}

	public int Id
	{ 
		get { return _id; }
	}

	public string Name
	{
		get
		{ return _name; }

		set
		{
			ValueValidator.AssertStringOnLength(value, 200, "Name");
			_name = value;
        }	
	}

	public string Info
	{
		get { return _info; }

		set
		{
			ValueValidator.AssertStringOnLength(value, 1000, "Info");
			_info = value;
		}
	}

	public double Cost
	{
		get { return _cost; }

		set
		{
			if(value >= 0 &&  value <= 1000)
			{
				_cost = value;
			}

			else
			{
				throw new ArgumentException("Диапазон от 0 до 1000!");
			}
		}
	}
}


