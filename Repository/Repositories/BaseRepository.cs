using Domain.Entities;
using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly List<T> _datas;

        public BaseRepository(List<T> datas)
        {
            _datas = datas;
        }
        
        public void Create(T entity)
        {
            _datas.Add(entity);
        }

        public void Delete(T entity)
        {
            _datas.Remove(entity);
        }

        public List<T> GetAll()
        {
            return _datas;
        }

        public T GetById(int id)
        {
            return _datas.FirstOrDefault(m => m.İd == id);
        }

        public void Update(T entity)
        {
            T existData = GetById(entity.İd);

            if (existData != null)
            {
                int index = _datas.IndexOf(existData);
                _datas[index] = entity;
            }
        }
    }
}
