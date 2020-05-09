---
title: "IAppHostChildElementCollection::Count Method"
ms.date: "10/07/2016"
ms.assetid: cb49dabb-b5f2-0133-a463-311d4ca9ffb1
---
# IAppHostChildElementCollection::Count Method
Gets the number of configuration elements in the collection.  
  
## Syntax  
  
```cpp  
HRESULT Count(  
   [out,  
   retval] DWORD* pcCount  
);  
```  
  
### Parameters  
 `pcCount`  
 A pointer to a `DWORD` that contains the number of child elements in the collection.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example lists all child elements under the `system.webServer/asp` configuration section for the MACHINE/WEBROOT/APPHOST configuration path.  
  
 [!code-cpp[IAppHostAdminLibrary#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementChildElements.cpp#1)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostChildElementCollection Interface](../../web-development-reference/native-code-api-reference/iapphostchildelementcollection-interface.md)
