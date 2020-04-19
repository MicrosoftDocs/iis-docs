---
title: "IGlobalRSCAQueryProvider Interface"
ms.date: "10/07/2016"
ms.assetid: b4d97a23-123d-5c77-b0f1-ccfc388d5517
---
# IGlobalRSCAQueryProvider Interface
Extends the [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md) interface by adding support for querying IIS Run-Time Status and Control information.  
  
## Syntax  
  
```cpp  
class IGlobalRSCAQueryProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IGlobalRSCAQueryProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetFunctionName](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-getfunctionname-method.md)|Returns the name of the dynamic function call that caused the event.|  
|[GetFunctionParameters](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-getfunctionparameters-method.md)|Returns the parameters of the dynamic function call that caused the event.|  
|[GetOutputBuffer](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-getoutputbuffer-method.md)|Creates a new `BYTE` array.|  
|[ResizeOutputBuffer](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-resizeoutputbuffer-method.md)|Resizes and returns the output `BYTE` array.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
|[SetResult](../../web-development-reference/native-code-api-reference/iglobalrscaqueryprovider-setresult-method.md)|Finalizes the internal buffer.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_RSCA_QUERY](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an `IGlobalRscaQueryProvider` pointer as a parameter on the [CGlobalModule::OnGlobalRSCAQuery](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalrscaquery-method.md)`virtual` method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_RSCA_QUERY` events. It then writes the `IGlobalRSCAQueryProvider` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IGlobalRSCAQueryProvider#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IGlobalRSCAQueryProvider/cpp/IGlobalRSCAQueryProvider.cpp#1)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes two new events to the application log of the Event Viewer, where the Data boxes contain strings similar to the following:  
  
```  
Function Name: PMH_App_Domain_Enum_V1  
```  
  
```  
Parameters:  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IGlobalRSCAQueryProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
