using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I18NLib
{
    public class English : ILanguage
    {
        public string INFO_STARTING => "Invoker started.";
        public string ERROR_CONFIGURE_NOT_SET => "Configure error, please check invoker.conf file.";
        public string INFO_WS_SERVICE_STARTED => "WebSocket service has started.";
        public string INFO_WEB_DASHBOARD_SERVICE_STARTED => "Website of Web-Dashboard has started.";
        public string INFO_READY_TO_START_ITEM => "Analyse configure complete, and will start items in configure.";
        public string INFO_STARTING_ITEM => "Start configure item, Order[{0}], Type[{1}], Path[{2}], Result[{3}], Info[{4}].";
    }
}
