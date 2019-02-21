---
title: "IHttpContext3::PostCompletion Method"
ms.date: "10/07/2016"
ms.assetid: aac130c8-3f20-47a1-9b45-b3cf964e9909
---
# IHttpContext3::PostCompletion Method
Posts the completion of the asynchronous operation.  
  
## Syntax  
  
```cpp  
virtual HRESULT PostCompletion(  
   DWORD                             cbBytes,  
   LPOVERLAPPED_COMPLETION_ROUTINE   pfnCompletionRoutine,  
   VOID *                            pvCompletionContext  
) = 0;  
```  
  
### Parameters  
 `cbBytes`  
 [IN] The number of bytes completed.  
  
 `pfnCompletionRoutine`  
 [IN] Points to a function that notifies the host when an overlapped (that is, asynchronous) operation has completed.  
  
 `pvCompletionContext`  
 [IN] The context pointer for the completion routine callback.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext3 Interface](../../web-development-reference\native-code-api-reference/ihttpcontext3-interface.md)