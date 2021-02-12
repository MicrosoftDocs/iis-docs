---
title: "IListenerChannelCallback Interface"
ms.date: "10/07/2016"
ms.assetid: a44e1556-723f-91a8-46e5-5553b676d201
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
|[GetBlob](../../web-development-reference/native-code-api-reference/ilistenerchannelcallback-getblob-method.md)|Retrieves data that the protocol manager will pass to a listener channel when the protocol manager is starting that listener channel.|  
|[GetBlobLength](../../web-development-reference/native-code-api-reference/ilistenerchannelcallback-getbloblength-method.md)|Returns the size of the buffered data in the listener channel.|  
|[GetId](../../web-development-reference/native-code-api-reference/ilistenerchannelcallback-getid-method.md)|Retrieves the ID of a listener channel that needs to be started.|  
|[ReportMessageReceived](../../web-development-reference/native-code-api-reference/ilistenerchannelcallback-reportmessagereceived-method.md)|Notifies the worker process framework that a new message was received.|  
|[ReportStarted](../../web-development-reference/native-code-api-reference/ilistenerchannelcallback-reportstarted-method.md)|Notifies the worker process framework that a listener channel has started.|  
|[ReportStopped](../../web-development-reference/native-code-api-reference/ilistenerchannelcallback-reportstopped-method.md)|Notifies the worker process framework that a listener channel has shut down.|  
  
## Properties  
 This interface contains no properties.  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 Use the `pBlob` parameter in the `GetBlob` method to communicate changes of listener channel data after the listener channel starts.  
  
## Inheritance Hierarchy  
 [IUnknown](/windows/win32/api/unknwn/nn-unknwn-iunknown)  
  
 `IListenerChannelCallback`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service API Reference](../../web-development-reference/native-code-api-reference/windows-process-activation-service-api-reference.md)
