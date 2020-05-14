---
title: "IAppHostElementSchema Interface"
ms.date: "10/07/2016"
ms.assetid: 07dfe345-8a9f-5347-b895-839d7d1234ca
---
# IAppHostElementSchema Interface
Represents the schema of a configuration element.  
  
## Syntax  
  
```cpp  
IAppHostElementSchema : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostElementSchema` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetMetadata](../../web-development-reference/native-code-api-reference/iapphostelementschema-getmetadata-method.md)|Gets metadata values from the element schema.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostElementSchema` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[DoesAllowUnschematizedProperties](../../web-development-reference/native-code-api-reference/iapphostelementschema-doesallowunschematizedproperties-property.md)|Determines whether properties that are not defined in the schema can be added to a configuration element.|  
|[Name](../../web-development-reference/native-code-api-reference/iapphostelementschema-name-property.md)|Gets the name of the current schema.|  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostElementSchema`  
  
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
 [IAppHostPropertySchema Interface](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-interface.md)
