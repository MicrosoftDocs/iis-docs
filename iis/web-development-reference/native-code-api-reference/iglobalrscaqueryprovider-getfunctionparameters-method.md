---
title: "IGlobalRSCAQueryProvider::GetFunctionParameters Method"
ms.date: "10/07/2016"
ms.assetid: 66f47e85-f9ad-b65a-aa82-9372115f9f82
---
# IGlobalRSCAQueryProvider::GetFunctionParameters Method
Returns the parameters of the dynamic function call that caused the event.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetFunctionParameters(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a constant null-terminated Unicode string that contains the parameters of the dynamic function call that caused the event.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_RSCA_QUERY](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [IGlobalRscaQueryProvider](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalRSCAQuery](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalrscaquery-method.md)`virtual` method. You can then retrieve the parameters of the function by calling the `GetFunctionParameters` method on the `IGlobalRSCAQueryProvider` pointer.  
  
 The return value of the `GetFunctionParameters` method depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
- The default implementer of the [IProtocolManager](../../web-development-reference/native-code-api-reference/iprotocolmanager-interface.md), [IPmCustomActions](../../web-development-reference/native-code-api-reference/ipmcustomactions-interface.md), [IPmHealthAndIdleMonitor](../../web-development-reference/native-code-api-reference/ipmhealthandidlemonitor-interface.md), and [IPmListenerChannelManager](../../web-development-reference/native-code-api-reference/ipmlistenerchannelmanager-interface.md) interfaces raises events when you call the [IRSCA_WorkerProcess::EnumerateAppDomains](https://msdn.microsoft.com/8be86f01-4f15-4f9c-8b65-aec64061d497) and [IRSCA_AppDomain::Unload](https://msdn.microsoft.com/f6e9a6a6-3029-4bbe-8454-b82b2e4b2bfb) methods. These methods map to the PMH_App_Domain_Enum_V1 and PMH_App_Domain_Unload_V1 values, respectively, which are returned when you call the [GetFunctionName](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-getfunctionname-method.md) method. The parameters of this function are, in turn, returned when you call `GetFunctionParameters`.  
  
- The `IGlobalRSCAQueryProvider` implementer receives the function name and function parameter values as strings when either of the [IRSCA_AppDomain](https://msdn.microsoft.com/0ac45ca7-4e5c-4ac2-9152-42465f4511fa) events is raised, and the implementer holds references to these strings. If a string is NULL, `GetFunctionParameters` returns the empty string. Otherwise, `GetFunctionParameters` returns a pointer to this shared string.  
  
## Notes for Implementers  
 `IGlobalRSCAQueryProvider` implementers are responsible for memory management with this data; therefore, `IGlobalRSCAQueryProvider` implementers that use dynamic memory allocation must release or call `delete` on the `PCWSTR` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IGlobalRSCAQueryProvider` implementers are responsible for memory management with this data; therefore, `IGlobalRSCAQueryProvider` clients must not release or call `delete` on the returned `PCWSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCWSTR`, because either an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_RSCA_QUERY](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the function parameter information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IGlobalRSCAQueryProvider#3](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IGlobalRSCAQueryProvider/cpp/GetFunctionParameters.cpp#3)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes an event to the application log of the Event Viewer, where the Data box contains a string similar to the following:  
  
```  
Parameters:  
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
 [IGlobalRSCAQueryProvider Interface](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-interface.md)