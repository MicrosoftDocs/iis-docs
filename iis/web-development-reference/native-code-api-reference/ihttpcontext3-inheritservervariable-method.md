---
title: "IHttpContext3::InheritServerVariable Method"
ms.date: "10/07/2016"
ms.assetid: 53aec6b2-0ca9-4bc9-96bb-fd2a13a066ae
---
# IHttpContext3::InheritServerVariable Method
Causes the request to inherit the specified server variable.  
  
## Syntax  
  
```cpp  
virtual HRESULT InheritServerVariable(  
   _In_ PCSTR szName,  
   _In_ BOOL  fFailIfNotExist = FALSE  
) = 0;  
```  
  
### Parameters  
 `szName`  
 [IN] Name of the server variable to inherit.  
  
 `fFailIfNotExist`  
 [IN] `true` is the method should fail if the server variable does not exist; otherwise `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
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
 [IHttpContext3 Interface](../../web-development-reference/native-code-api-reference/ihttpcontext3-interface.md)