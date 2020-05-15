---
title: "IReadEntityProvider::GetEntity Method"
ms.date: "10/07/2016"
ms.assetid: 84b5367c-ad22-9637-1ced-7500c0a952a8
---
# IReadEntityProvider::GetEntity Method

Retrieves the request entity.  
  
## Syntax  
  
```cpp  
virtual VOID GetEntity(  
   PVOID* ppBuffer,  
   DWORD* pcbData,  
   DWORD* pcbBuffer  
) = 0;  
```  
  
### Parameters  

 `ppBuffer`  
 A pointer to a void buffer that contains the request entity.  
  
 `pcbData`  
 A pointer to a `DWORD` that contains the size of the data in `ppBuffer`.  
  
 `pcbBuffer`  
 A pointer to a `DWORD` that contains the size of the `ppBuffer` buffer, which should be greater than or equal to `pcbData`.  
  
## Return Value  

 `VOID`.  
  
## Remarks  

 After you call the `GetEntity` method, the `ppBuffer` parameter will specify the request entity; the `pcbData` parameter will specify the size, in bytes, of the data in the request entity that was returned in `ppBuffer;` and the `pcbBuffer` parameter will specify the size, in bytes, of the request entity buffer that is pointed to by `ppBuffer`.  
  
> [!NOTE]
>  `pcbBuffer` should always be greater than or equal to `pcbData`.  
  
## Example  

 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1. Retrieves the request entity by using the `GetEntity` method.  
  
2. Creates an array of strings that contain the size of the request entity data and the buffer size.  
  
3. Writes an Event Viewer log entry that contains the request entity information, and then exits.  
  
 [!code-cpp[IReadEntityProviderGetEntity#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IReadEntityProviderGetEntity/cpp/IReadEntityProviderGetEntity.cpp#1)]  
  
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

 [IReadEntityProvider Interface](../../web-development-reference/native-code-api-reference/ireadentityprovider-interface.md)   
 [IReadEntityProvider::SetEntity Method](../../web-development-reference/native-code-api-reference/ireadentityprovider-setentity-method.md)   
 [IHttpRequest::ReadEntityBody Method](../../web-development-reference/native-code-api-reference/ihttprequest-readentitybody-method.md)   
 [IHttpRequest::InsertEntityBody Method](../../web-development-reference/native-code-api-reference/ihttprequest-insertentitybody-method.md)
