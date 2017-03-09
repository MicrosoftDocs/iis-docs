---
title: "URL Rewrite for Hosting Providers | Microsoft Docs"
author: walterov
description: "The purpose of this article is to provide a guiding map to the various resources available for hosters who are learning about and deploying the IIS URL Rewri..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 01/13/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/url-rewrite-for-hosting-providers
msc.type: authoredcontent
---
URL Rewrite for Hosting Providers
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

The purpose of this article is to provide a guiding map to the various resources available for hosters who are learning about and deploying the IIS URL Rewrite module. This module is an important component of the Windows Web Platform, as illustrated in this [Shared Hosting article](../planning-the-web-hosting-architecture/shared-hosting-configuration.md). The URL Rewrite module provides functionality to Web users and site administrators that was only partially available in a handful of limited, complex, custom systems.

For more information on the features of URL Rewrite Module, see [IIS URL Rewrite Module](https://technet.microsoft.com/en-us/library/ee215194(WS.10).aspx) in the TechNet library.

## Learn About the URL Rewrite Module

The URL Rewrite module provides server and site administrators with the ability to create rules that modify a site's URL appearance before the Web server processes it. This makes it possible to expose simpler URLs that would be easier for users to remember. Also, it lets server and site administrators use search engines to store, process, and present friendly URLs, improving the overall Web experience.   
Here is a basic explanation of friendly URLs that are enabled by the URL Rewrite module within a shared hosting environment:

[![](url-rewrite-for-hosting-providers/_static/image2.jpg)](url-rewrite-for-hosting-providers/_static/image1.jpg)

1. The image above depicts the following events involving URL Rewrite:   
 The end user types URL: "http://www.somestore.com/chocolates/dark/organic".
2. Then the URL Rewrite module in the Web server for site www.somestore.com alters it from "http://www.somestore.com/chocolates/dark/organic" to "http://www.somestore.com/catalog.php?Department=chocolates&amp;Category=dark&amp;Label=organic", which is then processed by the application.
3. If the user wants to see a list of all chocolates, the user can then bypass the navigation features of the Web application and type the following URL: "http://www.somestore.com/chocolates".

URL rewrite makes URL typing friendlier to users. Benefits include, but are not limited to:

- Web application users and search engines benefit from simpler, friendlier URLs.
- Web developers and administrators can use URL Rewrite to hide how applications work internally.
- Web developers can use URL Rewrite as a layer of abstraction, allowing the friendly URLs to be valid even after changing the core technology used to implement the application.
- Administrators can use URL Rewrite as a tool to combat some undesired practices, such as hot linking or inline linking.

### Documentation

For a complete list of features and guidance, see [Using the URL Rewrite Module](../../extensions/url-rewrite-module/using-the-url-rewrite-module.md).

## Deploy the URL Rewrite Module

As seen in the image above, the URL Rewrite module is found in:

1. Every Web server in the Web farm. This enables server and site administrators to manage their URL Rewrite rules. This implies that the URL Rewrite module should be part of the image used to build the servers in the farm.
2. The Application Request Routing (ARR) server. ARR uses the URL Rewrite module as a core component of its routing functionality. The ARR installer also installs the URL Rewrite module, so there is no need for a separate installation step.

URL Rewrite can be downloaded from:

• [Download the x86 version for IIS 7.0](https://www.iis.net/downloads?tabid=34&g=6&i=1691)   
• [Download the x64 version for IIS 7.0](https://www.iis.net/downloads?tabid=34&g=6&i=1692)

For detailed steps about the installer, see the section "Where to get the module" in [Using the URL Rewrite Module](../../extensions/url-rewrite-module/using-the-url-rewrite-module.md).

Once the URL Rewrite module is installed, its functionality is available to users by default. Separately, hosters could take advantage of global rules to define rules that affect all sites on the server. For more information, see [Global and Distributed Rewrite Rules](../../extensions/url-rewrite-module/using-global-and-distributed-rewrite-rules.md). Users are oblivious to global rules.

## Common URL Manipulation Tasks

The following [video](https://www.iis.net/community/files/URLRewriter/URLRewriteModule.wmv) provides demonstrations for:

- Enabling user and search engine friendly URLs for dynamic Web pages.
- Enforcing canonical host names for Web sites.
- Using rewrite maps.
- Blocking unwanted requests.
- Troubleshooting and debugging rewrite rules.

The section "Using the module" in [Using the URL Rewrite Module](../../extensions/url-rewrite-module/using-the-url-rewrite-module.md) provides links to content that covers the functionality of the URL Rewrite module and explanations about how to use it to accomplish common URL rewriting scenarios.

This [article](../../extensions/url-rewrite-module/iis-request-filtering-and-url-rewriting.md), describes the differences between URL Rewrite and HTTP Request Filtering. It will help you decide when to take advantage of either one.

## Conclusion

This article explains what the new URL Rewrite module is, why it is important for hosters, and guides the user to the resources available to learn about, deploy, and configure the IIS URL Rewrite module.