using System;
using System.Security;
using Microsoft.Web.Management.Server;
namespace ExtensibilityDemo {
    class DemoModuleProvider : ModuleProvider {
        public override Type ServiceType {
            get { return null; }
        }
        public override ModuleDefinition GetModuleDefinition(IManagementContext context) {
            return new ModuleDefinition(Name, typeof(DemoModule).AssemblyQualifiedName);
        }
        public override bool SupportsScope(ManagementScope scope) {
            return true;
        }
    }
}