---
title: "IAppHostSectionGroup::Type Property"
ms.date: "10/07/2016"
ms.assetid: b3e52338-322f-a954-c6a8-e5641d214dba
---
# IAppHostSectionGroup::Type Property
Gets or sets the type name of the configuration section group.  
  
## Syntax  
  
```cpp  
HRESULT get_Type(  
   [out,  
   retval] BSTR* pbstrType  
);   
HRESULT put_Type(  
   BSTR bstrType  
);  
```  
  
### Parameters  
 `pbstrType`  
 A pointer to a `BSTR` that contains the name of the configuration section group.  
  
 `bstrType`  
 A `BSTR` that contains the type name of the configuration section group.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 IIS rarely uses the `Type` property or the underlying `Type` attribute.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostSectionGroup Interface](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-interface.md)