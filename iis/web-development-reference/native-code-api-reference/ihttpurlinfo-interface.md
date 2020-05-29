---
title: "IHttpUrlInfo Interface"
ms.date: "10/07/2016"
ms.assetid: b167da0a-aa53-2848-82a9-4d741987defc
---
# IHttpUrlInfo Interface
Provides URL-specific information within the current context.  
  
## Syntax  
  
```cpp  
class IHttpUrlInfo  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpUrlInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpurlinfo-getmodulecontextcontainer-method.md)|Returns the context container for the URL-specific information.|  
|[IsFrequentlyHit](../../web-development-reference/native-code-api-reference/ihttpurlinfo-isfrequentlyhit-method.md)|Returns a Boolean value that indicates whether the URL is requested frequently.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 The `IHttpUrlInfo` interface provides information for a URL within the current context. For example, you can call the [IPreBeginRequestProvider::GetHttpContext](../../web-development-reference/native-code-api-reference/iprebeginrequestprovider-gethttpcontext-method.md) or [IGlobalTraceEventProvider::GetCurrentHttpRequestContext](../../web-development-reference/native-code-api-reference/iglobaltraceeventprovider-getcurrenthttprequestcontext-method.md) method to retrieve an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface for the current context, and then call the [IHttpContext::GetUrlInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-geturlinfo-method.md) method to retrieve an `IHttpUrlInfo` interface in order to retrieve the URL-specific information for the current context.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
