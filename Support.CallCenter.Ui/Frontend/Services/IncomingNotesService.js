var IncomingNotesService = function($http)
{
    var createIncomingNote = function(incomingNoteModel)
    {
        var requestUrl = "/incomingnotes";

        var requestPromise = $http.post(requestUrl, incomingNoteModel);

        return requestPromise;
    }

    var service =
        {
            CreateNote: createIncomingNote
        }

    return service;
}