namespace Lab5_Task_1;

public class Engineer : Employee
{
    private string Qualification { get; }
    
    public Engineer(string name, string surname, string patronymic, string sex, int age, double experience, string qualification) : base(name, surname, patronymic, sex, age, experience)
    {
        Qualification = qualification;
    }

    public override void Show()
    {
        base.Show();
        
        Console.WriteLine($"Qualification in engineering: {Qualification}\n");
    }
}