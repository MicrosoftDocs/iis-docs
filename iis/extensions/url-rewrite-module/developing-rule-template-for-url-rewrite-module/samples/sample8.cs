namespace CanonicalDomainTemplate
{
    internal sealed class CanonicalDomainModuleProvider : ModuleProvider
    {
        public override string FriendlyName
        {
            get
            {
                return Resource.ModuleFriendlyName;
            }
        }

        public override Type ServiceType
        {
            get {
                 return typeof(CanonicalDomainModuleService);
            }
        }

        public override ModuleDefinition GetModuleDefinition(IManagementContext context)
        {
            if (context != null && string.Compare(context.ClientUserInterfaceTechnology, 
            "System.Windows.Forms.Control", StringComparison.OrdinalIgnoreCase) != 0)
            {
                return null;
            }

            return new ModuleDefinition(Name, "CanonicalDomainTemplate.CanonicalDomainModule,
                                               CanonicalDomainTemplate.Client,Version=1.0.0.0,Culture=neutral,
                                               PublicKeyToken={your key}");
        }

        public override bool SupportsScope(ManagementScope scope)
        {
            return true;
        }
    }
}