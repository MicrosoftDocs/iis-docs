---
title: "IAppHostMethodInstance::Output Property"
description: Learn how the Output property gets an IAppHostElement Interface in which output parameters may be retrieved after a specified method instance has been executed.
ms.date: "10/07/2016"
ms.assetid: 69d9d293-d5d8-4443-8e24-e0e3a76f0721
---
# IAppHostMethodInstance::Output Property
Gets an [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) in which output parameters may be retrieved after a specified method instance has been executed.  
  
## Syntax  
  
```cpp  
[propget] HRESULT Output(  
   [out,retval] IAppHostElement ** ppOutputElement  
);  
```  
  
### Parameters  
 `ppOutputElement`  
 Contains the [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) that represents the output parameters.  
  
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
 [IAppHostMethodInstance Interface](../../web-development-reference/native-code-api-reference/iapphostmethodinstance-interface.md)
