using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент управления для списка покупателей.
    /// </summary>
    partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Нынешний список покупателей.
        /// </summary>
        List<Customer> _customers;

        /// <summary>
        /// Экземпляр класса генератора идентификационного номера.
        /// </summary>
        IdGenerator idGenerator;

        /// <summary>
        /// Биндер данных для списка
        /// </summary>
        BindingSource binding;

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                binding.DataSource = _customers; // связка биндера и списка покупателей
                binding.ResetBindings(false); // обновление данных в ListBox
            }
        }

        public CustomersTab()
        {
            InitializeComponent();

            _customers = new List<Customer>();
            binding = new BindingSource(); // создание экземпляра биндера

            idGenerator = new IdGenerator();
            binding.DataSource = _customers; // связка биндера и списка покупателей

            CustomersListBox.DataSource = binding; // связка ListBox и биндера
            CustomersListBox.DisplayMember = "Fullname";
            CustomersListBox.ValueMember = "Id";
            binding.ResetBindings(false); // обновление данных в ListBox при помощи биндера

        }

        /// <summary>
        /// Добавление шаблона покупателя.
        /// </summary>
        private void AddButon_Click(object sender, EventArgs e)
        {
            _customers.Add(new Customer("Placeholder",idGenerator.GetNextId()));
            binding.ResetBindings(false);
            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        /// <summary>
        /// Удаление покупателя из ListBox и списка
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null) // если выбран покупатель в ListBox
            {
                _customers.RemoveAt(CustomersListBox.SelectedIndex); // удалить его по индексу
                binding.ResetBindings(false);
            }
        }
        
        /// <summary>
        /// Обработчик события перевыбора элемента в ListBox
        /// </summary>
        private void CustomersListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedValue != null) // если выбран покупатель в ListBox
            {                                           // копирование данных в текстбоксы
                IdTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Id.ToString(); 
                FullNameTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Fullname;
                addressControl1.Address = ((Customer)CustomersListBox.SelectedItem).Address;
            }

        }

        /// <summary>
        /// Обработчик события изменения текста в текстбоксе полного имени покупателя.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {

            try // алгоритм подсветки текстбокса при вводе невалидных данных
            {
                if (CustomersListBox.SelectedValue != null) // при валидных вводных даных записывает их в 
                {                                           // выбранного пользователя 
                    ((Customer)CustomersListBox.SelectedItem).Fullname = FullNameTextBox.Text; 
                }
                FullNameTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
