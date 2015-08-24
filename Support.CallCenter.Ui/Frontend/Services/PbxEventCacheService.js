var PbxEventCacheService = function($http)
{
    var getCache = function()
    {
        var requestUrl = "/PbxEventCache";

        var requestPromise = $http.get(requestUrl);

        return requestPromise;
    }

    var removeFromCache = function (callId) {
        var requestUrl = "/PbxEventCache";

        var data =
            {
                PbxEventId: callId
            }
        var requestPromise = $http.post(requestUrl, data);

        return requestPromise;
    }

    var pbxEventCacheService =
        {
            GetCache: getCache,
            RemoveFromCache: removeFromCache
        };
    return pbxEventCacheService;
}