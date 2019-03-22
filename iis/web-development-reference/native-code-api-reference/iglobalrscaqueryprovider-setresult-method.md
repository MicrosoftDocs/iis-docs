---
title: "IGlobalRSCAQueryProvider::SetResult Method"
ms.date: "10/07/2016"
ms.assetid: 03b046ec-abf6-1e86-0a8e-7a08bfecf54e
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
  
### Parameters  
 `cbData`  
 A `DWORD` that contains the data size, in bytes, of the internal buffer.  
  
 `hr`  
 An `HRESULT` that indicates whether the internal buffer is valid.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_RSCA_QUERY](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [IGlobalRscaQueryProvider](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalRSCAQuery](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalrscaquery-method.md)`virtual` method. You can then validate or invalidate the internal buffer by calling the `SetResult` method on the `IGlobalRSCAQueryProvider` pointer.  
  
 `SetResult` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   The `IGlobalRSCAQueryProvider` implementer declares `private` member variables for the size of an internal buffer, an `HRESULT` that indicates whether the buffer is valid, and a Boolean flag that indicates whether `SetResult` has been called. The default values at construction of the implementer are 0, E_NOTIMPL, and `false`, respectively.  
  
-   After you call the [GetOutputBuffer](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-getoutputbuffer-method.md) or [ResizeOutputBuffer](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-resizeoutputbuffer-method.md) method, call `SetResult` to validate or invalidate the internal buffer by passing the size of the buffer, in bytes, and an `HRESULT` value that indicates whether the buffer is valid.  
  
 **Important** This method is part of the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] infrastructure and is not intended to be used directly from your code.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IGlobalRSCAQueryProvider Interface](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md)