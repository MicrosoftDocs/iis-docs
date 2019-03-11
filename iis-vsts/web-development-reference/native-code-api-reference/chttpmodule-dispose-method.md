---
title: "CHttpModule::Dispose Method"
ms.date: "10/07/2016"
ms.assetid: f5640e4c-5cf4-b7a5-8980-71b0c814b450
---
# CHttpModule::Dispose Method
Releases all resources used by the current instance of the [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) class.  
  
## Syntax  
  
```cpp  
virtual VOID Dispose(  
   VOID  
);  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 IIS automatically calls the `Dispose` method at the end of the request.  
  
> [!NOTE]
>  Typically you create a class that is derived from `CHttpModule` by using the C++ `new` operator. Classes that were created with the `new` operator do not need to implement the `Dispose` method to perform any cleanup at the end of the request.  
  
## Example  
 The following example demonstrates how to create a simple "Hello World" HTTP module. The module defines an exported `RegisterModule` function that passes an instance of an `IHttpModuleFactory` interface to the [IHttpModuleRegistrationInfo::SetRequestNotifications](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method and registers for the [RQ_BEGIN_REQUEST](../../web-development-reference\native-code-api-reference/request-processing-constants.md) notification. IIS uses the [IHttpModuleFactory::GetHttpModule](../../web-development-reference\native-code-api-reference/ihttpmodulefactory-gethttpmodule-method.md) method to create an instance of a `CHttpModule` class and returns a success status. IIS also uses the [IHttpModuleFactory::Terminate](../../web-development-reference\native-code-api-reference/ihttpmodulefactory-terminate-method.md) method to remove the factory from memory.  
  
 When an `RQ_BEGIN_REQUEST` notification occurs, IIS calls the module's [CHttpModule::OnBeginRequest](../../web-development-reference\native-code-api-reference/chttpmodule-onbeginrequest-method.md) method to process the current request. `OnBeginRequest` clears the response buffer and modifies the MIME type for the response. The method then creates a data chunk that contains a "Hello World" string and returns the string to a Web client. Finally, the module returns [RQ_NOTIFICATION_FINISH_REQUEST](../../web-development-reference\native-code-api-reference/request-notification-status-enumeration.md) to notify IIS that all notifications are finished and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [CHttpModuleHelloWorld#1](CHttpModuleHelloWorld#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../web-development-reference\native-code-api-reference/chttpmodule-class.md)