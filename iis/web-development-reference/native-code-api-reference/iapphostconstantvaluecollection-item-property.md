---
title: "IAppHostConstantValueCollection::Item Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c38ab36a-6af1-4d86-9a94-cad9a8950d58
caps.latest.revision: 7
author: "shirhatti"
manager: "wpickett"
---
# IAppHostConstantValueCollection::Item Property
Gets the constant value at the specified index.  
  
## Syntax  
  
```cpp  
[propget, id(DISPID_VALUE)] HRESULT Item(  
   [in] VARIANT cIndex,  
   [out, retval] IAppHostConstantValue ** ppConstantValue  
);  
```  
  
#### Parameters  
 `cIndex`  
 A `VARIANT` that represents the constant value to retrieve. If the `VARIANT` is of type integer, the index is a zero-based index to the collection of IAppHostElement objects. If the `VARIANT` is of type string, it is the name of the constant value.  
  
 `ppConstantValue`  
 A pointer to a pointer of an [IAppHostConstantValue Interface](../../web-development-reference\native-code-api-reference/iapphostconstantvalue-interface.md) object that contains the constant value.  
  
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
 [IAppHostConstantValue Interface](../../web-development-reference\native-code-api-reference/iapphostconstantvalue-interface.md)