using System;
using Microsoft.Web.Management.Server;

namespace Server {
    internal class DemoModuleProvider : ModuleProvider {
        public override ModuleDefinition GetModuleDefinition(IManagementContext context) {
            return new ModuleDefinition(Name, "Client.DemoModule," + AssemblyRef.Client);
        }

        public override Type ServiceType {
            get {
                return typeof(DemoModuleService);
            }
        }

        public override bool SupportsScope(ManagementScope scope) {
            return true;
        }
    }
}