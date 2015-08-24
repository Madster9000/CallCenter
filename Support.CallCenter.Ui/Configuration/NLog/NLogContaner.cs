using NLog;
using NLog.Config;
using NLog.Targets;

namespace Support.CallCenter.Ui.Configuration.NLog
{
    public class NLogContaner
    {
        private static Logger mInstance;

        public static Logger Instance
        {
            get
            {
                return mInstance ?? (mInstance = CreateLogger());
            }
        }

        private static Logger CreateLogger()
        {
            var config = new LoggingConfiguration();

            var fileTarget = new FileTarget();
            config.AddTarget("file", fileTarget);

            fileTarget.FileName = "${basedir}\\AsteriskLog.txt";
            fileTarget.Layout = "${date:format=yyyy-MM-dd HH\\:mm\\:ss}: ${message}";
            fileTarget.ArchiveFileName = "${basedir}\\archives\\log.{#####}.txt";
            fileTarget.ArchiveAboveSize = 10240000;
            fileTarget.ArchiveNumbering = ArchiveNumberingMode.Sequence;

            var rule = new LoggingRule("*", LogLevel.Trace, fileTarget);
            config.LoggingRules.Add(rule);

            var errorTarget = new FileTarget();
            config.AddTarget("errorfile", errorTarget);

            errorTarget.FileName = "${basedir}\\Errors.txt";
            errorTarget.Layout = "${date:format=yyyy-MM-dd HH\\:mm\\:ss}: ${message}";
            errorTarget.ArchiveFileName = "${basedir}\\archives\\log.{#####}.txt";
            errorTarget.ArchiveAboveSize = 10240000;
            errorTarget.ArchiveNumbering = ArchiveNumberingMode.Sequence;

            var errorsRule = new LoggingRule("*", LogLevel.Error, errorTarget);
            config.LoggingRules.Add(errorsRule);

            LogManager.Configuration = config;

            return LogManager.GetCurrentClassLogger();
        }
    }
}