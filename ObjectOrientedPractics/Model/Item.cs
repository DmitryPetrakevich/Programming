using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара.
    /// </summary>
    class Item
    {
         public Category Category { get; set; } 
        /// <summary>
        /// Максимальный размер названия товара.
        /// </summary>
        private const int MaxNameLength = 200;

        /// <summary>
        /// Максимальный размер описания товара.
        /// </summary>
        private const int MaxInfoLength = 1000;

        /// <summary>
        /// Минимально допустимая цена товара.
        /// </summary>
        private const double MinCost = 0;

        /// <summary>
        /// Максимально допустимая цена товара.
        /// </summary>
        private const double MaxCost = 100000;

        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Уникальный номер товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Название товара. Должно быть не больше <see cref="MaxNameLength">MaxNameLength</see> символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxNameLength, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Описание товара. Должно быть не больше <see cref="MaxInfoLength">MaxInfoLength</see> символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxInfoLength, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Цена товара. Должна быть от <see cref="MinCost">MinCost</see> до <see cref="MaxCost">MaxCost</see>.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertDoubleOnRange(value, MinCost, MaxCost, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">asdsad.</param>
        /// <param name="info">Описание товара. Должно быть не больше <see cref="MaxInfoLength">MaxInfoLength</see> символов.</param>
        /// <param name="cost">Цена товара. Должна быть от <see cref="MinCost">MinCost</see> до <see cref="MaxCost">MaxCost</see>.
        /// <param name="id">Уникальный номер товара. Класс не проверяет уникальность номера</param>
        public Item(string name, string info, double cost, int id, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = id;
            Category = category;
        }
    }


}
