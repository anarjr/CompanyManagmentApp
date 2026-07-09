using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class DepartmentRepository : BaseRepository<Departament>, IDepartmentRepository
    {
        public DepartmentRepository() : base(AppDbContext.Departments)
        {

        }

        public List<Departament> Search(string searchText)
        {
            return AppDbContext.Departments.Where(m => m.Name.Contains(searchText)).ToList();
                
        }

        public List<Departament> SortByCapacity()
        {
            return AppDbContext.Departments.OrderBy(d => d.Capacity).ToList();


        }
    }
}

