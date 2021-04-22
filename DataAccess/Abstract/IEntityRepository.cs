using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // class : It has to be a reference type.
    // IEntity : It has to be IEntity or anything that implements IEntity
    // new() : It can be anything that implements IEntity but not IEntity itself.   Because we can't 'new IEntity()'
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
