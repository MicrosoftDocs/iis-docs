---
title: "Creating Native-Code HTTP Modules"
ms.date: "10/07/2016"
ms.assetid: b99e275d-5da6-452a-ab3f-88ac0c57d618
---
# Creating Native-Code HTTP Modules
This section describes how to create native-code HTTP modules for use with IIS 7 and IIS 8.  
  
 In many ways, native-code HTTP modules resemble an amalgamation of the technologies that software developers used to create managed [!INCLUDE[vstecasp](../../wmi-provider/includes/vstecasp-md.md)] HTTP modules and native-code ISAPI filters and extensions with earlier versions of IIS. In the past, developers created managed HTTP modules by using the [!INCLUDE[dnprdnshort](../../wmi-provider/includes/dnprdnshort-md.md)], and the modules processed only [!INCLUDE[vstecasp](../../wmi-provider/includes/vstecasp-md.md)] requests. Native-code ISAPI filters and extensions were able to process all requests, but they lacked many of the HTTP module features. With IIS7 and IIS 8, developers can create HTTP modules by using new APIs that provide a class-based infrastructure that combines many of concepts from these earlier technologies into a single powerful architecture.  
  
## In This Section  
 [Comparing Native-Code and Managed-Code Notifications](../../web-development-reference/native-code-development-overview/comparing-native-code-and-managed-code-notifications.md)  
 Compares the list of notifications for native-code and managed-code HTTP modules.  
  
 [Designing Native-Code HTTP Modules](../../web-development-reference/native-code-development-overview/designing-native-code-http-modules.md)  
 Explains several concepts for HTTP module design.  
  
 [Walkthrough: Creating a Global-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-global-level-http-module-by-using-native-code.md)  
 Describes how to create a sample global-level HTTP module.  
  
 [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md)  
 Describes how to create a sample request-level HTTP module.  
  
## See Also  
 [Native-Code Development Overview](../../web-development-reference/native-code-development-overview/native-code-development-overview.md)