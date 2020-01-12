---
title: "IHttpModuleFactory::Terminate Method"
ms.date: "10/07/2016"
ms.assetid: d9fe6194-999d-df11-b41d-144d8bb1f0ed
---
# IHttpModuleFactory::Terminate Method
Terminates an [IHttpModuleFactory](../../web-development-reference/native-code-api-reference/ihttpmodulefactory-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual VOID Terminate(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 When you design an HTTP module, your `IHttpModuleFactory` interface must provide a `Terminate` method. Your module will use this method to perform any cleanup tasks before it exits. For example, your `Terminate` method should at the very least remove your `IHttpModuleFactory` interface from memory. In a more elaborate implementation, your module might utilize reference counting before removing an `IHttpModuleFactory` interface from memory, but that is not required.  
  
## Example  
 The following code example demonstrates how to create a simple "Hello World" HTTP module. The module defines an exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function that passes an instance of an `IHttpModuleFactory` interface to the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method and registers for the [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification. IIS uses the [IHttpModuleFactory::GetHttpModule](../../web-development-reference/native-code-api-reference/ihttpmodulefactory-gethttpmodule-method.md) method to create an instance of a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class and returns a success status. IIS also uses the `Terminate` method of the `IHttpModuleFactory` interface to remove the factory from memory.  
  
 When an `RQ_BEGIN_REQUEST` notification is triggered, IIS calls the module's [CHttpModule::OnBeginRequest](../../web-development-reference/native-code-api-reference/chttpmodule-onbeginrequest-method.md) method to process the current request. `OnBeginRequest` clears the response buffer and modifies the MIME type for the response. The method then creates a data chunk that contains a "Hello World" string and returns the string to a Web client. Finally, the module returns a status indicator that notifies IIS that all notifications are finished and then exits.  
  
 [!code-cpp[CHttpModuleHelloWorld#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/CHttpModuleHelloWorld/cpp/CHttpModuleHelloWorld.cpp#1)]  
  
 Your module must export the `RegisterModule` function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../web-development-reference/native-code-api-reference/chttpmodule-class.md)   
 [IHttpModuleFactory Interface](../../web-development-reference/native-code-api-reference/ihttpmodulefactory-interface.md)