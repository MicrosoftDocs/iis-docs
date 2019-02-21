---
title: "BypassElement Class"
ms.date: "10/07/2016"
ms.assetid: 5169123e-c88c-f1a4-750f-159bb0db613a
---
# BypassElement Class
Contains address information for resources that bypass the Web proxy server.  
  
## Syntax  
  
```vbs  
class BypassElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `BypassElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Address`|A required unique read/write `string` value that contains a regular expression that defines a resource address or addresses that bypass the proxy server. Requests for the resource are sent instead directly to the server where the resource resides. The key property. **Note:**  For more information about regular expressions, see the [System.Text.RegularExpressions](http://go.microsoft.com/fwlink/?LinkId=73545) namespace.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `BypassList` array property of the [BypassListSettings](../wmi-provider/bypasslistsettings-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `BypassElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [BypassListSettings Class](../wmi-provider/bypasslistsettings-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [DefaultProxySection Class](../wmi-provider/defaultproxysection-class.md)   
 [System.Net.BypassElement Class](http://go.microsoft.com/fwlink/?LinkID=70908)   
 [System.Net.Configuration.BypassElement.Address Property](http://go.microsoft.com/fwlink/?LinkId=70909)   
 [System.Text.RegularExpressions Namespace](http://go.microsoft.com/fwlink/?LinkId=73545)