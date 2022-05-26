---
title: "IHttpServer2::GetMetadata Method"
description: Describes the syntax, parameters, return value and requirements for the IHttpServer2::GetMetadata method.
ms.date: "10/07/2016"
ms.assetid: 780c10e6-4cfb-4cc9-9111-24ff1591fd76
---
# IHttpServer2::GetMetadata Method
Retrieves metadata about a website given its name and URL.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetMetadata(  
   _In_ PCWSTR                 pszSiteName,  
   _In_ PCWSTR                 pszUrl,  
   _Outptr_ IReferencedMetadataInfo  ** ppMetadataInfo  
    ) = 0;  
```  
  
### Parameters  
 `pszSiteName`  
 [IN] Name of the website.  
  
 `pszUrl`  
 [IN] The application URL (uniform resource locator).  
  
 `ppMetadataInfo`  
 [OUT] Points to metadata about the website.  
  
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
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer2 Interface](../../web-development-reference/native-code-api-reference/ihttpserver2-interface.md)
