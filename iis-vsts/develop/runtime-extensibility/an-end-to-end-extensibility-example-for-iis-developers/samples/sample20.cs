using System;
using System.Security;
using Microsoft.Web.Management.Server;
    
namespace IIS7Demos           
{
    class imageCopyrightUIProvider : ModuleProvider
    {
        public override Type ServiceType              
        {
            get { return null; }
        }

        public override ModuleDefinition GetModuleDefinition(IManagementContext context)
        {
            return new ModuleDefinition(Name, typeof(imageCopyrightUI).AssemblyQualifiedName);
        }

        public override bool SupportsScope(ManagementScope scope)
        {
            return true;
        }
    }            
}