using System;
using System.Collections.Generic;
using System.Linq;
using Support.Crm.Repository.Interfaces;

namespace Support.CallCenter.Pbx.PbxEventCache
{
    public class PbxEventCachesRepository: IRepository<PbxEventCache>
    {
        private readonly List<PbxEventCache> mCallCaches;

        public PbxEventCachesRepository()
        {
            mCallCaches = new List<PbxEventCache>();
        }


        public IQueryable<PbxEventCache> GetAll()
        {
            return mCallCaches.AsQueryable();
        }

        public PbxEventCache FindById(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public void Create(PbxEventCache inputEntity)
        {
            mCallCaches.RemoveAll(c => c.TimeStamp <= DateTime.Now.AddHours(-1));
            mCallCaches.Add(inputEntity);
        }

        public void Update(PbxEventCache inputEntity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PbxEventCache inputEntity)
        {
            mCallCaches.Remove(inputEntity);
           
        }

        public void Deactivate(PbxEventCache inputEntity, int stateCode, int statusCode)
        {
            throw new NotImplementedException();
        }
    }
}