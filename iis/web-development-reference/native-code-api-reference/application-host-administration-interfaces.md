---
title: "Application Host Administration Interfaces"
ms.date: "10/07/2016"
ms.assetid: e222d822-4d00-431a-8fc4-e09496636681
---
# Application Host Administration Interfaces

This section describes the API that provides read and write access to configuration data and read access to the configuration schema.  
  
## In This Section  

 The following methods were supported in IIS 7.0:  
  
|Interface|Description|  
|---------------|-----------------|  
|[IAppHostAdminManager](../../web-development-reference/native-code-api-reference/iapphostadminmanager-interface.md)|Provides read-only access to effective data in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostChangeHandler](../../web-development-reference/native-code-api-reference/iapphostchangehandler-interface.md)|Provides notifications of changes to the physical files in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration.|  
|[IAppHostChildElementCollection](../../web-development-reference/native-code-api-reference/iapphostchildelementcollection-interface.md)|Represents the child configuration elements that are nested within the current element.|  
|[IAppHostCollectionSchema](../../web-development-reference/native-code-api-reference/iapphostcollectionschema-interface.md)|Represents a schema for a collection in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigException](../../web-development-reference/native-code-api-reference/iapphostconfigexception-interface.md)|Represents an exception in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigFile](../../web-development-reference/native-code-api-reference/iapphostconfigfile-interface.md)|Represents a configuration file in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigLocation](../../web-development-reference/native-code-api-reference/iapphostconfiglocation-interface.md)|Represents a configuration location in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigLocationCollection](../../web-development-reference/native-code-api-reference/iapphostconfiglocationcollection-interface.md)|Provides access to a collection of configuration locations in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostConfigManager](../../web-development-reference/native-code-api-reference/iapphostconfigmanager-interface.md)|Provides access to the physical configuration files in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostElement](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md)|Represents a single element in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostElementCollection](../../web-development-reference/native-code-api-reference/iapphostelementcollection-interface.md)|Represents a collection of [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) objects.|  
|[IAppHostElementSchema](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md)|Represents the schema of a configuration element.|  
|[IAppHostMappingExtension](../../web-development-reference/native-code-api-reference/iapphostmappingextension-interface.md)|Extends the configuration system mapping functionality.|  
|[IAppHostPathMapper](../../web-development-reference/native-code-api-reference/iapphostpathmapper-interface.md)|Maps [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration paths to file system paths.|  
|[IAppHostProperty](../../web-development-reference/native-code-api-reference/iapphostproperty-interface.md)|Represents a property of a configuration element.|  
|[IAppHostPropertyCollection](../../web-development-reference/native-code-api-reference/iapphostpropertycollection-interface.md)|Represents a collection of properties.|  
|[IAppHostPropertyException](../../web-development-reference/native-code-api-reference/iapphostpropertyexception-interface.md)|Indicates that the configuration system has thrown an exception when it validates a property against the configuration schema.|  
|[IAppHostPropertySchema](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-interface.md)|Provides access to the attributes that define the schema for a property.|  
|[IAppHostSectionDefinition](../../web-development-reference/native-code-api-reference/iapphostsectiondefinition-interface.md)|Provides access to the attributes that define the behavior of a configuration section.|  
|[IAppHostSectionDefinitionCollection](../../web-development-reference/native-code-api-reference/iapphostsectiondefinitioncollection-interface.md)|Represents a collection of configuration sections definitions.|  
|[IAppHostSectionGroup](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-interface.md)|Provides access to a group of configuration section groups or configuration section definitions.|  
|[IAppHostWritableAdminManager](../../web-development-reference/native-code-api-reference/iapphostwritableadminmanager-interface.md)|Provides read/write access to explicit data in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
  
 The following methods were supported in IIS 7.5:  
  
|Interface|Description|  
|---------------|-----------------|  
|[IAppHostElementSchemaCollection Interface](../../web-development-reference/native-code-api-reference/iapphostelementschemacollection-interface.md)|Represents a collection of [IAppHostElementSchema Interface](../../web-development-reference/native-code-api-reference/iapphostelementschema-interface.md) objects.|  
|[IAppHostPropertySchemaCollection Interface](../../web-development-reference/native-code-api-reference/iapphostpropertyschemacollection-interface.md)|Represents a collection of [IAppHostPropertySchema Interface](../../web-development-reference/native-code-api-reference/iapphostpropertyschema-interface.md) objects.|  
|[IAppHostElementExtension Interface](../../web-development-reference/native-code-api-reference/iapphostelementextension-interface.md)|Used to handle element extensions in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostPropertyExtension Interface](../../web-development-reference/native-code-api-reference/iapphostpropertyextension-interface.md)|Used to handle property extensions in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostMethodInstance Interface](../../web-development-reference/native-code-api-reference/iapphostmethodinstance-interface.md)|Provides methods that access a specific invocation instance of the corresponding [IAppHostMethod Interface](../../web-development-reference/native-code-api-reference/iapphostmethod-interface.md).|  
|[IAppHostMethod Interface](../../web-development-reference/native-code-api-reference/iapphostmethod-interface.md)|Provides access to a custom method that is optionally supported on an [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) object.|  
|[IAppHostMethodExtension Interface](../../web-development-reference/native-code-api-reference/iapphostmethodextension-interface.md)|Used to handle method extensions in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[IAppHostMethodCollection Interface](../../web-development-reference/native-code-api-reference/iapphostmethodcollection-interface.md)|Represents a collection of methods.|  
|[IAppHostConstantValue Interface](../../web-development-reference/native-code-api-reference/iapphostconstantvalue-interface.md)|Provides methods that access the string names of a specific constant and its corresponding integer value.|  
|[IAppHostConstantValueCollection Interface](../../web-development-reference/native-code-api-reference/iapphostconstantvaluecollection-interface.md)|Represents a collection of constants.|  
|[IAppHostPathMapper2 Interface](../../web-development-reference/native-code-api-reference/iapphostpathmapper2-interface.md)|Provides methods that are called by the server implementation when the server informs the client about the hierarchy mapping decisions|  
  
## See Also  

 [Application Host Administration API Reference](../../web-development-reference/native-code-api-reference/application-host-administration-api-reference.md)
