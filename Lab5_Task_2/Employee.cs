namespace Lab5_Task_2;

public class Employee : Person
{
    private double Experience { get; }
    
    public Employee()
    {
        Experience = 0;
        
        Console.WriteLine("Constructor of class Employee");
    }
    public Employee(string name, string surname, string patronymic, string sex, int age, double experience) : base(name, surname, patronymic, sex, age)
    {
        Experience = experience;
        
        Console.WriteLine("Constructor of class Employee");
    }

    public override void Show()
    {
        base.Show();

        Console.WriteLine($"Employee`s experience: {Experience}\n");
    }
}