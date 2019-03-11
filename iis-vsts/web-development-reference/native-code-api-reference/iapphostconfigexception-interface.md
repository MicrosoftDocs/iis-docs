---
title: "IAppHostConfigException Interface"
ms.date: "10/07/2016"
ms.assetid: 09e456cc-7b93-2227-adf1-18f2287be43c
---
# IAppHostConfigException Interface
Represents an exception in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
Interface IAppHostConfigException : public IUnknown  
```  
  
## Methods  
 This interface contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostConfigException` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[ConfigPath](../../web-development-reference\native-code-api-reference/iapphostconfigexception-configpath-property.md)|Gets the configuration path of the file that contains the configuration that caused the exception.|  
|[ErrorLine](../../web-development-reference\native-code-api-reference/iapphostconfigexception-errorline-property.md)|Gets the contents of line in the configuration file that caused the current exception to be thrown.|  
|[ErrorString](../../web-development-reference\native-code-api-reference/iapphostconfigexception-errorstring-property.md)|Gets a description of the reason for the exception.|  
|[FileName](../../web-development-reference\native-code-api-reference/iapphostconfigexception-filename-property.md)|Gets the physical path of the configuration file that caused the current exception to be thrown.|  
|[LineNumber](../../web-development-reference\native-code-api-reference/iapphostconfigexception-linenumber-property.md)|Gets the number of the line in the configuration file that caused the exception to be thrown.|  
|[PostErrorLine](../../web-development-reference\native-code-api-reference/iapphostconfigexception-posterrorline-property.md)|Gets the contents of the line after the line in the configuration file that caused the current exception to be thrown.|  
|[PreErrorLine](../../web-development-reference\native-code-api-reference/iapphostconfigexception-preerrorline-property.md)|Gets the contents of the line before the line in the configuration file that caused the current exception to be thrown.|  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostConfigException`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference\native-code-api-reference/application-host-administration-interfaces.md)   
 [Application Host Administration API Reference](../../web-development-reference\native-code-api-reference/application-host-administration-api-reference.md)