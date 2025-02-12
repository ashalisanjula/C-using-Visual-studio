using OOP_concepts;

Student student = new Student();
student.displayDetails();

Student student1 = new Student(1,"Ashali");
student1.displayDetails();


SavingsAccount savingaccount = new SavingsAccount();
savingaccount.deposit();
savingaccount.balance();
savingaccount.withdraw();


Console.ReadKey(); // to fix the issue that console window close immediately after the execution