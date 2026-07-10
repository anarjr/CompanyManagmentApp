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
            }
        }
    }
}
