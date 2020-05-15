---
title: "ServerContainsSSLBinding Class"
ms.date: "10/07/2016"
ms.assetid: ef6ae9a0-9134-c320-1380-93cd00297da0
---
# ServerContainsSSLBinding Class

Provides a relationship between a Secure Sockets Layer (SSL) binding and a Web server that is running IIS.  
  
## Syntax  
  
```vbs  
class ServerContainsSSLBinding : ObjectContainerAssociation  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `ServerContainsSSLBinding` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Container`|(Inherited from [ObjectContainerAssociation](../wmi-provider/objectcontainerassociation-class.md).) A read-only [Server](../wmi-provider/server-class.md) object that represents a Web server running IIS.|  
|`Element`|(Inherited from `ObjectContainerAssociation`.) A read-only [SSLBinding](../wmi-provider/sslbinding-class.md) object that represents an SSL binding.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 This class is used to enumerate the SSL bindings that IIS uses on a Web server.  
  
## Inheritance Hierarchy  

 [ObjectContainerAssociation](../wmi-provider/objectcontainerassociation-class.md)  
  
 `ServerContainsSSLBinding`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [ObjectContainerAssociation Class](../wmi-provider/objectcontainerassociation-class.md)   
 [Server Class](../wmi-provider/server-class.md)   
 [SiteUsesSSLBinding Class](../wmi-provider/siteusessslbinding-class.md)   
 [SSLBinding Class](../wmi-provider/sslbinding-class.md)
