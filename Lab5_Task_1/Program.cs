namespace Lab5_Task_1;

public static class Program
{
    public static void Main()
    {
        Person person = new Employee("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 0);
        Person employee = new Employee("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 2.1);
        Person worker = new Worker("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 2.6, "Microsoft");
        Person engineer = new Engineer("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 1.4, "Bachelor");
        
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