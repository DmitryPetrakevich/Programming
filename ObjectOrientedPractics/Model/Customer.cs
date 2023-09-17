using System;

/// <summary>
/// Класс представляющий покупателя.
/// </summary>
public class Customer
{
    /// <summary>
    /// Уникальный номер покупателя.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Полное имя покупателя.
    /// </summary>
    private string _fullname;

    /// <summary>
    /// Адрес доставки покупателя.
    /// </summary>
    private string _address;

    /// <summary>
    /// Конструктор для создания экземпляра покупателя.
    /// </summary>
    /// <param name="fullname">Полное имя покупателя.</param>
    /// <param name="address">Адрес доставки покупателя.</param>
    public Customer(string fullname, string address)
    {
        _id = IdGenerator.GetNextId();
        Fullname = fullname;
        Address = address;
    }

    /// <summary>
    /// Получает уникальный номер покупателя.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Получает или устанавливает полное имя покупателя.
    /// </summary>
    public string Fullname
    {
        get { return _fullname; }

        set
        {
            ValueValidator.AssertStringOnLength(value, 200, "FullName");
            _fullname = value;
        }
    }

    /// <summary>
    /// Получает или устанавливает адрес доставки покупателя.
    /// </summary>
    public string Address
    {
        get { return _address; }

        set
        {
            ValueValidator.AssertStringOnLength(value, 500, "Address");
            _address = value;
        }
    }
}











