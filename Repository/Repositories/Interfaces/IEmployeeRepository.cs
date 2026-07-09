using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        List<Employee> GetEmployeesByAge(int age);
        List<Employee> GetEmployeesByDepartmentId(int departmentId);
        List<Employee> GetEmployeesByDepartmentName(string departmentName);
        List<Employee> SearchByNameOrSurname(string searchText);
        int GetAllCount();
    }
}
