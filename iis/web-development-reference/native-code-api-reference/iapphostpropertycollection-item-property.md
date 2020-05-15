---
title: "IAppHostPropertyCollection::Item Property"
ms.date: "10/07/2016"
ms.assetid: 5e7303e8-480b-dbd5-a48b-8435540f2ab2
---
# IAppHostPropertyCollection::Item Property

Gets the property with the requested index or property name in the collection.  
  
## Syntax  
  
```cpp  
HRESULT get_Item(  
   [in] VARIANT cIndex,  
   [out,  
   retval] IAppHostProperty** ppProperty  
);  
```  
  
### Parameters  

 `cIndex`  
 A `VARIANT` that contains the index or property name of the item to retrieve from the collection.  
  
 `ppProperty`  
 A pointer to a pointer for an [IAppHostProperty](../../web-development-reference/native-code-api-reference/iapphostproperty-interface.md) interface.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the requested property was not found.|  
  
## Example  

 The following code example demonstrates how to use the [IAppHostPropertyCollection](../../web-development-reference/native-code-api-reference/iapphostpropertycollection-interface.md) interface to access the `enabled` property of the `defaultDocument` configuration section.  
  
 [!code-cpp[IAppHostAdminLibrary#6](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostPropertySetValue.cpp#6)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  

 [IAppHostPropertyCollection Interface](../../web-development-reference/native-code-api-reference/iapphostpropertycollection-interface.md)
