---
title: "IWpfListenerChannelCallback::ReportStopped Method"
ms.date: "10/07/2016"
ms.assetid: 2f6912a9-9207-1a0f-1f00-6e3b44b810ed
---
# IWpfListenerChannelCallback::ReportStopped Method
Notifies the worker process framework that a listener channel has shut down.  
  
## Syntax  
  
```cpp  
virtual HRESULT ReportStopped(  
   HRESULT hr  
) = 0;  
```  
  
### Parameters  
 `hr`  
 The `HRESULT` that reports the status of the listener channel. For example, `hr` might contain the `HRESULT` error when a listener channel fails to stop.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfListenerChannelCallback Interface](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-interface.md)   
 [IWpfListenerChannelCallback::GetBlob Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-getblob-method.md)   
 [IWpfListenerChannelCallback::GetId Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-getid-method.md)   
 [IWpfListenerChannelCallback::ReportMessageReceived Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportmessagereceived-method.md)   
 [IWpfListenerChannelCallback::ReportStarted Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportstarted-method.md)
