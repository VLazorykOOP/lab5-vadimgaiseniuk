namespace Lab5_Task_1;

public static class Program
{
    public static void Main()
    {
        var person = new Employee("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 0);
        var employee = new Employee("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 2.1);
        var worker = new Worker("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 2.6, "Microsoft");
        var engineer = new Engineer("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 1.4, "Bachelor");
        
        person.Show();
        Console.WriteLine("---------------------------------------------");
        employee.Show();
        Console.WriteLine("---------------------------------------------");
        worker.Show();
        Console.WriteLine("---------------------------------------------");
        engineer.Show();
        Console.WriteLine("---------------------------------------------");
    }
}