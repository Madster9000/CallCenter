using System;
using System.Collections.Generic;
using System.Linq;
using Support.Crm.Repository.Interfaces;

namespace Support.Crm.Repository.Implementations
{
    public class StubRepository<T>: IRepository<T> where T: class
    {
        private readonly List<T> mEntities;

        public StubRepository()
        {
            mEntities = new List<T>();
        }
        public IQueryable<T> GetAll()
        {
            return mEntities.AsQueryable();
        }

        public T FindById(Guid entityId)
        {
            return mEntities.FirstOrDefault();
        }

        public void Create(T inputEntity)
        {
            mEntities.Add(inputEntity);
        }

        public void Update(T inputEntity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T inputEntity)
        {
            mEntities.Remove(inputEntity);
        }

        public void Deactivate(T inputEntity, int stateCode, int statusCode)
        {
        }
    }
}