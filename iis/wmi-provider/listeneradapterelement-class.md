---
title: "ListenerAdapterElement Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 36ff3ff9-7c5a-c35b-9ceb-0202ac71596b
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# ListenerAdapterElement Class
Specifies configuration settings for a listener adapter.  
  
## Syntax  
  
```vbs  
class ListenerAdapterElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ListenerAdapterElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Identity`|A read/write `string` value that contains the account name that is used to secure the Windows Process Activation Service (WAS) communication channel between the listener service and the listener adapter.|  
|`Name`|A read-only `string` value that contains the name of a listener adapter. The key property.|  
|`ProtocolManagerDll`|A read/write `string` value that specifies the name of the DLL where the listener adapter code is located. The string value may be either a fully qualified path or the short name of the DLL, and the DLL may be either managed or native code. If the DLL cannot be found on disk by using standard search procedures that depend on DLL type, the function specified in the `ProtocolManagerDllInitFunction` property is not called.|  
|`ProtocolManagerDllInitFunction`|A read/write `string` value that contains the name of the function to call on the custom listener adapter code. The function must reside in the DLL specified in the `ProtocolManagerDll` property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `ListenerAdapters` property of the [ListenerAdaptersSection](../wmi-provider/listeneradapterssection-class.md) class.  
  
 Listener adapters are components that establish communication between non-HTTP protocol listeners and the Windows Process Activation Service (WAS). The World Wide Web Publishing Service (WWW service), which contains HTTP-specific functionality, does not use `ListenerAdapterElement` configuration settings.  
  
 Changes to `ListenerAdapterElement` take effect only when a listener adapter connects with WAS. In most cases, this connection requires that the server be restarted.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ListenerAdapterElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.ApplicationHost.Configuration.ListenerAdapterElement](../wmi-provider/listeneradapterelement-class.md)
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [ListenerAdaptersSection Class](../wmi-provider/listeneradapterssection-class.md)