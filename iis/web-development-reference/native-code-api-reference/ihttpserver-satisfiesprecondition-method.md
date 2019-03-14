---
title: "IHttpServer::SatisfiesPrecondition Method"
ms.date: "10/07/2016"
ms.assetid: cc0beadd-fa0d-b706-02db-f4931ae6c78a
---
# IHttpServer::SatisfiesPrecondition Method
Determines whether a specific precondition has been met for the current request.  
  
## Syntax  
  
```cpp  
virtual BOOL SatisfiesPrecondition(  
   IN PCWSTR pszPrecondition  
) const = 0;  
```  
  
### Parameters  
 `pszPrecondition`  
 [IN] A pointer to a string that contains the precondition to test.  
  
## Return Value  
 `true` if the precondition has been met; otherwise, `false`.  
  
## Remarks  
 The `SatisfiesPrecondition` method tests whether a specific precondition has been met for the current request. For example, an HTTP handler may require a specific version of the [!INCLUDE[dnprdnshort](../../wmi-provider/includes/dnprdnshort-md.md)], or an HTTP module may require integrated or ISAPI mode.  
  
 The following table lists the possible preconditions for [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)].  
  
|Value|Description|  
|-----------|-----------------|  
|`integratedMode` or `ISAPIMode`|Specifies the required mode of operation as integrated or ISAPI mode.|  
|`runtimeVersionv1.0`, `runtimeVersionv1.1`, or `runtimeVersionv2.0`|Specifies the required version of the [!INCLUDE[dnprdnshort](../../wmi-provider/includes/dnprdnshort-md.md)].|  
|`bitness32` or `bitness64`|Specifies a 32-bit or 64-bit requirement.|  
|`appPoolName=name1;name2`|Specifies the names of required application pools.|  
  
## Example  
 The following code example demonstrates how to use the `SatisfiesPrecondition` method to create an HTTP module that determines whether the `integratedMode` precondition has been met and then returns a status message to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerSatisfiesPrecondition#1](IHttpServerSatisfiesPrecondition#1)]  -->  
  
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
 [IHttpServer Interface](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)