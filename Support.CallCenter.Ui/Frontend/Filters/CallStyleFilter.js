var CallStyleFilter = function()
{
    var callStyleFilter = function(inputCall)
    {
        switch (inputCall.State)
        {
            case "new":
                return "CallBlock_Wrapper_Incoming";
            case "joined":
                return "CallBlock_Wrapper_Joined";
            case "bridged":
                return "CallBlock_Wrapper_Received";
            case "missed":
                return "CallBlock_Wrapper_Missed";
            case "ended":
                return "CallBlock_Wrapper_Ended";

            default:
                return "";
        }
    };

    return callStyleFilter;
}