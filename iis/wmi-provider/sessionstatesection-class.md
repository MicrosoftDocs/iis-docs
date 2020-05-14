---
title: "SessionStateSection Class"
ms.date: "10/07/2016"
ms.assetid: ad32bf4b-d28b-34d9-ef89-c28e34f8c8f5
---
# SessionStateSection Class
Configures the session state for a Web application.  
  
## Syntax  
  
```vbs  
class SessionStateSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `SessionStateSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|(Inherited from [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md).)|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `SessionStateSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AllowCustomSqlDatabase`|A read/write `boolean` value. `true` if the user is allowed to specify the initial catalog value in the `SqlConnectionString` property; otherwise, `false`. The default is `false`.|  
|`Cookieless`|A read/write `sint32` value that configures how cookies are used to identify client sessions. The possible values are listed later in the Remarks section. **Note:**  There are two ways that session state can store the unique ID that associates the client with a server session: by storing an HTTP cookie on the client or by encoding the session ID in the URL. Storing the session ID in the cookie is more secure, but it requires the client browser to support cookies. For applications that allow clients that do not support cookies, such as a variety of mobile devices, the session ID may be stored in the URL. The URL option has several drawbacks. It requires that the links on the site be relative and that the page be redirected at the beginning of the session with new query-string values. It also exposes the session ID in the query string, where it can be used in a security attack. You should use the cookieless mode only if you need to support clients that lack cookie support.|  
|`CookieName`|A read/write `string` value that specifies the name of the HTTP cookie to use for session identification. The default is "ASP.NET_SessionId".|  
|`CustomProvider`|A read/write `string` value that specifies the name of a custom provider from the `Providers` property that is used when the `Mode` property is set to `Custom`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Mode`|A read/write `sint32` value that specifies where to store the session state. The possible values are listed later in the Remarks section. **Note:**  The `Mode` property is not required and can be inherited from a higher level in the configuration hierarchy or from the default value. However, the configuration handler will always write out the mode based on the current inherited value for the section.|  
|`PartitionResolverType`|A read/write `string` value that contains the fully qualified name of the resolver type that partitions session-state data across multiple backend nodes when the `Mode` property is set to `SQLServer` or `StateServer`. **Note:**  If this property is specified, the `SqlConnectionString` and `StateConnectionString` properties are ignored. The connection string returned by `PartitionResolverType` will be used on every request to connect to the appropriate server location for the remainder of the request. If the connection string is not valid, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] will throw the same exception that is thrown when the configured connection string to the server is not valid.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Providers`|A [ProviderSettings](../wmi-provider/providersettings-class.md) value that contains the name and type of providers that perform session-state-related services.|  
|`RegenerateExpiredSessionId`|A read/write `boolean` value. `true` if the session ID is regenerated when an expired session ID is specified by the client; otherwise, `false`. The default is `false`. **Note:**  By default, only cookieless URLs are reissued when this property is enabled.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`SessionIDManagerType`|A read/write `string` value that specifies the fully qualified type of the session ID manager.|  
|`SqlCommandTimeout`|A read/write `datetime` value that specifies the time-out for SQL commands that use the SQL Server session-state mode. The default is 30 seconds.|  
|`SqlConnectionString`|A read/write `string` value that contains the connection string to a SQL Server. The default is "data source=localhost;Integrated Security=SSPI". This property is required when the `Mode` property is set to `SQLServer`.|  
|`StateConnectionString`|A read/write `string` value that specifies the server name and port when the session state is stored remotely. The default is "tcpip=loopback:42424". This property is required when the `Mode` property is set to `StateServer`. **Note:**  Make sure the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] state service is running on the remote server that stores the session-state information. This service is installed with [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and is located by default at *[drive:]*\WINDOWS\Microsoft.NET\Framework\\*VersionNumber*\aspnet_state.exe. By default, this service is configured for manual start. You must change the start behavior to Automatic.|  
|`StateNetworkTimeout`|A read/write `datetime` value that specifies the time, in seconds, that the network connection between the Web server and the state server can remain idle before the session is abandoned. This property is required when the `Mode` property is set to `StateServer`. The default is 10 seconds.|  
|`Timeout`|A read/write `datetime` value that specifies the time, in minutes, after which the session will expire due to inactivity. The default is 20 minutes. **Note:**  You cannot set the `Timeout` property to a value greater than 525,601 minutes (1 year).|  
|`UseHostingIdentity`|A read/write `boolean` value. `true` if Windows authentication and the host process identity (either [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] or a Windows Service identity) are enabled for remote connections; `false` if the session state uses client impersonation when it is available. The default is `true`. **Note:**  This setting simplifies the management of Integrated Windows authentication by granting database access only to the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] worker process or application identity and not to the entire domain or a set of domain users.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 When a new client begins interacting with a Web application, a session ID is issued and associated with all the subsequent requests from the same client during the time the session is valid. This ID is used to maintain server-side state associated with the client session across requests. The `SessionStateSection` class controls how the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application establishes and maintains this association on behalf of each client.  
  
 The following table lists the possible values for the `Cookieless` property. The default is 1 (`UseCookies`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`UseUri`|The session ID is embedded as a query string in the Uniform Resource Identifier (URI) request, and the URI is redirected to the originally requested URL. The changed URI request is used for the duration of the session, so no cookie is necessary. **Note:**  When you use the `UseUri` mode, you should set the `RegenerateExpiredSessionId` property to `true`. This allows a Web server to expire and regenerate tokens, which gives a potential attacker less time to capture a cookie and gain access to Web server content. You should also consider changing the `Timeout` property to less than the 20-minute default.|  
|1|`UseCookies`|The session ID is stored in an HTTP cookie on the client for the duration of a user's connection to a Web site. Cookies are passed in the HTTP headers of all requests between a client and Web server and are more efficient in tracking session state because they do not require redirection. Additionally, they retain state if a user leaves a site to visit another and then returns to the original site. **Note:**  Consider changing the `Timeout` property to less than the 20-minute default so that a potential attacker has less time to capture a cookie and gain access to Web site content.|  
|2|`AutoDetect`|The session ID is stored in an HTTP cookie on the client only after a handshake with the browser verifies that a cookie may be stored. **Note:**  When you use the `AutoDetect` mode, you should set the `RegenerateExpiredSessionId` property to `true`. This allows a Web server to expire and regenerate tokens, which gives a potential attacker less time to capture a cookie and gain access to Web server content. You should also consider changing the `Timeout` property to less than the 20-minute default.|  
|3|`UseDeviceProfile`|The session ID is stored in an HTTP cookie on the client if the client device profile supports cookies; otherwise, no cookies are used. If the device profile supports cookies, they will be used even if the user has disabled cookie support. Use this setting to ensure that cookieless IDs will be used only with clients that require them (for example, mobile browsers). **Note:**  When you use the `UseDeviceProfile` mode, you should set the `RegenerateExpiredSessionId` property to `true`. This allows a Web server to expire and regenerate tokens, which gives a potential attacker less time to capture a cookie and gain access to Web server content. You should also consider changing the `Timeout` property to less than the 20-minute default.|  
  
 The following table lists the possible values for the `Mode` property. The default is 1 (`InProc`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Off`|Session state is disabled.|  
|1|`InProc`|Session state is stored for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application in the worker process where the application runs.<br /><br /> In-process session state is the fastest built-in state storage mode. However, as you store more data in a session, you consume more Web server memory, which can slow performance.<br /><br /> In-process session-state data is lost if the worker process recycles. If your [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications need to preserve session-state data, and speed of data access is not a primary concern, consider using an out-of-process session-state mode for storing the data.<br /><br /> In-process session state cannot be used in a Web farm without a session ID affinity scheme that guarantees that all requests with a given session ID will be directed to the same Web server. **Note:**  The [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] state service (Aspnet_state.exe) must be running for in-process session state to function. This service is installed with [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and is located by default at *[drive:]*\WINDOWS\Microsoft.NET\Framework\\*VersionNumber*\aspnet_state.exe. By default, this service is configured for manual start. You must change the start behavior to Automatic.|  
|2|`StateServer`|Session state uses the out-of-process [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] state service to store state information. The advantage of this configuration is that session state is preserved when the application's worker process recycles. If you use this setting, you must specify a connection string in the `StateConnectionString` property.|  
|3|`SQLServer`|Session state uses an out-of-process SQL Server database to store state information. The advantage of this configuration is that session state is preserved when the application's worker process recycles, or if either the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] state service or the Web server goes down. If you use this setting, you must specify a connection string in the `SqlConnectionString` property. **Note:**  To use the `SQLServe`r session-state mode, you must run the InstallSqlState.sql SQL script (which is installed in *[drive:]*\WINDOWS\Microsoft.NET\Framework\\*VersionNumber* as part of the default [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] installation) on the computer running SQL Server that will store the session state. This creates a database called ASPState with new stored procedures and creates new ASPStateTempApplications and ASPStateTempSessions tables in the TempDB database.|  
|4|`Custom`|Session state uses a custom data store to store session-state information. If you use this setting, you must specify the name of the custom provider in the `CustomProvider` property.|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `SessionStateSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.SystemWebSectionGroup.SessionState](/dotnet/api/system.web.configuration.systemwebsectiongroup.sessionstate#System_Web_Configuration_SystemWebSectionGroup_SessionState)
 [System.Web.SessionState.SessionStateMode](/dotnet/api/system.web.sessionstate.sessionstatemode)
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)
 [ProviderSettings Class](../wmi-provider/providersettings-class.md)
 [Fast, Scalable, and Secure Session State Management for Your Web Applications](https://go.microsoft.com/fwlink/?LinkId=69309)
