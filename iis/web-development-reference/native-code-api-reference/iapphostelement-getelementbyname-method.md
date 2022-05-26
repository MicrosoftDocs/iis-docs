---
title: "IAppHostElement::GetElementByName Method"
description: Learn how the IAppHostElement::GetElementByName method gets a requested child element from the current element.  
ms.date: "10/07/2016"
ms.assetid: 1fbd772c-733f-b950-cb44-db5f3ae5ec8a
---
# IAppHostElement::GetElementByName Method
Gets a requested child element from the current element.  
  
## Syntax  
  
```cpp  
HRESULT GetElementByName(  
   [in,  
   string] BSTR bstrSubName,  
   [out,  
   retval] IAppHostElement** ppElement  
);  
```  
  
### Parameters  
 `bstrSubName`  
 A `BSTR` that contains the name of the requested child element.  
  
 `ppElement`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) interface.  
  
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
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md)
