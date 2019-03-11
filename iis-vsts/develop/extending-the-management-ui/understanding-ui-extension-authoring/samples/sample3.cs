using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Management.Client;
using Microsoft.Web.Management.Server;

namespace Client {
    internal class DemoModuleServiceProxy : ModuleServiceProxy {
        public ArrayList GetAppSettings() {
            return (ArrayList )Invoke("GetAppSettings");
        }
    }
}