using Domain;
using Infrastructure;

var employeeServices = new EmployeeServices();
var depart = new DepartmentServices();
Console.WriteLine(employeeServices.CountEmployees());

var emp_dep1 = new Employee();
emp_dep1.FirstName = "Alijon";
emp_dep1.LastName = "Zabiri";
emp_dep1.Salary = 6000;

var dep = new Department()
{
    Name = "It",
    Description = "Softclub ba pesh",
    Manager = emp_dep1
};

var emp2 = new Employee();
emp2.FirstName = "Salmon";
emp2.LastName = "Sattorov";
emp2.Department = dep;
emp2.Salary = 5000;




var emp_dep2 = new Employee();
emp_dep2.FirstName = "Aaon";
emp_dep2.LastName = "SCXSC";
emp_dep2.Salary = 1000;

var dep2 = new Department()
{
    Name = "It",
    Description = "Softclub ba pesh",
    Manager = emp_dep2
};


var emp3 = new Employee();
emp3.FirstName = "Salmon";
emp3.LastName = "Sattorov";
emp3.Department = dep2;
emp3.Salary = 5000;

depart.AddDepartment(dep);
depart.AddDepartment(dep2);



employeeServices.AddEmployees(emp3);
employeeServices.AddEmployees(emp2);
foreach (var it in employeeServices.GetEmployees())
{
    System.Console.WriteLine(it.FirstName);
    System.Console.WriteLine(it.LastName);
    System.Console.WriteLine(it.Salary);
    System.Console.WriteLine(it.BirthDate); 
    System.Console.WriteLine("\n<=======Department========>\n");
    System.Console.WriteLine(it.Department.Name);
    System.Console.WriteLine(it.Department.Description);
}

