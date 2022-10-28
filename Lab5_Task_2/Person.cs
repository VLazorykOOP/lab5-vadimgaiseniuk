namespace Lab5_Task_2;

public class Person
{
    private string Name { get; }
    private string Surname { get; }
    private string Patronymic { get; }
    private string Sex { get; }
    private int Age { get; }

    protected Person()
    {
        (Name, Surname, Patronymic, Sex, Age) = ("Unknown", "Unknown", "Unknown", "Unknown", 0);
        
        Console.WriteLine("\nConstructor of class Person");
    }

    protected Person(string name, string surname, string patronymic, string sex, int age)
    {
        (Name, Surname, Patronymic, Sex, Age) = (name, surname, patronymic, sex, age);
        
        Console.WriteLine("Constructor of class Person");
    }

    public virtual void Show()
    {
        Console.WriteLine($"\nPerson`s Data:\n Name: {Name};\n Surname: {Surname};\n Patronymic: {Patronymic};\n Sex: {Sex};\n Age: {Age}\n");
    }
}