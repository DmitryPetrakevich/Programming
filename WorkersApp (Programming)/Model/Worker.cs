namespace WorkersApp__Programming_.Model;

using System;
using Newtonsoft.Json;

/// <summary>
/// Класс описывающий работника.
/// </summary>
public class Worker
{
    /// <summary>
    /// Поле полного имени работника.
    /// </summary>
    private string _fullName;

    /// <summary>
    /// Поле должности работника.
    /// </summary>
    private string _post;

    /// <summary>
    /// Поле даты приема работника на работу.
    /// </summary>
    private DateTime _employmentDate;

    /// <summary>
    /// Поле ежемесячного оклада работника.
    /// </summary>
    private int _salary;

    /// <summary>
    /// Задает и возвращает полное имя работника.
    /// Состоит только из символов английского алфавита.
    /// Содержит не более 100 символов в строке.
    /// </summary>
    [JsonProperty("FullName")]
    public string FullName
    {
        set
        {
            Validator.AssertValueOnCorrectLetters(value);
            Validator.AssertValueOnCorrectLength(100, value);
            Validator.AssertOnEmptyField(value);
            _fullName = value;
        }
        get => _fullName;
    }

    /// <summary>
    /// Задает и возвращает название должности, занимаемой работником.
    /// Состоит только из символов английского алфавита.
    /// Содержит не более 50 символов в строке.
    /// </summary>
    [JsonProperty("Post")]
    public string Post
    {
        set
        {
            Validator.AssertValueOnCorrectLetters(value);
            Validator.AssertValueOnCorrectLength(50, value);
            Validator.AssertOnEmptyField(value);
            _post = value;
        }
        get => _post;
    }

    /// <summary>
    /// Задает и возвращает дату приема на работу.
    /// Не позже нынешней даты и не раньше начала 2005-го года.
    /// </summary>
    [JsonProperty("EmploymentDate")]
    public DateTime EmploymentDate
    {
        set
        {
            var currentDate = DateTime.Now;
            var minimumDate = new DateTime(2005, 01, 01);
            if (value > currentDate || value < minimumDate)
            {
                throw new ArgumentException("Incorrect value of the date.");
            }
            _employmentDate = value;
        }
        get => _employmentDate;
    }

    /// <summary>
    /// Задает и возвращает значение ежемесячного оклада работника.
    /// В промежутке от 0 до 500000.
    /// </summary>
    [JsonProperty("Salary")]
    public int Salary
    {
        set
        {
            const int maxSalary = 500000;
            Validator.AssertValueOnRange(value, maxSalary, 0);
            _salary = value;
        }
        get => _salary;
    }

    /// <summary>
    /// Создает экземпляр класса Worker.
    /// </summary>
    /// <param name="fullName">Полное имя работника.</param>
    /// <param name="post">Должность работника.</param>
    /// <param name="employmentDate">Дата приема на работу.</param>
    /// <param name="salary">Ежемесячный оклад работника.</param>
    public Worker(string fullName, string post, DateTime employmentDate, int salary)
    {
        FullName = fullName;
        Post = post;
        EmploymentDate = employmentDate;
        Salary = salary;
    }

    /// <summary>
    /// Создает экземпляр класса Worker без параметров.
    /// </summary>
    public Worker()
    {

    }
}