namespace Invoker
{
    /// <summary>
    /// Class of single config.
    /// </summary>
    public class InvokerConfigItem
    {
        /// <summary>
        /// Path of execute file.
        /// </summary>
        public string FilePath { get; set; } = "";
        /// <summary>
        /// Work folder of execute file.
        /// </summary>
        public string WorkFolder { get; set; } = "";
        /// <summary>
        /// The startup sequence of the program.
        /// </summary>
        public int StartupIndex { get; set; } = 0;
    }
}
