using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services.Interfaces
{
    public interface IEmployeeService : IBaseService<Employee>
    {
        List<Employee> GetEmployeesByAge(int age);
        List<Employee> GetEmployeesByDepartmentId(int departmentId);
        List<Employee> GetEmployeesByDepartmentName(string departmentName);
        List<Employee> SearchByNameOrSurname(string searchText);
        int GetAllCount();
    }
}
