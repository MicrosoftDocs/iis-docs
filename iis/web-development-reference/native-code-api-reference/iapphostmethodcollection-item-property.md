---
title: "IAppHostMethodCollection::Item Property"
ms.date: "10/07/2016"
ms.assetid: 20d6b0bc-5c11-44ca-bb02-91440c404d5b
---
# IAppHostMethodCollection::Item Property
Gets the [IAppHostMethod Interface](../../web-development-reference/native-code-api-reference/iapphostmethod-interface.md) that is specified by the requested index.  
  
## Syntax  
  
```cpp  
[propget, id(DISPID_VALUE)] HRESULT Item(  
   [in] VARIANT cIndex,  
   [out, retval] IAppHostMethod** ppMethod  
);  
```  
  
### Parameters  
 `cIndex`  
 A `VARIANT` that specifies which `IAppHostMethod` is being selected from the collection. If the `VARIANT` is of type integer, the index is a zero-based index to the collection. If the VARIANT is of type string, the index is the name of the method being accessed.  
  
 `ppMethod`  
 Contains the `IAppHostMethod` that is being retrieved.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the requested method was not found.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostMethodCollection Interface](../../web-development-reference/native-code-api-reference/iapphostmethodcollection-interface.md)   
 [IAppHostMethod Interface](../../web-development-reference/native-code-api-reference/iapphostmethod-interface.md)
