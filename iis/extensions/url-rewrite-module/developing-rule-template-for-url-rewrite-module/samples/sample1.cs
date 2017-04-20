using System;
using Microsoft.Web.Management.Server;
using Microsoft.Web.Management.Client;
using Microsoft.Web.Management.Iis.Rewrite;

namespace CanonicalDomainTemplate
{
    internal class CanonicalDomainModule: Module
    {
        protected override void Initialize(IServiceProvider serviceProvider, ModuleInfo moduleInfo)
        {
            base.Initialize(serviceProvider, moduleInfo);

            IExtensibilityManager extensibilityManager = (IExtensibilityManager)GetService(typeof(IExtensibilityManager));

            extensibilityManager.RegisterExtension(typeof(RewriteTemplateFeature), new CanonicalDomainFeature(this)); 
        }
    }
}