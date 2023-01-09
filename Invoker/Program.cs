using AdvanceLogLib;
using ConfigureLib;
using I18NLib;

namespace Invoker
{
    internal class Program
    {
        #region Variable & Constant
        /// <summary>
        /// Module Name
        /// </summary>
        private const string ModuleName = "Invoker";
        /// <summary>
        /// File name of configure.
        /// </summary>
        private const string ConfigFileName = "invoker.conf";
        /// <summary>
        /// Language Instance.
        /// </summary>
        private static ILanguage? Language { get; set; }
        /// <summary>
        /// Config object.
        /// </summary>
        private static Configure? Configure { get; set; }
        /// <summary>
        /// List of ProcessState.
        /// </summary>
        private static List<ProcessState> ProcessStates { get; set; } = new();
        #endregion

        /// <summary>
        /// Main Entrypoint
        /// </summary>
        /// <param name="args"></param>
        public static void Main()
        {
            Language = I18N.GetInstance().GetLanguage();
            Configure = Configure.GetConfigure(ConfigFileName);
            Init();
        }

        #region Logic functions
        /// <summary>
        /// Init Invoker.
        /// </summary>
        private static void Init()
        {
            WriteLine(LogType.INFO, "Main", Language!.INFO_STARTING);

            if (Configure == null)
            {
                WriteLine(LogType.ERROR, "Init", Language.ERROR_CONFIGURE_NOT_SET);
                return;
            }

            if (Configure.UseClient || Configure.UseWebInterface)
            {
                WsHub.GetInstance().StartService(Configure.WsPort);
                WriteLine(LogType.INFO, "Init", Language.INFO_WS_SERVICE_STARTED);
            }

            if (Configure.UseWebInterface)
            {
                //TODO Start website of dashboard.
                WriteLine(LogType.INFO, "Init", Language.INFO_WEB_DASHBOARD_SERVICE_STARTED);
            }

            AnalyseConfigure();
        }
        /// <summary>
        /// Analyse configure and start items in configure.
        /// </summary>
        /// <returns></returns>
        private static bool AnalyseConfigure()
        {
            try
            {
                if (Configure == null || Language == null)
                    return false;

                WriteLine(LogType.INFO, "AnalyseConfigure", Language.INFO_READY_TO_START_ITEM);

                foreach (var item in Configure.InvokerConfigItems)
                {
                    if (Configure.StartupDelay > 0)
                        Thread.Sleep(Configure.StartupDelay);

                    StartItem(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                WriteLine(LogType.ERROR, "AnalyseConfigure", ex.Message);
                return false;
            }
        }
        #endregion

        #region Tool functions
        /// <summary>
        /// Write format log into commandline console.
        /// </summary>
        /// <param name="type">Log Level.</param>
        /// <param name="func">Func name.</param>
        /// <param name="desc">Log content.</param>
        private static void WriteLine(LogType type, string func, string desc)
        {
#if DEBUG
            Console.WriteLine($"> {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}:[{type}]-[{func}]-{desc}");
#else
            AdvanceLog.GetInstance().WriteLog(type, ModuleName, func, desc);
#endif
        }

        private static void StartItem(InvokerConfigItem item)
        {
            var result = true;
            var info = string.Empty;

            try
            {

            }
            catch (Exception ex)
            {
                info = ex.Message;
                WriteLine(LogType.ERROR, "StartItem", info);
            }

            var msg = string.Format(Language!.INFO_STARTING_ITEM,
                item.StartupIndex,
                item.Type,
                item.FilePath,
                result,
                info);

            WriteLine(LogType.INFO, "StartItem", msg);
        }
        #endregion
    }
}