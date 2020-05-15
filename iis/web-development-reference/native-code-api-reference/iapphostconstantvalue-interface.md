---
title: "IAppHostConstantValue Interface"
ms.date: "10/07/2016"
ms.assetid: 10e3f9c1-2fad-4a18-8e27-1c0ec23edeb8
---
# IAppHostConstantValue Interface

Provides methods that access the string names of a specific constant and its corresponding integer value.  
  
## Syntax  
  
```cpp  
interface IAppHostConstantValue : IUnknown  
```  
  
## Methods  

 This interface contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `IAppHostConstantValue` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[IAppHostConstantValue::Name Property](../../web-development-reference/native-code-api-reference/iapphostconstantvalue-name-property.md)|Gets the name of the constant.|  
|[IAppHostConstantValue::Value Property](../../web-development-reference/native-code-api-reference/iapphostconstantvalue-value-property.md)|Gets the integer value of the current constant.|  
  
## Inheritance Hierarchy  

 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostConstantValue`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  

 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)
