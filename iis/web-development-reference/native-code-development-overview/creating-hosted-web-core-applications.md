---
title: "Creating Hosted Web Core Applications | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1959167d-1711-45d7-babd-8e3a8217a736
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
---
# Creating Hosted Web Core Applications
This section describes how to design a Hosted Web Core. The topics in this section demonstrate how to create an application that uses the Hosted Web Core features, and how to create a custom configuration file for your application.  
  
## In This Section  
 [Walkthrough: Creating a Hosted Web Core Application](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-hosted-web-core-application.md)  
 Describes how to create an application that uses the Hosted Web Core.  
  
 [Walkthrough: Creating a Configuration File for Hosted Web Core](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-configuration-file-for-hosted-web-core.md)  
 Describes how to create a configuration file for use with a Hosted Web Core application.  
  
## Remarks  
 Hosted Web Core enables developers to create applications that load the core IIS functionality. Applications that load the Hosted Web Core use a separate configuration file from IIS, and this feature enables software developers to customize the functionality for their applications. For example, you can write an application that uses the Hosted Web Core functionality to serve Web pages and applications from a Web site that is separate from the Web sites that are hosted by IIS on the same server. When the World Wide Web Publishing Service (WWW service) for IIS is recycled, your application will continue to serve Web pages to Web clients.  
  
 Hosted Web Core applications do not inherit any of the reliability and monitoring features of IIS. Developers that use the Hosted Web Core features to create applications must provide any recovery and performance-related functionality. Because Hosted Web Core applications can host only a single application pool, they are generally single-purpose applications.  
  
 For most situations where customized functionality is required, developers should consider creating HTTP modules and hosting their applications inside IIS. For more information about how to create an HTTP module, see [Creating Native-Code HTTP Modules](../../web-development-reference\native-code-development-overview\creating-native-code-http-modules.md).  
  
## See Also  
 [Native-Code Development Overview](../../web-development-reference\native-code-development-overview\native-code-development-overview.md)   
 [Hosted Web Core API Reference](../../web-development-reference\native-code-api-reference/hosted-web-core-api-reference.md)