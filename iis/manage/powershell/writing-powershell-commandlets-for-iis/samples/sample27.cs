private string[] computer = { Environment.MachineName };
        [Parameter(
           ValueFromPipeline = true,
           ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string[] Computer
        {
            get { return computer; }
            set { computer = value; }
        }