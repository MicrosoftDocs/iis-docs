---
title: "ICacheProvider::GetCacheOperation Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1ebbf591-6426-8b58-37f8-b3e428c3e45e
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# ICacheProvider::GetCacheOperation Method
Returns the cache operation for the cache provider.  
  
## Syntax  
  
```cpp  
virtual CACHE_OPERATION GetCacheOperation(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A [CACHE_OPERATION](../../web-development-reference\webdev-native-api-reference/cache-operation-enumeration.md) enumeration for the [ICacheProvider](../../web-development-reference\webdev-native-api-reference/icacheprovider-interface.md) pointer.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference\webdev-native-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference\webdev-native-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve a `CACHE_OPERATION` enumeration by calling the `GetCacheOperation` method on the `ICacheProvider` pointer.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) events and then writes the `ICacheProvider` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [ICacheProvider#3](ICacheProvider#3)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes a new event to the application log of the Event Viewer, where the Data box contains a string similar to the following.  
  
```  
GetCacheOperation: CACHE_OPERATION_RETRIEVE  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ICacheProvider Interface](../../web-development-reference\webdev-native-api-reference/icacheprovider-interface.md)