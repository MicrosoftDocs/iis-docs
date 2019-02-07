---
title: "IAppHostConfigLocationCollection::AddLocation Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4223693f-1a64-b222-74bc-8505955306bb
caps.latest.revision: 9
author: "shirhatti"
manager: "wpickett"
---
# IAppHostConfigLocationCollection::AddLocation Method
Adds a new configuration location to the collection.  
  
## Syntax  
  
```cpp  
HRESULT AddLocation(  
   [in,  
   string] BSTR bstrLocationPath,  
   [out,  
   retval] IAppHostConfigLocation** ppNewLocation  
);  
```  
  
#### Parameters  
 `bstrLocationPath`  
 A `BSTR` that contains the path of the new configuration location.  
  
 `ppNewLocation`  
 A pointer to a pointer for an [IAppHostConfigLocation](../../web-development-reference\webdev-native-api-reference/iapphostconfiglocation-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_ALREADY_EXISTS|Indicates that the location already exists.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigLocationCollection Interface](../../web-development-reference\webdev-native-api-reference/iapphostconfiglocationcollection-interface.md)