using System;
using System.Linq;

namespace Support.Crm.Repository.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IQueryable<T> GetAll();

        T FindById(Guid entityId);

        void Create(T inputEntity);
        void Update(T inputEntity);
        void Delete(T inputEntity);
        void Deactivate(T inputEntity, int stateCode, int statusCode);
    }
}