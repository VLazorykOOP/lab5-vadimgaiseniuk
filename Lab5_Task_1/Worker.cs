namespace Lab5_Task_1;

public class Worker : Employee
{
    private string Workplace { get; }
    
    public Worker(string name, string surname, string patronymic, string sex, int age, double experience, string workplace) : base(name, surname, patronymic, sex, age, experience)
    {
        Workplace = workplace;
    }

    public override void Show()
    {
        base.Show();
        Console.Write($"Workplace: {Workplace}\n");
    }
}