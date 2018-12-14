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
 [IReadEntityProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ireadentityprovider-interface.md)   
 [IReadEntityProvider::GetEntity Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ireadentityprovider-getentity-method.md)   
 [IHttpRequest::ReadEntityBody Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-readentitybody-method.md)   
 [IHttpRequest::InsertEntityBody Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-insertentitybody-method.md)