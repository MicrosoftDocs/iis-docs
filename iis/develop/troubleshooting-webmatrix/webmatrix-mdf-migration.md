---
title: "WebMatrix MDF Migration | Microsoft Docs"
author: rick-anderson
description: "Symptom: You see a Database Migration Required message when you are trying to download a database from SQL Azure into a local MDF database. For example, when..."
ms.author: iiscontent
manager: soshir
ms.date: 06/06/2012
ms.topic: article
ms.assetid: 4e53bfb5-2e62-4e7e-a2a9-b342f9b35594
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/troubleshooting-webmatrix/webmatrix-mdf-migration
msc.type: authoredcontent
---
WebMatrix MDF Migration
====================
by Faith A

**Symptom:** You see a Database Migration Required message when you are trying to download a database from SQL Azure into a local MDF database.

For example, when you install an application such as DotNetNuke, the default installation uses an MDF file. You can publish this directly to a remote site and SQL server, including SQL Azure. If you have published the site to SQL Azure and then click the Download button in order to sync remote changes, then you will see this message.

This is because you cannot migrate a SQL Azure database back into an attached MDF file. To resolve this issue, click on the Databases workspace, select the local database and click Migrate in the ribbon.

The migration will not affect your data or schema. Once migration is complete, you can click Download.