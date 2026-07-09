using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services.Interfaces
{
    public interface IDepartmentService : IBaseService<Departament>
    {
        List<Departament> Search(string searchText);
        List<Departament> SortByCapacity();
    }
}
