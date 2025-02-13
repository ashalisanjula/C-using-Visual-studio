using OOP_concepts;

Student student = new Student();
student.displayDetails();

Student student1 = new Student(1, "Ashali");
student1.displayDetails();


SavingsAccount savingaccount = new SavingsAccount();
savingaccount.getMessage();
savingaccount.deposit();
savingaccount.balance();
savingaccount.withdraw();


SavingAcc savingacc1 = new SavingAcc();
savingacc1.openAccount();
savingacc1.deposit();
savingacc1.balance();
savingacc1.withdraw(); 
savingacc1.closeAccount();


Console.WriteLine();

Console.WriteLine(Calculator.increment());
Console.WriteLine(Calculator.increment());
Console.WriteLine(Calculator.increment());
Console.WriteLine(Calculator.decrement());

int number = 100;

bool result = number.IsGreaterThan(1000);
Console.WriteLine(result);


string s = "Hello World";

int strLength = s.Length;
Console.WriteLine(strLength);


Console.WriteLine();

var employee = new Employee();
Console.WriteLine(employee.EmpId);
Console.WriteLine(employee.EmpName);
employee.DisplayDetails();

Console.WriteLine();

User user = new User();
user.Name = "King";
user.Age = 34;
Console.WriteLine(user.Name);
Console.WriteLine(user.CompanyName);
Console.WriteLine(user.Age);

Console.WriteLine();

StringIndeexerType stringIndeexerType = new StringIndeexerType();
stringIndeexerType[0] = "String One";
stringIndeexerType[1] = "String Two";
stringIndeexerType[2] = "String Three";
stringIndeexerType[3] = "String four";


for(int i = 0; i < 10; i++)
{
    Console.WriteLine(stringIndeexerType[i]);
}


Console.WriteLine();

EnumDemo enumDemo = new EnumDemo();
enumDemo.display();

Console.WriteLine();

Calculation calculation = new Calculation();
calculation.calculate(12,0);
calculation.calculateAnother();

Console.ReadKey(); // to fix the issue that console window close immediately after the execution