---
title: "Using Web Deploy for Web Farms | Microsoft Docs"
author: rick-anderson
description: "Web Deploy (Web Deployment Tool) is an IIS Extension that simplifies the migration, management and deployment of IIS Web servers, Web applications and Web si..."
ms.author: iiscontent
manager: soshir
ms.date: 07/23/2009
ms.topic: article
ms.assetid: 7c433163-13d9-4b55-a644-6003588fb05c
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-web-deploy/using-web-deploy-for-web-farms
msc.type: authoredcontent
---
Using Web Deploy for Web Farms
====================
by Faith A

Web Deploy (Web Deployment Tool) is an IIS Extension that simplifies the migration, management and deployment of IIS Web servers, Web applications and Web sites. Administrators can use the Web Deployment Tool to synchronize both IIS 6.0 and IIS 7.0 and above servers, or to migrate an IIS 6.0 server to IIS 7.0 or above. It also enables administrators and delegated users to use IIS Manager to deploy ASP.NET and PHP applications to an IIS 7.0 or above server.

The tool can be used to synchronize a web farm, including deploying new applications or just keeping changes synchronized between the web farm servers. The tool does not currently support a central UI or configuration store for a list of servers in a farm (i.e., syncing multiple machines at once), but you can simply store this list of servers and perform sync operations against each server. These can easily be scheduled using System Center or another scheduling mechanism. Resources that can be synchronized include Web sites or applications, content folders and files, databases, registry keys, assemblies in the GAC and more. You can also build custom "providers" that understand other types of resources that are not supported in-the-box.

For specific features available in Application Center and whether they are supported in the Web Deployment Tool (or within IIS itself), please see the comparison table. While there are a limited set of Application Center features that do not have a direct replacement, many of these will be added to future versions of Microsoft products.


## Application Center Comparison Table

| **Application Center Feature** | **Corresponding Web Deployment Tool Feature** |
| --- | --- |
| **Cluster services**- ability to define a group of servers for operations | **Web Deploy: Manual sync** - Essentially there is no central controller for a web farm in the tool. It can be accomplished today by calling Web Deploy for each server in the farm. This feature is being considered for future versions. |
| **Cluster services** - COM+ routing | None |
| **Cluster services** - COM+ app cluster | None |
| **Load balancing**– NLB | **NLB** or **Application Request Router** (ARR) can be used for the web farm but there is not currently a control mechanism for controlling NLB. This feature is being considered for future versions. |
| **Load balancing** – CLB | None |
| **Load balancing**- Other devices | Other devices can be used for load balancing the web farm but we don't have a specific control mechanism. This feature is being considered for future versions. |
| **Request Forwarder** - allows specific requests to be forwarded | **Application Request Router**, NLB or similar mechanisms allow for this functionality. |
| **Deployment**- deploying an application across a cluster of machines | **Web Deploy: Deployment**- This is provided today and goes beyond AC, it allows granular control over what is synced. |
| **Synchronization/Replication** - syncing sites and more across a cluster of machines | **Web Deploy: Synchronization** - This is essentially the same as deployment. |
| **Synchronization Schedule** - ability to sync based on a schedule | This can be managed through mechanisms such as **Windows task scheduler**, **System Center Configuration Manager** or a custom program/script. This feature is being considered for future versions. |
| **Automatic Synchronization**- ability to detect changes and sync based on changes/trigger | None yet. This feature is being considered for future versions. |
| **Monitoring** - aggregation of logs/perf counters and threshold-based actions | **System Center Operations Manager** provides this functionality. |
| **Administrative console**- single UI for managing web farm tasks | We have the **IIS Manager console** that can be used to manage servers. This can be used with shared configuration to make changes that are shared across a farm. We also have a **Web Farm Framework** that introduces the concept of a cluster of machines inside the IIS Manager.What is not available yet is the ability to sync across the farm in IIS Manager using the Web Deployment Tool. Today, the sync needs to be done manually outside of IIS Manager. This feature is being considered for future versions. |
| **Application Images** - Definitions of what is an app and should be synced | **Web Deploy: Custom manifest / packages** - A manifest is used to define a collection of resources that make up an application. You can then create an application package (.zip file) that contains all of these resources and can be used for deployment, sync, versioning and roll back. |
| **AC.exe** - command-line tool for administering the cluster | **Web Deploy: msdeploy.exe** - command-line tool that allows control over syncs and deployment. In addition, we also have a public API and PowerShell support. We also have common tools for editing configuration of a group of machines if they use shared config (i.e., point to the same config file), such as appcmd.exe, PowerShell, scripting API's and more. |