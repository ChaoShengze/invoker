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
        public const string ModuleName = "Invoker";
        /// <summary>
        /// File name of configure.
        /// </summary>
        public const string ConfigFileName = "invoker.conf";
        /// <summary>
        /// Language Instance.
        /// </summary>
        public static ILanguage? Language { get; private set; }
        /// <summary>
        /// Config object.
        /// </summary>
        public static Configure? Configure { get; private set; }
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
        #endregion
    }
}