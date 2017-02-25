---
title: "Tools and Utilities Questions | Microsoft Docs"
author: rick-anderson
description: "The recommendation for IIS 7.0 is to NOT use shared application pools. Is there a tool that validates configuration files before loading in IIS 7.0? No, the..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/22/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/frequently-asked-questions-faq/tools-and-utilities-questions
msc.type: authoredcontent
---
Tools and Utilities Questions
====================
by Walter Oliver

#### What tools are available to be able to see which site is using memory in an application pool?

The recommendation for IIS 7.0 is to NOT use shared application pools.

#### Is there a tool that validates configuration files before loading in IIS 7.0?

No, the best tool today is to use appcmd. "appcmd list config" will find most configuration errors in applicationhost.config.

#### Can different levels of permission be given to different customer tier representatives? Can we have authorization in the server management?

There are no roles currently built-in to the system. All the delegation is based on a "path-basis" and no roles or user specific permissions can be granted. Having said that, you could potentially delegate to an Application administrator certain features, so you can only read certain things, but your Site administrator could read/write more features, and of course Server Administrator has full control.

#### Is there a tool to encrypt passwords in web.config?

Encrypted properties will be encrypted when you write them through the config APIs or appcmd. Example:

Appcmd set config -section:anonymousAuthentication -userName:poolUser1 -password:IWillBeEncrypted!!!

#### Is there a Web Administration Tool for users that do not have Visual studio?

There is a tool available for download on IIS.NET:

[https://www.iis.net/downloads/files/inetmgr/mswebmgr.msi](../../../community/files/inetmgr/mswebmgr.msi.md)

#### Is Sysprep fully supported by IIS 7.0?

Sysprep is not going away. It is still there and works like in previous Windows versions.

#### Can appcmd be used to update scriptmaps (handlers)? Does this require an IISReset? Can this be removed from customer's delegations?

Appcmd can be used to update scriptmaps. No IIS reset is required. Delegation can be turned off or on like any other feature by using the overrideMode or overrideModeDefault on &lt;handlers&gt; config section in applicationhost.config.

#### If a customer has multiple delegated connections in the IIS Connection Manager, can the credentials be cached and used for all connections?

For security reasons, the user will always be prompted when a connection is initialized. There is no way for to know that user "X" is the same when connecting to site "A" than connecting to site "B". Remote authentication extensibility could potentially mean that a 3rd party authentication system could authenticate users to a different store based on the site or application they are connecting to.

#### How do you change the priority of the default documents?

Priority will be based on whichever one is listed first. This is a known issue.

#### Is there a way to test the connection strings in the UI when the strings are being specified?

Unfortunately, there is no easy way to test connection strings because the connection string might only work in the context of the worker process.

#### When running a backup using appcmd, the backup is stored in the system32\inetsrv\backup directory. Can a target directory to store the backup be specified?

Not at this time. A bug has been filed for this.

#### What kinds of tools are available to run stress tests?

WCAT is the tool that is being used now. It is part of IIS 6.0 Resource Kit which can be downloaded from the following link:

[https://www.microsoft.com/downloads/details.aspx?FamilyID=56fc92ee-a71a-4c73-b628-ade629c89499&amp;DisplayLang=en](https://www.microsoft.com/downloads/details.aspx?FamilyID=56fc92ee-a71a-4c73-b628-ade629c89499&amp;DisplayLang=en)

#### Will IIS Manager run on any other OS?

Yes, it is available for XP, Win2k3, and Vista/Windows Server® 2008. There is a specific version that corresponds to the server build that is deployed. It is available for download from the following link:

[https://www.iis.net/downloads/files/inetmgr/mswebmgr.msi](../../../community/files/inetmgr/mswebmgr.msi.md)

#### What migration tools are available?

There is no migration tool available yet, but we are working on it and hope to have something in the next 3-4 weeks.

#### Can the Admin UI client binaries be made available to customers for download from their web site?

Yes, it is available for XP, Win2k3, and Vista/Windows Server® 2008. There is a specific version that corresponds to the server build that is deployed. It is available for download from the following link:

[https://www.iis.net/downloads/files/inetmgr/mswebmgr.msi](../../../community/files/inetmgr/mswebmgr.msi.md)

#### Is there a way to tell where a particular URL path is in the www hierarchy using request monitoring if you have multiply default.htm files?

The information is available from the Microsoft.Web.Administration API. Unfortunately, we do not show it in the UI or command line.

#### When using IIS Manager to stop a site in a Shared Configuration, the site is only stopped on the server you stopped it on. Is this correct?

This is by design. Site start/stop is not a configuration operation. It is a runtime state operation against RSCA. Setting the "serverautostart" setting will only prevent the site from starting on reboot (since it was stopped explicitly); it will not stop an already running site. If you want to stop a site running on multiple machines, you will need to use WMI or Microsoft.Web.Administration and run the stop method on each machine.

#### Is it possible to filter the list of websites in the IIS Manager GUI?

Yes, click on 'sites' node, and the list async loads in the content pane. Enter search criteria in list box, and the list of sites is filtered. Double click on a site and it will open under &lt;sites&gt; node, without expanding all sites (unless there are less than a few hundred sites). You do not have to wait for the site list to load to begin searching.