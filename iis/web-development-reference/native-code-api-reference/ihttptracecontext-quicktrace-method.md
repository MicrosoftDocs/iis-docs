---
title: "IHttpTraceContext::QuickTrace Method"
ms.date: "10/07/2016"
ms.assetid: a0d43e55-a773-4f55-ae09-33b451adfe4b
---
# IHttpTraceContext::QuickTrace Method
Writes a message to the IIS trace log.  
  
## Syntax  
  
```cpp  
virtual  
    HRESULT  
    QuickTrace(  
        IN PCWSTR   pszData1,  
        IN PCWSTR   pszData2 = NULL,  
        IN HRESULT  hrLastError = S_OK,  
        IN UCHAR    Level = 4  
    ) = 0;  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`pszData1`|A message to log.|  
|`pszData2`|A second message to log.|  
|`hrLastError`|The `HRESULT` to log. The default is S_OK.|  
|`level`|The trace level. The possible values are 1 through 7. The default is 4 (TRACE_LEVEL_INFORMATION). For more information, see the Remarks section.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 Event trace levels 1 through 5 correspond to Event Tracing for Windows (ETW) trace levels. For more information about these trace levels, see the [EVENT_TRACE_HEADER](https://go.microsoft.com/fwlink/?LinkId=102211) structure. You can also use trace level 6 (defined as HTTP_TRACE_LEVEL_START in the Httptrace.h header file) and trace level 7 (defined as HTTP_TRACE_LEVEL_END in Httptrace.h).  
  
## Example  
 The following example demonstrates how to use the [IHttpRequest::SetUrl](../../web-development-reference/native-code-api-reference/ihttprequest-seturl-method.md) method to change a requested URL to another URL and log the change with the `QuickTrace` method.  
  
 You must enable Failed Event Request tracing to see the event.  
  
 [!code-cpp[_GPR#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/_GPR/cpp/global_module.cpp#1)]
 [!code-cpp[_GPR#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/_GPR/cpp/_base.cpp#1)]  
[!code-cpp[_GPR#2](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/_GPR/cpp/_base.cpp#2)]  
  
 [!code-cpp[IHttpRequestSetHttpMethod#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestSetHttpMethod/cpp/IHttpRequestSetHttpMethod.cpp#1)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|