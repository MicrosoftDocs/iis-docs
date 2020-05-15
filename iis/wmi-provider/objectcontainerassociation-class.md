---
title: "ObjectContainerAssociation Class1"
ms.date: "10/07/2016"
ms.assetid: 40a82997-34e7-1626-d580-a3d6b90ce7f6
---
# ObjectContainerAssociation Class1

Associates an object with its child objects.  
  
## Syntax  
  
```vbs  
class ObjectContainerAssociation  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `ObjectContainerAssociation` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Container`|An `object ref` value that represents a containing object.|  
|`Element`|An `object ref` value that represents the object within the container.|  
  
## Subclasses  
  
|Name|Description|  
|----------|-----------------|  
|[ApplicationContainsVirtualDirectory](../wmi-provider/applicationcontainsvirtualdirectory-class.md)|Provides a relationship between an IIS application and its virtual directories.|  
|[ApplicationPoolContainsApplication](../wmi-provider/applicationpoolcontainsapplication-class.md)|Provides a relationship between an application pool and its applications.|  
|[ApplicationPoolContainsProcess](../wmi-provider/applicationpoolcontainsprocess-class.md)|Provides a relationship between an application pool and its worker processes.|  
|[ServerContainsApplicationPool](../wmi-provider/servercontainsapplicationpool-class.md)|Provides a relationship between a Web server and its application pools.|  
|[ServerContainsSite](../wmi-provider/servercontainssite-class.md)|Provides a relationship between a Web server and its Web sites.|  
|[ServerContainsSSLBinding](../wmi-provider/servercontainssslbinding-class.md)|Provides a relationship between a Secure Sockets Layer (SSL) binding and a Web server that is running IIS.|  
|[SiteContainsApplication](../wmi-provider/sitecontainsapplication-class.md)|Provides a relationship between a Web site and its applications.|  
|[SiteUsesSSLBinding](../wmi-provider/siteusessslbinding-class.md)|Provides a relationship between an IIS Web site and a Secure Sockets Layer (SSL) binding.|  
|[WorkerProcessContainsAppDomain](../wmi-provider/workerprocesscontainsappdomain-class.md)|Provides a relationship between a worker process and its application domains.|  
  
## Remarks  

 This base class allows one member of the [Object](../wmi-provider/object-class.md) class to contain another member of the `Object` class. The containing object (for example, [Site](../wmi-provider/site-class.md)) is called a *container*, and the contained object (for example, [Application](../wmi-provider/application-class.md)) is called an *element*. A container object may contain one or more elements. `ObjectContainerAssociation` classes are useful because they enable you to create intuitive parent/child associations that would otherwise be difficult to implement in the relatively flat WMI namespace.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [AppDomain Class](../wmi-provider/appdomain-class.md)   
 [Application Class](../wmi-provider/application-class.md)   
 [ApplicationPool Class](../wmi-provider/applicationpool-class.md)   
 [ApplicationContainsVirtualDirectory Class](../wmi-provider/applicationcontainsvirtualdirectory-class.md)   
 [ApplicationPoolContainsApplication Class](../wmi-provider/applicationpoolcontainsapplication-class.md)   
 [ApplicationPoolContainsProcess Class](../wmi-provider/applicationpoolcontainsprocess-class.md)   
 [ConfiguredObject Class](../wmi-provider/configuredobject-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [WMI Provider](../wmi-provider/wmi-provider.md)   
 [Object Class](../wmi-provider/object-class.md)   
 [Site Class](../wmi-provider/site-class.md)   
 [SiteContainsApplication Class](../wmi-provider/sitecontainsapplication-class.md)   
 [VirtualDirectory Class](../wmi-provider/virtualdirectory-class.md)   
 [WorkerProcess Class](../wmi-provider/workerprocess-class.md)   
 [WorkerProcessContainsAppDomain Class](../wmi-provider/workerprocesscontainsappdomain-class.md)
