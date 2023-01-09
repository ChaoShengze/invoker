using I18NLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoker
{
    internal class WsHub
    {
        #region Singleton
        private static WsHub? Instance;
        private static readonly object Locker = new();
        public static WsHub GetInstance()
        {
            lock (Locker)
                Instance ??= new WsHub();

            return Instance;
        }
        private WsHub() { }
        #endregion

        /// <summary>
        /// Start Ws Service.
        /// </summary>
        /// <param name="port">Port of websocket service.</param>
        public void StartService(int port)
        { 
        
        }
    }
}
