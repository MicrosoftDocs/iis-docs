---
title: "IHttpContext3::EnableFullDuplex Method"
ms.date: "10/07/2016"
ms.assetid: 4113c932-4bb4-4046-bc3e-28fc8cfbfb0a
---
# IHttpContext3::EnableFullDuplex Method

Enables an asynchronous full-duplex connection for this context.  
  
## Syntax  
  
```cpp  
virtual VOID EnableFullDuplex(  
   VOID  
) = 0;  
```  
  
### Parameters  

 This method accepts no parameters.  
  
## Return Value  

 This method does not return a value.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [IHttpContext3 Interface](../../web-development-reference/native-code-api-reference/ihttpcontext3-interface.md)
