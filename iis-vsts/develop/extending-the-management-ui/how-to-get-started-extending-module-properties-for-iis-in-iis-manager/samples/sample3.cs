public class CustomModuleProvider : ModuleProvider { 
      public override Type ServiceType { 
        get { 
          return typeof(CustomModuleService); 
        } 
      } 

      public override ModuleDefinition GetModuleDefinition(IManagementContext context) { 
        ModuleDefinition moduleDefinition = 
          new ModuleDefinition(Name, typeof(CustomModule).AssemblyQualifiedName); 
        return moduleDefinition; 
      } 

      public override bool SupportsScope(ManagementScope scope) { 
        return (scope == ManagementScope.Application) || 
          (scope == ManagementScope.Site) || 
          (scope == ManagementScope.Server); 
      } 
    }