---
title: "IPAddressFilterElement Class"
ms.date: "10/07/2016"
ms.assetid: ecb74b4d-36ab-5b4d-c096-c0490bb2cc4d
---
# IPAddressFilterElement Class
Allows or denies access to content based on a unique combination of the IP address, subnet mask, and domain name.  
  
## Syntax  
  
```vbs  
class IPAddressFilterElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IPAddressFilterElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Allowed`|A read/write `boolean` value. `true` if access is granted to the location specified by the combination of the `IPAddress`, `DomainName`, and `SubnetMask` properties; otherwise; `false`. The default is `false`.|  
|`DomainName`|A required unique read/write `string` value that specifies a domain name (for example, "www.contoso.com") or a wildcard domain name (for example, "*.contoso.com") to which access is granted or denied. A key property.|  
|`IpAddress`|A required unique read/write `string` value that specifies an IP address to which access is granted or denied. A key property.|  
|`SubnetMask`|A required unique read/write `string` value that corresponds to a subnet mask to which access is granted or denied. The default is 255.255.255.255. You can use this property in conjunction with the `IpAddress` property to specify a range of IP addresses. A key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `IpSecurity` property of the [IPSecuritySection](../wmi-provider/ipsecuritysection-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `IPAddressFilterElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [IPSecuritySection Class](../wmi-provider/ipsecuritysection-class.md)
