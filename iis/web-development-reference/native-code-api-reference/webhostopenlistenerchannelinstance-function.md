---
title: "WebhostOpenListenerChannelInstance Function"
ms.date: "10/07/2016"
ms.assetid: 40420cdc-4133-273e-ddbc-d42ab2046558
---
# WebhostOpenListenerChannelInstance Function
Requests that a listener channel be started in a worker process for this application pool.  
  
## Syntax  
  
```cpp  
HRESULT WebhostOpenListenerChannelInstance(  
   IN DWORD ProtocolHandle,  
   IN LPCWSTR AppPoolId,  
   IN DWORD ListenerChannelId,  
   IN PBYTE ListenerChannelBlob,  
   IN DWORD ListenerChannelBlobByteCount  
);  
```  
  
### Parameters  
 `ProtocolHandle`  
 [IN] A `DWORD` that contains the protocol handle for the listener channel.  
  
 `AppPoolId`  
 [IN] A string that contains the application pool ID for the listener channel.  
  
 `ListenerChannelId`  
 [IN] A `DWORD` that contains the listener channel identifier.  
  
 `ListenerChannelBlob`  
 [IN] A `PBYTE` that contains information needed for connecting the worker process to the listener. The data is not visible to the Windows Process Activation Service (WAS). For more information, see the Remarks section below.  
  
 `ListenerChannelBlobByteCount`  
 [IN] A `DWORD` that contains the number of bytes in the listener channel BLOB.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_INVALIDARG|Indicates that one of the parameters is not valid.|  
|HRESULT_FROM_WIN32( ERROR_NOT_FOUND)|Indicates that the protocol has not been registered.|  
|HRESULT_FROM_WIN32(ERROR_PIPE_NOT_CONNECTED)|Indicates that the listener adapter is not connected to the Windows Process Activation Service.|  
  
## Remarks  
 The function is called when the listener channel receives its first request, or when the Windows Process Activation Service notifies the listener adapter that it can start another instance of the listener channel.  
  
 The `ListenerChannelBlob` parameter is passed to the Windows Process Activation Service, the worker process, and the protocol manager. If the listener adapter is routing requests per application, the BLOB will probably contain the application key that the process protocol handler will need to pass to the protocol manager. The protocol manager needs the application key for the application domain protocol handler to be connected. The details of the BLOB are left to the protocol writer.  
  
 By default, the Windows Process Activation Service establishes an overlapped recycle process, in which the worker process that is to be shut down is kept running until after a new worker process is started. The Windows Process Activation Service saves the listener channel BLOB and will use it to ask the new worker process to connect. This means that the listener channel must be able to accept multiple processes connecting to it.  
  
 The Windows Process Activation Service does not manage how a listener channel relates to an application (for example, the listener can choose to have many listener channels per application pool or just one). Therefore, the Windows Process Activation Service cannot determine for the listener adapter what should happen to the listener channels when changes occur. The Windows Process Activation Service will just notify the listener adapter and allow it to manage those decisions.  
  
 You will need to set the listener channels access control lists (ACLs) to the identity of the application pool.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [Listener Adapter Exported Functions](../../web-development-reference/native-code-api-reference/listener-adapter-exported-functions.md)