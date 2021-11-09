using System;

class Program {
  public static void Main (string[] args) {
    Employee Employee1 = new Employee();//constructor with no parameters
    Employee1.Intro();

    Employee Employee2 = new Employee("Robert","Downey","12321",12,100);
    Employee2.Intro();

    Employee Employee3 = new Employee("John","Smith","S0089",38,50000);
    Employee3.Intro();
    Employee3.IncreaseSalary(-2.0);
    Employee3.RemoveEmployee();

    Employee Employee4 = new Employee("Maria","Lambert","S0100",26,80000);
    Employee4.Intro();
    Employee4.IncreaseSalary(7.0);
    Employee4.RemoveEmployee();
    Employee4.RemoveEmployee();
  }
}