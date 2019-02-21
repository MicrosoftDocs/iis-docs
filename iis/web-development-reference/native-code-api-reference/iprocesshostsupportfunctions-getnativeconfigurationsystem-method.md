---
title: "IProcessHostSupportFunctions::GetNativeConfigurationSystem Method"
ms.date: "10/07/2016"
ms.assetid: 62c808d8-fe81-749e-8574-f9800fdf2811
---
# IProcessHostSupportFunctions::GetNativeConfigurationSystem Method
Retrieves the [INativeConfigurationSystem](http://msdn.microsoft.com/en-us/ef29f2da-90b4-be7d-e59b-83fa1799f477) interface pointer.  
  
## Syntax  
  
```cpp  
virtual HRESULT __stdcall GetNativeConfigurationSystem(  
   VOID **ppConfigSystem  
) = 0;  
```  
  
### Parameters  
 `ppConfigSystem`  
 The address of a `VOID` pointer that receives an `INativeConfigurationSystem` interface pointer.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 For more information, see the [IHttpServer::GetConfigObject](../../web-development-reference\native-code-api-reference/ihttpserver-getconfigobject-method.md) method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [IProcessHostSupportFunctions Interface](../../web-development-reference\native-code-api-reference/iprocesshostsupportfunctions-interface.md)   
 [IHttpServer::GetConfigObject Method](../../web-development-reference\native-code-api-reference/ihttpserver-getconfigobject-method.md)