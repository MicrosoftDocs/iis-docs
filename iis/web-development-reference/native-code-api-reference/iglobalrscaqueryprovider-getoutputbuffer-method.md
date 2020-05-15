---
title: "IGlobalRSCAQueryProvider::GetOutputBuffer Method"
ms.date: "10/07/2016"
ms.assetid: 22f7388d-9dcc-6b6d-694d-0b5332e826fe
---
# IGlobalRSCAQueryProvider::GetOutputBuffer Method

Creates a new `BYTE` array.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetOutputBuffer(  
   DWORD cbBuffer,  
   OUT BYTE** ppbBuffer  
) = 0;  
```  
  
### Parameters  

 `cbBuffer`  
 [IN] A `DWORD` that contains the number of bytes to allocate.  
  
 `ppbBuffer`  
 [OUT] A pointer to a `BYTE` array that contains the new buffer.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_OUTOFMEMORY|Indicates that heap memory is exhausted.|  
  
## Remarks  

 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_RSCA_QUERY](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [IGlobalRscaQueryProvider](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalRSCAQuery](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalrscaquery-method.md)`virtual` method. You can then retrieve a new `BYTE` array by calling the `GetOutputBuffer` method on the `IGlobalRSCAQueryProvider` pointer.  
  
 The `GetOutputBuffer` return value depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
 The `IGlobalRSCAQueryProvider` implementer declares a private `BYTE` pointer as a member variable called `buffer`; the implementer initializes `buffer` to NULL at construction. If `buffer` is not NULL when `GetOutputBuffer` is called, the [LocalFree](https://go.microsoft.com/fwlink/?LinkId=63532) function is called on `buffer`. The [LocalAlloc](https://go.microsoft.com/fwlink/?LinkId=63531) function is called to assign `buffer` to a new `BYTE` array of size `cbBuffer` on the heap. `buffer` is then returned in the dereferenced `ppbBuffer` parameter if `GetOutputBuffer` returns S_OK.  
  
 **Important** This method is part of the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] infrastructure and is not intended to be used directly from your code.  
  
## Notes for Implementers  

 `IGlobalRSCAQueryProvider` implementers are responsible for memory management with this data; therefore, `IGlobalRSCAQueryProvider` implementers that use dynamic memory allocation must release or call `delete` on the `BYTE` pointer when it is no longer needed.  
  
## Notes for Callers  

 `IGlobalRSCAQueryProvider` implementers are responsible for memory management with this data; therefore, `IGlobalRSCAQueryProvider` clients must not release or call delete on the returned `BYTE` pointer when this data is no longer needed.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [IGlobalRSCAQueryProvider Interface](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md)   
 [IGlobalRSCAQueryProvider::ResizeOutputBuffer Method](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-resizeoutputbuffer-method.md)
