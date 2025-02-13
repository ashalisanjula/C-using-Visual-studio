class Program
{
    static void Main()
    {
        var obj = new
        {
            firstName = "King",
            lastName = "Kochhar",
            salary = 12000
        };

        Console.WriteLine(obj.firstName);
        Console.WriteLine(obj.lastName);
        Console.WriteLine(obj.salary);
    }
}

