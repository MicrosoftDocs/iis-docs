---
title: "Understanding Sites, Applications, and Virtual Directories on IIS 7"
author: arkaytee
description: "In IIS, you can create sites, applications, and virtual directories to share information with users over the Internet, an intranet, or an extranet. Although..."
ms.date: 11/23/2007
ms.assetid: 02003c66-968f-4d86-aae7-b827b84bd03f
msc.legacyurl: /learn/get-started/planning-your-iis-architecture/understanding-sites-applications-and-virtual-directories-on-iis
msc.type: authoredcontent
---
Understanding Sites, Applications, and Virtual Directories on IIS 7
====================
by [Reagan Templin](https://github.com/arkaytee)

## Introduction

In IIS, you can create sites, applications, and virtual directories to share information with users over the Internet, an intranet, or an extranet. Although these concepts existed in earlier versions of IIS, several changes in IIS 7 and above affect the definition and functionality of these concepts. Most importantly, sites, applications, and virtual directories now work together in a hierarchical relationship as the basic building blocks for hosting online content and providing online services.

This article provides a quick overview of applications in IIS 6.0 so that you can better understand the differences introduced in IIS 7. It then explains the concepts of sites, applications, and virtual directories in IIS and introduces the `<sites>` section in configuration.

<a id="About6.0"></a>

## About Sites, Applications, and Virtual Directories in IIS 6.0

In IIS 6.0, the concepts of virtual directories and applications were confusing. Although they were discussed as separate concepts, (and they were conceptually different from a functionality standpoint), an application was not a physically separate object from a virtual directory. In IIS 6.0, an application was really just a virtual directory with one or a combination of the following properties in the metabase: **AppFriendlyName**, **AppRoot**, **AppIsolated**, and **AppPoolID**.

> [!NOTE]
> The site root is an exception, as it was implicitly treated as an application even if those properties were not set.

Applications were less important to IIS than to the technologies that extended Web server functionality, such as Active Server Pages (ASP), Internet Server Application Programming Interface (ISAPI), and ASP.NET. These technologies provided additional features and processing for applications hosted in IIS 6.0, and enabled developers to create more complex applications. The important question for IIS 6.0 was isolating such applications in a way that would prevent applications in one application pool from affecting applications in another application pool on the server.

<a id="About7.0"></a>

## About Sites, Applications, and Virtual Directories in IIS 7 and Above

IIS 7 and above formalizes the concepts of sites, applications, and virtual directories. Virtual directories and applications are now separate objects, and they exist in a hierarchical relationship in the IIS configuration schema. Briefly, a site contains one or more applications, an application contains one or more virtual directories, and a virtual directory maps to a physical directory on a computer.

As in IIS 6.0, a site contains all the content, both static and dynamic, that is associated with that site. However, each site must contain at least one application, which is named the root application. And each application (including the root application) must contain at least one virtual directory, which is named the root virtual directory. These objects work together to form the site.

Additionally, in IIS 7 and above, the concept of an application now has meaning to both IIS and the technologies that extend IIS functionality. An application is an object important to the server at runtime. This is because the IIS and ASP.NET request-processing pipelines have merged in IIS 7 and above so that content can take advantage of functionality previously provided for only managed code applications. For example, each managed code application runs in an Application Domain (AppDomain). An application can have several virtual directories, and each one will be served by the same AppDomain as the application to which they belong.

The following sections explain sites, applications, virtual directories, and their related configurations in more detail.

<a id="Sites"></a>

## Sites

A site is a container for applications and virtual directories, and you can access it through one or more unique bindings.

The binding includes two attributes important for communication: the *binding protocol* and the *binding information*. The binding protocol defines the protocol over which communication between the server and client occurs. The binding information defines the information that is used to access the site. For example, the binding protocol of a Web site can be either HTTP or HTTPS, and the binding information is the combination of IP address, port, and optional host header.

A site may contain more than one binding if the site requires different protocols or binding information. In earlier versions of IIS, only the HTTP and HTTPS protocols were supported. For example, a Web site might have had both an HTTP binding and an HTTPS binding when sections of the site required secure communication over HTTPS.

In IIS 7 and above, bindings can apply to any protocol. The Windows Process Activation Service (WAS) is the new service that makes it possible for IIS to use additional protocols. This service retains the familiar IIS 6.0 process model, such as application pools and message-based process activation, as well as hosting features, such as rapid failure protection, health monitoring, and recycling. However, WAS removes the dependency on HTTP from the activation architecture. This is useful for technologies that provide application-to-application communication in Web Services over standard protocols. The Windows Communication Foundation (WCF) programming model is one such technology that can enable communication over the standard protocols of Transmission Control Protocol (TCP), Microsoft Message Queuing (MSMQ), and Named Pipes. This lets applications that use communication protocols take advantage of IIS features, such as process recycling, rapid fail protection, and configuration that were previously only available to HTTP-based applications. For more information about the WCF programming model, see [Windows Communication Foundation](https://go.microsoft.com/fwlink/?LinkId=88604) on MSDN.

In addition to containing applications (which contain virtual directories) and specifying bindings, the following configuration settings belong to the site:

- Limits: configure settings to limit the amount of bandwidth, the number of connections, or the amount of time allowed for connections to a site.
- Logging: configure settings for handling and storage of log files for the site.
- Failed request trace logs: configure settings for logging failed-request traces for the site.

<a id="Applications"></a>

## Applications

An application is a group of files that delivers content or provides services over protocols, such as HTTP. When you create an application in IIS, the application's path becomes part of the site's URL.

In IIS 7 and above, each site must have an application which is named the root application, or default application. However, a site can have more than one application. For example, you might have an online commerce Web site that has several applications, such as a shopping cart application that lets users gather items during shopping and a login application that allows users to recall saved payment information when they make a purchase.

In addition to belonging to a site, an application belongs to an application pool, which isolates the application from applications in other application pools on the server. In the case of managed code applications, make sure to associate your application together with an application pool that is running the .NET Framework version that your application requires.

As described in the Sites section of this paper, IIS supports HTTP and HTTPS by default, but you can use additional protocols. For each site, you specify one or more bindings to communicate with and access content in the site. For an application to communicate by using a protocol that is specified in the parent site's binding, you must enable the protocol. To do this, specify the protocol in the **enabledProtocols** attribute for the application, and ensure that you have the appropriate listener adapter on the server and specified in the `<listenerAdapters>` section in configuration.

<a id="Virtual"></a>

## Virtual Directories

A virtual directory is a directory name (also referred to as path) that you specify in IIS and map to a physical directory on a local or remote server. The directory name then becomes part of the application's URL, and users can request the URL from a browser to access content in the physical directory, such as a Web page or a list of additional directories and files. If you specify a different name for the virtual directory than the physical directory, it is more difficult for users to discover the actual physical file structure on your server because the URL does not map directly to the root of the site.

In IIS 7 and above, each application must have a virtual directory, which is named the root virtual directory, and which maps the application to the physical directory that contains the application's content. However, an application can have more than one virtual directory. For example, you might use a virtual directory when you want your application to include images from another location in the file system, but you do not want to move the image files into the physical directory that is mapped to the application's root virtual directory.

By default, IIS uses configuration from Web.config files in the physical directory to which the virtual directory is mapped, as well as in any child directories in that physical directory. If you do not want to use Web.config files in child directories, specify **false** for the **allowSubDirConfig** attribute on the virtual directory.

Optionally, when you need to specify credentials and a method to access the virtual directory, you can specify values for the **username**, **password**, and **logonMethod** attributes.

<a id="Configuration"></a>

## IIS Configuration: `<sites>` Section

Take a look at the default `<sites>` section in IIS 7 and above. This is what is in the ApplicationHost.config file (located at `%windir%\system32\inetsrv\config\`) after installing IIS on Windows Server® 2008.

[!code-xml[Main](understanding-sites-applications-and-virtual-directories-on-iis/samples/sample1.xml)]

When you see a single "/" in a path field, you know that this is a root object. Depending on whether it is in the application or virtual directory section, it is a root application or a root virtual directory.

### Default Elements

The following section lists the collections and elements in the `<sites>` section, and their hierarchical relationship within the `<sites>` section.

[!code-xml[Main](understanding-sites-applications-and-virtual-directories-on-iis/samples/sample2.xml)]

Notice that there are two elements that appear in more than one place: the `<applicationDefaults>` element and the `<virtualDirectoryDefaults>` element. There is also a `<siteDefaults>` element, although it appears only once because it can be configured in only one location in the `<sites>` section. Default elements are special because they enable you to configure default values for attributes instead of having to repeat the same values in each collection.

When an attribute is configured at more than one level, the value at the lowest level is used. For example, if you specify a default value in an `<applicationDefaults>` element in both the `<sites>` section and in a `<site>` collection, the value from the `<site>` collection will be used. Additionally, if the same attribute or child element is configured in both a default element and in the object's collection, the value in the collection will be used. For example, if you configure an attribute in an `<applicationDefaults>` element and in an `<application>` collection, the value from the `<application>` collection will be used.

The following table specifies under which parent elements an `<applicationDefaults>` element can be configured, and describes the effect that the values have on applications.

| Parent element | Description |
| --- | --- |
| `<sites>` section | Specifies the default settings for all applications on the server. |
| `<site>` collection | Specifies the default settings for all applications in the parent site. |

The following table specifies under which parent elements a `<virtualDirectoryDefaults>` element can be configured, and describes the effect that the values have on virtual directories.

| Parent element | Description |
| --- | --- |
| `<sites>` section | Specifies the default settings for all virtual directories on the server. |
| `<site>` collection | Specifies the default settings for all virtual directories in the parent site. |
| `<application>` collection | Specifies the default settings for all virtual directories in the parent application. |

<a id="Summary"></a>

## Summary

You should now have a better understanding of sites, applications, and virtual directories in IIS 7 and above. Unlike IIS 6.0, applications and virtual directories have become distinct objects in configuration, which highlights their unique purpose to the Web server and their relationship to the site. Additionally, sites can now contain applications that use protocols other than HTTP and HTTPS, which extends site functionality while retaining the benefits of the process model introduced in IIS 6.0.

For more information about WAS and IIS architecture, see IIS Request-Processing Architecture on IIS.NET. For more information about the configuration settings discussed in this article, see [IIS 7 Settings Schema](https://go.microsoft.com/fwlink/?LinkId=88551) on MSDN.
