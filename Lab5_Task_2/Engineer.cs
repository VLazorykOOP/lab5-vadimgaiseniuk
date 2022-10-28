namespace Lab5_Task_2;

public class Engineer : Employee
{
    private string Qualification { get; }

    public Engineer()
    {
        Qualification = "Unknown";
        
        Console.WriteLine("Constructor of class Engineer");
    }
    
    public Engineer(string name, string surname, string patronymic, string sex, int age, double experience, string qualification) : base(name, surname, patronymic, sex, age, experience)
    {
        Qualification = qualification;
        
        Console.WriteLine("Constructor of class Engineer");
    }

    public override void Show()
    {
        base.Show();
        
        Console.WriteLine($"Qualification in engineering: {Qualification}\n");
    }
}