namespace Invoker
{
    /// <summary>
    /// Configure class
    /// </summary>
    public class Configure
    {
        /// <summary>
        /// Invoker will search items with relative path in this folder.
        /// </summary>
        public string WorkFolder { get; set; } = "";
        /// <summary>
        /// If Invoker start an admin webpage or not.
        /// </summary>
        public bool UseWebInterface { get; set; } = true;
        /// <summary>
        /// Allow Invoker client connect this service with Websocket or not.
        /// </summary>
        public bool UseClient { get; set; } = true;
        /// <summary>
        /// List of items need starting.
        /// </summary>
        public List<InvokerConfigItem> InvokerConfigItems { get; set; } = new();
    }
}
