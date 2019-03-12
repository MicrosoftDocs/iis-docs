---
title: "IHttpEventProvider::SetErrorStatus Method"
ms.date: "10/07/2016"
ms.assetid: 62f84393-a0b2-32f6-6f80-6db3ada4378a
---
# IHttpEventProvider::SetErrorStatus Method
Specifies an error to return.  
  
## Syntax  
  
```cpp  
virtual VOID SetErrorStatus(  
   IN HRESULT hrError  
) = 0;  
```  
  
### Parameters  
 `hrError`  
 [IN] An `HRESULT` that contains the error to specify.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `SetErrorStatus` method does not directly affect request processing, but it can be used to indicate the reason for a failure to IIS or other modules. For example, if a module that you have written traps an error, the module can set the error status for the request and return processing to the integrated request-processing pipeline so that other modules can process the error.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that sends an example string to the Web client and captures the return value from this operation. The module uses the `SetErrorStatus` method to specify the return value as the error status for the current request and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpEventProviderSetErrorStatus#1](IHttpEventProviderSetErrorStatus#1)]  -->  
  
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
 [IHttpEventProvider Interface](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)