---
title: "IAppHostElementSchemaCollection Interface"
ms.date: "10/07/2016"
ms.assetid: ce2e0069-bc9b-4a83-98d1-727690e424bb
---
# IAppHostElementSchemaCollection Interface
Represents a collection of [IAppHostElementSchema](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md) objects.  
  
## Syntax  
  
```cpp  
interface IAppHostElementSchemaCollection : IUnknown  
```  
  
## Properties  
 The following table lists the properties exposed by the [IAppHostElementSchemaCollection](../../web-development-reference/native-code-api-reference/iapphostelementschemacollection-interface.md) interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../web-development-reference/native-code-api-reference/iapphostelementschemacollection-count-property.md)|Gets the number of element schemas in the current collection.|  
|[Item](../../web-development-reference/native-code-api-reference/iapphostelementschemacollection-item-property.md)|Gets the element schema at the requested index in the current collection.|  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostElementSchemaCollection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostElementSchema Interface](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md)
