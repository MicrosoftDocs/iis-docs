---
title: "IWpfReferencedObject::Release Method"
ms.date: "10/07/2016"
ms.assetid: 069ddfd4-c9d2-f0d0-01ee-aaa2a70973fd
---
# IWpfReferencedObject::Release Method
Decrements the reference count for the [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual ULONG Release (  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `ULONG` that contains the updated reference count.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on Windows Vista<br />-   IIS 7.5 on Windows 7<br />-   IIS Express 7.5 on Windows XP, Windows Vista, Windows 7<br />-   IIS 8.0 on Windows 8 Client|  
|Server|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfReferencedObject Interface](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md)   
 [IWpfReferencedObject::AddRef Method](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-addref-method.md)
