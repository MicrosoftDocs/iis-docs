---
title: "IReadEntityProvider::SetEntity Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 894a9196-08e5-51a6-e804-6d2f6b4c28d3
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
---
# IReadEntityProvider::SetEntity Method
Specifies the request entity.  
  
## Syntax  
  
```cpp  
virtual VOID SetEntity(  
   PVOID pBuffer,  
   DWORD cbData,  
   DWORD cbBuffer  
) = 0;  
```  
  
#### Parameters  
 `pBuffer`  
 A pointer to a void buffer that contains the request entity.  
  
 `cbData`  
 A `DWORD` that contains the size of the data in `pBuffer`.  
  
 `cbBuffer`  
 A `DWORD` that contains the size of the `pBuffer` buffer, which should be greater than or equal to `cbData`.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `SetEntity` method replaces the preloaded HTTP request entity body with the entity body that is pointed to by the `pBuffer` parameter. The `cbData` parameter must specify the size, in bytes, of the data in the request entity that was returned in `pBuffer`, and the `cbBuffer` parameter must specify the size, in bytes, of the request entity buffer that is pointed to by `pBuffer`.  
  
> [!NOTE]
>  `cbBuffer` should always be greater than or equal to `cbData`.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Allocates a 1-KB buffer. If the buffer cannot be allocated, the module returns an error and exits.  
  
2.  Creates a string that contains a response value.  
  
3.  Specifies the request entity by using the `SetEntity` method, and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IReadEntityProviderSetEntity#1](IReadEntityProviderSetEntity#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IReadEntityProvider Interface](../../web-development-reference\native-code-api-reference/ireadentityprovider-interface.md)   
 [IReadEntityProvider::GetEntity Method](../../web-development-reference\native-code-api-reference/ireadentityprovider-getentity-method.md)   
 [IHttpRequest::ReadEntityBody Method](../../web-development-reference\native-code-api-reference/ihttprequest-readentitybody-method.md)   
 [IHttpRequest::InsertEntityBody Method](../../web-development-reference\native-code-api-reference/ihttprequest-insertentitybody-method.md)