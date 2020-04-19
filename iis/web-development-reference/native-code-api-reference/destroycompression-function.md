---
title: "DestroyCompression Function"
ms.date: "10/07/2016"
ms.assetid: a3be752e-2d92-4185-a28b-b2a0c15f28dc
---
# DestroyCompression Function
Destroys the specified compression context.  
  
## Syntax  
  
```cpp  
VOID WINAPI DestroyCompression(  
   IN PVOID context  
);  
```  
  
### Parameters  
 `context`  
 [OUT] Pointer to the compression context to destroy.  
  
## Return Value  
 This function does not return a value.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcompression.h|  
  
## See Also  
 [Web Server Core Functions](../../web-development-reference/native-code-api-reference/web-server-core-functions.md)