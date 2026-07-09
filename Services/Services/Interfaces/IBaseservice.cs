using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(int id);
        List<T> GetAll();
    }
}
