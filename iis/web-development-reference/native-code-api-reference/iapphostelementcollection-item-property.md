---
title: "IAppHostElementCollection::Item Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 551db540-404a-2a9b-3e9e-988399c52d64
caps.latest.revision: 12
author: "shirhatti"
manager: "wpickett"
---
# IAppHostElementCollection::Item Property
Gets the element at the requested index in the current collection.  
  
## Syntax  
  
```cpp  
HRESULT Item(  
   [in] VARIANT cIndex,  
   [out,  
   retval] IAppHostElement** ppElement  
);  
```  
  
#### Parameters  
 `cIndex`  
 A `VARIANT` that represents the index of the item to retrieve from the collection.  
  
 `ppElement`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference\webdev-native-api-reference/iapphostelement-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following example loops through all the child elements and properties of the `system.applicationHost/sites` configuration section in the MACHINE/WEBROOT/APPHOST commit path.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#2](IAppHostAdminLibrary#2)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElementCollection Interface](../../web-development-reference\webdev-native-api-reference/iapphostelementcollection-interface.md)