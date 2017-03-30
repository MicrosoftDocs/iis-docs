---
title: "Other Managed Code Samples | Microsoft Docs"
author: walterov
description: "Use the following managed code samples to set permissions and to create a user account. Using the Code Set Permissions Use the following to set permissions o..."
ms.author: iiscontent
manager: soshir
ms.date: 12/02/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/other-managed-code-samples
msc.type: authoredcontent
---
Other Managed Code Samples
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

Use the following managed code samples to set permissions and to create a user account.

## Using the Code

### Set Permissions

Use the following to set permissions on a folder using managed code **.**

> [!NOTE]
> A reference to System.DirectoryServices.dll is required.


[!code-csharp[Main](other-managed-code-samples/samples/sample1.cs)]


### Create a User Account

Use the following to create a user account using managed code.


[!code-csharp[Main](other-managed-code-samples/samples/sample2.cs)]