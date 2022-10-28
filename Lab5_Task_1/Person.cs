namespace Lab5_Task_1;

public class Person
{
    private string Name { get; }
    private string Surname { get; }
    private string Patronymic { get; }
    private string Sex { get; }
    private int Age { get; }

    public Person(string name, string surname, string patronymic, string sex, int age) =>
        (Name, Surname, Patronymic, Sex, Age) = (name, surname, patronymic, sex, age);

    public virtual void Show()
    {
        Console.WriteLine($"\nPerson`s Data:\n Name: {Name};\n Surname: {Surname};\n Patronymic: {Patronymic};\n Sex: {Sex};\n Age: {Age}\n");
    }
}