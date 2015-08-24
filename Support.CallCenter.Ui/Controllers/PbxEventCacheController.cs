using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Support.CallCenter.Pbx.PbxEventCache;
using Support.CallCenter.Ui.Contracts;
using Support.Crm.Repository.Interfaces;

namespace Support.CallCenter.Ui.Controllers
{
    public class PbxEventCacheController : ApiController
    {
        private readonly IRepository<PbxEventCache> mPbxEventCachesRepository;

        public PbxEventCacheController(IRepository<PbxEventCache> pbxEventCachesRepository)
        {
            mPbxEventCachesRepository = pbxEventCachesRepository;
        }

        public IEnumerable<Dictionary<string, string>> GetAll()
        {
            return mPbxEventCachesRepository.GetAll().Select(p => p.Event).ToList();
        }

        public string PostRemovedPbxEvent(RemovePbxEventRequest request)
        {
            try
            {
                var eventsToRemove =
                    mPbxEventCachesRepository
                        .GetAll()
                        .Where
                        (
                            e =>
                                (e.Event.ContainsKey("Uniqueid1") && e.Event["Uniqueid1"] == request.PbxEventId)
                                ||
                                (e.Event.ContainsKey("Uniqueid") && e.Event["Uniqueid"] == request.PbxEventId)
                        ).ToList();
                foreach (var pbxEvent in eventsToRemove)
                {
                    mPbxEventCachesRepository.Delete(pbxEvent);
                }

                return "success";
            }
            catch (Exception e)
            {

                return e.ToString();
            }

        }
    }
}
