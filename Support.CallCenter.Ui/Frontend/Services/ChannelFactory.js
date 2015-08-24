var ChannelFactory = function()
{
    var channel = function()
    {
        this.Sender = {};
        this.Listeners = [];
    };

    channel.prototype.Subscribe = function (listener)
    {
        this.Listeners.push(listener);
    };

    channel.prototype.Publish = function (sender, message)
    {
        for (var i = 0; i < this.Listeners.length; i++)
        {
            this.Listeners[i](sender, message);
        }
    };


    var getInstance = function()
    {
        var newChannel = new channel();

        return newChannel;
    }

    var factory =
        {
            GetInstance: getInstance
        };

    return factory;
}