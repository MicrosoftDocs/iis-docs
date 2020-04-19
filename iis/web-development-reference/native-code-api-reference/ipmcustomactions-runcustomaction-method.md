---
title: "IPmCustomActions::RunCustomAction Method"
ms.date: "10/07/2016"
ms.assetid: 1e5e7cb6-1dd9-e28e-d4c7-e94454dd1c8b
---
# IPmCustomActions::RunCustomAction Method
Enables the worker process framework to request support functions for Run-Time Status and Control data from a protocol manager, and reports results back by using an [ICustomActionResultCallback](../../web-development-reference/native-code-api-reference/icustomactionresultcallback-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual HRESULT RunCustomAction(  
   IN PCWSTR pszFunctionName,  
   IN PCWSTR pszFunctionArgs,  
   IN ICustomActionResultCallback* pCompletionCallbackClass  
) = 0 ;  
```  
  
### Parameters  
 `pszFunctionName`  
 A pointer to a string that contains the name of the custom Run-Time Status and Control action to be performed.  
  
 `pszFunctionArgs`  
 A pointer to a string that contains the arguments to be passed to the function specified by `pszFunctionName`.  
  
 `pCompletionCallbackClass`  
 A pointer to an [ICustomActionResultCallback](../../web-development-reference/native-code-api-reference/icustomactionresultcallback-interface.md) interface that will be used to report the results.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful and the custom action has been queued. The results of the action will be returned using the [ICustomActionResultCallback::ReportResult](../../web-development-reference/native-code-api-reference/icustomactionresultcallback-reportresult-method.md) interface.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IPmCustomActions Interface](../../web-development-reference/native-code-api-reference/ipmcustomactions-interface.md)   
 [ICustomActionResultCallback::ReportResult Method](../../web-development-reference/native-code-api-reference/icustomactionresultcallback-reportresult-method.md)