namespace Lab5_Task_2;

public static class Program
{
    public static void Main()
    {
        var person = new Employee("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 0);
        var worker = new Worker("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 2.6, "Microsoft");
        var engineer = new Engineer("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 1.4, "Bachelor");
        var employee = new Employee();
        
        person.Show();
        Console.WriteLine("---------------------------------------------");
        worker.Show();
        Console.WriteLine("---------------------------------------------");
        engineer.Show();
        Console.WriteLine("---------------------------------------------");
        employee.Show();

    }
}