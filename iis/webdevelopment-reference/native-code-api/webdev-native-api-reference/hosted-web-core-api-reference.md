---
title: "Hosted Web Core API Reference | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d9d5406e-edef-ab14-c78a-711f70d5cda2
caps.latest.revision: 29
author: "shirhatti"
manager: "wpickett"
---
# Hosted Web Core API Reference
This section describes the functions that developers can use to host Web pages with the Hosted Web Core. Hosted Web Core enables processes other than a worker process to load an instance of the IIS core. This instance requires a separate configuration file and can host only one application pool.  
  
## In This Section  
  
|Function|Description|  
|--------------|-----------------|  
|[PFN_WEB_CORE_ SET_METADATA_DLL_ENTRY](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-web-core-activate-function.md)|Starts an instance of the Hosted Web Core.|  
|PFN_WEB_CORE_SET_METADATA_DLL_ENTRY|Sets metadata options for a web core activation.|  
|[PFN_WEB_CORE_SHUTDOWN](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-web-core-shutdown-function.md)|Shuts down an instance of the Hosted Web Core.|  
  
## Remarks  
 Creating an instance of the Hosted Web Core enables a process other than a worker process to load the IIS core, which is the base Web application and content-serving functionality that is provided by IIS.  
  
> [!NOTE]
>  Applications written using the Hosted Web Core do not inherit the monitoring functionality that is provided by the Windows Process Activation Service (WAS) for IIS applications.  
  
 Hosted Web Core enables a process to host Web pages without having to re-create the application functionality that is provided natively by the IIS core. For example, the IIS core already provides authentication and authorization; therefore, a developer who is writing an application that uses the Hosted Web Core would not have to manually create a security infrastructure. The IIS core also provides additional functionality that would require a lot of effort to manually re-create, such as Internet Server API (ISAPI) filter and extension support, functionality provided by the HTTP protocol stack (HTTP.sys) driver, authentication, and so on.  
  
> [!NOTE]
>  The Hosted Web Core requires a configuration file that follows the design of the ApplicationHost.config file, except that Hosted Web Core supports only one application pool. For more information about the configuration file required for Hosted Web Code, see [Walkthrough: Creating a Configuration File for Hosted Web Core](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-configuration-file-for-hosted-web-core.md).  
  
## See Also  
 [Creating Hosted Web Core Applications](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/creating-hosted-web-core-applications.md)