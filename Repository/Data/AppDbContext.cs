using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class AppDbContext
    {
       
            public static List<Departament> Departments { get; set; } = new();
            public static List<Employee> Employees { get; set; } = new();
        
    }
}
