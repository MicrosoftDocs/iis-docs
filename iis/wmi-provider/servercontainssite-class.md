---
title: "ServerContainsSite Class1"
ms.date: "10/07/2016"
ms.assetid: bde6c297-ab07-6523-36ca-985f9d415995
---
# ServerContainsSite Class1

Provides a relationship between a Web server and its Web sites.  
  
## Syntax  
  
```vbs  
class ServerContainsSite : ObjectContainerAssociation  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `ServerContainsSite` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Container`|(Inherited from [ObjectContainerAssociation](../wmi-provider/objectcontainerassociation-class.md).) A [Server](../wmi-provider/server-class.md) object that represents a Web server. A key property.|  
|`Element`|(Inherited from `ObjectContainerAssociation`.) A [Site](../wmi-provider/site-class.md) object that represents a Web site. A key property.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Inheritance Hierarchy  

 [ObjectContainerAssociation](../wmi-provider/objectcontainerassociation-class.md)  
  
 `ServerContainsSite`  
  
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
 [Site Class](../wmi-provider/site-class.md)
