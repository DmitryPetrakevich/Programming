using System;

/// <summary>
/// Класс представляющий товар.
/// </summary>
public class Item
{
    /// <summary>
    /// Уникальный номер товара.
    /// </summary>
    private readonly int _id;

    /// <summary>
    ///  Название товара.
    /// </summary>
    private string _name;

    /// <summary>
    /// Описание товара.
    /// </summary>
    private string _info;

    /// <summary>
    /// Стоимость товара.
    /// </summary>
    private double _cost;

    /// <summary>
    /// Конструктор для создания экземпляра товара.
    /// </summary>
    /// <param name="name">Название товара.</param>
    /// <param name="info">Описание товара.</param>
    /// <param name="cost">Стоимость товара.</param>
    public Item(string name, string info, double cost)
    {
        _id = IdGenerator.GetNextId();
        Name = name;
        Info = info;
        Cost = cost;
    }

    /// <summary>
    /// Получает уникалльный номер товара.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Получает или устанавливает название товара.
    /// </summary>
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

    /// <summary>
    /// Получает или устанавливает название товара.
    /// </summary>
    public string Info
    {
        get { return _info; }

        set
        {
            ValueValidator.AssertStringOnLength(value, 1000, "Info");
            _info = value;
        }
    }

    /// <summary>
    /// Получает или устанавливает стоимость товара.
    /// </summary>
    public double Cost
    {
        get { return _cost; }

        set
        {
            ValueValidator.AssertStringOnLength(value, 100_000, "Cost");
            _cost = value;
        }
    }
}



