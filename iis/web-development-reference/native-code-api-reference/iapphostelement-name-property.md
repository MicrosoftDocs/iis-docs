---
title: "IAppHostElement::Name Property"
description: "The IAppHostElementName property gets the name of the current element. This article describes its syntax, return value, example, and requirements."
ms.date: "10/07/2016"
ms.assetid: 160b5e71-ac79-9d7d-1c7e-880e191967e2
---
# IAppHostElement::Name Property
Gets the name of the current element.  
  
## Syntax  
  
```cpp  
HRESULT Name(  
   [out,  
   retval] BSTR* pbstrName  
);  
```  
  
### Parameters  
 `pbstrName`  
 A pointer to a `BSTR` that contains name of the current element.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example displays all child elements of the `system.webServer/asp` configuration section for the MACHINE/WEBROOT/APPHOST configuration path.  
  
 [!code-cpp[IAppHostAdminLibrary#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementChildElements.cpp#1)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md)
