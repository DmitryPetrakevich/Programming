using System;
using Programming.Model.Geometry;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контактах.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _number;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создает экземпляр класса Contact.
        /// </summary>
        public Contact()
        {
        }

        //TODO: Точка в конце комментария
        /// <summary>
        /// Создает экземпляр класса Contact.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="number">Номер телефона. Должен состоять из цифр и длиной 11 цифр.</param>
        /// <param name="city">Город</param>
        public Contact(string name, 
                       string number, 
                       string city)
        {
            Name = name;
            Number = number;
            City = city;
        }

        /// <summary>
        /// Возращает и задает номер телефона. Должен состоять только из цифр длиной 11 цифр.
        /// </summary>
        public string Number
        {
            get 
            { 
                return _number; 
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Incorrect number format");
                }

                if(long.TryParse(value, out long num) == false)
                {
                    throw new ArgumentException("The phone number must contain only numbers");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя контакта. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validators.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validators.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город контакта.
        /// </summary>
        public string City { get; set; }
    }
}
