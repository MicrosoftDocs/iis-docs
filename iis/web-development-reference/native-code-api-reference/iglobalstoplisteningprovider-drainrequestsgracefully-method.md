---
title: "IGlobalStopListeningProvider::DrainRequestsGracefully Method"
ms.date: "10/07/2016"
ms.assetid: 047b08d2-bc6e-f885-038c-0bf55226a2a9
---
# IGlobalStopListeningProvider::DrainRequestsGracefully Method
Indicates whether IIS will gracefully close any currently pending requests.  
  
## Syntax  
  
```cpp  
virtual BOOL DrainRequestsGracefully(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if IIS will close current requests gracefully; otherwise, `false`.  
  
## Remarks  
 The `DrainRequestsGracefully` method retrieves information about how IIS is going to close any pending requests when a worker process is shutting down. For example, if IIS is restarted, the `DrainRequestsGracefully` method will return `false` because all pending requests will be terminated. However, if an application pool is recycled, the `DrainRequestsGracefully` method will return `true` because all pending requests on the worker process that is shutting down will be closed gracefully.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1. Registers for the [GL_STOP_LISTENING](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
2. Creates a [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) class that contains an [OnGlobalStopListening](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalstoplistening-method.md) method. This method performs the following tasks:  
  
    1. Retrieves the status that IIS will use to close current requests by using the `DrainRequestsGracefully` method.  
  
    2. Formats a string that contains the status information.  
  
    3. Writes the string as an event to the application log of the Event Viewer.  
  
3. Removes the `CGlobalModule` class from memory and then exits.  
  
 [!code-cpp[IGlobalStopListeningProviderDrainRequestsGracefully#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IGlobalStopListeningProviderDrainRequestsGracefully/cpp/IGlobalStopListeningProviderDrainRequestsGracefully.cpp#1)]  
  
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
 [IGlobalStopListeningProvider Interface](../../web-development-reference/native-code-api-reference/iglobalstoplisteningprovider-interface.md)
