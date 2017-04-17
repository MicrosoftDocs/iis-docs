using System;
using System.Windows.Forms;
using Microsoft.Web.Management.Client;
using Microsoft.Web.Management.Server;

namespace ExtensibilityDemo {
    internal class DemoModule : Module {
        protected override void Initialize(IServiceProvider serviceProvider, ModuleInfo moduleInfo) {
            base.Initialize(serviceProvider, moduleInfo);
             MessageBox.Show("Hello World Inside InetMgr");
        }
    }
}