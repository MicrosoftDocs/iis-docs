---
title: "IListenerChannelCallback Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a44e1556-723f-91a8-46e5-5553b676d201
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IListenerChannelCallback Interface
Provides listener-channel notifications from protocol handlers to the worker process framework. Also allows protocol handlers to access additional parameters, such as the ID of the listener channel.  
  
## Syntax  
  
```cpp  
struct IListenerChannelCallback : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IListenerChannelCallback` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetBlob](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ilistenerchannelcallback-getblob-method.md)|Retrieves data that the protocol manager will pass to a listener channel when the protocol manager is starting that listener channel.|  
|[GetBlobLength](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ilistenerchannelcallback-getbloblength-method.md)|Returns the size of the buffered data in the listener channel.|  
|[GetId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ilistenerchannelcallback-getid-method.md)|Retrieves the ID of a listener channel that needs to be started.|  
|[ReportMessageReceived](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ilistenerchannelcallback-reportmessagereceived-method.md)|Notifies the worker process framework that a new message was received.|  
|[ReportStarted](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ilistenerchannelcallback-reportstarted-method.md)|Notifies the worker process framework that a listener channel has started.|  
|[ReportStopped](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ilistenerchannelcallback-reportstopped-method.md)|Notifies the worker process framework that a listener channel has shut down.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 Use the `pBlob` parameter in the `GetBlob` method to communicate changes of listener channel data after the listener channel starts.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IListenerChannelCallback`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/windows-process-activation-service-api-reference.md)