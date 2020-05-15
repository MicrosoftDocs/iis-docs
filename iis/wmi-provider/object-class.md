---
title: "Object Class1"
ms.date: "10/07/2016"
ms.assetid: e0c0f720-51e6-d244-eb1a-e4551d427019
---
# Object Class1

Serves as a base class from which to derive the primary namespace objects for the [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] WMI provider.  
  
## Syntax  
  
```vbs  
class Object  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 This class contains no properties.  
  
## Subclasses  

 The following table lists the classes derived from the `Object` class.  
  
|Name|Description|  
|----------|-----------------|  
|[AppDomain](../wmi-provider/appdomain-class.md)|Represents an IIS application domain.|  
|[ApplicationPool](../wmi-provider/applicationpool-class.md)|Represents an IIS application pool.|  
|[ConfiguredObject](../wmi-provider/configuredobject-class.md)|Acts as a base type for namespace objects whose configuration can be specified in configuration sections.|  
|[HttpRequest](../wmi-provider/httprequest-class.md)|Represents an HTTP request in a worker process.|  
|[Server](../wmi-provider/server-class.md)|Exposes default configuration settings for applications, application pools, Web sites, and virtual directories on a Web server running IIS.|  
|[SSLBinding](../wmi-provider/sslbinding-class.md)|Represents a Secure Sockets Layer (SSL) binding.|  
|[WorkerProcess](../wmi-provider/workerprocess-class.md)|Represents a Windows Process Activation Service (WAS) worker process (w3wp.exe).|  
  
## Remarks  

 Although the `Object` class is not directly useful for scripting, it enables the WMI CIM Studio tool to conveniently group `WebAdministration` classes. CIM Studio is a utility that you can use to view WMI classes, properties, qualifiers, and instances. It is available from the [Microsoft Download Center](https://go.microsoft.com/fwlink/?LinkId=72615) as part of WMITools.exe suite of WMI Administrative Tools.  
  
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
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [ObjectConfigurationAssociation Class](../wmi-provider/objectconfigurationassociation-class.md)   
 [ObjectContainerAssociation Class](../wmi-provider/objectcontainerassociation-class.md)
