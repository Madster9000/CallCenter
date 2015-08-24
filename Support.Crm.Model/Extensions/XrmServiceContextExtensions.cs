using System;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Client.Caching;
using Microsoft.Xrm.Sdk;

namespace Support.Crm.Model.Extensions
{
    /// <summary>
    /// Класс расширений контекста XrmServiceContext
    /// </summary>
    public static class XrmServiceContextExtensions
    {
        /// <summary>
        /// Деактиврует запись record
        /// </summary>
        /// <param name="xrmServiceContext"></param>
        /// <param name="record"></param>
        /// <returns></returns>
        public static SetStateResponse DeactivateEntityRecord(this XrmServiceContext xrmServiceContext, Entity record)
        {
            IOrganizationService service = xrmServiceContext;

            //State represents the field with schema name “state code” and display name “status”.
            //Suppose we are working on the account entity  in which the state code field has to be 1 so that the record be inactive.

            //Status  represents the field with schema name “Status code” and display name “Status Reason”.
            // set this value to -1 to let the system automatically set the appropriate corresponding status value.
            SetStateRequest setStateRequest = new SetStateRequest
            {
                EntityMoniker = new EntityReference(record.LogicalName, record.Id),
                State = new OptionSetValue(1),
                Status = new OptionSetValue(-1)
            };

            // Execute the request
            var response = (SetStateResponse)service.Execute(setStateRequest);

            return response;
        }

        /// <summary>
        /// Удаляет сущность с именем entityName из кеша
        /// </summary>
        /// <param name="xrmServiceContext"></param>
        /// <param name="entityName"></param>
        public static void ClearXrmCache(this XrmServiceContext xrmServiceContext, string entityName)
        {
            var dependency = String.Format("xrm:dependency:entity:{0}", entityName).ToLower();
            var cache = ObjectCacheManager.GetInstance(null);
            cache.Remove(dependency);
        }
    }
}