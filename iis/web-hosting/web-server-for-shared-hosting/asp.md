---
title: "ASP | Microsoft Docs"
author: walterov
description: "Classic ASP is included in IIS 7.0 and above, and can be used in Shared Hosting scenarios. However, hosters planning to do so should consider the following r..."
ms.author: iiscontent
manager: soshir
ms.date: 12/01/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/asp
msc.type: authoredcontent
---
ASP
====================
by [Walter Oliver](https://github.com/walterov)

Classic ASP is included in IIS 7.0 and above, and can be used in Shared Hosting scenarios. However, hosters planning to do so should consider the following recommendations:

1. **Turn off the ASP Template Cache**. Because the ASP disk template cache is not shared hosting aware, it should be disabled. This should not pose a problem because up to 500 ASP pages per worker process are cached in memory before anything is written to the disk.
2. **Delegate the scriptErrorSentToBrowser setting**. The IIS team tightened Classic ASP security more in IIS 7.0 and above. The scriptErrorSentToBrowser property is set to false for example. This means that no script error whatsoever is displayed in the user's browser. In a hosted environment this might be a problem however. There are pretty much no other ways to troubleshoot Classic ASP errors. Notice that it is not recommend to delegate the &lt;asp&gt; section in applicationhost.config because there are certain settings like the location of the template cache and the runOnEndAnonymously setting that hosters might not want to delegate. The guidance below provides instructions on how to delegate the scriptErrorSentToBrowser setting without delegating the complete &lt;asp&gt; section.

### To turn off the ASP Template Cache:

Open a command prompt and run the following:

%windir%\system32\inetsrv\appcmd set config -section:asp -cache.maxDiskTemplateCacheFiles:0

### To Delegate the scriptErrorSentToBrowser setting:

1. Allow the delegation of the &lt;asp&gt; section in applicationhost.config via overrideModeDefault by opening "%windir%\system32\inetsrv\config\applicationhost.config" with a text editor and changing the &lt;section name="asp" overrideModeDefault="Deny" /&gt; element as follows:  

    [!code-xml[Main](asp/samples/sample1.xml)]
2. Use lockAllAttributesExcept and lockElements to only allow the delegation of the scriptErrorSentToBrowser setting, locate the &lt;asp&gt; element and change as follows:  

    [!code-aspx[Main](asp/samples/sample2.aspx)]
3. Now you as the hoster can use appcmd to set the scriptErrorSentToBrowser setting to true (see example below)  

    [!code-console[Main](asp/samples/sample3.cmd)]

    or you could ask your customers to put the following statement in their web.config files:

    [!code-aspx[Main](asp/samples/sample4.aspx)]

### Resources

For more information see:

- [Delegated Administration](delegated-administration.md)
- [Introduction to ApplicationHost.config](../../get-started/planning-your-iis-architecture/introduction-to-applicationhostconfig.md)
- [https://blogs.iis.net/thomad/archive/2008/03/14/delegating-iis7-settings-in-hosted-environments.aspx](https://blogs.iis.net/thomad/archive/2008/03/14/delegating-iis7-settings-in-hosted-environments.aspx)