---
title: "ConfigurationSectionWithCollection Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b0963c4c-d99f-2f45-3532-ab003df8db2c
caps.latest.revision: 31
author: "shirhatti"
manager: "wpickett"
---
# ConfigurationSectionWithCollection Class
Serves as a base class for configuration-section classes that contain collections.  
  
## Syntax  
  
```vbs  
class ConfigurationSectionWithCollection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `ConfigurationSectionWithCollection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|Adds an element to a collection in a configuration section.|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|Clears all elements from a collection in a configuration section.|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|Retrieves the specified member of a collection from a configuration section.|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|Removes the specified element from a collection in a configuration section.|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `ConfigurationSectionWithCollection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 The following table lists the subclasses exposed by the `ConfigurationSectionWithCollection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[ApplicationDependenciesSection](../wmi-provider/applicationdependenciessection-class.md)|Exposes application dependency information.|  
|[AppSettingsSection](../wmi-provider/appsettingssection-class.md)|Contains custom application settings, such as file paths, XML Web service URLs, or information that is stored in the .ini file for an application.|  
|[AuthenticationModulesSection](../wmi-provider/authenticationmodulessection-class.md)|Specifies the authentication modules that conduct the authentication process with a server.|  
|[AuthenticationSection](../wmi-provider/authenticationsection-class.md)|Configures [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] authentication.|  
|[AuthorizationSection](../wmi-provider/authorizationsection-class.md)|Configures authorization for access to URLs.|  
|[CachingSection](../wmi-provider/cachingsection-class.md)|Configures output and kernel caching.|  
|[ClientTargetSection](../wmi-provider/clienttargetsection-class.md)|Specifies a collection of mappings between aliases and user agents.|  
|[CompilationSection](../wmi-provider/compilationsection-class.md)|Configures compilation settings for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications.|  
|[ConfigProtectedDataSection](../wmi-provider/configprotecteddatasection-class.md)|Contains protected configuration provider information.|  
|[ConnectionManagementSection](../wmi-provider/connectionmanagementsection-class.md)|Contains a collection that specifies the maximum number of connections to specified network hosts for System.Net APIs.|  
|[ConnectionStringsSection](../wmi-provider/connectionstringssection-class.md)|Specifies a collection of database connection strings for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications.|  
|[CustomErrorsSection](../wmi-provider/customerrorssection-class.md)|Configures [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] custom error messages.|  
|[DefaultDocumentSection](../wmi-provider/defaultdocumentsection-class.md)|Specifies the Web page file names to serve to clients by default.|  
|[DefaultProxySection](../wmi-provider/defaultproxysection-class.md)|Configures Web proxy server defaults.|  
|[DeviceFiltersSection](../wmi-provider/devicefilterssection-class.md)|Represents a collection of device filters that determine mobile device types or mobile browser capabilities.|  
|[FastCgiSection](../wmi-provider/fastcgisection-class.md)|Contains configuration settings for FastCGI applications.|  
|[GlobalModulesSection](../wmi-provider/globalmodulessection-class.md)|Exposes configuration settings for IIS global modules.|  
|[HandlersSection](../wmi-provider/handlerssection-class.md)|Stores the handlers for a URL.|  
|[HealthMonitoringSection](../wmi-provider/healthmonitoringsection-class.md)|Configures an application for health monitoring.|  
|[HttpCompressionSection](../wmi-provider/httpcompressionsection-class.md)|Configures HTTP compression.|  
|[HttpErrorsSection](../wmi-provider/httperrorssection-class.md)|Configures HTTP error handling for a Web server.|  
|[HttpHandlersSection](../wmi-provider/httphandlerssection-class.md)|Configures settings for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] handlers.|  
|[HttpModulesSection](../wmi-provider/httpmodulessection-class.md)|Contains [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] modules.|  
|[HttpProtocolSection](../wmi-provider/httpprotocolsection-class.md)|Represents an HTTP protocol configuration section.|  
|[HttpRedirectSection](../wmi-provider/httpredirectsection-class.md)|Configures HTTP redirection.|  
|[HttpTracingSection](../wmi-provider/httptracingsection-class.md)|Represents an HTTP tracing configuration section.|  
|[IisClientCertificateMappingAuthenticationSection](../wmi-provider/iisclientcertificatemappingauthenticationsection-class.md)|Configures mapping for IIS client certificates.|  
|[IPSecuritySection](../wmi-provider/ipsecuritysection-class.md)|Configures access to Web server content based on IP address-related information.|  
|[IsapiCgiRestrictionSection](../wmi-provider/isapicgirestrictionsection-class.md)|Configures ISAPI and Common Gateway Interface (CGI) restrictions for a Web server that runs in ISAPI mode.|  
|[IsapiFiltersSection](../wmi-provider/isapifilterssection-class.md)|Configures the ISAPI filters on a Web server.|  
|[ListenerAdaptersSection](../wmi-provider/listeneradapterssection-class.md)|Exposes a collection of listener adapters.|  
|[MembershipSection](../wmi-provider/membershipsection-class.md)|Validates user credentials and manages user settings.|  
|[MobileControlsSection](../wmi-provider/mobilecontrolssection-class.md)|Exposes configuration information for mobile controls, their adapters, and device filters.|  
|[ModulesSection](../wmi-provider/modulessection-class.md)|Represents the modules section in a configuration file.|  
|[OutputCacheSettingsSection](../wmi-provider/outputcachesettingssection-class.md)|Specifies the output-cache profile settings that can be applied to pages in an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application.|  
|[PagesSection](../wmi-provider/pagessection-class.md)|Represents the `<pages>` section of a Web.config file.|  
|[ProtocolsSection](../wmi-provider/protocolssection-class.md)|Contains a list of transmission protocols that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] can use to decrypt data sent from a client browser in the HTTP request.|  
|[RequestFilteringSection](../wmi-provider/requestfilteringsection-class.md)|Configures the scanning of incoming URL requests.|  
|[RoleManagerSection](../wmi-provider/rolemanagersection-class.md)|Defines configuration settings that are used to support the role management infrastructure of Web applications.|  
|[SchemaImporterExtensionsSection](../wmi-provider/schemaimporterextensionssection-class.md)|Contains a collection of extensions that map XML Schema (XSD) types to [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] types.|  
|[SecurityPolicySection](../wmi-provider/securitypolicysection-class.md)|Defines a collection of mappings between security policy files and their trust-level names.|  
|[SessionStateSection](../wmi-provider/sessionstatesection-class.md)|Configures the session state for a Web application.|  
|[SiteMapSection](../wmi-provider/sitemapsection-class.md)|Defines configuration settings for site navigation.|  
|[SqlCacheDependencySection](../wmi-provider/sqlcachedependencysection-class.md)|Represents a <xref:System.Web.Caching.SqlCacheDependency?displayProperty=fullName> configuration section.|  
|[StaticContentSection](../wmi-provider/staticcontentsection-class.md)|Exposes configuration settings for static content on a Web site.|  
|[SystemCodeDomSection](../wmi-provider/systemcodedomsection-class.md)|Specifies a collection of compilers that provide Code Document Object Model (CodeDOM) support.|  
|[SystemDataSection](../wmi-provider/systemdatasection-class.md)|Specifies a list of installed [!INCLUDE[vstecado](../wmi-provider/includes/vstecado-md.md)] data providers.|  
|[SystemDiagnosticsSection](../wmi-provider/systemdiagnosticssection-class.md)|Configures system diagnostics and tracing.|  
|[TraceFailedRequestsSection](../wmi-provider/tracefailedrequestssection-class.md)|Represents a failed-request tracing configuration section.|  
|[TraceProviderDefinitionsSection](../wmi-provider/traceproviderdefinitionssection-class.md)|Represents the configuration section that defines trace providers.|  
|[UrlMappingsSection](../wmi-provider/urlmappingssection-class.md)|Represents a `<urlMappings>` section that contains pairs of inbound/outbound URL mappings.|  
|[WebRequestModulesSection](../wmi-provider/webrequestmodulessection-class.md)|Contains a collection of registered Web request modules.|  
|[WebServicesSection](../wmi-provider/webservicessection-class.md)|Controls the behavior of XML Web services and their clients.|  
|[WindowsAuthenticationSection](../wmi-provider/windowsauthenticationsection-class.md)|Configures Integrated Windows authentication.|  
  
## Remarks  
 If you change a key property that is in a collection, the positional order (and index) of the property in the collection may change. The changed key property will be added to the beginning or end of the collection depending on the value of the `mergeAppend` attribute.  
  
> [!NOTE]
>  The `mergeAppend` attribute is in the appropriate schema file in the section that corresponds to the class property. If the `mergeAppend` attribute is `false`, new items are added to the beginning of the collection; if the `mergeAppend` attribute is `true`, new items are added to the end of the collection.  
  
 You should be careful how you access a key property in a collection after the key property's value has changed. For example, if you change the value of a key property whose index is 4, the new index for the key property will be 0 if the `mergeAppend` attribute is `false`.  
  
> [!NOTE]
>  You should be aware of this behavior when you create any custom schema and custom configuration files. You should not modify the `mergeAppend` attributes in the schema files that ship with [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)]. You cannot modify the `mergeAppend` attribute by using the WMI provider for [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)].  
  
 The `mergeAppend` attribute affects the following `ConfigurationSectionWithCollection` class properties that ship with [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)]. The table lists these properties and their corresponding schema files. In all these cases, the schema files that ship with [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] specify `false` for the `mergeAppend` attribute.  
  
|Class|Property|Schema file|  
|-----------|--------------|-----------------|  
|[AuthorizationSection](../wmi-provider/authorizationsection-class.md)|`Authorization`|ASPNET_Schema.xml|  
|[CachingSection](../wmi-provider/cachingsection-class.md)|`Profiles.Profiles`|IIS_Schema.xml|  
|[DefaultDocumentSection](../wmi-provider/defaultdocumentsection-class.md)|`Files.Files`|IIS_Schema.xml|  
|[HandlersSection](../wmi-provider/handlerssection-class.md)|`Handlers`|IIS_Schema.xml|  
|[HttpHandlersSection](../wmi-provider/httphandlerssection-class.md)|`HttpHandlers`|ASPNET_Schema.xml|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|Webadministration.mof|  
  
## See Also  
 [AuthorizationRule Class](../wmi-provider/authorizationrule-class.md)   
 [AuthorizationSection Class](../wmi-provider/authorizationsection-class.md)   
 [CachingProfileElement Class](../wmi-provider/cachingprofileelement-class.md)   
 [CachingProfileSettings Class](../wmi-provider/cachingprofilesettings-class.md)   
 [CachingSection Class](../wmi-provider/cachingsection-class.md)   
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [DefaultDocumentSection Class](../wmi-provider/defaultdocumentsection-class.md)   
 [FileSettings Class](../wmi-provider/filesettings-class.md)   
 [HandlerAction Class](../wmi-provider/handleraction-class.md)   
 [HandlersSection Class](../wmi-provider/handlerssection-class.md)   
 [HttpHandlerAction Class](../wmi-provider/httphandleraction-class.md)   
 [HttpHandlersSection Class](../wmi-provider/httphandlerssection-class.md)   
 [StringElement Class](../wmi-provider/stringelement-class.md)