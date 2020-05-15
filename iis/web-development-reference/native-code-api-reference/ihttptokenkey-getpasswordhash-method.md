---
title: "IHttpTokenKey::GetPasswordHash Method"
ms.date: "10/07/2016"
ms.assetid: 1259192c-d947-3f24-d7e8-f72092b07e38
---
# IHttpTokenKey::GetPasswordHash Method

Returns the user password as a hash value.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetPasswordHash(  
   VOID  
) const = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Return Value  

 A pointer to a constant null-terminated Unicode string that contains the user password as a hash value.  
  
## Remarks  

 When a user logs on, the password is hashed into a null-terminated Unicode string based on a one-way hashing algorithm. This unique hash value may then be used for very fast lookups on users in the global token cache.  
  
## Notes for Implementers  

 [IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpTokenKey` implementers that use dynamic memory allocation must release or call `delete` on the `PCWSTR` pointer when it is no longer needed.  
  
## Notes for Callers  

 `IHttpTokenKey` implementers are responsible for memory management with this data; therefore, `IHttpTokenKey` clients must not release or call `delete` on the returned `PCWSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCWSTR`; otherwise, an access violation will be thrown or the data will become invalid.  
  
## Example  

 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `GetPasswordHash` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpTokenKey#4](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpTokenKey/cpp/GetPasswordHash.cpp#4)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML that is similar to the following.  
  
```  
IHttpTokenKey::GetPasswordHash: 123456d1536d0b180399107b980bc6f82187d135799f92072b612156a4c14ec2  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  

 [IHttpTokenKey Interface](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md)
