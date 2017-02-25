[Cmdlet(VerbsCommon.Add, "IISSite", SupportsShouldProcess = true)]
    public class AddSiteCommand : RemotingCommand
    {
        //… 
       private SwitchParameter passThru = new SwitchParameter(false);
        [Parameter]
        public SwitchParameter PassThru
        {
            get { return passThru; }
            set { passThru = value; }
        }
 
        protected override void EndProcessing()
        {
            base.EndProcessing();
            if (ShouldProcess(string.Format("{0} bound to {1} on {2}", name, bindings.ToString(), rootFolder)))
            {
                object[] args = new object[4];
                args[0] = Name;
                ManagementBaseObject[] mbarr = new ManagementBaseObject[bindings.Length];
                for (int b = 0; b < bindings.Length; ++b)
                {
                    mbarr[b] = ObjectConverter.ToManagementObject(
                        GetScope(Computer), "BindingElement", bindings[b]);
                }
                args[1] = mbarr;
                args[2] = rootFolder;
                args[3] = autoStart;
                ManagementClass siteClass = CreateClassObject(Computer, "Site");
                try 
               {
                    siteClass.InvokeMethod("Create", args);
                }
                catch (COMException comEx)
                {
                    WriteError(new ErrorRecord(comEx, comEx.Message, ErrorCategory.InvalidArgument, Name));
                }
                if (PassThru.IsPresent)
                {
                    string getSiteScript = "get-iissite" 
                            + " -name " + Name
                            + " -computer " + Computer
                            + " -credential $args[0]";
                    this.InvokeCommand.InvokeScript(
                        getSiteScript, false, PipelineResultTypes.Output, null, Credential);
                }
            }
        }
    }