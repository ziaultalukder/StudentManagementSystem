using SchoolManagement.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Model.Contract;
using StudentManagement.BLL.Contracts;

namespace StudentManagement.BLL.Base
{
    public class Manager<T>:IManager<T> where T:class, IDeletable
    {
        protected IRepository<T> _repository;

        public Manager(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }

        public virtual bool Remove(IDeletable entity)
        {
            bool isDeleteable = entity is IDeletable;
            if (!isDeleteable)
            {
                throw new Exception("This Item is not Deleteable!");
            }
            return _repository.Remove(entity);
        }

        public bool Remove(ICollection<IDeletable> entities)
        {
            return _repository.Remove(entities);
        }

        public ICollection<T> GetAll(bool withDeleted = false)
        {
            return _repository.GetAll(withDeleted);
        }

        public ICollection<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> query)
        {
            return _repository.Get(query);
        }

        public T GetById(int Id)
        {
            return _repository.GetById(Id);
        }
    }
}
