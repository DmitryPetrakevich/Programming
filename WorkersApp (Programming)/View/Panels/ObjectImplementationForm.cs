namespace WorkersApp__Programming_.View.Panels;

using System;
using Model;
using Newtonsoft.Json;

/// <summary>
/// Элемент управления ObjectImplementationForm.
/// Реализует создание и редактирование объектов 
/// класса <see cref="Worker"/>, валидацию задаваемых
/// значений, запись данных на файл Json.
/// </summary>
public partial class ObjectImplementationForm : Form
{
    /// <summary>
    /// Переменная пользовательского элемента управления.
    /// </summary>
    private readonly WorkersListManagerControl _control;

    /// <summary>
    /// Объект работника без параметров.
    /// </summary>
    private Worker _worker = new();

    /// <summary>
    /// Присваивает полям объекта работника параметры из 
    /// текстовых полей.
    /// </summary>
    /// <param name="worker">Работник, параметры которого требуется
    /// задать.</param>
    private void SetWorkerInfo(Worker worker)
    {
        worker.FullName = WorkersNameTextBox.Text;
        worker.Post = WorkersPostTextBox.Text;
        worker.EmploymentDate = EmploymentTimePicker.Value;
        worker.Salary = int.Parse(WorkersSalaryTextBox.Text);
    }

    /// <summary>
    /// Сериализует объект и записывает его на файл json.
    /// Производит проверку существования рабочей папки и рабочего файла.
    /// Создет папку и файл, если такогого не существует.
    /// </summary>
    private void SerializeObject()
    {
        if (!Directory.Exists(ServiseMethods.GetPathToFolder()) || File.Exists(ServiseMethods.GetPath()))
        {
            Directory.CreateDirectory(ServiseMethods.GetPathToFolder());
            string serializedList = JsonConvert.SerializeObject(_control.WorkersList);
            File.WriteAllText(ServiseMethods.GetPath(), serializedList);
        }
        else
        {
            string serializedList = JsonConvert.SerializeObject(_control.WorkersList);
            File.WriteAllText(ServiseMethods.GetPath(), serializedList);
        }
    }

    /// <summary>
    /// Заполняет поля параметров работника.
    /// </summary>
    /// <param name="currentWorker">Выбранный работник.</param>
    private void UpdateWorkerInfo(Worker currentWorker)
    {
        WorkersNameTextBox.Text = currentWorker.FullName;
        WorkersPostTextBox.Text = currentWorker.Post;
        EmploymentTimePicker.Value = currentWorker.EmploymentDate.Date;
        WorkersSalaryTextBox.Text = Convert.ToString(currentWorker.Salary);
    }

    /// <summary>
    /// Обработчик события ObjectImplementationForm_Load.
    /// Заполняет текстовые поля данной формы значениями параметров
    /// выбранного работника.
    /// </summary>
    private void ObjectImplementationForm_Load(object sender, EventArgs e)
    {
        if (_control.WorkersList.Contains(_worker))
        {
            UpdateWorkerInfo(_worker);
        }
    }

    /// <summary>
    /// Конструктор формы данного класса.
    /// </summary>
    /// <param name="owner">Объект пользовательского элемента управления,
    /// элементами которого управляет данная форма.</param>
    public ObjectImplementationForm(WorkersListManagerControl owner, Worker worker, string formName)
    {
        Text = formName;
        InitializeComponent();

        // Дочерний элемент управления данной формы.
        _control = owner;

        // Присвоение значений параметров объекта из формы, вызвавшей данную форму.
        _worker = worker;

        // Формат отображения даты в элементе EmploymentTimePicker (дд.мм.гггг).
        EmploymentTimePicker.Format = DateTimePickerFormat.Short;

        // Максимально возможная дата, которую может выбрать пользователь (текущая дата).
        EmploymentTimePicker.MaxDate = DateTime.Now;

        // Минимально возможная дата, которую может выбрать пользователь (01.01.2005).
        EmploymentTimePicker.MinDate = new DateTime(2005, 01, 01);
    }

    /// <summary>
    /// Обработчик события ApplyButton_Click.
    /// Производит присвоение значений параметрам объекта
    /// <see cref="Worker"/>, подаваемого на вход данной форме.
    /// Если объект уже существует в списке, удаляет его, заменяя на новый (редактирование).
    /// Если объект не существует, добавляет новый объект в список.
    /// Если валидация параметров не прошла успешно, показывает предупреждение.
    /// Производит запись данных на файл формата Json.
    /// </summary>
    private void ApplyButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (_control.WorkersList.Contains(_worker))
            {
                _control.WorkersList.Remove(_worker);

                SetWorkerInfo(_worker);

                _control.WorkersList.Add(_worker);
            }
            else
            {
                SetWorkerInfo(_worker);

                _control.WorkersList.Add(_worker);
            }

            _control.WorkersListBox.Items.Clear();
            var names = ServiseMethods.WorkersNames(_control.WorkersList);
            _control.WorkersListBox.Items.AddRange(names);

            SerializeObject();

            Close();
        }
        catch
        {
            MessageBox.Show("Некорректный ввод информации.");
        }
    }

    /// <summary>
    /// Обработчик события WorkerNameTextBox_TextChanged.
    /// Проверяет значение поля полного имени работника
    /// (производит подсветку некорректных данных).
    /// </summary>
    private void WorkerNameTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var fullName = WorkersNameTextBox.Text;
            Validator.AssertValueOnCorrectLetters(fullName);
            Validator.AssertValueOnCorrectLength(100, fullName);
            WorkersNameTextBox.BackColor = Color.White;
        }
        catch
        {
            WorkersNameTextBox.BackColor = Color.LightPink;
        }
    }

    /// <summary>
    /// Обработчик события WorkersPostTextBox_TextChanged.
    /// Проверяет значение поля должности работника
    /// (производит подсветку некорректных данных).
    /// </summary>
    private void WorkersPostTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var post = WorkersPostTextBox.Text;
            Validator.AssertValueOnCorrectLetters(post);
            Validator.AssertValueOnCorrectLength(50, post);
            WorkersPostTextBox.BackColor = Color.White;
        }
        catch
        {
            WorkersPostTextBox.BackColor = Color.LightPink;
        }
    }

    /// <summary>
    /// Обработчик события WorkersSalaryTextBox_TextChanged.
    /// Проверяет значение поля зарплаты работника
    /// (производит подсветку некорректных данных).
    /// </summary>
    private void WorkersSalaryTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var salary = int.Parse(WorkersSalaryTextBox.Text);
            Validator.AssertValueOnRange(salary, 500000, 0);
            WorkersSalaryTextBox.BackColor = Color.White;
        }
        catch
        {
            WorkersSalaryTextBox.BackColor = Color.LightPink;
        }
    }

    /// <summary>
    /// Обработчик события CloseButtonClick.
    /// Закрывает данную форму.
    /// </summary>
    private void CloseButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
