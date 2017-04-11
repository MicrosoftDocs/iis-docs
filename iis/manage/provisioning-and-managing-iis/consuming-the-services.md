---
title: "Consuming the Services | Microsoft Docs"
author: walterov
description: "Since Hosting Services Code Sample is implemented using Windows Communication Foundation, consuming it is fairly straightforward. Here, a few key points are..."
ms.author: iiscontent
manager: soshir
ms.date: 12/06/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/consuming-the-services
msc.type: authoredcontent
---
Consuming the Services
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

Since Hosting Services Code Sample is implemented using Windows Communication Foundation, consuming it is fairly straightforward. Here, a few key points are described. Refer to WCF documentations for details regarding how to consume WCF services.

This article contains:

- [Client Configuration](consuming-the-services.md#Client)
- [Client Web.Config](consuming-the-services.md#ClientWeb)
- [Implementing the Proxy](consuming-the-services.md#Proxy)
- [Common Scenarios](consuming-the-services.md#Common)

<a id="Client"></a>

## Client Configuration

Calling the services from a client application involves some configuration. The SampleWebClient project is an example of such an application. Generating the proxy for each of the services can be done either through Visual Studio® 2005, or by using the SvcUtil.exe command-line utility, found in \Program Files\Microsoft SDKs\Windows\v6.0\Bin. The following command generates the proxy for the WebManagementService.svc.


[!code-console[Main](consuming-the-services/samples/sample1.cmd)]


The Proxy class can then be added to the project's Service References.

SvcUtil.exe has many options for controlling how the proxy classes are generated. Refer to SvcUtil related documentations for details. In the sample client application, we use the namespace option to dedicate the namespace for generated proxy classes to avoid the class conflicts.

The following screen shot shows a fragment of the proxy codes generated:

[![](consuming-the-services/_static/image3.jpg)](consuming-the-services/_static/image1.jpg)

<a id="ClientWeb"></a>

## Client Web.Config

In the SampleWebClient, we provide the address and binding in the client's web.config file. Notice that there are binding and endpoint sections for each proxy class.

[!code-xml[Main](consuming-the-services/samples/sample2.xml)]

When moving the client application from one environment to another, ensure that the endpoint address and userPrincipalName are modified to reflect the correct environment.

<a id="Proxy"></a>

## Implementing the Proxy

From the client application, add the System.ServiceModel namespace as well as the appropriate subsystem namespace.


[!code-csharp[Main](consuming-the-services/samples/sample3.cs)]


[!code-csharp[Main](consuming-the-services/samples/sample4.cs)]


[!code-csharp[Main](consuming-the-services/samples/sample5.cs)]


To call a service, you must first instantiate a proxy. The following line instantiates the proxy object for the Web subsystem's provisioning operation.


[!code-console[Main](consuming-the-services/samples/sample6.cmd)]
  

Call the method to be executed, passing the appropriate parameter. In cases where the parameter consists of more complex data types, find the definition in the corresponding Data Contract class.


[!code-console[Main](consuming-the-services/samples/sample7.cmd)]


Then close the proxy. Closing the proxy terminates the session with the service and closes the connection.


[!code-console[Main](consuming-the-services/samples/sample8.cmd)]

<a id="Common"></a>

## Common Scenarios

The following **CreateWebSite** method creates a site, based on the site properties set in the **WebSiteProvisioningRequest** parameter.

[!code-csharp[Main](consuming-the-services/samples/sample9.cs)]

The WebSiteProvisioningRequest class contains properties to:

- Create an Application pool
- Create a site
- Create the default application
- Create the default virtual directory
- Add the bindings

In addition, it configures logging and fault logging.

### C# Sample

The following code sample demonstrates the creation of a website using the service. You must instantiate the **WebProvisioningServiceClient** proxy. The CreateWebSite(WebSiteProvisioningRequest request) method requires a parameter. All data types used in the methods are found in the corresponding Data Contract class. In this case, the **WebSiteProvisioningRequest** object can be found in the Microsoft.Hosting.Web.DataContract namespace.

The fault contracts apply to all subsystems and can be implemented as shown in the code below.

[!code-console[Main](consuming-the-services/samples/sample10.cmd)]

For more examples, refer to the sample web client application included with the Visual Studio Solution. 