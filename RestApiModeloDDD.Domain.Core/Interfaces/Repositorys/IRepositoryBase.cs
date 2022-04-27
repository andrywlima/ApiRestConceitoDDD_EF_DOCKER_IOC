using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void add(TEntity obj);
        void Update(TEntity oj);
        void remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id); 
    }
}
