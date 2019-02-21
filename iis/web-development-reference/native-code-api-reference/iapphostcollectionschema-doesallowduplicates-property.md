---
title: "IAppHostCollectionSchema::DoesAllowDuplicates Property"
ms.date: "10/07/2016"
ms.assetid: a57aec87-3cc3-4734-848a-9d27ccdf40db
---
# IAppHostCollectionSchema::DoesAllowDuplicates Property
Gets a Boolean value that determines whether a collection that implements the current schema allows for duplicate keys.  
  
## Syntax  
  
```cpp  
HRESULT DoesAllowDuplicates(  
   [out,  
   retval] VARIANT_BOOL* pfAllowDuplicates  
);  
```  
  
### Parameters  
 `pfAllowDuplicates`  
 A pointer to a `VARIANT_BOOL`. `VARIANT_TRUE` if duplicate names are allowed; otherwise, `VARIANT_FALSE`.  
  
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
 [IAppHostCollectionSchema Interface](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-interface.md)