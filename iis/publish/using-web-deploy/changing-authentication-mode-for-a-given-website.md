---
title: "Changing authentication mode for a given website | Microsoft Docs"
author: Tuesdaysgreen
description: "This is a new Web Deploy provider which will provide support for changing authentication mode for a given website. Many a times in enterprise environments ap..."
ms.author: iiscontent
manager: soshir
ms.date: 07/26/2012
ms.topic: article
ms.assetid: e8edd332-702e-4de9-b839-28ff2ddf0739
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-web-deploy/changing-authentication-mode-for-a-given-website
msc.type: authoredcontent
---
Changing authentication mode for a given website
====================
by [Elliott Hamai](https://github.com/Tuesdaysgreen)

## ApphostAuthOverride Provider

This is a new Web Deploy provider which will provide support for changing authentication mode for a given website. Many a times in enterprise environments applications want to choose their own authentication method using web.config file, but AppHostConfig file locks this setting. This means that if a developer tries to set his/her site's authentication settings, IIS will not obey it. The Application Host Authentication Override provider allows developers to configure how IIS locks an authentication setting on the server by adding a &lt;location&gt; tag for that setting within the server's applicationHost.config file. Here is an example of what that looks like in config:

[!code-xml[Main](changing-authentication-mode-for-a-given-website/samples/sample1.xml)]

Here is a few command line examples of how this could be done *(msdeploy.exe is located under "%programfiles%\IIS\Microsoft Web Deploy V3")*:

· **Allow Windows Authentication on Destination at site = SiteName:** 

[!code-console[Main](changing-authentication-mode-for-a-given-website/samples/sample2.cmd)]

· **Allow ASP.Net Forms Authentication on Destination at site = SiteName:** 

[!code-console[Main](changing-authentication-mode-for-a-given-website/samples/sample3.cmd)]

· **Deny Anonymous Authentication on Destination at site = SiteName:** 

[!code-console[Main](changing-authentication-mode-for-a-given-website/samples/sample4.cmd)]

· **Reset Windows Authentication Setting on Destination at site = SiteName:** 

[!code-console[Main](changing-authentication-mode-for-a-given-website/samples/sample5.cmd)]

Please note the sytax carefully, both &lt;sitename" and authentication setting are part of -dest:ApphostAuthOverride value.