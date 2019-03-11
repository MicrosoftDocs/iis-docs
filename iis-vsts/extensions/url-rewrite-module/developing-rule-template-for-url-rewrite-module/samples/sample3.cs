using System;
using Microsoft.Web.Management.Client;
using Microsoft.Web.Management.Server;

namespace CanonicalDomainTemplate
{
    class CanonicalDomainModuleServiceProxy : ModuleServiceProxy
    {

        public void GenerateRule(string domainName)
        {
            Invoke("GenerateRule", domainName);
        }
    }
}