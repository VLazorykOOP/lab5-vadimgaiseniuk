namespace Lab5_Task_1;

public class Employee : Person
{
    private double Experience { get; }
    
    public Employee(string name, string surname, string patronymic, string sex, int age, double experience) : base(name, surname, patronymic, sex, age)
    {
        Experience = experience;
    }

    public override void Show()
    {
        base.Show();

        Console.WriteLine($"Employee`s experience: {Experience}\n");
    }
}