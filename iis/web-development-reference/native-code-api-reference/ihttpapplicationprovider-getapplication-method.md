---
title: "IHttpApplicationProvider::GetApplication Method"
ms.date: "10/07/2016"
ms.assetid: 0fe58b12-e575-f28c-028e-1235e6f2d321
---
# IHttpApplicationProvider::GetApplication Method
Retrieves an [IHttpApplication](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual IHttpApplication* GetApplication(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an `IHttpApplication` interface.  
  
## Remarks  
 Developers can use the `GetApplication` method to retrieve an `IHttpApplication` interface, which they can then use to retrieve configuration information for an application.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Registers for the [GL_APPLICATION_START](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
2.  Creates a [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) class that contains an [OnGlobalApplicationStart](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalapplicationstart-method.md) method. This method performs the following tasks:  
  
    1.  Retrieves an `IHttpApplication` interface by using the `GetApplication` method.  
  
    2.  Retrieves the physical path of the current context's application by using the [IHttpApplication::GetApplicationPhysicalPath](../../web-development-reference/native-code-api-reference/ihttpapplication-getapplicationphysicalpath-method.md) method.  
  
    3.  Writes the physical path information as an event to the application log of the Event Viewer.  
  
3.  Removes the `CGlobalModule` class from memory and then exits.  
  
 [!code-cpp[IHttpApplicationProviderGetApplication#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpApplicationProviderGetApplication/cpp/IHttpApplicationProviderGetApplication.cpp#1)]  
  
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
 [IHttpApplicationProvider Interface](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-interface.md)