---
title: "IAppHostConfigException Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 09e456cc-7b93-2227-adf1-18f2287be43c
caps.latest.revision: 14
author: "shirhatti"
manager: "wpickett"
---
# IAppHostConfigException Interface
Represents an exception in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
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
|[ConfigPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-configpath-property.md)|Gets the configuration path of the file that contains the configuration that caused the exception.|  
|[ErrorLine](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-errorline-property.md)|Gets the contents of line in the configuration file that caused the current exception to be thrown.|  
|[ErrorString](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-errorstring-property.md)|Gets a description of the reason for the exception.|  
|[FileName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-filename-property.md)|Gets the physical path of the configuration file that caused the current exception to be thrown.|  
|[LineNumber](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-linenumber-property.md)|Gets the number of the line in the configuration file that caused the exception to be thrown.|  
|[PostErrorLine](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-posterrorline-property.md)|Gets the contents of the line after the line in the configuration file that caused the current exception to be thrown.|  
|[PreErrorLine](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-preerrorline-property.md)|Gets the contents of the line before the line in the configuration file that caused the current exception to be thrown.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostConfigException`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [Application Host Administration API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-api-reference.md)