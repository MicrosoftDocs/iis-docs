---
title: "Provisioning Sample in C#"
author: walterov
description: "Over the years, it has become simple for advanced Web users to create their own Web site. Once an end-user has registered their domain name, there are variou..."
ms.date: 12/22/2007
ms.assetid: 3f2893c1-46aa-4a2f-b8e7-e5d76d565daa
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/provisioning-sample-in-c
msc.type: authoredcontent
---
Provisioning Sample in C#
====================
by [Walter Oliver](https://github.com/walterov)

## Overview

Over the years, it has become simple for advanced Web users to create their own Web site. Once an end-user has registered their domain name, there are various types of hosters to choose from. Web hosters are available throughout the world to meet the demands of end customers. But regardless of which hoster is chosen, the scenario of signing up and creating a web site is similar in all cases.

Initially, a new user account needs to be established for the user. Once the account has been set up, the end user decides what features and options the site should incorporate: for instance, how much disk space, FTP capability, creation of virtual directories, whether or not databases are needed, etc. Hosters build control panels or dashboard applications that allow end users to create and manage these features.

There are a number of ways that these capabilities can be implemented into the control panel. In this section, we look at implementing the provisioning aspect of these features through managed code. An outline of the features is as follows:

## Provision a New User Account

The site owner who manages and maintains the site needs a new user account. The account can either be an Active Directory® account or a local user account. The following code fragments demonstrate the creation of a local account. Note that the System.DirectoryServices namespace must be specified.


[!code-csharp[Main](provisioning-sample-in-c/samples/sample1.cs)]


## Create Content Storage

A Web site requires a location on the file systems to which users can upload content for the site. The Microsoft® .NET Directory Class provides the application programming interface (API) to create directories on the file system.


[!code-console[Main](provisioning-sample-in-c/samples/sample2.cmd)]


The content storage requires specific permissions configured so that users can manage their own contents. The following code fragment demonstrates how to set directory permissions using managed code in C#:


[!code-csharp[Main](provisioning-sample-in-c/samples/sample3.cs)]


The following code fragment demonstrates how to set disk quota using managed code if the disk quota is restricted. To use the disk quota management, you must add reference to the Windows® disk quota management component; it resides under Windows\system32\dskquota.dll.


[!code-csharp[Main](provisioning-sample-in-c/samples/sample4.cs)]


## Create an Application Pool

An application pool defines the settings for a worker process that hosts one or more Internet Information Services 7 (IIS 7) applications, which carry out their request processing. The application pool is a unit of process isolation, since all request processing for an application runs within its application pool's worker processes.

An application pool also provides isolation, which in turn provides security. Each application pool can run with a unique identity and can use an access control list (ACL) to prevent applications in other pools from accessing its resources. The following code fragment demonstrates the creation of an application pool, setting the identity, and setting properties.


[!code-csharp[Main](provisioning-sample-in-c/samples/sample5.cs)]

<a id="CreateWebsite"></a>

## Create a Site

A site is the top-level logical container that specifies how HTTP requests are received and processed. A site defines a group of bindings that determine how the site listens for incoming requests, and a site contains the definitions of applications or virtual directories that partition the site's URL namespace for the purposes of structuring the application content.

The following code fragment demonstrates how to create a new site. The Microsoft.Web.Administration namespaces are necessary when implementing the ServerManager object. Note that the application collection, site collection, and binding objects are all accessed through the ServerManager object.


[!code-csharp[Main](provisioning-sample-in-c/samples/sample6.cs)]


## Create a Binding

A bindingis a combination of the protocol name and protocol-specific binding information. While IIS 7 supports multi-protocol bindings (such as the Windows® Communication Foundation [WCF] SOAP-TCP and FTP), the code that follows uses the HTTP path only; an HTTP binding effectively defines an HTTP endpoint that listens on a specific interface IP address (or all interfaces), a specific port number, or a specific HTTP host header (or all host headers). In this way, you can configure many sites on your server that listen on different IP addresses, different ports, or on the same IP address or port but with different host headers.


[!code-csharp[Main](provisioning-sample-in-c/samples/sample7.cs)]


## Create a Root Application

An applicationis a logical container for the Web site functionality, letting you divide the site URL namespace into separate parts and control the runtime behavior of each part individually.

For example, you can configure each application to reside in a separate application pool. This isolates an application from other applications by putting it in a separate process, and optionally making that process run with a different Windows identity to sandbox it.


[!code-csharp[Main](provisioning-sample-in-c/samples/sample8.cs)]


## Create a Virtual Directory

A virtual directory maps a part of the application URL namespace to a physical location on disk. When a request is routed to the application, it uses the same algorithm to find the virtual directory with the longest virtual path matching the remainder of the request's absolute path after the application path.


[!code-csharp[Main](provisioning-sample-in-c/samples/sample9.cs)]

<a id="CreateFTPsite"></a>

## Create an FTP Site

An FTP site lets customers upload content to their Web site and provides the ability to move files across the Internet. The customer can manage both content and access. The creation of an FTP site is similar to that of a Web site: An application pool and site is created with a root application and virtual directory, and then an FTP binding is applied.


[!code-csharp[Main](provisioning-sample-in-c/samples/sample10.cs)]