---
title: "IUriKey::GetSiteName Method"
description: "Describes the IUriKey::GetSiteName method and details its syntax, parameters, return value, remarks, code example, and requirements."
ms.date: 10/07/2016
ms.assetid: c2e5a65e-b0c5-e25c-411b-5e742e1ea77c
---
# IUriKey::GetSiteName Method
Returns the site name associated with the Uniform Resource Identifier (URI) data.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetSiteName(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a constant null-terminated Unicode string that contains the name of the Web site.  
  
## Remarks  
 An example site name for the default Web site is "Default Web Site".  
  
## Notes for Implementers  
 [IUriKey](../../web-development-reference/native-code-api-reference/iurikey-interface.md) implementers are responsible for memory management with this data; therefore, `IUriKey` implementers that use dynamic memory allocation must release or call `delete` on the `PCWSTR` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IUriKey` implementers are responsible for memory management with this data; therefore, `IUriKey` clients must not release or call `delete` on the returned `PCWSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCWSTR`; otherwise, an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `GetSiteName` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IUriKey#4](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IUriKey/cpp/GetSiteName.cpp#4)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML that is similar to the following.  
  
```  
IUriKey::GetSiteName: Default Web Site  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [IUriKey Interface](../../web-development-reference/native-code-api-reference/iurikey-interface.md)
