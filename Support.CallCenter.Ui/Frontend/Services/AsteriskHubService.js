var AsteriskHubService = function($, $timeout, pbxEventCacheService, channelsService)
{
    var hubProxy = {};
    var asteriskChannel = channelsService.AsteriskMessageReceivedChannel;
    var calledBackChannel = channelsService.RemoveCallMessageReceivedChannel;

    //старт подключения к хабу.
    var startConnection = function()
    {
        var connection = $.hubConnection();
        hubProxy = connection.createHubProxy("asteriskHub");

        hubProxy.on("broadcastMessage", function(msg)
        {
            asteriskChannel.Publish("AsteriskHubService", { Messages: msg });
        });
        hubProxy.on("broadcastCalledBackCall", function(msg)
        {
            calledBackChannel.Publish("AsteriskHubService", { CallId: msg });
        });

        //включение логирования в консоли браузера.
        //connection.logging = true;

        connection.start();

        connection.disconnected(function()
        {
            $timeout(function()
            {
                connection.start();
            }, 1000);
        });
    }

    var initialize = function()
    {
        //вытаскиваем закешированные события астериска и стартуем подключение
        pbxEventCacheService
            .GetCache()
            .then
            (
                function(response)
                {
                    //таймаут здесь нужен чтобы старт подключения к астериску осуществлялся после старта всех сервисов.
                    $timeout(function()
                    {
                        asteriskChannel.Publish("AsteriskHubService", { Messages: response.data });
                        startConnection();
                    });
                }
            );
    }

    var callWasCalledBack = function(callId)
    {
        //Вызываем метод из бекенда, чтобы отправить его всем подписчикам на хаб.
        hubProxy.invoke("callWasCalledBack", {PbxEventId: callId});
    }

    var hubService =
        {
            Initialize: initialize,
            CallWasCalledBack: callWasCalledBack
        };

    return hubService;
}