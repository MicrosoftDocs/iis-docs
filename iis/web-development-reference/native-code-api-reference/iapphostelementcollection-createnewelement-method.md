---
title: "IAppHostElementCollection::CreateNewElement Method"
ms.date: "10/07/2016"
ms.assetid: e1fdf112-7a39-9ed8-1a05-e143edb500a2
---
# IAppHostElementCollection::CreateNewElement Method
Creates a new element.  
  
## Syntax  
  
```cpp  
HRESULT CreateNewElement(  
   [in,  
   string,  
   defaultvalue("")] BSTR bstrElementName,  
   [out,  
   retval] IAppHostElement** ppElement  
);  
```  
  
### Parameters  
 `bstrElementName`  
 A `BSTR` that contains the name for the newly created element.  
  
 `ppElement`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that `bstrElementName` is not valid.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElementCollection Interface](../../web-development-reference/native-code-api-reference/iapphostelementcollection-interface.md)