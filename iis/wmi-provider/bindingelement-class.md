---
title: "BindingElement Class1"
ms.date: "10/07/2016"
ms.assetid: 359250eb-6680-f075-7ccb-cebc4850903e
---
# BindingElement Class1
Represents a binding element for a Web site.  
  
## Syntax  
  
```vbs  
class BindingElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `BindingElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`BindingInformation`|A nonempty read/write `string` value with three colon-delimited fields that specify binding information for a Web site. The first field is a specific IP address or an asterisk (an asterisk specifies all unassigned IP addresses). The second field is the port number; the default is 80. The third field is an optional host header.|  
|`Protocol`|A required unique nonempty read/write `string` value that specifies the protocol that the site binding uses. The default is "HTTP". The key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Bindings` array property of the [Site](../wmi-provider/site-class.md) class.  
  
## Example  
 The following example retrieves the bindings for all of the sites on a Web server.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get all Web site instances.  
Set oSites = oWebAdmin.InstancesOf("Site")  
  
' Display the name of each site and its bindings.  
For Each oSite In oSites  
  
    WScript.Echo oSite.Name  
  
    For Each objItem in oSite.Bindings  
        Wscript.Echo "Binding Info: " & objItem.BindingInformation  
        Wscript.Echo "Protocol: " & objItem.Protocol  
    Next  
    WScript.Echo  
Next  
```  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `BindingElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)
 [SSLBinding Class](../wmi-provider/sslbinding-class.md)
 [Site Class](../wmi-provider/site-class.md)
