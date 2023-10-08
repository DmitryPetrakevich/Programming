using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Address
    {
        /// <summary>
        /// Минимальное число для почтового индекса.
        /// </summary>
		private const int MinIndex = 99999;

        /// <summary>
        /// Максимальное число для почтового индекса.
        /// </summary>
		private const int MaxIndex = 1000000;

        /// <summary>
        /// Максимальное кол-во символов для страны.
        /// </summary>
        private const int MaxCountryLength = 51;

        /// <summary>
        /// Максимальное кол-во символов для города.
        /// </summary>
        private const int MaxCityLength = 51;

        /// <summary>
        /// Максимальное кол-во символов для улицы.
        /// </summary>
        private const int MaxStreetLength = 101;

        /// <summary>
        /// Максимальное кол-во символов для здания.
        /// </summary>
        private const int MaxBuildingLength = 11;

        /// <summary>
        /// Максимальное кол-во символов для квартиры.
        /// </summary>
        private const int MaxApartmentLength = 11;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна.
        /// </summary>
		private string _country;

        /// <summary>
        /// Город.
        /// </summary>
		private string _city;

        /// <summary>
        /// Улица
        /// </summary>
		private string _street;

        /// <summary>
        /// Здание
        /// </summary>
		private string _building;

        /// <summary>
        /// Квартира
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс. Должен быть шестизначным числом.
        /// </summary>
		public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                string propertyName = nameof(Index);
                ValueValidator.AssertDoubleOnRange(value, MinIndex, MaxIndex, propertyName);
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт страну. Должна быть меньше <see cref="MaxCountryLength">MaxCountryLength</see> символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                string propertyName = nameof(Country);
                ValueValidator.AssertStringOnLength(value, MaxCountryLength, propertyName);
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт город. Должен быть меньше <see cref="MaxCityLength">MaxCityLength</see> символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                string propertyName = nameof(City);
                ValueValidator.AssertStringOnLength(value, MaxCityLength, propertyName);
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт улицу. Должна быть меньше <see cref="MaxStreetLength">MaxStreetLength</see> символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                string propertyName = nameof(Street);
                ValueValidator.AssertStringOnLength(value, MaxStreetLength, propertyName);
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт здание. Должно быть меньше <see cref="MaxBuildingLength">MaxBuildingLength</see> символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                string propertyName = nameof(Building);
                ValueValidator.AssertStringOnLength(value, MaxBuildingLength, propertyName);
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт квартиру. Должна быть меньше <see cref="MaxApartmentLength">MaxApartmentLength</see> символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                string propertyName = nameof(Apartment);
                ValueValidator.AssertStringOnLength(value, MaxApartmentLength, propertyName);
                _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address">Address</see> c пустыми строковыми свойствами и индексом, равным 100000.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address">Address</see>.
        /// </summary>
        /// <param name="country">Страна. Должна быть меньше <see cref="MaxCountryLength">MaxCountryLength</see> символов.</param>
        /// <param name="city">Город. Должен быть меньше <see cref="MaxCityLength">MaxCityLength</see> символов.</param>
        /// <param name="street">Улица. Должна быть меньше <see cref="MaxStreetLength">MaxStreetLength</see> символов.</param>
        /// <param name="building">Здание. Должно быть меньше <see cref="MaxBuildingLength">MaxBuildingLength</see> символов.</param>
        /// <param name="apartment">Квартира. Должна быть меньше <see cref="MaxApartmentLength">MaxApartmentLength</see> символов.</param>
        /// <param name="index">Почтовый индекс. Должен быть шестизначным число.</param>
        public Address(string country, string city, string street, string building, string apartment, int index)
        {
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
            Index = index;
        }

    }

}
