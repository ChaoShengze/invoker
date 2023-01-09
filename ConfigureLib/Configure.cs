using AdvanceLogLib;
using Newtonsoft.Json;

namespace ConfigureLib
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
        /// <summary>
        /// Load config from *.conf file.
        /// </summary>
        /// <param name="configPath">Path of *.conf file</param>
        /// <returns></returns>
        public static Configure GetConfigure(string configPath)
        {
            try
            {
                if (!File.Exists(configPath))
                    WriteConfigure(Activator.CreateInstance<Configure>(), configPath);

                var text = File.ReadAllText(configPath);
                var conf = JsonConvert.DeserializeObject<Configure>(text);
                if (conf != null)
                    return conf;
                else
                    return Activator.CreateInstance<Configure>();
            }
            catch (Exception ex)
            {
                AdvanceLog.GetInstance().WriteLog(LogType.ERROR, "Configure",
                    "GetConfigure", ex.Message);
                return Activator.CreateInstance<Configure>();
            }
        }
        /// <summary>
        /// Write config into *.conf file.
        /// </summary>
        /// <param name="configure"></param>
        /// <param name="configPath"></param>
        public static bool WriteConfigure(Configure configure, string configPath)
        {
            try
            {
                var text = JsonConvert.SerializeObject(configure);
                File.WriteAllText(configPath, text);
                return true;
            }
            catch (Exception ex)
            {
                AdvanceLog.GetInstance().WriteLog(LogType.ERROR, "Configure",
                    "WriteConfigure", ex.Message);
                return false;
            }
        }
    }
}
