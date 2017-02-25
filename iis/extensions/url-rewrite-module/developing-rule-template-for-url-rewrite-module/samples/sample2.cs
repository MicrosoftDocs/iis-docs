using System;
using Microsoft.Web.Management.Client;
using Microsoft.Web.Management.Iis.Rewrite;
using System.Windows.Forms;
using System.Collections;

namespace CanonicalDomainTemplate
{
    class CanonicalDomainFeature: RewriteTemplateFeature
    {
        private const string FeatureTitle = "Canonical Domain Name";
        private const string FeatureDescription = "Creates a rewrite rule for enforcing canonical domain name for your web site";

        public CanonicalDomainFeature(Module module)
            : base(module, FeatureTitle, FeatureDescription, Resource.domain_icon16, Resource.domain_icon32)
        {
        }

        public override void Run()
        {
            CanonicalDomainModuleServiceProxy serviceProxy = 
                 (CanonicalDomainModuleServiceProxy)Connection.CreateProxy(this.Module, 
                                                                           typeof(CanonicalDomainModuleServiceProxy));
            CanonicalDomainForm form = new CanonicalDomainForm(serviceProxy);
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Navigate(GetPageType("Rewrite"));
            }
        }

        /// <summary>
        /// Returns the main page for the specified module
        /// </summary>
        private Type GetPageType(string moduleName)
        {
            IControlPanel controlPanel = (IControlPanel)GetService(typeof(IControlPanel));
            Module module = (Module)Connection.Modules[moduleName];

            if (module != null)
            {
                ICollection pageInfos = controlPanel.GetPages(module);

                foreach (ModulePageInfo pageInfo in pageInfos)
                {
                    if (pageInfo.IsEnabled && !pageInfo.PageType.IsAssignableFrom(typeof(IModuleChildPage)))
                    {
                        return pageInfo.PageType;
                    }
                }
            }

            return null;
        }
    }
}