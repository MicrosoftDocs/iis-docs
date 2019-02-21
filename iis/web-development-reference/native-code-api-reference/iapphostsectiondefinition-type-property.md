---
title: "IAppHostSectionDefinition::Type Property"
ms.date: "10/07/2016"
ms.assetid: 4aeb69c1-4e84-884f-d98f-2a7d07eacfc2
---
# IAppHostSectionDefinition::Type Property
Gets the type name of a class that represents the current configuration section.  
  
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
 A pointer to a `BSTR` that contains the type name of the current configuration section.  
  
 `bstrType`  
 A `BSTR` that contains the new type name of the current [IAppHostSectionDefinition](../../web-development-reference\native-code-api-reference/iapphostsectiondefinition-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
  
> [!NOTE]
>  This property is used only when a file is opened from a class in the [System.Configuration](/dotnet/api/system.configuration) namespace.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostSectionDefinition Interface](../../web-development-reference\native-code-api-reference/iapphostsectiondefinition-interface.md)