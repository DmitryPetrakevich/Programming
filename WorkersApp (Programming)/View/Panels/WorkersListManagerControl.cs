namespace WorkersApp__Programming_.View.Panels;

using System;
using Model;
using Newtonsoft.Json;

/// <summary>
/// Пользовательский элемент контроля WorkersListManagerControl.
/// Реализует работу с пользовательским классом Worker.
/// </summary>
public partial class WorkersListManagerControl : UserControl
{
    /// <summary>
    /// Список объектов пользовательского класса <see cref="Worker"/>.
    /// </summary>
    public List<Worker> WorkersList = new();

    /// <summary>
    /// Переменная работника.
    /// </summary>
    private Worker _currentWorker = new();

    /// <summary>
    /// Очищает тестовые поля параметров класса <see cref="Worker"/>.
    /// </summary>
    private void CleanWorkerInfo()
    {
        SelectedWorkerControl.WorkersNameTextBox.Clear();
        SelectedWorkerControl.WorkersPostTextBox.Clear();
        SelectedWorkerControl.EmploymentTimePicker.Value = DateTime.Now.Date;
        SelectedWorkerControl.WorkersSalaryTextBox.Clear();
    }

    /// <summary>
    /// Заполняет поля параметров объекта класса Worker.
    /// </summary>
    /// <param name="currentWorker">Выбранный работник.</param>
    private void UpdateWorkerInfo(Worker currentWorker)
    {
        SelectedWorkerControl.WorkersNameTextBox.Text = currentWorker.FullName;
        SelectedWorkerControl.WorkersPostTextBox.Text = currentWorker.Post;
        SelectedWorkerControl.EmploymentTimePicker.Value = currentWorker.EmploymentDate.Date;
        SelectedWorkerControl.WorkersSalaryTextBox.Text = Convert.ToString(currentWorker.Salary);
    }

    /// <summary>
    /// Конструктор формы данного класса.
    /// </summary>
    public WorkersListManagerControl()
    {
        InitializeComponent();

        // Формат отображения даты в элементе EmploymentTimePicker (дд.мм.гггг).
        SelectedWorkerControl.EmploymentTimePicker.Format = DateTimePickerFormat.Short;

        // Максимально возможная дата, которую может выбрать пользователь (текущая дата).
        SelectedWorkerControl.EmploymentTimePicker.MaxDate = DateTime.Now;

        // Минимально возможная дата, которую может выбрать пользователь (01.01.2005).
        SelectedWorkerControl.EmploymentTimePicker.MinDate = new DateTime(2005, 01, 01);
    }

    //TODO: в Serializer
    /// <summary>
    /// Обработчик события WorkersListManager_Load.
    /// Производит загрузку данных из файла Json.
    /// Если такового не существует - происходит загрузка по умолчанию.
    /// </summary>
    private void WorkersListManager_Load(object sender, EventArgs e)
    {
        if (File.Exists(ServiseMethods.GetPath()))
        {
            var stringWorkersList = File.ReadAllText(ServiseMethods.GetPath());

            WorkersList = JsonConvert.DeserializeObject<List<Worker>>(stringWorkersList)!;

            var names = ServiseMethods.WorkersNames(WorkersList);
            WorkersListBox.Items.AddRange(names);
        }
    }

    /// <summary>
    /// Обработчик события AddWorkerButton_Click.
    /// Вызывает форму добавления нового работника.
    /// </summary>
    private void AddWorkerButton_Click(object sender, EventArgs e)
    {
        _currentWorker = new();
        new ObjectImplementationForm(this, _currentWorker, "Add new worker").ShowDialog();
    }

    /// <summary>
    /// Обработчик события DeleteWorkerButton_Click.
    /// Удаляет описание работника из панели ListBox.
    /// Удаляет работника из списка WorkersList.
    /// Производит запись данных на файл Json.
    /// </summary>
    private void DeleteWorkerButton_Click(object sender, EventArgs e)
    {
        if (WorkersListBox.SelectedIndex != -1)
        {
            _currentWorker = WorkersList[WorkersListBox.SelectedIndex];
            WorkersListBox.Items.RemoveAt(WorkersListBox.SelectedIndex);
            WorkersList.Remove(_currentWorker);

            //TODO: Использовать метод сериализации
            string serializedList = JsonConvert.SerializeObject(WorkersList);
            File.WriteAllText(ServiseMethods.GetPath(), serializedList);
        }
    }

    /// <summary>
    /// Обработчик события EditWorkerInfoButton_Click.
    /// Вызывает форму редактирования параметров выбранного работника.
    /// Если работник не выбран, показывает предупреждение.
    /// </summary>
    private void EditWorkerInfoButton_Click(object sender, EventArgs e)
    {
        if (WorkersListBox.SelectedIndex != -1)
        {
            _currentWorker = WorkersList[WorkersListBox.SelectedIndex];
            new ObjectImplementationForm(this, _currentWorker, $"Edit worker \"{_currentWorker.FullName}\"").ShowDialog();
        }
        else MessageBox.Show("Необходимо выбрать работника.");
    }

    /// <summary>
    /// Обработчик события WorkersListBox_SelectedIndexChanged.
    /// Выводит информацию о выбранном работнике на поля правого столбца.
    /// Если работник не выбран, производит очистку полей параметров.
    /// </summary>
    private void WorkersListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (WorkersListBox.SelectedIndex != -1)
        {
            _currentWorker = WorkersList[WorkersListBox.SelectedIndex];
            UpdateWorkerInfo(_currentWorker);
        }
        else CleanWorkerInfo();
    }
}