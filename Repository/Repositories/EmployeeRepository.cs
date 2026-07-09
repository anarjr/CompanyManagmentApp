using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository() : base(AppDbContext.Employees)
        {

        }

        public int GetAllCount()
        {
            return AppDbContext.Employees.Count;
        }

        public List<Employee> GetEmployeesByAge(int age)
        {
            return AppDbContext.Employees.Where(m => m.Age == age).ToList();
        }

        public List<Employee> GetEmployeesByDepartmentId(int departmentId)
        {
            return AppDbContext.Employees.Where(m => m.Department.İd == departmentId).ToList();
        }

        public List<Employee> GetEmployeesByDepartmentName(string departmentName)
        {
            return AppDbContext.Employees.Where(m => m.Department.Name.Contains(departmentName)).ToList();
        }

        public List<Employee> SearchByNameOrSurname(string searchText)
        {
            return AppDbContext.Employees.Where(m => m.Name.Contains(searchText) || m.Surname.Contains(searchText)).ToList();
        }
    }
}
