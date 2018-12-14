---
title: "IGlobalRSCAQueryProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b4d97a23-123d-5c77-b0f1-ccfc388d5517
caps.latest.revision: 30
author: "shirhatti"
manager: "wpickett"
---
# IGlobalRSCAQueryProvider Interface
Extends the [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md) interface by adding support for querying IIS Run-Time Status and Control information.  
  
## Syntax  
  
```cpp  
class IGlobalRSCAQueryProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IGlobalRSCAQueryProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetFunctionName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-getfunctionname-method.md)|Returns the name of the dynamic function call that caused the event.|  
|[GetFunctionParameters](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-getfunctionparameters-method.md)|Returns the parameters of the dynamic function call that caused the event.|  
|[GetOutputBuffer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-getoutputbuffer-method.md)|Creates a new `BYTE` array.|  
|[ResizeOutputBuffer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-resizeoutputbuffer-method.md)|Resizes and returns the output `BYTE` array.|  
|[SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md).)|  
|[SetResult](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalrscaqueryprovider-setresult-method.md)|Finalizes the internal buffer.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_RSCA_QUERY](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events receive an `IGlobalRscaQueryProvider` pointer as a parameter on the [CGlobalModule::OnGlobalRSCAQuery](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalrscaquery-method.md)`virtual` method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_RSCA_QUERY` events. It then writes the `IGlobalRSCAQueryProvider` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalRSCAQueryProvider#1](IGlobalRSCAQueryProvider#1)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes two new events to the application log of the Event Viewer, where the Data boxes contain strings similar to the following:  
  
```  
Function Name: PMH_App_Domain_Enum_V1  
```  
  
```  
Parameters:  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md)  
  
 `IGlobalRSCAQueryProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)