using NLayerArc.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.DataAccess
{   /* Database üzerinde sık kullandığımız ve entitylerde ortak kullandığımız methodalrı her nesneye özel (data access level) için yeni Interface implemente edip tekrarlı olarak method imzalarını yazmayı önlemek için bu çözümü kullanabiliriz: [ REPOSITORY PATTERN ] */
    public interface IEntityRepository<T> where T:class,IEntity,new()  /* Bu intetrface'i implemente edebilece alanları sınırlıyoruz. class(referans tip olmalı), IEntity(IEntity interface'i ya da ondan implemente edilmiş olmalı), new(new'lenebilir olmalı) */
    {
        List<T> GetAllItems();
        T GetById(int id);
        T GetById(string id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
