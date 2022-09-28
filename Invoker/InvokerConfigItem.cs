namespace Invoker
{
    /// <summary>
    /// Class of single config.
    /// </summary>
    public class InvokerConfigItem
    {
        /// <summary>
        /// The startup sequence of the program.
        /// </summary>
        public int StartupIndex { get; set; } = 0;
        /// <summary>
        /// Path of file.
        /// </summary>
        public string FilePath { get; set; } = "";
        /// <summary>
        /// Work folder.
        /// </summary>
        public string WorkFolder { get; set; } = "";
        /// <summary>
        /// Type of file.
        /// </summary>
        public InvokeType Type { get; set; } = InvokeType.EXECUTABLE_FILE;
    }

    public enum InvokeType
    { 
        EXECUTABLE_FILE = 0,
        SHELL
    }
}
