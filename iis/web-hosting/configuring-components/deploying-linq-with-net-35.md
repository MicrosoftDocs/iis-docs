---
title: "Enabling LINQ with ASP.NET | Microsoft Docs"
author: walterov
description: "ASP.NET is a unified Web development model that includes the services necessary to build Web applications with a minimum of coding. ASP.NET is part of the .N..."
ms.author: iiscontent
manager: soshir
ms.date: 11/02/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/configuring-components/deploying-linq-with-net-35
msc.type: authoredcontent
---
Enabling LINQ with ASP.NET
====================
by [Walter Oliver](https://github.com/walterov)

## Overview

[ASP.NET](https://msdn.microsoft.com/en-us/library/4w3ex9c2.aspx "ASP.NET Overview") is a unified Web development model that includes the services necessary to build Web applications with a minimum of coding. ASP.NET is part of the .NET Framework, and when coding ASP.NET applications you have access to classes in the .NET Framework. You can code your applications in any language compatible with the common language runtime (CLR), including Microsoft Visual Basic, C#, JScript .NET, and J#. These languages enable you to develop ASP.NET applications that benefit from the common language runtime, type safety, inheritance, and so on.

[Language-Integrated Query](https://msdn.microsoft.com/en-us/library/bb397926.aspx "LINQ Overview") (LINQ) is a set of features in Visual Studio 2008 that extends powerful query capabilities to the language syntax of C# and Visual Basic. LINQ introduces standard, easily-learned patterns for querying and updating data, and the technology can be extended to support potentially any kind of data store.

> [!IMPORTANT]
> When hosting Web Applications that use LINQ, you might have to change the policy files for code-access security.

The following sections describe these settings. See [Using LINQ with ASP.NET](https://msdn.microsoft.com/en-us/library/bb907622.aspx "Using LINQ with ASP.NET") for more information.

## Using LINQ with Medium Trust


To use LINQ in a Web application that is running under medium trust, you must include two elements (SecurityClass and IPermission) in the policy file that is defined for Medium trust. By default, the web\_mediumtrust.config file is the policy file for medium trust and already contains these elements.

Within the **SecurityClasses** element, add a **SecurityClass** element with the following attributes:


[!code-xml[Main](deploying-linq-with-net-35/samples/sample1.xml)]


Within the **PermissionSet** element that has the **Name** attribute set to "ASP.Net", add an **IPermission** element that has the following attributes:


[!code-xml[Main](deploying-linq-with-net-35/samples/sample2.xml)]


## Using LINQ with High Trust

To use LINQ in a Web application that is running under high trust, you must include one element in the policy file that is defined for High trust. By default, the web\_hightrust.config file is the policy file for high trust. This file already includes an **IPermission** element within a **PermissionsSet** element that references the **ReflectionPermission** class. You must modify this element when you use LINQ.

Within the **PermissionSet** element that has the **Name** attribute set to "ASP.Net", find the **IPermission** element for **ReflectionPermission** and set it as follows:


[!code-xml[Main](deploying-linq-with-net-35/samples/sample3.xml)]