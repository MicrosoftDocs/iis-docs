---
title: "IProcessHostSupportFunctions Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0e13e83c-9f64-b9a0-ff4c-0138931fb70d
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IProcessHostSupportFunctions Interface
Provides helper functions for the process host.  
  
## Syntax  
  
```cpp  
struct IProcessHostSupportFunctions : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IProcessHostSupportFunctions` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IProcessHostSupportFunctions::GetAppHostConfigFilename](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshostsupportfunctions-getapphostconfigfilename-method.md)|Retrieves the application host configuration (.config) file path.|  
|[IProcessHostSupportFunctions::GetApplicationProperties](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshostsupportfunctions-getapplicationproperties-method.md)|Retrieves the properties from the application's metabase.|  
|[IProcessHostSupportFunctions::GetConfigToken](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshostsupportfunctions-getconfigtoken-method.md)|Retrieves a Windows security token for the specified application’s root directory.|  
|[IProcessHostSupportFunctions::GetNativeConfigurationSystem](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshostsupportfunctions-getnativeconfigurationsystem-method.md)|Retrieves the [INativeConfigurationSystem](http://msdn.microsoft.com/en-us/ef29f2da-90b4-be7d-e59b-83fa1799f477) interface pointer.|  
|[IProcessHostSupportFunctions::GetRootWebConfigFilename](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshostsupportfunctions-getrootwebconfigfilename-method.md)|Retrieves the physical path for the ApplicationHost.config file.|  
|[IProcessHostSupportFunctions::MapPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprocesshostsupportfunctions-mappath-method.md)|Retrieves the physical path of a relative URL.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IProcessHostSupportFunctions`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/windows-process-activation-service-interfaces.md)