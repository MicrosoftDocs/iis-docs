[Cmdlet(VerbsCommon.Remove, "IISSite", SupportsShouldProcess = true)]
public class RemoveSiteCommand : RemotingCommand
{
	private string name = null;
	[Parameter(
	   Position = 0,
	   ValueFromPipeline = true,
	   ValueFromPipelineByPropertyName = true)]
	[ValidateNotNullOrEmpty]
	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	protected override void EndProcessing()
	{
		base.EndProcessing();

		if (ShouldProcess(string.Format("{0} on server {1}", name, Computer)))
		{
			ManagementObject site = CreateClassInstance(Computer, "Site.Name=\"" + Name + "\"");
			site.Delete();
		}
	}
} //RemoveSiteCommand