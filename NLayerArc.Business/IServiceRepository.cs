using NLayerArc.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.Business
{
    public interface IServiceRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAllItems();
        T GetById(int id);
        T GetById(string id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
