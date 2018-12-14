---
title: "IHttpContext::GetMetadata Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9d5031b5-474a-1bbd-87c5-fb6743568419
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetMetadata Method
Retrieves the metadata container for the current request context.  
  
## Syntax  
  
```cpp  
virtual IMetadataInfo* GetMetadata(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IMetadataInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-interface.md) interface.  
  
## Remarks  
 The `GetMetadata` method retrieves an `IMetadataInfo` interface, which you use to retrieve information from an [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration file, for the current context. You can then use the [GetMetaPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-getmetapath-method.md) method from the `IMetadataInfo` interface to retrieve the configuration path for the current request context.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `GetMetadata` method to retrieve a pointer to an `IMetadataInfo` interface. The module completes the following steps:  
  
1.  Uses the [IMetadataInfo::GetMetaPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-getmetapath-method.md) method to retrieve the configuration path for the current request.  
  
2.  Uses the [IHttpServer::GetConfigObject](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-getconfigobject-method.md) method to retrieve a pointer to an [INativeConfigurationSystem](http://msdn.microsoft.com/en-us/ef29f2da-90b4-be7d-e59b-83fa1799f477) interface.  
  
3.  Passes the configuration path for the current request to the [INativeConfigurationSystem::GetConfigSection](http://msdn.microsoft.com/en-us/ad4c47fd-a00e-eb0e-f181-0cb41e98c89d) method.  
  
4.  Retrieves an [INativeConfigurationElement](http://msdn.microsoft.com/en-us/70c26f09-2188-b797-062a-b2eaca3d9ef7) interface for the log settings for IIS.  
  
5.  Uses the [INativeConfigurationElement::GetBooleanProperty](http://msdn.microsoft.com/en-us/6f2c8f06-b85d-1e93-ab1b-771a6e1e3ca7) method to retrieve a value that indicates whether logging is enabled for the current request context.  
  
6.  Returns this information to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetMetadata#1](IHttpContextGetMetadata#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)