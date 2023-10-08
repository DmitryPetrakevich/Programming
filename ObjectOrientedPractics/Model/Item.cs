using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара.
    /// </summary>
    class Item
    {
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

        public Category Category { get; set; }

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
                string propertyName = nameof(Name);
                ValueValidator.AssertStringOnLength(value, MaxNameLength, propertyName);
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
                string propertyName = nameof(Info);
                ValueValidator.AssertStringOnLength(value, MaxInfoLength, propertyName);
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
                string propertyName = nameof(Cost);
                ValueValidator.AssertDoubleOnRange(value, MinCost, MaxCost, propertyName);
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
        /// <param name="category">Категория товара</param>
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
