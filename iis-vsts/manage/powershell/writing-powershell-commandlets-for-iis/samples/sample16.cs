public class SiteMethods
{
	static public void Start(PSObject site)
	{
		InvokeMethod(site, "Start");
	}
	static public void Stop(PSObject site)
	{
		InvokeMethod(site, "Stop");
	}

	static public string GetStatus(PSObject site)
	{
		uint status = (uint)InvokeMethod(site, "GetState");
		string statusName =
			status == 0 ? "Starting" :
			status == 1 ? "Started" :
			status == 2 ? "Stopping" :
			status == 3 ? "Stopped" : "Unknown";
		return statusName;
	}

	static private object InvokeMethod(PSObject site, string methodName)
	{
		string computerName = site.Properties["Computer"].Value as string;
		string siteName = site.Properties["Name"].Value as string;
		PSCredential credential = site.Properties["Credential"].Value as PSCredential;
		ConnectionOptions connection = new ConnectionOptions();
		connection.Username = credential.UserName;
		connection.Password = credential.GetNetworkCredential().Password;
		connection.Impersonation = ImpersonationLevel.Impersonate;
		connection.Authentication = AuthenticationLevel.PacketPrivacy;
		ManagementScope scope = new ManagementScope(
			"\\\\" + computerName + "\\root\\webadministration", connection);
		string sitePath = "Site.Name=\"" + siteName + "\"";
		ManagementObject wmiSite = new ManagementObject(
			scope, new ManagementPath(sitePath), new ObjectGetOptions());
		return wmiSite.InvokeMethod(methodName, new object[] { });
	}
}