using Domain.Entities;
using Repository.Repositories.Interfaces;
using Services.Exception;
using Services.Helpers;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        protected readonly IBaseRepository<T> _context;

        public BaseService(IBaseRepository<T> repository)
        {
            _context = repository;
        }

        public void Create(T entity)
        {
            _context.Create(entity);
        }

        public void Update(T entity)
        {
            T existData = GetById(entity.İd);
            _context.Update(entity);
        }

        public void Delete(int id)
        {
            T existData = GetById(id);
            _context.Delete(existData);
        }

        public T GetById(int id)
        {
            T data = _context.GetById(id);

            if (data == null)
            {
                throw new NotFoundException(ValidationMessages.EmployeeNotFound);
            }

            return data;
        }

        public List<T> GetAll()
        {
            return _context.GetAll();
        }
    }
}
