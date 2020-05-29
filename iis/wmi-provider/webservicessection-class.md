---
title: "WebServicesSection Class"
ms.date: "10/07/2016"
ms.assetid: 5ab3a470-f3e2-9b55-dbc6-01b4e64b0d70
---
# WebServicesSection Class
Controls the behavior of XML Web services and their clients.  
  
## Syntax  
  
```vbs  
class WebServicesSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `WebServicesSection` class.  
  
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
 The following table lists the properties exposed by the `WebServicesSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ConformanceWarnings`|A [ConformanceWarningSettings](../wmi-provider/conformancewarningsettings-class.md) value that lists the WS-I (Web Services Interoperability Organization) profiles that are used to validate the Web services. **Note:**  Currently, the only WS-I profile supported in the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] is Basic Profile Version 1.1 (BasicProfile 1_1).|  
|`Diagnostics`|A [DiagnosticsSettings](../wmi-provider/diagnosticssettings-class.md) value that specifies whether to return exceptions to the client for debugging.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Protocols`|A [WebServicesProtocolSettings](../wmi-provider/webservicesprotocolsettings-class.md) value that specifies the transmission protocols that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] can use to decrypt data sent from a client browser in the HTTP request.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`ServiceDescriptionFormatExtensionTypes`|A [ServiceDescriptionFormatSettings](../wmi-provider/servicedescriptionformatsettings-class.md) value that specifies the service description format extensions to run in the scope of the configuration file.|  
|`SoapEnvelopeProcessing`|A [SoapEnvelopeProcessingInfo](../wmi-provider/soapenvelopeprocessinginfo-class.md) value that configures a time-out to help mitigate denial of service attacks.|  
|`SoapExtensionImporterTypes`|A [SoapExtensionImporterTypesSettings](../wmi-provider/soapextensionimportertypessettings-class.md) value that specifies the SOAP extensions to run when a service description for a Web service in the scope of the configuration file is accessed to create a proxy class.|  
|`SoapExtensionReflectorTypes`|A [SoapExtensionReflectorTypesSettings](../wmi-provider/soapextensionreflectortypessettings-class.md) value that specifies the SOAP extensions to run when a service description is generated for all Web services in the scope of the configuration file.|  
|`SoapExtensionTypes`|A [SoapExtensionTypesInfo](../wmi-provider/soapextensiontypesinfo-class.md) value that specifies the SOAP extensions to run with all Web services in the scope of the configuration file.|  
|`SoapServerProtocolFactory`|A [SoapServerProtocolFactory](../wmi-provider/soapserverprotocolfactory-class.md) value that sets a [System.Web.Services.Configuration.TypeElement](https://go.microsoft.com/fwlink/?LinkId=70958) object that corresponds to the protocol that is used to call the Web service.|  
|`SoapTransportImporterTypes`|A [SoapTransportImporterTypesInfo](../wmi-provider/soaptransportimportertypesinfo-class.md) value that contains  [SoapTransportImporterTypeElement](../wmi-provider/soaptransportimportertypeelement-class.md) instances that import SOAP transmission protocols into Web services.|  
|`WsdlHelpGenerator`|A [WsdlHelpGeneratorInfo](../wmi-provider/wsdlhelpgeneratorinfo-class.md) value that specifies the Web service Help page (an .aspx file) that is displayed to a browser when the user browses to an .asmx page.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `WebServicesSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.SystemWebSectionGroup.WebServices](/dotnet/api/system.web.configuration.scriptingwebservicessectiongroup)  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [ConformanceWarning Class](../wmi-provider/conformancewarning-class.md)   
 [ConformanceWarningSettings Class](../wmi-provider/conformancewarningsettings-class.md)   
 [DiagnosticsSettings Class](../wmi-provider/diagnosticssettings-class.md)   
 [ServiceDescriptionFormatSettings Class](../wmi-provider/servicedescriptionformatsettings-class.md)   
 [SoapEnvelopeProcessingInfo Class](../wmi-provider/soapenvelopeprocessinginfo-class.md)   
 [SoapExtensionImporterTypesSettings Class](../wmi-provider/soapextensionimportertypessettings-class.md)   
 [SoapExtensionReflectorTypesSettings Class](../wmi-provider/soapextensionreflectortypessettings-class.md)   
 [SoapExtensionTypesInfo Class](../wmi-provider/soapextensiontypesinfo-class.md)   
 [SoapServerProtocolFactory Class](../wmi-provider/soapserverprotocolfactory-class.md)   
 [SoapTransportImporterTypeElement Class](../wmi-provider/soaptransportimportertypeelement-class.md)   
 [SoapTransportImporterTypesInfo Class](../wmi-provider/soaptransportimportertypesinfo-class.md)   
 [TypeElement Class](../wmi-provider/typeelement-class.md)   
 [WebServicesProtocolSettings Class](../wmi-provider/webservicesprotocolsettings-class.md)   
 [IIS 7.0: WebServicesSection Class](../wmi-provider/webservicessection-class.md)   
 [WsdlHelpGeneratorInfo Class](../wmi-provider/wsdlhelpgeneratorinfo-class.md)   
 [System.Web.Services.Description.SoapTransportImporter](https://go.microsoft.com/fwlink/?LinkId=70959)
