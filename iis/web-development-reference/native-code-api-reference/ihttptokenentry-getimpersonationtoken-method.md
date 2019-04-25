---
title: "IHttpTokenEntry::GetImpersonationToken Method"
ms.date: "10/07/2016"
ms.assetid: c02033ef-5f32-4c95-4a15-b19c885741c9
---
# IHttpTokenEntry::GetImpersonationToken Method
Returns the impersonation token for a user.  
  
## Syntax  
  
```cpp  
virtual HANDLE GetImpersonationToken(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `HANDLE` that represents the impersonation token for a user. May be NULL.  
  
## Remarks  
 An impersonation token is a handle that defines the security context of the user that is making a request. This token allows the server to impersonate a user during a request so that access to system resources is based upon the access rules for that user.  
  
 During impersonation, both the primary token returned from the [GetPrimaryToken](../../web-development-reference/native-code-api-reference/ihttpuser-getprimarytoken-method.md) method and the impersonation token returned from the `GetImpersonationToken` method are used. This may either expand or contract the user privileges based upon security rules for that user.  
  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) pointer by calling the [ICacheProvider::GetCacheRecord](../../web-development-reference/native-code-api-reference/icacheprovider-getcacherecord-method.md) method and, in some cases, you can downcast this `IHttpCacheSpecificData` pointer to an [IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md) pointer. You can then retrieve the impersonation token handle by calling the `GetImpersonationToken` method.  
  
 For more information on downcast rules, see [ICacheProvider::GetCacheRecord](../../web-development-reference/native-code-api-reference/icacheprovider-getcacherecord-method.md).  
  
## Notes for Implementers  
 `IHttpTokenEntry` implementers are responsible for resource management with this data; therefore, `IHttpTokenEntry` implementers must call the [CloseHandle](https://go.microsoft.com/fwlink/?LinkId=60019) function on the handle when it is no longer needed.  
  
## Notes for Callers  
 `IHttpTokenEntry` implementers are responsible for resource management with this data; therefore, `IHttpTokenEntry` clients must not call `CloseHandle` on the returned handle when this data is no longer needed. Furthermore, clients must not change the state of the memory that this handle references, because an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpTokenEntry` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpTokenEntry#2](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpTokenEntry/cpp/GetImpersonationToken.cpp#2)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains a string similar to the following.  
  
```  
IHttpTokenEntry::GetImpersonationToken: valid  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpTokenEntry Interface](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md)   
 [IHttpTokenEntry::GetPrimaryToken Method](../../web-development-reference/native-code-api-reference/ihttptokenentry-getprimarytoken-method.md)   
 [IHttpTokenEntry::GetSid Method](../../web-development-reference/native-code-api-reference/ihttptokenentry-getsid-method.md)