---
title: "IProcessHostSupportFunctions Interface"
ms.date: "10/07/2016"
ms.assetid: 0e13e83c-9f64-b9a0-ff4c-0138931fb70d
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
|[IProcessHostSupportFunctions::GetAppHostConfigFilename](../../web-development-reference\native-code-api-reference/iprocesshostsupportfunctions-getapphostconfigfilename-method.md)|Retrieves the application host configuration (.config) file path.|  
|[IProcessHostSupportFunctions::GetApplicationProperties](../../web-development-reference\native-code-api-reference/iprocesshostsupportfunctions-getapplicationproperties-method.md)|Retrieves the properties from the application's metabase.|  
|[IProcessHostSupportFunctions::GetConfigToken](../../web-development-reference\native-code-api-reference/iprocesshostsupportfunctions-getconfigtoken-method.md)|Retrieves a Windows security token for the specified application’s root directory.|  
|[IProcessHostSupportFunctions::GetNativeConfigurationSystem](../../web-development-reference\native-code-api-reference/iprocesshostsupportfunctions-getnativeconfigurationsystem-method.md)|Retrieves the [INativeConfigurationSystem](https://msdn.microsoft.com/en-us/ef29f2da-90b4-be7d-e59b-83fa1799f477) interface pointer.|  
|[IProcessHostSupportFunctions::GetRootWebConfigFilename](../../web-development-reference\native-code-api-reference/iprocesshostsupportfunctions-getrootwebconfigfilename-method.md)|Retrieves the physical path for the ApplicationHost.config file.|  
|[IProcessHostSupportFunctions::MapPath](../../web-development-reference\native-code-api-reference/iprocesshostsupportfunctions-mappath-method.md)|Retrieves the physical path of a relative URL.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IProcessHostSupportFunctions`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Interfaces](../../web-development-reference\native-code-api-reference/windows-process-activation-service-interfaces.md)