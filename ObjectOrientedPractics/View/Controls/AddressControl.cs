using ObjectOrientedPractics.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для адресов пользователей.
    /// </summary>
    partial class AddressControl : UserControl
    {
        /// <summary>
        /// Нынешний адрес.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задаёт адрес. После назначения адерса вызывает метод <see cref="UpdateTextBoxes">UpdateTextBoxes</see>
        /// для обновления данных в текстовых полях.
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
                UpdateTextBoxes();
            }
        }

        public AddressControl()
        {
            InitializeComponent();

            Address = new Address();
            UpdateTextBoxes();
        }
        /// <summary>
        /// Вносит данные адреса в текстовые поля в элементе управления
        /// </summary>
        private void UpdateTextBoxes()
        {
            CountryTextBox.Text = Address.Country;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
            CityTextBox.Text = Address.City;
            IndexTextBox.Text = Address.Index.ToString();
        }

        /// <summary>
        /// Обработчик события изменения текста в текстбоксе страны.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в текстбоксе улицы.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в текстбоксе здания.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в текстбоксе квартиры.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в текстбоксе городе.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в текстбоксе почтового индекса.
        /// </summary>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Index = Convert.ToInt32(IndexTextBox.Text);
                IndexTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                IndexTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
