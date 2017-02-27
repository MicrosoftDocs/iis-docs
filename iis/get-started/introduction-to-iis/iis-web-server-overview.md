---
title: "IIS Web Server Overview | Microsoft Docs"
author: rick-anderson
description: "The IIS 7 and later Web server have a completely modular architecture that offers three key benefits: Componentization, Extensibility, and ASP.NET Integratio..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/16/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/get-started/introduction-to-iis/iis-web-server-overview
msc.type: authoredcontent
---
IIS Web Server Overview
====================
by IIS Team, Mike Volodarsky

### Compatibility


| Version | Notes |
| --- | --- |
| IIS 7.0 and later | The features described in this article were introduced in IIS 7.0. |
| IIS 6.0 and earlier | The features described in this article were not supported prior to IIS 7.0. |


The IIS 7 and later web servers have a completely modular architecture which offers three key benefits:

- Componentization
- Extensibility
- ASP.NET Integration

## Componentization

All of the Web server features are now managed as [standalone components](iis-modules-overview.md) which you can easily add, remove, and replace. This enables several key advantages over previous versions of IIS:

1. **Secure the server by reducing the attack surface area**. Reducing surface area is one of the most powerful ways to secure a server system. With IIS, you can remove all unused server features, achieving the minimum surface area possible while preserving the functionality of your application.
2. **Improve performance and reduce memory footprint**. By removing unused server features, you can also reduce the amount of memory the server uses, and improve performance by reducing the amount of feature code that executes on every request to your application.
3. **Build custom / specialized servers**. By selecting a particular set of server features, you can build custom servers that are optimized for performing a specific function within your application topology, such as edge caching or load balancing. You can add custom features to extend or replace any existing functionality using your own or third party server components built on the new extensibility APIs. The componentized architecture provides long term benefits to the IIS community: it facilitates the development of new server features as they are needed both inside Microsoft and among third party developers.

IIS has also componentized the powerful HTTP process activation model introduced in IIS 6.0 with Application Pools. The HTTP process activation model is available for more than just Web applications, receiving requests or messages over any protocol. This protocol independent service is called the Windows Process Activation Service (WAS). The [Windows Communication Foundation](https://msdn.microsoft.com/en-us/library/ms735119.aspx) (WCF) ships with protocol adapters that can leverage the capabilities of the WAS, improving the reliability and resource usage of WCF services.

## Extensibility

Developers can leverage the modular architecture of IIS to build powerful server components that extend or replace the existing Web server features and add value to web applications hosted on IIS.

Here are reasons to develop for IIS:

1. **Empower Web applications**. Extending IIS enables Web applications to benefit from functionality that in many cases cannot be easily provided at the application layer. Using the IIS ASP.NET or native C++ extensibility, developers can build solutions that add value for all application components, such as custom authentication schemes, monitoring and logging, security filtering, load balancing, content redirection, and state management.
2. **Better development experience**. The [brand new C++ extensibility model](../../develop/runtime-extensibility/develop-a-native-cc-module-for-iis.md) alleviates most of the problems that previously plagued the ISAPI development, introducing a simplified object oriented API that promotes writing robust server code. In addition, better Visual Studio integration further improves the experience of developing for IIS.
3. **Use the full power of ASP.NET.** [ASP.NET integration](../../application-frameworks/building-and-running-aspnet-applications/aspnet-integration-with-iis.md) enables server modules to be [rapidly developed with the familiar interfaces of ASP.NET 2.0](../../develop/runtime-extensibility/developing-a-module-using-net.md) and rich ASP.NET application services. ASP.NET modules can provide services uniformly to ASP, CGI, static files and other content types, and can fully extend the server without the limitation present in previous versions of IIS.

## ASP.NET Integration

IIS allows Web applications to fully leverage the powerful features and extensibility of ASP.NET 2.0. ASP.NET features including forms-based authentication, membership, session state and many others can be used for all types of content, providing a unified experience across the entire Web application. Developers can use the familiar ASP.NET extensibility model and rich .NET APIs to build IIS server features that are as powerful as those written using the native C++ APIs.

Use the links below to start learning the aspects of IIS configuration, see a lab about getting started and download kits with resources readily available on IIS.NET.

**Start Learning**

- [IIS Modules Overview](iis-modules-overview.md)
- [ASP.NET Integration with IIS](../../application-frameworks/building-and-running-aspnet-applications/aspnet-integration-with-iis.md)
- [How to Take Advantage of the IIS Integrated Pipeline](../../application-frameworks/building-and-running-aspnet-applications/how-to-take-advantage-of-the-iis-integrated-pipeline.md)
- [End-to-End Extensibility Example](../../develop/runtime-extensibility/an-end-to-end-extensibility-example-for-iis-developers.md)
- [Building a Customized Server](../planning-your-iis-architecture.md)
- [Develop a Module Using .NET](../../develop/runtime-extensibility/developing-a-module-using-net.md)
- [Develop a Native (C\C++) Module](../../develop/runtime-extensibility/develop-a-native-cc-module-for-iis.md)

**Get Started**

- [Windows Server 2008 R2 Evaluation Editions and Virtual Labs](https://www.microsoft.com/en-us/server-cloud/windows-server/2008-r2-trial.aspx)

**Downloads**

- [Managed Module Starter Kit](https://www.iis.net/downloads/community)
- [Native (C\C++) Module Starter Kit](https://www.iis.net/downloads/community)
  
  
[Discuss in IIS Forums](https://forums.iis.net/default.aspx?GroupID=41)