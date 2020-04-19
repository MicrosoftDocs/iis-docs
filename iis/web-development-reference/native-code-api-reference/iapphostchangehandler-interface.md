---
title: "IAppHostChangeHandler Interface"
ms.date: "10/07/2016"
ms.assetid: e5d96058-2b9b-381e-2bab-51514d730c0a
---
# IAppHostChangeHandler Interface
Provides notifications of changes to the physical files in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration.  
  
## Syntax  
  
```cpp  
interface IAppHostChangeHandler: IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostChangeHandler` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[OnSectionChanges](../../web-development-reference/native-code-api-reference/iapphostchangehandler-onsectionchanges-method.md)|Notifies listeners when a section has changed in a physical file of the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration. All callers must implement the listener.|  
  
## Remarks  
 This notification occurs when the configuration cache needs to flush a configuration file because the physical file has changed. If the physical file changes but does not exist in the configuration cache, the notification will not occur.  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostChangeHandler`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration API Reference](../../web-development-reference/native-code-api-reference/application-host-administration-api-reference.md)
