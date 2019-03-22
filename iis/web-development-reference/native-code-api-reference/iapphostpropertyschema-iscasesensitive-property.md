---
title: "IAppHostPropertySchema::IsCaseSensitive Property"
ms.date: "10/07/2016"
ms.assetid: 8265b9e8-9d05-f2e7-0211-0fbe1725e7ca
---
# IAppHostPropertySchema::IsCaseSensitive Property
Gets a value that indicates whether the property value is case-sensitive.  
  
## Syntax  
  
```cpp  
HRESULT get_IsCaseSensitive(  
   [out,  
   retval] VARIANT_BOOL* pfIsCaseSensitive  
);  
```  
  
### Parameters  
 `pfIsCaseSensitive`  
 A pointer to a `VARIANT_BOOL`. `VARIANT_TRUE` if the property value is case-sensitive; otherwise, `VARIANT_FALSE`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 If the `pfIsCaseSensitive` parameter returns `VARIANT_TRUE`, properties that use the current schema will be case-sensitive. For example, a case-sensitive property that accepted values of "Allow" and "Deny" would not accept the values "allow" and "deny". By default, this property is `VARIANT_FALSE`.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostPropertySchema Interface](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-interface.md)