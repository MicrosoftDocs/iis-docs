---
title: "DeInitCompression Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 5d51951a-cdd7-4a2b-aebf-65239963bf1d
caps.latest.revision: 4
author: "shirhatti"
manager: "wpickett"
---
# DeInitCompression Function
De-initializes the compression scheme.  
  
## Syntax  
  
```cpp  
VOID WINAPI DeInitCompression(  
   VOID  
);  
```  
  
#### Parameters  
 This function takes no parameters.  
  
## Return Value  
 This function does not return a value  
  
## Remarks  
 When used with IIS, this method is called before the compression scheme dynamic link library (DLL) is unloaded by the IIS compression module.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcompression.h|  
  
## See Also  
 [Web Server Core Functions](../../web-development-reference\webdev-native-api-reference/web-server-core-functions.md)