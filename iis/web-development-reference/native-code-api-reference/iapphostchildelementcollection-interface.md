---
title: "IAppHostChildElementCollection Interface"
description: IAppHostChildElementCollection Interface represents the child configuration elements that are nested within the current element.
ms.date: "10/07/2016"
ms.assetid: 4e64c317-e442-5738-b14c-1f252b7b6ea9
---
# IAppHostChildElementCollection Interface
Represents the child configuration elements that are nested within the current element.  
  
## Syntax  
  
```cpp  
interface IAppHostChildElementCollection: IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostChildElementCollection` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[Count](../../web-development-reference/native-code-api-reference/iapphostelementcollection-count-property.md)|Gets the number of configuration elements in the collection.|  
|[Item](../../web-development-reference/native-code-api-reference/iapphostelementcollection-item-property.md)|Gets a configuration element from the collection.|  
  
## Example  
 The following code example lists all child elements under the `system.webServer/asp` configuration section for the MACHINE/WEBROOT/APPHOST path.  
  
 [!code-cpp[IAppHostAdminLibrary#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementChildElements.cpp#1)]  
  
## Inheritance Hierarchy  
 [IUnknown](/windows/win32/api/unknwn/nn-unknwn-iunknown)  
  
 `IAppHostChildElementCollection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostChildElementCollection Interface](../../web-development-reference/native-code-api-reference/iapphostchildelementcollection-interface.md)
