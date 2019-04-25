---
title: "IHttpApplication::GetApplicationId Method"
ms.date: "10/07/2016"
ms.assetid: 08081804-c3f1-7971-b5f9-fc4e5e967106
---
# IHttpApplication::GetApplicationId Method
Retrieves the identifying application path for the current request.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetApplicationId(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the identifying path for the application pool.  
  
## Remarks  
 The `GetApplicationId` method returns the unique identity path for the application that is processing the current request. For example, the identifying path for the application pool that is processing requests for the default Web site would be /LM/W3SVC/1/ROOT.  
  
## Example  
 The following code example demonstrates how to use the `GetApplicationId` method to create an HTTP module that retrieves the identifying path for the current application and returns this information to a Web client.  
  
 [!code-cpp[IHttpApplicationGetApplicationId#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpApplicationGetApplicationId/cpp/IHttpApplicationGetApplicationId.cpp#1)]  
  
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
 [IHttpApplication Interface](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md)