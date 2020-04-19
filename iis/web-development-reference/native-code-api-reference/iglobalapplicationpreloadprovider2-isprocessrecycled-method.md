---
title: "IGlobalApplicationPreloadProvider2::IsProcessRecycled Method"
ms.date: "10/07/2016"
ms.assetid: 1f882ddc-2a96-46ee-8b3f-1d72ed17601d
---
# IGlobalApplicationPreloadProvider2::IsProcessRecycled Method
Indicates whether the application’s worker process has recycled.  
  
## Syntax  
  
```cpp  
Virtual BOOL IsProcessRecycled(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method accepts no parameters.  
  
## Return Value  
 `true` if the process has recycled; otherwise, `false`.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IGlobalApplicationPreloadProvider2 Interface](../../web-development-reference/native-code-api-reference/iglobalapplicationpreloadprovider2-interface.md)