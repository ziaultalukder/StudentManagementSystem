using Microsoft.AspNet.Identity.EntityFramework;
using SchoolManagement.Model.Contract;
using SchoolManagement.Repository.Contracts;
using StudentManagement.Model.DatabaseContext;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repository.Base
{
    public abstract class Repository<T> : IRepository<T> where T : class,IEntityModel, IDeletable
    {
        public IdentityDbContext db;
        public Repository(IdentityDbContext db)
        {
            this.db = db;
        }

        public virtual bool Add(T entity)
        {
            db.Set<T>().Add(entity);
            return db.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            db.Set<T>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public virtual bool Remove(IDeletable entity)
        {
            entity.Delete();
            return Update((T)entity);
        }

        public virtual bool Remove(ICollection<IDeletable> entities)
        {
            int removeCount = 0;
            foreach (var entity in entities)
            {
                bool isRemove = Remove(entity);
                if (isRemove)
                {
                    removeCount++;
                }
            }

            return entities.Count == removeCount;
        }

        public virtual ICollection<T> GetAll(bool withDeleted = false)
        {
            return db.Set<T>().Where(c => c.IsDeleted == false || c.IsDeleted == withDeleted).ToList();
        }

        public virtual ICollection<T> Get(Expression<Func<T, bool>> query)
        {
            return db.Set<T>().Where(query).ToList();
        }

        public virtual T GetById(int Id)
        {
            return db.Set<T>().Find(Id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }


}
