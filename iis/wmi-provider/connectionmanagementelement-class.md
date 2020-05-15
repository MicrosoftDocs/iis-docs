---
title: "ConnectionManagementElement Class"
ms.date: "10/07/2016"
ms.assetid: f06a0303-0aec-1e35-7711-f48e4399a249
---
# ConnectionManagementElement Class

Defines the maximum number of connections to a server or group of servers.  
  
## Syntax  
  
```vbs  
class ConnectionManagementElement : CollectionElement  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `ConnectionManagementElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Address`|A required unique read/write `string` value that contains a [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] regular expression that specifies an IP address or DNS name of a network host. The key property.|  
|`MaxConnection`|A read/write `sint32` value that specifies the maximum number of connections allowed to a server. The default is 2.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `ConnectionManagement` property of the [ConnectionManagementSection](../wmi-provider/connectionmanagementsection-class.md) class.  
  
## Inheritance Hierarchy  

 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ConnectionManagementElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [\<connectionManagement> Element (Network Settings)](https://go.microsoft.com/fwlink/?LinkId=70910)   
 [.NET Framework Regular Expressions](https://go.microsoft.com/fwlink/?LinkId=70911)
