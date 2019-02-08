---
title: "IAppHostPathMapper::MapPath Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b258e39a-5c1c-761a-73d0-33e5fd237349
caps.latest.revision: 12
author: "shirhatti"
manager: "wpickett"
---
# IAppHostPathMapper::MapPath Method
Maps [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration paths to custom file system paths.  
  
## Syntax  
  
```cpp  
HRESULT MapPath(  
   [in,  
   string] BSTR bstrConfigPath,  
   [in,  
   string] BSTR bstrMappedPhysicalPath,  
   [out,  
   string,  
   retval] BSTR* pbstrNewPhysicalPath  
);  
```  
  
#### Parameters  
 `bstrConfigPath`  
 A `BSTR` that contains the configuration path.  
  
 `bstrMappedPhysicalPath`  
 A `BSTR` that contains the default file system path mapping.  
  
 `pbstrNewPhysicalPath`  
 A pointer to a `BSTR` that contains the new file system path.  
  
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
 [IAppHostPathMapper Interface](../../web-development-reference\native-code-api-reference/iapphostpathmapper-interface.md)