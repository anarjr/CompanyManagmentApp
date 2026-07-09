using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.Interfaces
{
    public interface IDepartmentRepository : IBaseRepository<Departament>
    {
        List<Departament> Search(string searchText);
        List<Departament> SortByCapacity();
    }
}
