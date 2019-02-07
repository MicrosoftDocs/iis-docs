---
title: "ResetCompression Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8c4c5c42-9c9a-4075-b618-3b2057be2e46
caps.latest.revision: 3
author: "shirhatti"
manager: "wpickett"
---
# ResetCompression Function
Resets the compression context.  
  
## Syntax  
  
```cpp  
HRESULT WINAPI ResetCompression(  
   IN OUT PVOID context  
);  
```  
  
#### Parameters  
 `context`  
 [OUT] Pointer to the compression context to reset.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 This function is a required export, but is not used in IIS 7.0 on Windows Vista or on Windows Server 2008. This function has been deprecated and is not a required export for IIS 7.5 on Windows 7 or on Windows Server 2008 R2, or for IIS 8.0 on Windows 8 Client or on Windows 8 Server.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcompression.h|  
  
## See Also  
 [Web Server Core Functions](../../web-development-reference\native-code-api-reference/web-server-core-functions.md)