using CompanyManagementApp.Controllers;
using Domain.Models;

public class Program
{
    static void Main(string[] args)
    {
        DepartmentController departmentController = new DepartmentController();
        EmployeeController employeeController = new EmployeeController();

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("--------------- Company Management ---------------");
            Console.WriteLine("1. Create Department");
            Console.WriteLine("2. Update Department");
            Console.WriteLine("3. Delete Department");
            Console.WriteLine("4. Get Department By Id");
            Console.WriteLine("5. Get All Departments");
            Console.WriteLine("6. Search Department");
            Console.WriteLine("7. Sort Departments By Capacity");
            Console.WriteLine("8. Create Employee");
            Console.WriteLine("9. Update Employee");
            Console.WriteLine("10. Delete Employee");
            Console.WriteLine("11. Get Employee By Id");
            Console.WriteLine("12. Get Employees By Age");
            Console.WriteLine("13. Get Employees By Department Id");
            Console.WriteLine("14. Get Employees By Department Name");
            Console.WriteLine("15. Search Employee");
            Console.WriteLine("16. Get All Employee Count");
            Console.WriteLine("17. Get All Employees");
            Console.WriteLine("0. Exit");

            Console.Write("Select: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Department name: ");
                        string name = Console.ReadLine();

                        Console.Write("Capacity: ");
                        int capacity = int.Parse(Console.ReadLine());

                        Departament department = new Departament
                        {
                            İd = departmentController.GetAll().Count + 1,
                            Name = name,
                            Capacity = capacity
                        };

                        departmentController.Create(department);

                        Console.WriteLine("Department created successfully.");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Department Id: ");
                        int id = int.Parse(Console.ReadLine());

                        Departament department = departmentController.GetById(id);

                        if (department != null)
                        {
                            Console.Write("New Name: ");
                            department.Name = Console.ReadLine();

                            Console.Write("New Capacity: ");
                            department.Capacity = int.Parse(Console.ReadLine());

                            departmentController.Update(department);

                            Console.WriteLine("Department updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Department not found.");
                        }

                        break;
                    }
                case 3:
                    {
                        Console.Write("Department Id: ");
                        int id = int.Parse(Console.ReadLine());

                        departmentController.Delete(id);

                        Console.WriteLine("Department deleted successfully.");

                        break;
                    }
                case 4:
                    {
                        Console.Write("Department Id: ");
                        int id = int.Parse(Console.ReadLine());

                        Departament department = departmentController.GetById(id);

                        if (department != null)
                        {
                            Console.WriteLine($"Id: {department.İd}");
                            Console.WriteLine($"Name: {department.Name}");
                            Console.WriteLine($"Capacity: {department.Capacity}");
                        }
                        else
                        {
                            Console.WriteLine("Department not found.");
                        }

                        break;
                    }
                case 5:
                    {
                        List<Departament> departments = departmentController.GetAll();

                        foreach (Departament department in departments)
                        {
                            Console.WriteLine(
                                $"Id: {department.İd}, Name: {department.Name}, Capacity: {department.Capacity}"
                            );
                        }

                        break;
                    }

                case 6:
                    {
                        Console.Write("Search text: ");
                        string searchText = Console.ReadLine();

                        List<Departament> departments = departmentController.Search(searchText);

                        foreach (Departament department in departments)
                        {
                            Console.WriteLine(
                                $"Id: {department.İd}, Name: {department.Name}, Capacity: {department.Capacity}"
                            );
                        }

                        break;
                    }

                case 7:
                    {
                        List<Departament> departments = departmentController.SortByCapacity();

                        foreach (Departament department in departments)
                        {
                            Console.WriteLine(
                                $"Id: {department.İd}, Name: {department.Name}, Capacity: {department.Capacity}"
                            );
                        }

                        break;
                    }
                case 8:
                    {
                        Console.Write("Employee Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Surname: ");
                        string surname = Console.ReadLine();

                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Address: ");
                        string address = Console.ReadLine();

                        Console.Write("Department Id: ");
                        int departmentId = int.Parse(Console.ReadLine());

                        Departament department = departmentController.GetById(departmentId);

                        Employee employee = new Employee
                        {
                            İd = employeeController.GetAll().Count + 1,
                            Name = name,
                            Surname = surname,
                            Age = age,
                            Address = address,
                            Department = department
                        };

                        employeeController.Create(employee);

                        Console.WriteLine("Employee created successfully.");

                        break;
                    }
                case 9:
                    {
                        Console.Write("Employee Id: ");
                        int id = int.Parse(Console.ReadLine());

                        Employee employee = employeeController.GetById(id);

                        Console.Write("New Name: ");
                        employee.Name = Console.ReadLine();

                        Console.Write("New Surname: ");
                        employee.Surname = Console.ReadLine();

                        Console.Write("New Age: ");
                        employee.Age = int.Parse(Console.ReadLine());

                        Console.Write("New Address: ");
                        employee.Address = Console.ReadLine();

                        Console.Write("New Department Id: ");
                        int departmentId = int.Parse(Console.ReadLine());

                        employee.Department = departmentController.GetById(departmentId);

                        employeeController.Update(employee);

                        Console.WriteLine("Employee updated successfully.");

                        break;
                    }
                case 10:
                    {
                        Console.Write("Employee Id: ");
                        int id = int.Parse(Console.ReadLine());

                        employeeController.Delete(id);

                        Console.WriteLine("Employee deleted successfully.");

                        break;
                    }
                case 11:
                    {
                        Console.Write("Employee Id: ");
                        int id = int.Parse(Console.ReadLine());

                        Employee employee = employeeController.GetById(id);

                        if (employee != null)
                        {
                            Console.WriteLine($"Id: {employee.İd}");
                            Console.WriteLine($"Name: {employee.Name}");
                            Console.WriteLine($"Surname: {employee.Surname}");
                            Console.WriteLine($"Age: {employee.Age}");
                            Console.WriteLine($"Address: {employee.Address}");
                            Console.WriteLine($"Department: {employee.Department.Name}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }

                        break;
                    }
                case 12:
                    {
                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());

                        List<Employee> employees = employeeController.GetEmployeesByAge(age);

                        foreach (Employee employee in employees)
                        {
                            Console.WriteLine($"Id: {employee.İd}, Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}");
                        }

                        break;
                    }
                case 13:
                    {
                        Console.Write("Department Id: ");
                        int departmentId = int.Parse(Console.ReadLine());

                        List<Employee> employees =
                            employeeController.GetEmployeesByDepartmentId(departmentId);

                        foreach (Employee employee in employees)
                        {
                            Console.WriteLine(
                                $"Id: {employee.İd}, Name: {employee.Name}, Surname: {employee.Surname}, Department: {employee.Department.Name}"
                            );
                        }

                        break;
                    }

                case 14:
                    {
                        Console.Write("Department Name: ");
                        string departmentName = Console.ReadLine();

                        List<Employee> employees =
                            employeeController.GetEmployeesByDepartmentName(departmentName);

                        foreach (Employee employee in employees)
                        {
                            Console.WriteLine(
                                $"Id: {employee.İd}, Name: {employee.Name}, Surname: {employee.Surname}, Department: {employee.Department.Name}"
                            );
                        }

                        break;
                    }

                case 15:
                    {
                        Console.Write("Search text: ");
                        string searchText = Console.ReadLine();

                        List<Employee> employees =
                            employeeController.SearchByNameOrSurname(searchText);

                        foreach (Employee employee in employees)
                        {
                            Console.WriteLine(
                                $"Id: {employee.İd}, Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}"
                            );
                        }

                        break;
                    }
                case 16:
                    {
                        int count = employeeController.GetAllCount();

                        Console.WriteLine($"Employee Count: {count}");

                        break;
                    }
                case 17:
                    {
                        List<Employee> employees = employeeController.GetAll();

                        foreach (Employee employee in employees)
                        {
                            Console.WriteLine($"Id: {employee.İd}");
                            Console.WriteLine($"Name: {employee.Name}");
                            Console.WriteLine($"Surname: {employee.Surname}");
                            Console.WriteLine($"Age: {employee.Age}");
                            Console.WriteLine($"Address: {employee.Address}");
                            Console.WriteLine($"Department: {employee.Department.Name}");
                            Console.WriteLine("--------------------------------");
                        }

                        break;
                    }
                case 0:
                    {
                        isRunning = false;
                        Console.WriteLine("Program dayandirildi.");
                        break;
                    }
            }
        }
    }
}
