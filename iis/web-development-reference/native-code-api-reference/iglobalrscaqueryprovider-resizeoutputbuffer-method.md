---
title: "IGlobalRSCAQueryProvider::ResizeOutputBuffer Method"
ms.date: "10/07/2016"
ms.assetid: 0f550da6-ac62-5d76-e29c-08d5e1238762
---
# IGlobalRSCAQueryProvider::ResizeOutputBuffer Method
Resizes and returns the output `BYTE` array.  
  
## Syntax  
  
```cpp  
virtual HRESULT ResizeOutputBuffer(  
   DWORD cbNewBuffer,  
   DWORD cbBytesToCopy,  
   IN OUT BYTE** ppbBuffer  
) = 0;  
```  
  
### Parameters  
 `cbNewBuffer`  
 [IN] A `DWORD` that contains the number of bytes to allocate.  
  
 `cbBytesToCopy`  
 [IN] A `DWORD` that contains the number of bytes to copy from `ppbBuffer` into the new buffer.  
  
 `ppbBuffer`  
 [IN][OUT] A pointer to a `BYTE` array that contains the new buffer.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_INVALIDARG|Indicates that `cbBytesToCopy` is greater than `cbNewBuffer`.|  
|E_OUTOFMEMORY|Indicates that heap memory is exhausted.|  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_RSCA_QUERY](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [IGlobalRscaQueryProvider](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalRSCAQuery](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalrscaquery-method.md)`virtual` method. You can then resize a current `BYTE` array by calling the `ResizeOutputBuffer` method on the `IGlobalRSCAQueryProvider` pointer.  
  
 The `ResizeOutputBuffer` return value depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
 The `IGlobalRSCAQueryProvider` implementer declares a `private``BYTE` pointer as a member variable called `buffer`; the implementer initializes `buffer` to NULL at construction. If the `cbBytesToCopy` parameter is greater than the `cbNewBuffer` parameter when `ResizeOutputBuffer` is called, `ResizeOutputBuffer` immediately returns E_INVALIDARG. Otherwise, the [LocalAlloc](https://go.microsoft.com/fwlink/?LinkId=63531) function is called to create a new buffer of size `cbNewBuffer`, and the contents of the `ppbBuffer` parameter (up to the length of `cbBytesToCopy`) are copied into this new buffer. The [LocalFree](https://go.microsoft.com/fwlink/?LinkId=63532) function is then called to dispose of the private buffer, which is reassigned to the new buffer. The `private` buffer is then returned in the dereferenced `ppbBuffer` parameter if `ResizeOutputBuffer` returns S_OK.  
  
 **Important** This method is part of the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] infrastructure and is not intended to be used directly from your code.  
  
## Notes for Implementers  
 `IGlobalRSCAQueryProvider` implementers are responsible for memory management with this data; therefore, `IGlobalRSCAQueryProvider` implementers that use dynamic memory allocation must release or call `delete` on the `BYTE` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IGlobalRSCAQueryProvider` implementers are responsible for memory management with this data; therefore, `IGlobalRSCAQueryProvider` clients must not release or call `delete` on the returned `BYTE` pointer when this data is no longer needed.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IGlobalRSCAQueryProvider Interface](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md)   
 [IGlobalRSCAQueryProvider::GetOutputBuffer Method](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-getoutputbuffer-method.md)
