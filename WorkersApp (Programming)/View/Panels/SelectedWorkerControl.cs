namespace WorkersApp__Programming_.View.Panels;

using Model;

/// <summary>
/// Пользовательский элемент контроля SelectedWorkerControl.
/// Содержит поля, в которых отображаются параметры
/// класса <see cref="Worker"/>.
/// </summary>
public partial class SelectedWorkerControl : UserControl
{
    /// <summary>
    /// Конструктор данного класса.
    /// </summary>
    public SelectedWorkerControl()
    {
        InitializeComponent();

        // Запретить пользовательский контроль над элементом.
        EmploymentTimePicker.Enabled = false;
    }

    /// <summary>
    /// Обработчик события WorkerNameTextBox_KeyPress.
    /// Запрещает ввод данных в текстовое поле.
    /// </summary>
    private void WorkerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    /// <summary>
    /// Обработчик события WorkersPostTextBox_KeyPress.
    /// Запрещает ввод данных в текстовое поле.
    /// </summary>
    private void WorkersPostTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    /// <summary>
    /// Обработчик события WorkersSalaryTextBox_KeyPress.
    /// Запрещает ввод данных в текстовое поле.
    /// </summary>
    private void WorkersSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }
}