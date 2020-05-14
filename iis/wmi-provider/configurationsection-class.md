---
title: "ConfigurationSection Class1"
ms.date: "10/07/2016"
ms.assetid: 7b785db0-a6d8-5278-b524-bdcfc0463613
---
# ConfigurationSection Class1
Serves as a base class for classes that represent configuration sections.  
  
## Syntax  
  
```vbs  
class ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `ConfigurationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|Retrieves the `allowDefinition` attribute for a configuration section.|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|Retrieves the `allowLocation` attribute for a configuration section.|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|Reverts configuration values in a section to those of its parent section.|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|Sets the `allowDefinition` attribute for a configuration section.|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|Sets the `allowLocation` attribute for a configuration section.|  
  
## Properties  
 The following table lists the properties exposed by the `ConfigurationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Location`|A read-only `string` value that contains the path to a target object relative to the current object. For example, in the object path "MACHINE/WEBROOT/APPHOST/MYSITE/APP/", the `Location` property would contain "MYSITE/APP/". A key property.|  
|`Path`|A read-only `string` value that contains the path to the current object. For example, in the object path "MACHINE/WEBROOT/APPHOST/MYSITE/APP/", the `Path` property would contain "MACHINE/WEBROOT/APPHOST/". A key property.|  
|`SectionInformation`|A [SectionInformation](../wmi-provider/sectioninformation-class.md) object whose read/write properties provide metadata and control locking for a configuration section.|  
  
## Subclasses  
 The following table lists the subclasses exposed by the `ConfigurationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[AccessSection](../wmi-provider/accesssection-class.md)|Specifies access permissions to content protected by Secure Sockets Layer (SSL).|  
|[AnonymousAuthenticationSection](../wmi-provider/anonymousauthenticationsection-class.md)|Configures Anonymous authentication.|  
|[AnonymousIdentificationSection](../wmi-provider/anonymousidentificationsection-class.md)|Specifies how cookies are used in a Web application.|  
|[AspSection](../wmi-provider/aspsection-class.md)|Exposes Active Server Pages (ASP) configuration settings for ASP applications.|  
|[BasicAuthenticationSection](../wmi-provider/basicauthenticationsection-class.md)|Configures Basic authentication.|  
|[CacheSection](../wmi-provider/cachesection-class.md)|Defines cache settings for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] Web application.|  
|[CgiSection](../wmi-provider/cgisection-class.md)|Configures Common Gateway Interface (CGI) settings.|  
|[ClientCertificateMappingAuthenticationSection](../wmi-provider/clientcertificatemappingauthenticationsection-class.md)|Enables or disables client certificate mapping authentication.|  
|[ConfigurationHistorySection](../wmi-provider/configurationhistorysection-class.md)|Configures the configuration history settings of the ApplicationHost Helper Service.|  
|[ConfigurationRedirectionSection](../wmi-provider/configurationredirectionsection-class.md)|Configures the location of the ApplicationHost.config and Administration.config files.|  
|[ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)|Serves as a base class for configuration-section classes that contain collections.|  
|[DateTimeSerializationSection](../wmi-provider/datetimeserializationsection-class.md)|Handles configuration settings for XML serialization of [System.DateTime](https://go.microsoft.com/fwlink/?LinkId=70919) instances.|  
|[DigestAuthenticationSection](../wmi-provider/digestauthenticationsection-class.md)|Configures Digest authentication.|  
|[DirectoryBrowseSection](../wmi-provider/directorybrowsesection-class.md)|Configures directory browsing in IIS.|  
|[GlobalizationSection](../wmi-provider/globalizationsection-class.md)|Configures the globalization settings for a Web application.|  
|[HostingEnvironmentSection](../wmi-provider/hostingenvironmentsection-class.md)|Defines configuration settings that control the behavior of the application hosting environment.|  
|[HttpCookiesSection](../wmi-provider/httpcookiessection-class.md)|Configures properties for cookies used by a Web application.|  
|[HttpLoggingSection](../wmi-provider/httploggingsection-class.md)|Configures the logging of HTTP requests.|  
|[HttpRuntimeSection](../wmi-provider/httpruntimesection-class.md)|Configures [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] HTTP run-time settings that determine how a request is processed for a given [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application.|  
|[IdentitySection](../wmi-provider/identitysection-class.md)|Specifies whether an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application should run as the application pool identity (the default), the IIS-authenticated user identity, or a custom configured identity.|  
|[LogSection](../wmi-provider/logsection-class.md)|Configures the logging for a server or site.|  
|[MachineKeySection](../wmi-provider/machinekeysection-class.md)|Defines the configuration settings that control the key generation and algorithms that are used in encryption, decryption, and media access control (MAC) operations in Forms authentication, view-state validation, and session-state application isolation.|  
|[OdbcLoggingSection](../wmi-provider/odbcloggingsection-class.md)|Specifies configuration settings for logging IIS events to a database through an Open Database Connectivity (ODBC) connection.|  
|[OutputCacheSection](../wmi-provider/outputcachesection-class.md)|Specifies output cache settings for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application.|  
|[ProcessModelSection](../wmi-provider/processmodelsection-class.md)|Configures the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] process model settings on a Web server that is running IIS.|  
|[RequestCachingSection](../wmi-provider/requestcachingsection-class.md)|Contains configuration information for request caching.|  
|[ServerRuntimeSection](../wmi-provider/serverruntimesection-class.md)|Configures request limits for applications on a Web server.|  
|[ServerSideIncludeSection](../wmi-provider/serversideincludesection-class.md)|Configures server-side includes (SSI) directives.|  
|[SessionPageStateSection](../wmi-provider/sessionpagestatesection-class.md)|Configures page view-state settings for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application.|  
|[SettingsSection](../wmi-provider/settingssection-class.md)|Contains settings that specify how the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] connects to the network.|  
|[SmtpMailSettingsSection](../wmi-provider/smtpmailsettingssection-class.md)|Contains Simple Mail Transfer Protocol (SMTP) configuration settings.|  
|[SystemWebDeploymentSection](../wmi-provider/systemwebdeploymentsection-class.md)|Defines configuration settings that support the deployment of a Web application.|  
|[SystemWindowsFormsSection](../wmi-provider/systemwindowsformssection-class.md)|Stores application settings for Windows Forms applications.|  
|[TraceSection](../wmi-provider/tracesection-class.md)|Configures the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] code-tracing service.|  
|[TransactionsDefaultSettingsSection](../wmi-provider/transactionsdefaultsettingssection-class.md)|Contains default settings for transactions.|  
|[TransactionsMachineSettingsSection](../wmi-provider/transactionsmachinesettingssection-class.md)|Represents an XML section in a configuration file that contains settings that can be modified only at the computer level.|  
|[TrustSection](../wmi-provider/trustsection-class.md)|Configures the level of code-access security that is applied to an application.|  
|[UrlCompressionSection](../wmi-provider/urlcompressionsection-class.md)|Enables or disables dynamic or static compression.|  
|[ValidationSection](../wmi-provider/validationsection-class.md)|Enables or disables validation checks on configuration files.|  
|[WebControlsSection](../wmi-provider/webcontrolssection-class.md)|Specifies the shared location of client script files.|  
|[WebLimitsSection](../wmi-provider/weblimitssection-class.md)|Specifies limits on client traffic to a Web server.|  
|[XhtmlConformanceSection](../wmi-provider/xhtmlconformancesection-class.md)|Specifies the XHTML rendering mode for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications.|  
|[XmlSerializerSection](../wmi-provider/xmlserializersection-class.md)|Handles the XML elements used to configure XML serialization.|  
  
## Remarks  
 The association classes that derive from the [ObjectConfigurationAssociation](../wmi-provider/objectconfigurationassociation-class.md) class use the `ConfigurationSection` class to link objects to configuration sections.  
  
 All classes that derive from `ConfigurationSection` inherit the `Location`, `Path`, and `SectionInformation` properties. `Location` and `Path` are key properties for all subclasses of `ConfigurationSection`.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [WMI Provider](../wmi-provider/wmi-provider.md)
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)
 [ObjectConfigurationAssociation Class](../wmi-provider/objectconfigurationassociation-class.md)
 [SectionInformation Class](../wmi-provider/sectioninformation-class.md)
