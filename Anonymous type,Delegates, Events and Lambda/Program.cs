class Program
{
    static void Main()
    {
        var obj = new
        {
            firstName = "King",
            lastName = "Kochhar",
            salary = 12000,
            address = new {streetName = "Civil Lines", city="Delhi"},
            project = new[]
            {
                new{projectName="Ecommerce",projectDuration="40 hours"},
                new{projectName="Admin Portal",projectDuration="30 hours"},
                new{projectName="Accounting",projectDuration="25 hours"}
            }
        };

        Console.WriteLine(obj.firstName);
        Console.WriteLine(obj.lastName);
        Console.WriteLine(obj.salary);
        Console.WriteLine(obj.address.streetName);
        Console.WriteLine(obj.address.city);
        foreach(var project in obj.project)
        {
            Console.WriteLine(project.projectName+ ":" +project.projectDuration);
        }
    }
}

