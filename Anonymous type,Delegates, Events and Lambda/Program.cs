using Anonymous_type_Delegates__Events_and_Lambda;

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

        Console.WriteLine();

        //CalculateDelegate c1 = new CalculateDelegate(DelegateExamples.addition);
        //CalculateDelegate c2 = new CalculateDelegate(DelegateExamples.Multiplication);

        //c1(100);
        //Console.WriteLine(DelegateExamples.getNumber());
        //c2(100);
        //Console.WriteLine(DelegateExamples.getNumber());

        //tying delegates in another way

        CalculateDelegate c3 = new CalculateDelegate(DelegateExamples.addition);

        c3(100);

        Console.WriteLine(DelegateExamples.getNumber());
        c3 += new CalculateDelegate(DelegateExamples.addition);
        c3 += new CalculateDelegate(DelegateExamples.Multiplication);

        c3(100);
        Console.WriteLine(DelegateExamples.getNumber());


        Console.WriteLine();

        //The subscriber model(calling the event)

        EventsExamples events = new EventsExamples();
        events.event_OddNumber += new EventsExamples.delegate_OddNumber(EventMessage);
        events.addition();
        Console.ReadLine(); 

        static void EventMessage()
        {
            Console.WriteLine("Event Executed: Odd Number");
        }

    }
}


