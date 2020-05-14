---
title: "IHttpTokenKey Interface"
ms.date: "10/07/2016"
ms.assetid: cefa2c4f-3fde-009e-ee80-3af8719b3175
---
# IHttpTokenKey Interface
Represents key information for accessing associated data in the global token cache.  
  
## Syntax  
  
```cpp  
class IHttpTokenKey : public IHttpCacheKey  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpTokenKey` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[Enum](../../web-development-reference/native-code-api-reference/ihttpcachekey-enum-method.md)|(Inherited from [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md).)|  
|[GetCacheName](../../web-development-reference/native-code-api-reference/ihttptokenkey-getcachename-method.md)|Overridden. Returns the name of the global token cache.|  
|[GetHash](../../web-development-reference/native-code-api-reference/ihttpcachekey-gethash-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetIsEqual](../../web-development-reference/native-code-api-reference/ihttpcachekey-getisequal-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetIsPrefix](../../web-development-reference/native-code-api-reference/ihttpcachekey-getisprefix-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetLogonMethod](../../web-development-reference/native-code-api-reference/ihttptokenkey-getlogonmethod-method.md)|Returns the `LOGON32_*` value used when the user logs on.|  
|[GetPasswordHash](../../web-development-reference/native-code-api-reference/ihttptokenkey-getpasswordhash-method.md)|Returns the user password as a hash value.|  
|[GetUserName](../../web-development-reference/native-code-api-reference/ihttptokenkey-getusername-method.md)|Returns the user name.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 Whenever a user logs on to a Web site, a token is created for that user. The `IHttpTokenKey` interface implements methods for gaining access to data that represents that user.  
  
 `IHttpTokenKey` extends the [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md) interface by adding support for returning-user information, such as the logon method, the password hash, and the user name. `IHttpTokenKey` also overrides the [IHttpCacheKey::GetCacheName](../../web-development-reference/native-code-api-reference/ihttpcachekey-getcachename-method.md) method by providing the default implementation through the [IHttpTokenKey::GetCacheName](../../web-development-reference/native-code-api-reference/ihttptokenkey-getcachename-method.md) method.  
  
## Notes for Implementers  
 Each nonabstract class that implements the `IHttpTokenKey` interface must provide an algorithm in the `GetHash` method that maps the data that an `IHttpTokenKey` pointer holds to a unique `DWORD` value for that data across the global token cache.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpTokenKey` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpTokenKey#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpTokenKey/cpp/IHttpTokenKey.cpp#1)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML that is similar to the following.  
  
```  
<cacheProvider>  
    <tokenKey
        userName="IUSR"
        hashedPassword="123456"
        logon="3"
        cacheName="TOKEN"
        hash="0"
        isEqual="true"
        isPrefix="false" />  
</cacheProvider>  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md)  
  
 `IHttpTokenKey`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
