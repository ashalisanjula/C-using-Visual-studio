﻿using OOP_concepts;

Student student = new Student();
student.displayDetails();

Student student1 = new Student(1,"Ashali");
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



Console.ReadKey(); // to fix the issue that console window close immediately after the execution