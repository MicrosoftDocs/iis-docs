using System;
using System.Windows.Forms;
using Microsoft.Web.Management.Client;
using Microsoft.Web.Management.Server;

namespace IIS7Demos
{
    internal class imageCopyrightUI : Module
    {
        protected override void Initialize(IServiceProvider serviceProvider, ModuleInfo moduleInfo)
        {
            base.Initialize(serviceProvider, moduleInfo);
            IControlPanel controlPanel = (IControlPanel)GetService(typeof(IControlPanel));
            ModulePageInfo modulePageInfo = new ModulePageInfo(this, typeof(imageCopyrightUIPage), "Image Copyright", "Image Copyright");
            controlPanel.RegisterPage(modulePageInfo);
        }
    }              
}