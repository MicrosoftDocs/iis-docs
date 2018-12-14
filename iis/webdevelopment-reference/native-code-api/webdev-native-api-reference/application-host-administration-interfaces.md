---
title: "Application Host Administration Interfaces | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e222d822-4d00-431a-8fc4-e09496636681
caps.latest.revision: 9
author: "shirhatti"
manager: "wpickett"
---
# Application Host Administration Interfaces
This section describes the API that provides read and write access to configuration data and read access to the configuration schema.  
  
## In This Section  
 The following methods were supported in IIS 7.0:  
  
|Interface|Description|  
|---------------|-----------------|  
|[IAppHostAdminManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-interface.md)|Provides read-only access to effective data in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostChangeHandler](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostchangehandler-interface.md)|Provides notifications of changes to the physical files in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration.|  
|[IAppHostChildElementCollection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostchildelementcollection-interface.md)|Represents the child configuration elements that are nested within the current element.|  
|[IAppHostCollectionSchema](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostcollectionschema-interface.md)|Represents a schema for a collection in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigException](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigexception-interface.md)|Represents an exception in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigFile](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-interface.md)|Represents a configuration file in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigLocation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfiglocation-interface.md)|Represents a configuration location in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigLocationCollection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfiglocationcollection-interface.md)|Provides access to a collection of configuration locations in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigmanager-interface.md)|Provides access to the physical configuration files in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md)|Represents a single element in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostElementCollection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementcollection-interface.md)|Represents a collection of [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) objects.|  
|[IAppHostElementSchema](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschema-interface.md)|Represents the schema of a configuration element.|  
|[IAppHostMappingExtension](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmappingextension-interface.md)|Extends the configuration system mapping functionality.|  
|[IAppHostPathMapper](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpathmapper-interface.md)|Maps [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration paths to file system paths.|  
|[IAppHostProperty](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostproperty-interface.md)|Represents a property of a configuration element.|  
|[IAppHostPropertyCollection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertycollection-interface.md)|Represents a collection of properties.|  
|[IAppHostPropertyException](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyexception-interface.md)|Indicates that the configuration system has thrown an exception when it validates a property against the configuration schema.|  
|[IAppHostPropertySchema](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-interface.md)|Provides access to the attributes that define the schema for a property.|  
|[IAppHostSectionDefinition](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinition-interface.md)|Provides access to the attributes that define the behavior of a configuration section.|  
|[IAppHostSectionDefinitionCollection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinitioncollection-interface.md)|Represents a collection of configuration sections definitions.|  
|[IAppHostSectionGroup](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiongroup-interface.md)|Provides access to a group of configuration section groups or configuration section definitions.|  
|[IAppHostWritableAdminManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostwritableadminmanager-interface.md)|Provides read/write access to explicit data in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
  
 The following methods were supported in IIS 7.5:  
  
|Interface|Description|  
|---------------|-----------------|  
|[IAppHostElementSchemaCollection Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschemacollection-interface.md)|Represents a collection of [IAppHostElementSchema Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementschema-interface.md) objects.|  
|[IAppHostPropertySchemaCollection Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschemacollection-interface.md)|Represents a collection of [IAppHostPropertySchema Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyschema-interface.md) objects.|  
|[IAppHostElementExtension Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementextension-interface.md)|Used to handle element extensions in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostPropertyExtension Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpropertyextension-interface.md)|Used to handle property extensions in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostMethodInstance Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodinstance-interface.md)|Provides methods that access a specific invocation instance of the corresponding [IAppHostMethod Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethod-interface.md).|  
|[IAppHostMethod Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethod-interface.md)|Provides access to a custom method that is optionally supported on an [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) object.|  
|[IAppHostMethodExtension Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodextension-interface.md)|Used to handle method extensions in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostMethodCollection Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmethodcollection-interface.md)|Represents a collection of methods.|  
|[IAppHostConstantValue Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconstantvalue-interface.md)|Provides methods that access the string names of a specific constant and its corresponding integer value.|  
|[IAppHostConstantValueCollection Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconstantvaluecollection-interface.md)|Represents a collection of constants.|  
|[IAppHostPathMapper2 Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostpathmapper2-interface.md)|Provides methods that are called by the server implementation when the server informs the client about the hierarchy mapping decisions|  
  
## See Also  
 [Application Host Administration API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-api-reference.md)