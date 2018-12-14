---
title: "IReadEntityProvider::GetEntity Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 84b5367c-ad22-9637-1ced-7500c0a952a8
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
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
  
1.  Retrieves the request entity by using the `GetEntity` method.  
  
2.  Creates an array of strings that contain the size of the request entity data and the buffer size.  
  
3.  Writes an Event Viewer log entry that contains the request entity information, and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IReadEntityProviderGetEntity#1](IReadEntityProviderGetEntity#1)]  -->  
  
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
 [IReadEntityProvider::SetEntity Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ireadentityprovider-setentity-method.md)   
 [IHttpRequest::ReadEntityBody Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-readentitybody-method.md)   
 [IHttpRequest::InsertEntityBody Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-insertentitybody-method.md)