---
title: "SSLBinding.Create Method1 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b68af3fb-9509-4d3d-9787-be79438a47f2
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# SSLBinding.Create Method1
Creates a Secure Sockets Layer (SSL) binding.  
  
## Syntax  
  
```jscript#  
oWebAdmin.Get("SSLBinding").Create(  
   IPAddress,  
   Port,  
   CertificateHash,  
   StoreName  
);  
```  
  
```vbs  
oWebAdmin.Get("SSLBinding").Create  
   IPAddress,  
   Port,  
   CertificateHash,  
   StoreName  
  
```  
  
#### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`CertificateHash`|A `string` value that specifies the certificate hash for the SSL binding.|  
|`IPAddress`|A `string` value that specifies the IP address for the SSL binding.|  
|`Port`|A `uint32` value that specifies the port number for the SSL binding.|  
|`StoreName`|A `string` value that specifies the name of the certificate store for the SSL binding.|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 The following script shows the different formats that you can use for the `IPAddress` parameter:  
  
```  
' This is the standard format for a specific IP address.  
oWebAdmin.Get("SSLBinding").Create "172.30.190.122", 443, "fbbca460988a482227ec71122177045e47f9f2ff", "MyStoreName"  
  
' Each of the following formats is an acceptable way to create a secure binding   
' to port 443 on all IP addresses.  
oWebAdmin.Get("SSLBinding").Create "*", 443, "fbbca460988a482227ec71122177045e47f9f2ff", "MyStoreName"  
oWebAdmin.Get("SSLBinding").Create "0.0.0.0", 443, "fbbca460988a482227ec71122177045e47f9f2ff", "MyStoreName"  
oWebAdmin.Get("SSLBinding").Create "", 443, "fbbca460988a482227ec71122177045e47f9f2ff", "MyStoreName"  
```  
  
## Example  
 The following example creates a secure binding and adds it to a Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Create the secure binding.  
oWebAdmin.Get("SSLBinding").Create "*", 443, "fbbca460988a482227ec71122177045e47f9f2ff", "MyStoreName"  
  
' Create a new binding element.  
Set oBinding = oWebAdmin.Get("BindingElement").SpawnInstance_  
oBinding.BindingInformation = "*:443:"  
oBinding.Protocol = "https"  
  
' Get the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
  
' Increase the size of the array in the site's Bindings property.  
arrBindings = oSite.Bindings  
ReDim Preserve arrBindings(UBound(arrBindings) + 1)  
  
' Add the new binding to the array.   
Set arrBindings(UBound(arrBindings)) = oBinding  
  
' Assign the array to the Site.Bindings property.  
oSite.Bindings = arrBindings   
Set oPath = oSite.Put_  
  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [BindingElement Class](../wmi-provider/bindingelement-class1.md)   
 [SSLBinding Class](../wmi-provider/sslbinding-class.md)   
 [Site Class](../wmi-provider/site-class1.md)