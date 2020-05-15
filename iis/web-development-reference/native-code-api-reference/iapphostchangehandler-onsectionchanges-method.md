---
title: "IAppHostChangeHandler::OnSectionChanges Method"
ms.date: "10/07/2016"
ms.assetid: d6185b17-fabc-49bc-8cb0-c79195aae3c6
---
# IAppHostChangeHandler::OnSectionChanges Method

Notifies listeners when a section has changed in a physical file of the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration. All callers must implement the listener.  
  
## Syntax  
  
```cpp  
HRESULT OnSectionChanges(  
   [in,  
   string] BSTR bstrSectionName,  
   [in,  
   string] BSTR bstrConfigPath  
);  
```  
  
### Parameters  

 `bstrSectionName`  
 A `BSTR` that contains the configuration section that changed.  
  
 `bstrConfigPath`  
 A `BSTR` that contains the configuration path that changed.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Implementers should return S_OK to indicate that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## Remarks  

 An example of a `bstrConfigPath` is "MACHINE/WEBROOT/APPHOST". An example of a `bstrSectionName` is "system.webServer/defaultDocument".  
  
## See Also  

 [IAppHostChangeHandler Interface](../../web-development-reference/native-code-api-reference/iapphostchangehandler-interface.md)
