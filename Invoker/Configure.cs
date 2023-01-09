namespace Invoker
{
    /// <summary>
    /// Configure class
    /// </summary>
    public class Configure
    {
        /// <summary>
        /// If Invoker start an admin webpage or not.
        /// </summary>
        public bool UseWebInterface { get; set; } = true;
        /// <summary>
        /// Port of WebInterface.
        /// </summary>
        public int WebInterfacePort { get; set; } = 8088;
        /// <summary>
        /// Allow Invoker client connect this service with Websocket or not.
        /// </summary>
        public bool UseClient { get; set; } = true;
        /// <summary>
        /// Port of client.
        /// </summary>
        public int ClientPort { get; set; } = 8090;
        /// <summary>
        /// Delay(ms) of every startup object. Zero means no delay.
        /// </summary>
        public int StartupDelay { get; set; } = 1000;
        /// <summary>
        /// User without root authority.
        /// </summary>
        public string UserName { get; set; } = string.Empty;
        /// <summary>
        /// Password of user without root authority.
        /// </summary>
        public string UserPassword { get; set; } = string.Empty;
        /// <summary>
        /// List of items need starting.
        /// </summary>
        public List<InvokerConfigItem> InvokerConfigItems { get; set; } = new();
    }
}
