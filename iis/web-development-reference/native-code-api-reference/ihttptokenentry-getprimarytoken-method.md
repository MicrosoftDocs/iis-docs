---
title: "IHttpTokenEntry::GetPrimaryToken Method"
ms.date: "10/07/2016"
ms.assetid: 3c259dad-6886-1f73-1dad-14f576f6b030
---
# IHttpTokenEntry::GetPrimaryToken Method
Returns the primary token for the process that is servicing a request.  
  
## Syntax  
  
```cpp  
virtual HANDLE GetPrimaryToken(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `HANDLE` that represents the impersonation token for the process that is servicing a request. May be NULL.  
  
## Remarks  
 A primary token is a handle that defines the security context of the user account associated with the process that is servicing a request. This token restricts access to system resources based on the access rules for the process.  
  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) pointer by calling the [ICacheProvider::GetCacheRecord](../../web-development-reference/native-code-api-reference/icacheprovider-getcacherecord-method.md) method and, in some cases, you can downcast this `IHttpCacheSpecificData` pointer to an [IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md) pointer. You can then retrieve the primary token handle by calling the `GetPrimaryToken` method.  
  
 For more information on downcast rules, see [ICacheProvider::GetCacheRecord](../../web-development-reference/native-code-api-reference/icacheprovider-getcacherecord-method.md).  
  
## Notes for Implementers  
 `IHttpTokenEntry` implementers are responsible for resource management with this data; therefore, `IHttpTokenEntry` implementers must call [CloseHandle](https://go.microsoft.com/fwlink/?LinkId=60019) on the handle when it is no longer needed.  
  
## Notes for Callers  
 `IHttpTokenEntry` implementers are responsible for resource management with this data; therefore, `IHttpTokenEntry` clients must not call `CloseHandle` on the returned handle when this data is no longer needed. Furthermore, clients must not change the state of the memory that this handle references, because an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpTokenEntry` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpTokenEntry#3](IHttpTokenEntry#3)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains a string similar to the following.  
  
```  
IHttpTokenEntry::GetPrimaryToken: valid  
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