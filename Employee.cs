/*Author Charlie Yingling*/
using System;

//Add a new class called Employee in Employee.cs
class Employee {
//fields
  private string firstname;
  private string lastname;
  private string id;
  private string address;
  private string phonenumber;
  private string title;
  private string employmentstatus;
  private double yearlysalary;
  private int age;

  //properties
  public string FirstName {
  get; 
  set;
  }
  public string LastName {
  get; 
  set;
  }
  public string Id {
  get; 
  set;
  }
  public string EmploymentStatus {
  get; 
  set;
  }
  public double YearlySalary {
  get {
    return yearlysalary;
  } 
  set {
    if (value > 1000) 
    yearlysalary = value;
     else {
      yearlysalary = 1000;
      //Console.WriteLine("Yearly salary cannot be less than $1000 so it is set to $1000");
    }
  }
  }
  public int Age {
      get { 
        return age; 
        }
      set {
        if (value > 18)
          age = value;
        else {
          age = 18;
        }
      }
    }


  public Employee() { //constructor with no parameters
    FirstName="unknown";
    LastName="unknown";
    Id="unknown";
    Age=0;
    EmploymentStatus="active";
    //Console.WriteLine("A new employee object has been created!");
  }
  public Employee(string employeefirst, string employeelast, string employeeid, int employeeage) { //constructor with 4 parameters
    FirstName = employeefirst;
    LastName = employeelast;
    Id = employeeid;
    Age = employeeage;
    EmploymentStatus = "active";
    //Console.WriteLine("A new employee object has been created!");
  }
  public Employee(string employeefirst, string employeelast, string employeeid, int employeeage, double employeesalary) { //constructor with 5 parameters
    FirstName = employeefirst;
    LastName = employeelast;
    Id = employeeid;
    Age = employeeage;
    YearlySalary = employeesalary;
    EmploymentStatus = "active";
    //Console.WriteLine("A new employee object has been created!");
  }
  public void Intro() {
    Console.WriteLine("First name: " + FirstName);
    Console.WriteLine("Last name: " + LastName);
    Console.WriteLine("Age: " + Age);
    Console.WriteLine("Id: " + Id);
    Console.WriteLine("Yearly Salary: " + YearlySalary);
  }
  public void IncreaseSalary(double percent) {
    //x = ((x * y)/y) + (x * (y/100));
    YearlySalary = ((YearlySalary * percent)/percent) + (YearlySalary*(percent/100));
    if (percent >  0){
        Console.WriteLine("Yearly salary updated to " + YearlySalary);  
      }
      else
      {
        Console.WriteLine("invalid input. Yearly Salary not updated");
      }
    }
    public void RemoveEmployee() {
  if (EmploymentStatus == "inactive") {
    Console.WriteLine("Employee already inactive.");
  } else if (EmploymentStatus == "active") {
      EmploymentStatus = "inactive";
    Console.WriteLine("Employee removed.");
  }
    }
  }