namespace Lab5_Task_2;

public static class Program
{
    public static void Main()
    {
        Engineer engineer = new Engineer("Vadim", "Gaiseniuk", "Anatoliyovich", "male", 20, 4, "Bachelor");

        Employee employee = new Employee();
        
        employee.Show();
    }
}