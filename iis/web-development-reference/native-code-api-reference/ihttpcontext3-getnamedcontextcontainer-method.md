---
title: "IHttpContext3::GetNamedContextContainer Method"
ms.date: "10/07/2016"
ms.assetid: e2d27fe0-83f6-4716-a137-85aa39f2a064
---
# IHttpContext3::GetNamedContextContainer Method
Retrieves a container of named context objects.  
  
## Syntax  
  
```cpp  
virtual INamedContextContainer * GetNamedContextContainer(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method accepts no parameters.  
  
## Return Value  
 A pointer to an [INamedContextContainer](../../web-development-reference/native-code-api-reference/inamedcontextcontainer-interface.md) interface.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext3 Interface](../../web-development-reference/native-code-api-reference/ihttpcontext3-interface.md)
