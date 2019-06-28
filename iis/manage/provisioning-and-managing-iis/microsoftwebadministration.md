---
title: "Microsoft.Web.Administration"
author: walterov
description: "Managed code can be used to provision Web sites and edit configuration. Using the Script Use the following to create a site and an application pool, and to..."
ms.date: 12/02/2007
ms.assetid: e8968a50-879c-4f12-811c-9fdc0ed5c522
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/microsoftwebadministration
msc.type: authoredcontent
---
# Microsoft.Web.Administration

by [Walter Oliver](https://github.com/walterov)

## Introduction

Managed code can be used to provision Web sites and edit configuration.

## Using the Script

Use the following to create a site and an application  pool, and to set temporary compilation directories.

### Creating a Site and Application Pool

[!code-csharp[Main](microsoftwebadministration/samples/sample1.cs)]

### Set a Unique Temporary Compilation Directory for Each Site

[!code-csharp[Main](microsoftwebadministration/samples/sample2.cs)]

<a id="_msocom_7"></a>

> [!NOTE]
> This code uses network service as the application pool identity. It should use a unique AD or machine account for each site.
