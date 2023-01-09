using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I18NLib
{
    public interface ILanguage
    {
        /// <summary>
        /// Starting info.
        /// </summary>
        string INFO_STARTING { get; }
        /// <summary>
        /// Configure file is not ready.
        /// </summary>
        string ERROR_CONFIGURE_NOT_SET { get; }
        /// <summary>
        /// Websocket service has started.
        /// </summary>
        string INFO_WS_SERVICE_STARTED { get; }
        /// <summary>
        /// Web-Dashboard service has started.
        /// </summary>
        string INFO_WEB_DASHBOARD_SERVICE_STARTED { get; }
        /// <summary>
        /// Analyse configure complete and will start items in configure.
        /// </summary>
        string INFO_READY_TO_START_ITEM { get; }
        /// <summary>
        /// Text templet of start item.
        /// </summary>
        string INFO_STARTING_ITEM { get; }
    }
}
