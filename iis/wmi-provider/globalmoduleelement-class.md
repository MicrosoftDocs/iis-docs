---
title: "GlobalModuleElement Class"
ms.date: "10/07/2016"
ms.assetid: e1f046e1-2b3a-031f-d47b-aa0f97c2ba9f
---
# GlobalModuleElement Class

Configures a native or managed code module that processes requests to the Web server.  
  
## Syntax  
  
```vbs  
class GlobalModuleElement : CollectionElement  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `GlobalModuleElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Image`|A read/write `string` value that specifies either a managed type or the file system path of the .dll file that contains the global module.|  
|`Name`|A required unique read/write `string` value that specifies a unique name for the global module. The key property.|  
|`PreCondition`|A read/write `string` value that contains a comma-delimited list of values that represent preconditions for the module to be loaded. The possible values are listed later in the Remarks section.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `GlobalModules` array property of the [GlobalModulesSection](../wmi-provider/globalmodulessection-class.md) class.  
  
 The following table lists the possible values for the `Precondition` property. The `integratedMode` and `ISAPIMode` settings are mutually exclusive. The default is `null`.  
  
|Value|Description|  
|-----------|-----------------|  
|`integratedMode`|IIS loads the module only for application pools that run in integrated mode.|  
|`ISAPIMode`|IIS loads the module only for application pools that run in ISAPI mode.|  
|`runtimeVersion`|IIS loads the module only for application pools that use the specified [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] version. To enable this precondition, append a string in the format v*MajorVersion*.*MinorVersion* to the string "runtimeVersion" (for example, "runtimeVersionv2.0").|  
|`managedHandler`|IIS loads the module only if the request is mapped to a managed handler. This setting can optimize performance by preventing static files from going through managed modules for every request.|  
  
## Inheritance Hierarchy  

 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `GlobalModuleElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [GlobalModulesSection Class](../wmi-provider/globalmodulessection-class.md)
