---
title: "IGlobalRSCAQueryProvider::SetResult Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 03b046ec-abf6-1e86-0a8e-7a08bfecf54e
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IGlobalRSCAQueryProvider::SetResult Method
Finalizes the internal buffer.  
  
## Syntax  
  
```cpp  
virtual VOID SetResult(  
   DWORD cbData,  
   HRESULT hr  
) = 0;  
```  
  
#### Parameters  
 `cbData`  
 A `DWORD` that contains the data size, in bytes, of the internal buffer.  
  
 `hr`  
 An `HRESULT` that indicates whether the internal buffer is valid.  
  
## Remarks  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_RSCA_QUERY](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events receive an [IGlobalRscaQueryProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalRSCAQuery](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalrscaquery-method.md)`virtual` method. You can then validate or invalidate the internal buffer by calling the `SetResult` method on the `IGlobalRSCAQueryProvider` pointer.  
  
 `SetResult` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   The `IGlobalRSCAQueryProvider` implementer declares `private` member variables for the size of an internal buffer, an `HRESULT` that indicates whether the buffer is valid, and a Boolean flag that indicates whether `SetResult` has been called. The default values at construction of the implementer are 0, E_NOTIMPL, and `false`, respectively.  
  
-   After you call the [GetOutputBuffer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-getoutputbuffer-method.md) or [ResizeOutputBuffer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-resizeoutputbuffer-method.md) method, call `SetResult` to validate or invalidate the internal buffer by passing the size of the buffer, in bytes, and an `HRESULT` value that indicates whether the buffer is valid.  
  
 **Important** This method is part of the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] infrastructure and is not intended to be used directly from your code.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IGlobalRSCAQueryProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-interface.md)