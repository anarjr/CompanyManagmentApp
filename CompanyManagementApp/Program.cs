using CompanyManagementApp.Controllers;

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
            }
        }
    }
}
