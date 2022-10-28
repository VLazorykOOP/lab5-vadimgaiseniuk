namespace Lab5_Task_2;

public class Worker : Employee
{
    private string Workplace { get; }

    public Worker()
    {
        Workplace = "Unknown";
        
        Console.WriteLine("Constructor of class Worker");
    }
    
    public Worker(string name, string surname, string patronymic, string sex, int age, double experience, string workplace) : base(name, surname, patronymic, sex, age, experience)
    {
        Workplace = workplace;
        
        Console.WriteLine("Constructor of class Worker");
    }

    public override void Show()
    {
        base.Show();
        Console.Write($"Workplace: {Workplace}\n");
    }
}