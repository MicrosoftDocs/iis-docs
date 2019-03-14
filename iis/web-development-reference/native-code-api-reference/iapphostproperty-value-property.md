---
title: "IAppHostProperty::Value Property"
ms.date: "10/07/2016"
ms.assetid: faa2afd0-3e3a-cf4e-7d1b-9832d325edcc
---
# IAppHostProperty::Value Property
Gets or sets the value of the current property.  
  
## Syntax  
  
```cpp  
HRESULT get_Value(  
   [out,  
   retval] VARIANT* pVariant  
);  
HRESULT put_Value(  
   VARIANT value  
);  
```  
  
### Parameters  
 `pVariant`  
 A pointer to a `VARIANT` that contains the current property value.  
  
 `value`  
 A `VARIANT` that contains the new property value.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 When you set this property, the new value that is passed to the property must validate against the property schema that is assigned to the current property.  
  
## Example  
 The following code example disables the default document by setting the `enabled` attribute of the `defaultDocument` element to `false`.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#6](IAppHostAdminLibrary#6)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostProperty Interface](../../web-development-reference/native-code-api-reference/iapphostproperty-interface.md)