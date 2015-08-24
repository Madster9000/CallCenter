var ContactsService = function($http)
{
    var getContactByPhoneNumber = function(phoneNumber)
    {
        var requestUrl = "/contacts/" + phoneNumber;

        var requestPromise = $http.get(requestUrl);

        return requestPromise;
    }

    var getContactsBySearchContract = function(contactSearch)
    {
        var requestUrl = "/contacts?FirstName=" + contactSearch.FirstName + "&LastName=" + contactSearch.LastName + "&RouteNumber=" + contactSearch.RouteNumber;

        requestUrl = encodeURI(requestUrl);
        var requestPromise = $http.get(requestUrl);

        return requestPromise;
    }

    var contactsService =
        {
            GetContactByPhoneNumber: getContactByPhoneNumber,
            GetContactsBySearchContract: getContactsBySearchContract
        };
    return contactsService;
}