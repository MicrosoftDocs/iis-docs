WebProvisioningServiceClient.CreateWebSite(WebSiteProvisioningRequest request)
WebSiteProvisioningRequest exists in the Microsoft.Hosting.Web.Client.WebManagement.DataContract namespace. It is shown below.
public class WebSiteProvisioningRequest
public class WebSiteProvisioningRequest
{
      #region Fields
        private long _siteId;
        private string _siteName;
        private string _domainName;
        private string _userName;
        private string _password;
        private string _contentPath;
        private bool _useDefaultContentStructure;
        private string _physicalRootPath; 
        private string _logPath;
        private string _faultRequestsLoggingPath;
        private bool _createNewApplicationPool;
        private string _applicationPoolName;
        private bool _startSite;
        private BindingInfo _bindingInfo;
        //give the option for specifing to use an existing application pool or to create a new          application pool
      #endregion 
     }