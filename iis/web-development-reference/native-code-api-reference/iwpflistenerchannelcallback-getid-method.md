---
title: "IWpfListenerChannelCallback::GetId Method"
ms.date: "10/07/2016"
ms.assetid: 031a01fe-3958-c081-d984-dcd22411eeb0
---
# IWpfListenerChannelCallback::GetId Method
Retrieves the ID of a listener channel that needs to be started.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetId(  
   OUT DWORD* pdwListenerChannelId  
) = 0;  
```  
  
### Parameters  
 `pdwListenerChannelId`  
 A pointer to a `DWORD` buffer that receives the ID of a listener channel.  
  
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
 [IWpfListenerChannelCallback::ReportMessageReceived Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportmessagereceived-method.md)
 [IWpfListenerChannelCallback::ReportStarted Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportstarted-method.md)
 [IWpfListenerChannelCallback::ReportStopped Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportstopped-method.md)
