using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс покупателя.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Максимальный размер полного имени.
        /// </summary>
        private const int MaxFullname = 200;

        /// <summary>
        /// Максимальный размер адреса.
        /// </summary>
        private const int MaxAddress = 500;

        private readonly int _id;
        private string _fullname;
        private string _address;

        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Полное имя покупателя. Должно быть не больше <see cref="MaxFullname">MaxFullname</see>.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxFullname, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Адрес покупателя. Должно быть не больше <see cref="MaxAddress">MaxAddress</see>.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxAddress, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. Должно быть не больше <see cref="MaxFullname">MaxFullname</see>.</param>
        /// <param name="address">Адрес покупателя. Должно быть не больше <see cref="MaxAddress">MaxAddress</see>.</param>
        /// <param name="id">Уникальный идентификатор покупателя. Класс не проверяет уникальность идентификатора.</param>
        public Customer(string fullname, string address, int id)
        {
            Fullname = fullname;
            Address = address;
            _id = id;
        }
    }
}
