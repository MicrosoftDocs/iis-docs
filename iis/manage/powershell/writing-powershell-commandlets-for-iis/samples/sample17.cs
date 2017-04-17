private PSObject ConstructPSSite(
            string computerName,
            ManagementObject site)
        {
            PSObject pssite = ObjectConverter.ConvertSiteToPSObject(site);
            pssite.Properties.Add(new PSNoteProperty("Computer", computerName));
            pssite.Properties.Add(new PSNoteProperty("Credential", Credential));
            Type siteMethodsType = typeof(SiteMethods);
            foreach (MethodInfo mi in siteMethodsType.GetMethods())
            {
                if (mi.Name.Equals("Start", StringComparison.InvariantCultureIgnoreCase))
                {
                    pssite.Methods.Add(new PSCodeMethod("Start", mi));
                }
                if (mi.Name.Equals("Stop", StringComparison.InvariantCultureIgnoreCase))
                {
                    pssite.Methods.Add(new PSCodeMethod("Stop", mi));
                }
                if (mi.Name.Equals("GetStatus", StringComparison.InvariantCultureIgnoreCase))
                {
                    pssite.Properties.Add(new PSCodeProperty("Status", mi));
                }
            }
            return pssite;
        }