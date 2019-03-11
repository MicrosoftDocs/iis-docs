---
title: "IAppHostMethodCollection Interface"
ms.date: "10/07/2016"
ms.assetid: dd460889-c151-4b4e-9e37-dfcdc7d74c72
---
# IAppHostMethodCollection Interface
Represents a collection of methods.  
  
## Syntax  
  
```cpp  
interface IAppHostMethodCollection : IUnknown  
```  
  
## Methods  
 This interface contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostMethodCollection` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[IAppHostMethodCollection::Count Property](../../web-development-reference\native-code-api-reference/iapphostmethodcollection-count-property.md)|Gets the number methods in the collection.|  
|[IAppHostMethodCollection::Item Property](../../web-development-reference\native-code-api-reference/iapphostmethodcollection-item-property.md)|Gets the method with the requested index or method name in the collection.|  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostMethodCollection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostProperty Interface](../../web-development-reference\native-code-api-reference/iapphostproperty-interface.md)