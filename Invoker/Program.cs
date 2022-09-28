using AdvanceLogLib;

namespace Invoker
{
    internal class Program
    {
        #region Variable & Constant
        /// <summary>
        /// Module Name
        /// </summary>
        public const string ModuleName = "Invoker";
        #endregion

        /// <summary>
        /// Main Entrypoint
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Init();
        }

        #region Logic functions
        /// <summary>
        /// Init Invoker.
        /// </summary>
        private static void Init()
        {
            WriteLine(LogType.INFO, "Main", "Invoker start...");
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