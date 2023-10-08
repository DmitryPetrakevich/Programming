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
    /// Элемент управления для списка товаров.
    /// </summary>
    partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Нынешний список покупателей.
        /// </summary>
        List<Item> _items;

        /// <summary>
        /// Экземпляр класса генератора идентификационного номера.
        /// </summary>
        IdGenerator idGenerator;

        /// <summary>
        /// Биндер данных для списка
        /// </summary>
        BindingSource binding;

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                binding.DataSource = _items; // связка биндера и списка товаров
                binding.ResetBindings(false); // обновление данных в ListBox
            }
        }

        public ItemsTab()
        {
            InitializeComponent();

            _items = new List<Item>();

            binding = new BindingSource(); // создание экземпляра биндера
            idGenerator = new IdGenerator();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category)); // связка ComboBox и перечисления 
            binding.DataSource = _items; // связка биндера и списка товаров

            ItemsListBox.DataSource = binding; // связка ListBox и биндера
            ItemsListBox.DisplayMember = "Name";
            ItemsListBox.ValueMember = "Id";
            binding.ResetBindings(false); // обновление данных в ListBox при помощи биндера
        }

        /// <summary>
        /// Добавление шаблона товара.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _items.Add(new Item("Placeholder", "Placeholder", 0, idGenerator.GetNextId(), 0));
            binding.ResetBindings(false);
            ItemsListBox.SelectedIndex = _items.Count - 1;
        }

        /// <summary>
        /// Удаление покупателя из ListBox и списка
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null) // если выбран товар в ListBox
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex); // удалить его по индексу
                binding.ResetBindings(false);
            }
        }


        /// <summary>
        /// Обработчик события изменения текста в текстбоксе цены товара.
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try // алгоритм подсветки текстбокса при вводе невалидных данных
            {
                if (ItemsListBox.SelectedValue != null) // при валидных вводных даных записывает их в
                {                                       // выбранного пользователя 
                    ((Item)ItemsListBox.SelectedItem).Cost = Convert.ToDouble(CostTextBox.Text);
                }
                CostTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в текстбоксе названии товара.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedValue != null)
                {
                    ((Item)ItemsListBox.SelectedItem).Name = NameTextBox.Text;
                }
                NameTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в текстбоксе описании товара.
        /// </summary>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedValue != null)
                {
                    ((Item)ItemsListBox.SelectedItem).Info = DescriptionTextBox.Text;
                }
                DescriptionTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                DescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события перевыбора элемента в ListBox
        /// </summary>
        private void ItemsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedValue != null) // если выбран товар в ListBox
            {                                       // копирование данных в текстбоксы и комбобокс
                IdTextBox.Text = ((Item)ItemsListBox.SelectedItem).Id.ToString(); 
                CostTextBox.Text = ((Item)ItemsListBox.SelectedItem).Cost.ToString();
                NameTextBox.Text = ((Item)ItemsListBox.SelectedItem).Name;
                DescriptionTextBox.Text = ((Item)ItemsListBox.SelectedItem).Info;
                CategoryComboBox.SelectedItem = ((Item)ItemsListBox.SelectedItem).Category;
            }
        }

        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                ((Item)ItemsListBox.SelectedItem).Category = (Category)CategoryComboBox.SelectedItem;
            }
        }
    }
}
