---
title: "IAppHostElement::Properties Property"
ms.date: "10/07/2016"
ms.assetid: 357d4d6b-291c-90ec-a39b-59f6de3fdd61
---
# IAppHostElement::Properties Property
Gets the collection of properties that are defined for the current element.  
  
## Syntax  
  
```cpp  
HRESULT get_Properties(  
   [out,  
   retval] IAppHostPropertyCollection** ppProperties  
);  
```  
  
### Parameters  
 `ppProperties`  
 A pointer to a pointer for an [IAppHostPropertyCollection](../../web-development-reference/native-code-api-reference/iapphostpropertycollection-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example obtains the `enabled` property from the property collection of the `system.webServer/defaultDocument` configuration section, sets the value to `false`, and then commits the changes.  
  
 [!code-cpp[IAppHostAdminLibrary#6](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostPropertySetValue.cpp#6)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md)