---
title: "IAppHostConstantValueCollection Interface"
ms.date: "10/07/2016"
ms.assetid: 90e2f8f5-7b99-40c5-a911-a583abc73080
---
# IAppHostConstantValueCollection Interface
Represents a collection of [IAppHostConstantValue Interface](../../web-development-reference\native-code-api-reference/iapphostconstantvalue-interface.md) objects.  
  
## Syntax  
  
```cpp  
interface IAppHostConstantValueCollection : IUnknown  
```  
  
## Methods  
 This interface contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostConstantValueCollection` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[IAppHostConstantValueCollection::Count Property](../../web-development-reference\native-code-api-reference/iapphostconstantvaluecollection-count-property.md)|Gets the count of constant values in the current collection.|  
|[IAppHostConstantValueCollection::Item Property](../../web-development-reference\native-code-api-reference/iapphostconstantvaluecollection-item-property.md)|Gets the constant value at the specified index.|  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostConstantValueCollection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\native-code-api-reference/application-host-administration-interfaces.md)