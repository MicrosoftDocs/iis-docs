---
title: "IAppHostPropertySchema::TimeSpanFormat Property"
description: Learn how the TimeSpanFormat property gets a string that describes how the corresponding property should be formatted if the property represents a time span.
ms.date: "10/07/2016"
ms.assetid: ff13d198-e9fd-4e9f-8a77-dd9825ddac68
---
# IAppHostPropertySchema::TimeSpanFormat Property
Gets a string that describes how the corresponding property should be formatted if the property represents a time span.  
  
## Syntax  
  
```cpp  
[propget] HRESULT TimeSpanFormat(  
   [out,  
   retval] BSTR * pbstrTimeSpanFormat  
);  
```  
  
### Parameters  
 `pbstrTimeSpanFormat`  
 Contains the format string to use for the property.  
  
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
 [IAppHostPropertySchema Interface](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-interface.md)
