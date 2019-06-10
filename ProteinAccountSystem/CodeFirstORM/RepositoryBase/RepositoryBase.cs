using CodeFirstORM.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Z.EntityFramework.Plus;

namespace CodeFirstORM.DBLayer
{
    public class RepositoryBase<T> where T : class, IEntity
    {
        protected readonly IDatabaseContext _database;

        public RepositoryBase(IDatabaseContext database)
        {
            _database = database;
        }

        public virtual bool Add(T entity)
        {
            _database.Set<T>().Add(entity);
            return _database.SaveChanges() > 0;
        }

        public virtual IEnumerable<T> AddIfNotExists(IEnumerable<T> entitys, Expression<Func<T, bool>> predicate = null)
        {
            List<T> result = new List<T>();
            var db = _database.Set<T>();
            foreach (var entity in entitys)
            {
                var exists = predicate != null ? db.Any(predicate) : db.Any();
                if (!exists)
                {
                    db.Add(entity);
                    if (_database.SaveChanges() < 0)
                        result.Add(entity);
                }
            }

            return result;
        }

        public virtual bool Add(IEnumerable<T> entitys)
        {
            foreach (var entity in entitys)
                _database.Set<T>().Add(entity);

            return _database.SaveChanges() > 0;
        }

        public virtual T Get(int id)
        {
            return _database.Set<T>().Single(p => p.Key == id);
        }

        public virtual IQueryable<T> Get(Expression<Func<T, bool>> exp)
        {
            return _database.Set<T>().Where(exp);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _database.Set<T>();
        }

        public virtual int GetRowCount(Expression<Func<T, bool>> exp)
        {
            return _database.Set<T>().Where(exp).Count();
        }

        public virtual bool Remove(T entity)
        {
            _database.Set<T>().Remove(entity);
            return _database.SaveChanges() > 0;
        }

        public virtual bool Update(Expression<Func<T, bool>> exp, Expression<Func<T, T>> updateFactory)
        {
            return _database.Set<T>().Where(exp).Update(updateFactory) > 0;
        }

        public virtual bool Update(T entity)
        {
            var entry = _database.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                var set = _database.Set<T>();
                var attachedEntity = set.Find(entity.Key);

                if (attachedEntity != null)
                {
                    var attachedEntry = _database.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);
                }
                else
                {
                    entry.State = EntityState.Modified;
                }
            }
            return _database.SaveChanges() > 0;
        }

        public virtual bool Update(IEnumerable<T> entitys)
        {
            foreach (var entity in entitys)
            {
                var entry = _database.Entry(entity);
                if (entry.State == EntityState.Detached)
                {
                    var set = _database.Set<T>();
                    var attachedEntity = set.Find(entity.Key);

                    if (attachedEntity != null)
                    {
                        var attachedEntry = _database.Entry(attachedEntity);
                        attachedEntry.CurrentValues.SetValues(entity);
                    }
                    else
                    {
                        entry.State = EntityState.Modified;
                    }
                }
            }
            return _database.SaveChanges() > 0;
        }
    }
}