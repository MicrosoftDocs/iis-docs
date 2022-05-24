---
title: "IAppHostMethod Interface"
description: Describes the IAppHostMethod interface and provides the syntax, methods, properties, inheritance hierarchy, and requirements.
ms.date: "10/07/2016"
ms.assetid: 86f78e95-288b-4fd5-979c-33a4a0e891e9
---
# IAppHostMethod Interface
Provides access to a custom method that is optionally supported on an [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) object.  
  
## Syntax  
  
```cpp  
interface IAppHostMethod : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostMethod` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[IAppHostMethod::CreateInstance Method](../../web-development-reference/native-code-api-reference/iapphostmethod-createinstance-method.md)|Creates an executable  [IAppHostMethodInstance Interface](../../web-development-reference/native-code-api-reference/iapphostmethodinstance-interface.md) object from the current method.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostMethod` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[IAppHostMethod::Name Property](../../web-development-reference/native-code-api-reference/iapphostmethod-name-property.md)|Gets the name of the method.|  
|[IAppHostMethod::Schema Property](../../web-development-reference/native-code-api-reference/iapphostmethod-schema-property.md)|Gets the schema assigned to the current method.|  
  
## Remarks  
 [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) objects provide a means for an administration system to support custom-defined methods that can be executed against a specific [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) object. The methods are executed on the server side and the implementation of these custom methods is not exposed to the client.  
  
## Inheritance Hierarchy  
 [IUnknown](/windows/win32/api/unknwn/nn-unknwn-iunknown)  
  
 `IAppHostMethod`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md)   
 [IAppHostMethodInstance Interface](../../web-development-reference/native-code-api-reference/iapphostmethodinstance-interface.md)   
 [IAppHostMethodExtension Interface](../../web-development-reference/native-code-api-reference/iapphostmethodextension-interface.md)
