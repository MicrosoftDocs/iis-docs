foreach (string computerName in Computer)
        {
            ManagementObjectCollection sites = CreateClassObject(computerName, "Site").GetInstances();
            foreach (ManagementObject site in sites)
            {
                if (Name != null)
                {
                    string siteName = site.GetPropertyValue("Name") as string;
                    if (siteName.Equals(Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        WriteObject(ConstructPSSite(computerName, site));
                        break;
                    }
                }
                else 
               {
                    WriteObject(ConstructPSSite(computerName, site));
                }
            }
        }