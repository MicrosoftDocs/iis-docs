---
title: "IAppHostChildElementCollection::Item Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 882e0b49-d2ca-c629-8018-0b73afab53cd
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
---
# IAppHostChildElementCollection::Item Method
Gets a configuration element from the collection.  
  
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
 A `VARIANT` that contains the index of the element to return from the collection.  
  
 `ppElement`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference\native-code-api-reference/iapphostelement-interface.md) instance.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the property is out of range.|  
  
## Example  
 The following code example lists all child elements under the `system.webServer/asp` configuration section for the MACHINE/WEBROOT/APPHOST configuration path.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#1](IAppHostAdminLibrary#1)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostChildElementCollection Interface](../../web-development-reference\native-code-api-reference/iapphostchildelementcollection-interface.md)