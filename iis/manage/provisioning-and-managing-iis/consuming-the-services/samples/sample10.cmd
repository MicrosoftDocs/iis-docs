WebProvisioningServiceClient client = new WebProvisioningServiceClient();
try
{
  BindingInfo binding = new BindingInfo();
  binding.Protocol ="http"; 
  binding.IPAddress ="*"; //all ip addresses
  binding.TCPPort = 80;
  binding.HostHeader ="www.contoso.com";
  WebSiteProvisioningRequest request = new WebSiteProvisioningRequest();
  request.SiteName ="www.contoso.com";
  request.DomainName =string.Empty;
  request.UserName ="Testuser";
  request.Password ="pass@word1";
  request.ContentPath = @"c:\contents\";
  request.UserDefaultContentStructure = false;
  request.PhysicalRootPath = @"c:\contents\www.contoso.com";
  request.LogPath = @"c:\contents\www.contoso.com\logs";
  request.FaultRequestsLoggingPath = c:\contents\www.contoso.com\logs\FailedRequestLogs";
  request.Binding = binding;
  request.CreateNewApplicationPool = true;
  request.ApplicationPoolName = "TestAppPool";
  request.StartSite = true;
  request.SiteId = 0;
  if (client.CreateWebSite(request))
  this.lblResult.Text = "Web Site: " + request.SiteName + " has been successfully created.";
  client.Close();
}
catch (FaultException<HostingServiceFault> ex)
{
  this.lblResult.Text = "FaultException<HostingServiceException>: Hosting service fault while doing " + 
  ex.Detail.Operation + ". Error: " + ex.Detail.ErrorMessage;
  client.Abort();
}
  catch (FaultException ex)
{
  this.lblResult.Text = "Add Web Site Failed with unknown faultexception: " + e.GetType().Name + " - " + ex.Message;
  client.Abort();
}
  catch (Exception ex)
{
  this.lblResult.Text = "Failed with exception: " + ex.GetType().Name + " - " + ex.Message;
  client.Abort();
}