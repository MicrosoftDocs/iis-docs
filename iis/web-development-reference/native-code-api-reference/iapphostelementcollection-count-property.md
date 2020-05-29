---
title: "IAppHostElementCollection::Count Property"
ms.date: "10/07/2016"
ms.assetid: e91d28c5-2287-b8e8-e2b0-55b81420a53f
---
# IAppHostElementCollection::Count Property
Returns the number of elements in the current collection.  
  
## Syntax  
  
```cpp  
HRESULT Count(  
   [out,  
   retval] DWORD* pcElementCount  
);  
```  
  
### Parameters  
 `pcElementCount`  
 A pointer to a `DWORD` that contains the number of elements.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example loops through all the child elements and properties of the `system.applicationHost/sites` configuration section in the MACHINE/WEBROOT/APPHOST commit path.  
  
 [!code-cpp[IAppHostAdminLibrary#2](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementGetCollection.cpp#2)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElementCollection Interface](../../web-development-reference/native-code-api-reference/iapphostelementcollection-interface.md)
