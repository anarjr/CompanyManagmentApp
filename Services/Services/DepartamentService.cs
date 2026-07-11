using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class DepartmentService : BaseService<Departament>, IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService() : base(new DepartmentRepository())
        {
            _departmentRepository = new DepartmentRepository();
        }

        public List<Departament> Search(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return GetAll();
            }

            return _departmentRepository.Search(searchText.Trim());
        }

        public List<Departament> SortByCapacity()
        {
            return _departmentRepository.SortByCapacity();
        }
        public override void Create(Departament department)
        {
            var existDepartment = GetAll()
                .FirstOrDefault(x => x.Name.ToLower() == department.Name.ToLower());

            if (existDepartment != null)
            {
                throw new System.Exception("Bu adda department artıq mövcuddur.");
            }

            base.Create(department);
        }
    }
}
