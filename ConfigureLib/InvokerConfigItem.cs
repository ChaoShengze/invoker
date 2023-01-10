namespace ConfigureLib
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
        public string FilePath { get; set; } = string.Empty;
        /// <summary>
        /// Args of starting process.
        /// </summary>
        public string Args { get; set; } = string.Empty;
        /// <summary>
        /// Work folder.
        /// </summary>
        public string WorkFolder { get; set; } = string.Empty;
        /// <summary>
        /// Type of file.
        /// </summary>
        public InvokeType Type { get; set; } = InvokeType.EXECUTABLE_FILE;
        /// <summary>
        /// Permission level, only for Linux or macOS.
        /// </summary>
        public PermissionLevel PermissionLevel { get; set; } = PermissionLevel.USER;
    }

    public enum InvokeType
    {
        EXECUTABLE_FILE = 0,
        SHELL
    }

    /// <summary>
    /// Permission level, only for Linux or macOS.
    /// </summary>
    public enum PermissionLevel
    {
        ROOT = 0,
        USER
    }
}
