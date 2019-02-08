---
title: "EmbeddedObject Class1 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0cca8529-7424-62d9-301c-e3c44fd1cd4b
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# EmbeddedObject Class1
Serves as a base type for embedded objects.  
  
## Syntax  
  
```vbs  
class EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 This class contains no properties.  
  
## Subclasses  
 The following table lists the subclasses exposed by the `EmbeddedObject` class.  
  
|Name|Description|  
|----------|-----------------|  
|[ApplicationElementDefaults](../wmi-provider/applicationelementdefaults-class.md)|Specifies the default application pool and enabled protocols for new applications.|  
|[ApplicationPoolElementDefaults](../wmi-provider/applicationpoolelementdefaults-class.md)|Contains the default properties for the [ApplicationPool](../wmi-provider/applicationpool-class.md) class.|  
|[ApplicationPoolFailureSettings](../wmi-provider/applicationpoolfailuresettings-class.md)|Exposes properties that determine the actions to be taken when an application pool or worker process fails.|  
|[ApplicationPoolProcessorSettings](../wmi-provider/applicationpoolprocessorsettings-class.md)|Configures the CPU settings for an application pool.|  
|[AspCache](../wmi-provider/aspcache-class.md)|Configures properties related to ASP caching.|  
|[AspComPlus](../wmi-provider/aspcomplus-class.md)|Exposes properties related to COM+.|  
|[AspLimits](../wmi-provider/asplimits-class.md)|Configures properties related to ASP limits.|  
|[AspSession](../wmi-provider/aspsession-class.md)|Configures properties related to ASP sessions.|  
|[AssemblySettings](../wmi-provider/assemblysettings-class.md)|Contains assembly references that are used during compilation of an ASP.NET Web application.|  
|[AssertSettings](../wmi-provider/assertsettings-class.md)|Specifies the user-interface mode for the [System.Diagnostics.Debug.Assert](http://go.microsoft.com/fwlink/?LinkId=70960) method and the name of a message log file.|  
|[AuthenticationProviderSettings](../wmi-provider/authenticationprovidersettings-class.md)|Contains security support providers that are used for Integrated Windows authentication.|  
|[BufferModeSettings](../wmi-provider/buffermodesettings-class.md)|Contains ASP.NET event-buffering settings for event providers.|  
|[BuildProviderSettings](../wmi-provider/buildprovidersettings-class.md)|Contains build providers that compile custom resource files of a particular file type and generate code during compilation.|  
|[BypassListSettings](../wmi-provider/bypasslistsettings-class.md)|Contains address information for resources that bypass the Web proxy server.|  
|[CachingProfileSettings](../wmi-provider/cachingprofilesettings-class.md)|Contains profiles for output and kernel caching.|  
|[CentralBinaryLogFile](../wmi-provider/centralbinarylogfile-class.md)|Configures settings for centralized binary logging on a server.|  
|[CentralW3CLogFile](../wmi-provider/centralw3clogfile-class.md)|Configures settings for World Wide Web Consortium (W3C) centralized logging on a server.|  
|[CompilerSettings](../wmi-provider/compilersettings-class.md)|Contains compilers that are used for Web applications.|  
|[ConformanceWarningSettings](../wmi-provider/conformancewarningsettings-class.md)|Contains Web Services Interoperability (WS-I) conformance declarations.|  
|[CustomHeaderSettings](../wmi-provider/customheadersettings-class.md)|Contains name/value pairs that are added to the HTTP headers in responses from the Web server.|  
|[DbProviderFactorySettings](../wmi-provider/dbproviderfactorysettings-class.md)|Contains configuration settings for ADO.NET 2.0 provider factories.|  
|[DiagnosticsSettings](../wmi-provider/diagnosticssettings-class.md)|Specifies whether a Web service returns exceptions to the client.|  
|[DirectorySettings](../wmi-provider/directorysettings-class.md)|Specifies code subdirectories for ASP.NET Web applications.|  
|[DynamicTypeSettings](../wmi-provider/dynamictypesettings-class.md)|Specifies the MIME types that IIS serves with dynamic compression.|  
|[EventMappingSettings](../wmi-provider/eventmappingsettings-class.md)|Contains mappings of friendly event names to related event types.|  
|[ExpressionBuilderSettings](../wmi-provider/expressionbuildersettings-class.md)|Contains resource strings that associate prefixes with expression builder types during compilation.|  
|[FailureDefinition](../wmi-provider/failuredefinition-class.md)|Specifies the conditions under which a request trace is generated.|  
|[FileExtensionsSettings](../wmi-provider/fileextensionssettings-class.md)|Configures the filtering of file extensions in requests.|  
|[FileSettings](../wmi-provider/filesettings-class.md)|Contains Web page file names to serve to clients by default.|  
|[FormsAuthenticationConfiguration](../wmi-provider/formsauthenticationconfiguration-class.md)|Configures Forms authentication for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application.|  
|[FormsAuthenticationCredentials](../wmi-provider/formsauthenticationcredentials-class.md)|Configures user credentials for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications that use Forms authentication.|  
|[FtpCachePolicySettings](../wmi-provider/ftpcachepolicysettings-class.md)|Represents the default FTP cache policy for network resources.|  
|[HeaderLimitsSettings](../wmi-provider/headerlimitssettings-class.md)|Specifies permitted sizes for HTTP request headers.|  
|[HiddenSegmentSettings](../wmi-provider/hiddensegmentsettings-class.md)|Contains segments whose content will not be served to the client.|  
|[HttpCachePolicySettings](../wmi-provider/httpcachepolicysettings-class.md)|Represents the default HTTP cache policy for network resources.|  
|[HttpClientCache](../wmi-provider/httpclientcache-class.md)|Exposes the caching configuration for an HTTP client.|  
|[HttpWebRequestSettings](../wmi-provider/httpwebrequestsettings-class.md)|Configures the maximum length for response headers.|  
|[Ipv6Settings](../wmi-provider/ipv6settings-class.md)|Determines whether Internet Protocol version 6 (IPv6) is enabled on the local computer.|  
|[ListenerSettings](../wmi-provider/listenersettings-class.md)|Contains shared listeners that any source or trace element can reference.|  
|[ManyToOneCertificateRuleSettings](../wmi-provider/manytoonecertificaterulesettings-class.md)|Contains many-to-one certificate mapping rules.|  
|[ManyToOneSettings](../wmi-provider/manytoonesettings-class.md)|Specifies many-to-one client certificate mappings.|  
|[ModuleSettings](../wmi-provider/modulesettings-class.md)|Represents the type information for a custom [System.Net.IWebProxy](http://go.microsoft.com/fwlink/?LinkId=70961) module.|  
|[NamespaceInfo](../wmi-provider/namespaceinfo-class.md)|Contains namespace references similar to the `Import` directive.|  
|[OneToOneSettings](../wmi-provider/onetoonesettings-class.md)|Contains one-to-one client certificate mappings.|  
|[OutputCacheProfileSettings](../wmi-provider/outputcacheprofilesettings-class.md)|Contains values that configure output cache profiles for the pages of a Web application.|  
|[PassportAuthentication](../wmi-provider/passportauthentication-class.md)|Configures Microsoft Passport Network authentication in [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications.|  
|[PerformanceCounterSettings](../wmi-provider/performancecountersettings-class.md)|Specifies the size of the global memory shared by performance counters.|  
|[PerformanceCountersSettings](../wmi-provider/performancecounterssettings-class.md)|Determines whether performance counters are enabled.|  
|[PeriodicRestartSettings](../wmi-provider/periodicrestartsettings-class.md)|Specifies the conditions under which worker processes will be recycled.|  
|[ProcessModelSettings](../wmi-provider/processmodelsettings-class.md)|Exposes configuration settings for IIS worker processes.|  
|[ProfileSettings](../wmi-provider/profilesettings-class.md)|Configures an event profile that determines how an event is collected by ASP.NET and raised to providers.|  
|[ProviderSettings](../wmi-provider/providersettings-class.md)|Specifies the name and type of ASP.NET-related providers.|  
|[ProvidersSettings](../wmi-provider/providerssettings-class.md)|Specifies managed providers that manage membership or roles for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application, or encrypt and decrypt configuration data.|  
|[ProxySettings](../wmi-provider/proxysettings-class.md)|Contains configuration settings for a Web proxy server.|  
|[RecyclingSettings](../wmi-provider/recyclingsettings-class.md)|Specifies recycling settings for worker processes.|  
|[RedirectHeaderSettings](../wmi-provider/redirectheadersettings-class.md)|Contains redirect name/value pairs that are added to the HTTP headers in responses from the Web server.|  
|[RequestLimitsElement](../wmi-provider/requestlimitselement-class.md)|Specifies size limits on incoming HTTP requests.|  
|[RuleSettings](../wmi-provider/rulesettings-class.md)|Maps Web events to health-monitoring providers.|  
|[ScheduleElement](../wmi-provider/scheduleelement-class.md)|Specifies the local time at which an application will be recycled.|  
|[SectionInformation](../wmi-provider/sectioninformation-class.md)|Specifies override-mode and control-locking settings for a configuration section.|  
|[ServiceDescriptionFormatSettings](../wmi-provider/servicedescriptionformatsettings-class.md)|Contains Web service description information.|  
|[ServicePointManagerSettings](../wmi-provider/servicepointmanagersettings-class.md)|Represents the default settings used to create connections to a remote computer.|  
|[SiteElementDefaults](../wmi-provider/siteelementdefaults-class.md)|Contains the default values for IIS Web site properties.|  
|[SiteLimits](../wmi-provider/sitelimits-class.md)|Exposes connection-related limits for a site.|  
|[SiteLogFile](../wmi-provider/sitelogfile-class.md)|Configures logging for a Web site.|  
|[SmtpNetworkSettings](../wmi-provider/smtpnetworksettings-class.md)|Configures Simple Mail Transfer Protocol (SMTP) network settings.|  
|[SmtpSpecifiedPickupDirectorySettings](../wmi-provider/smtpspecifiedpickupdirectorysettings-class.md)|Configures a Simple Mail Transfer Protocol (SMTP) pickup directory.|  
|[SoapEnvelopeProcessingInfo](../wmi-provider/soapenvelopeprocessinginfo-class.md)|Configures a time-out that helps mitigate denial of service attacks.|  
|[SoapExtensionImporterTypesSettings](../wmi-provider/soapextensionimportertypessettings-class.md)|Contains SOAP extension information that is used to create a Web service proxy class.|  
|[SoapExtensionReflectorTypesSettings](../wmi-provider/soapextensionreflectortypessettings-class.md)|Contains SOAP extension information for Web services.|  
|[SoapExtensionTypesInfo](../wmi-provider/soapextensiontypesinfo-class.md)|Specifies SOAP extensions that inspect or modify SOAP messages.|  
|[SoapServerProtocolFactory](../wmi-provider/soapserverprotocolfactory-class.md)|Specifies the type of a class that processes XML Web service requests.|  
|[SoapTransportImporterTypesInfo](../wmi-provider/soaptransportimportertypesinfo-class.md)|Contains types that import SOAP transmission protocols into XML Web services.|  
|[SocketSettings](../wmi-provider/socketsettings-class.md)|Specifies whether completion ports are used for connecting and accepting connections.|  
|[SourceListenerSettings](../wmi-provider/sourcelistenersettings-class.md)|Contains listeners that monitor and format trace output.|  
|[SourceSettings](../wmi-provider/sourcesettings-class.md)|Contains trace sources that initiate tracing messages.|  
|[SqlCacheDependencyDatabaseSettings](../wmi-provider/sqlcachedependencydatabasesettings-class.md)|Contains configuration settings for SQL data in an ASP.NET cache.|  
|[StaticTypeSettings](../wmi-provider/statictypesettings-class.md)|Specifies the MIME types that IIS serves with static compression.|  
|[SwitchSettings](../wmi-provider/switchsettings-class.md)|Contains switch names and their managed types.|  
|[TagMapInfo](../wmi-provider/tagmapinfo-class.md)|Contains statements that remap tag types.|  
|[TagPrefixInfo](../wmi-provider/tagprefixinfo-class.md)|Contains configuration information for custom and user controls.|  
|[TraceAreaSettings](../wmi-provider/traceareasettings-class.md)|Contains trace areas that configure trace events and trace log file entries.|  
|[TraceFailedRequestsLogging](../wmi-provider/tracefailedrequestslogging-class.md)|Configures the trace logging of failed requests for a Web site.|  
|[TraceListenerSettings](../wmi-provider/tracelistenersettings-class.md)|Contains listeners that monitor trace output and produce formatted output from it.|  
|[TraceSettings](../wmi-provider/tracesettings-class.md)|Configures the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] trace functionality and controls how trace results are gathered, stored, and displayed.|  
|[TraceUrlAreaSettings](../wmi-provider/traceurlareasettings-class.md)|Contains criteria for generating trace events and configuring the content of log file entries.|  
|[TraceUrlSettings](../wmi-provider/traceurlsettings-class.md)|Specifies tracing for specific types of requests.|  
|[TypedElement](../wmi-provider/typedelement-class.md)|Defines a filter for a trace listener.|  
|[UrlSequenceSettings](../wmi-provider/urlsequencesettings-class.md)|Contains URL sequences that request filtering will deny.|  
|[VerbsSettings](../wmi-provider/verbssettings-class.md)|Exposes configuration settings for HTTP verbs.|  
|[VirtualDirectoryElementDefaults](../wmi-provider/virtualdirectoryelementdefaults-class.md)|Exposes default configuration settings for IIS virtual directories.|  
|[WebProxyScriptSettings](../wmi-provider/webproxyscriptsettings-class.md)|Configures Web proxy scripts.|  
|[WebServicesProtocolSettings](../wmi-provider/webservicesprotocolsettings-class.md)|Specifies protocols that decrypt data sent from a client browser in an HTTP request.|  
|[WsdlHelpGeneratorInfo](../wmi-provider/wsdlhelpgeneratorinfo-class.md)|Specifies the XML Web service Help page (an .aspx file) that is displayed to a browser when the browser navigates directly to an .asmx (XML Web services) page.|  
  
## Remarks  
 This class groups embedded objects conveniently under one base type.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [WMI Provider](../wmi-provider/wmi-provider.md)   
 [ConfiguredObject Class](../wmi-provider/configuredobject-class.md)   
 [Object Class](../wmi-provider/object-class.md)   
 [ObjectConfigurationAssociation Class](../wmi-provider/objectconfigurationassociation-class.md)   
 [ObjectContainerAssociation Class](../wmi-provider/objectcontainerassociation-class.md)