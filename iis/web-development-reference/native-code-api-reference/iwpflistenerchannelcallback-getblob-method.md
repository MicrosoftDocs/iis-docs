---
title: "IWpfListenerChannelCallback::GetBlob Method"
ms.date: "10/07/2016"
ms.assetid: 31afe7e7-b508-326a-3770-485b4429c29f
---
# IWpfListenerChannelCallback::GetBlob Method
Retrieves data that the protocol manager will pass to a listener channel when the protocol manager is starting a listener channel.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetBlob(  
   IN OUT PBYTE pBlob,  
   IN OUT DWORD* pcbBlob  
) = 0;  
```  
  
### Parameters  
 `pBlob`  
 A pointer to a `BYTE` buffer that contains data that will be passed to the listener channel.  
  
 `pcbBlob`  
 A pointer to a `DWORD` that contains the size of the data pointed to by `pBlob`.  
  
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
 [IWpfListenerChannelCallback::GetId Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-getid-method.md)   
 [IWpfListenerChannelCallback::ReportMessageReceived Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportmessagereceived-method.md)   
 [IWpfListenerChannelCallback::ReportStarted Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportstarted-method.md)   
 [IWpfListenerChannelCallback::ReportStopped Method](../../web-development-reference/native-code-api-reference/iwpflistenerchannelcallback-reportstopped-method.md)