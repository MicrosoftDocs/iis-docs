---
title: "PFN_WEB_CORE_ACTIVATE Function"
ms.date: "10/07/2016"
ms.assetid: 33897340-911a-4c64-ab92-db1fc283b332
---
# PFN_WEB_CORE_ACTIVATE Function

Starts an instance of the Hosted Web Core.  
  
## Syntax  
  
```cpp  
typedef HRESULT (*PFN_WEB_CORE_ACTIVATE)(  
   IN PCWSTR pszAppHostConfigFile,  
   IN PCWSTR pszRootWebConfigFile,  
   IN PCWSTR pszInstanceName  
);  
```  
  
### Parameters  

 `pszAppHostConfigFile`  
 A pointer to a string that contains the path of a configuration file.  
  
 `pszRootWebConfigFile`  
 A pointer to a string that contains the path of a root Web.config file. (Optional)  
  
 `pszInstanceName`  
 A pointer to a string that contains the name of the instance that will be used for event logging.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_SERVICE_ALREADY_RUNNING|Indicates that an instance of the Hosted Web Core is already running in the process.|  
|ERROR_INVALID_DATA|Indicates that a configuration error occurred in the configuration file.|  
  
> [!NOTE]
>  If the `PFN_WEB_CORE_ACTIVATE` function returns an ERROR_INVALID_DATA message, the Event Viewer may contain additional details regarding the cause of the failure.  
  
## Remarks  

 The `PFN_WEB_CORE_ACTIVATE` function is a prototype for the `WebCoreActivate` DLL entry point in Hwebcore.dll that is used to start the Hosted Web Core. The process that hosts the Web core is required to provide the path of a configuration file that contains the configuration settings for any sites, the application pool, and so on, that are to be created.  
  
> [!NOTE]
> The Hosted Web Core requires a configuration file that follows the design of the ApplicationHost.config file, except that Hosted Web Core supports only one application pool. For more information about how to create a configuration file for your application, see [Walkthrough: Creating a Configuration File for Hosted Web Core](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-configuration-file-for-hosted-web-core.md).  
  
 This function also requires the name of the instance of the Hosted Web Core that [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] uses when it logs events to the Event Viewer. The hosting process may optionally provide the path of a root Web.config file that contains any additional parameters.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Hwebcore.h|  
  
## See Also  

 [Hosted Web Core API Reference](../../web-development-reference/native-code-api-reference/hosted-web-core-api-reference.md)   
 [PFN_WEB_CORE_SHUTDOWN Function](../../web-development-reference/native-code-api-reference/pfn-web-core-shutdown-function.md)
