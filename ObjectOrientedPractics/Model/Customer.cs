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

        private readonly int _id;
        private string _fullname;
        private Address _address = new Address();

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
                string propertyName = nameof(Fullname); 
                ValueValidator.AssertStringOnLength(value, MaxFullname, propertyName);
                _fullname = value;
            }
        }

        /// <summary>
        /// Адрес покупателя</see>.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. Должно быть не больше <see cref="MaxFullname">MaxFullname</see>.</param>
        /// <param name="address">Адрес покупателя. Должно быть экземпляром класса 
        ///     <see cref="ObjectOrientedPractics.Model.Address">Address</see>.</param>
        /// <param name="id">Уникальный идентификатор покупателя. Класс не проверяет уникальность идентификатора.</param>
        public Customer(string fullname, int id)
        {
            Fullname = fullname;
            _id = id;
        }
    }
}
