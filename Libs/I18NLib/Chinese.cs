using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I18NLib
{
    public class Chinese : ILanguage
    {
        public string INFO_STARTING => "Invoker 已启动。";
        public string ERROR_CONFIGURE_NOT_SET => "配置错误，请检查 invoker.conf 文件。";
        public string INFO_WS_SERVICE_STARTED => "WebSocket 服务已启动。";
        public string INFO_WEB_DASHBOARD_SERVICE_STARTED => "Web 控制台已启动。";
        public string INFO_READY_TO_START_ITEM => "配置解析完毕，准备开始进程启动作业。";
        public string INFO_STARTING_ITEM => "启动配置项，次序[{0}]，类型[{1}]，路径[{2}]，启动结果[{3}]，信息[{4}]。";
    }
}
