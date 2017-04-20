[Cmdlet(VerbsCommon.Get, "IISSite")]
    public class GetSiteCommand : RemotingCommand
    {
        private string name = null;
        [Parameter(
           Position = 0,
           ValueFromPipeline = true,
           ValueFromPipelineByPropertyName = true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
 
        protected override void EndProcessing()
        {
            base.EndProcessing();
 
            ManagementObjectCollection sites = CreateClassObject(computerName, "Site").GetInstances();
            foreach (ManagementObject site in sites)
            {
                string siteName = site.GetPropertyValue("Name") as string;
                if (Name != null)
                {
                    if (siteName.Equals(Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        WriteObject(siteName);
                        break;
                    }
                }
                else 
                {
                    WriteObject(siteName);
                }
            }
        }
    } //GetSiteCommand 
    // 
    // [RunInstaller(true)] 
    // public class IISDemoCmdSnapIn : PSSnapIn {…} 
    // 
} // Microsoft.Samples.PowerShell.IISCommands