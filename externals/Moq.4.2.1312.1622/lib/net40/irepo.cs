using Test.Infrastructure;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Test.Framework
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        IQueryable<T> All();
        T FindSingle(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] includes);
        IQueryable<T> Filter(Expression<Func<T, bool>> predicate);
        IQueryable<T> Filter(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] includes);
        IQueryable<T> FindIncluding(params Expression<Func<T, object>>[] includeProperties);
        int Count(Expression<Func<T, bool>> predicate = null);
        bool Contains(Expression<Func<T, bool>> predicate);
        bool Exist(Expression<Func<T, bool>> predicate = null);
        PagedListResult<T> Search(SearchQuery<T> searchQuery);
        int SaveChanges();
    }
}
