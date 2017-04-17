protected override void EndProcessing()
        {
            base.EndProcessing();
 
            ManagementObjectCollection sites = CreateClassObject(Computer, "Site").GetInstances();
            foreach (ManagementObject site in sites)
            {
                string siteName = site.GetPropertyValue("Name") as string;
                if (Name != null)
                {
                    if (siteName.Equals(Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        WriteObject(ConstructPSSite(Computer, site));
                        break;
                    }
                }
                else 
               {
                    WriteObject(ConstructPSSite(Computer, site));
                }
            }
        }