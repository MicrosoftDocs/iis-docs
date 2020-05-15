---
title: "IProcessHostSupportFunctions::GetApplicationProperties Method"
ms.date: "10/07/2016"
ms.assetid: 84b98c00-58c7-296c-7255-b47ac1d032dc
---
# IProcessHostSupportFunctions::GetApplicationProperties Method

Retrieves the properties from the application's metabase.  
  
## Syntax  
  
```cpp  
virtual HRESULT __stdcall GetApplicationProperties(  
   LPCWSTR appId,  
   BSTR* pbstrVirtualPath,  
   BSTR* pbstrPhysicalPath,  
   BSTR* pbstrSiteName,  
   BSTR* pbstrSiteId  
) = 0;  
```  
  
### Parameters  

 `appId`  
 A string that contains the unique identifier of the application.  
  
 `pbstrVirtualPath`  
 A pointer to a `BSTR` that receives the root virtual path of the application.  
  
 `pbstrPhysicalPath`  
 A pointer to a `BSTR` that receives the root physical path of the application.  
  
 `pbstrSiteName`  
 A pointer to a `BSTR` that receives the display name of the application.  
  
 `pbstrSiteId`  
 A pointer to a `BSTR` that receives the site ID.  
  
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
|Header|Webhost.h|  
  
## See Also  

 [IProcessHostSupportFunctions Interface](../../web-development-reference/native-code-api-reference/iprocesshostsupportfunctions-interface.md)
