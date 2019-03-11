using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Management.Client;

namespace Client {
    internal class DemoModule : Module {
        protected override void Initialize(IServiceProvider serviceProvider, Microsoft.Web.Management.Server.ModuleInfo moduleInfo) {
            base.Initialize(serviceProvider, moduleInfo);

            IControlPanel controlPanel = (IControlPanel)GetService(typeof(IControlPanel));
            controlPanel.RegisterPage(new ModulePageInfo(this, typeof(DemoModuleListPage), "DemoPage"));
        }
    }
}