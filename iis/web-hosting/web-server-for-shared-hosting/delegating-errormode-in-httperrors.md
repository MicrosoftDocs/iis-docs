---
title: "Delegating errorMode in httpErrors | Microsoft Docs"
author: walterov
description: "Warning : This functionality is not currently working as expected in IIS 7.0. It is being addressed for the next release. In IIS 7.0 you can lock and unlock..."
ms.author: iiscontent
manager: soshir
ms.date: 03/19/2008
ms.topic: article
ms.assetid: 716f3d38-a524-4ae4-b059-120f225a6458
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/delegating-errormode-in-httperrors
msc.type: authoredcontent
---
Delegating errorMode in httpErrors
====================
by [Walter Oliver](https://github.com/walterov)

*Warning*: *This functionality is not currently working as expected in IIS 7.0. It is being addressed for the next release. In IIS 7.0 you can lock and unlock HTTP errors for particular sites or for the entire server; but, currently, "lockAllAttributesExcept="errorMode" is not working for httpErrors. Yet you can use the ideas in this article about unlocking particular attributes in other IIS configuration sections*.

There are cases when a hoster may need to delegate to its customers specific settings in the "applicationhost.config" file without delegating the entire section, the errorMode setting in the httpErrors section is one of them, another one is the [scriptErrorSentToBrowser setting in the ASP section](asp.md). For troubleshooting purposes, a hoster's customer may want to show Detailed Errors in remote clients. To enable it, the hoster would need to lock all attributes except errorMode (lockAllAttributesExcept="errorMode") and lock the error element (lockElements="error"). This way customers can change errorMode from "detailedLocalOnly" to "Detailed" and they would get Detailed Errors for all of their errors.

### To Delegate the errorMode setting:

1. Allow the delegation of the &lt;httpErrors&gt; section in applicationhost.config via overrideModeDefault by opening `%windir%\system32\inetsrv\config\applicationhost.config` with a text editor and changing the &lt;section name="httpErrors" overrideModeDefault="Deny" /&gt; element as follows:  

    [!code-xml[Main](delegating-errormode-in-httperrors/samples/sample1.xml)]
2. Use lockAllAttributesExcept and lockElements to only allow the delegation of the errorMode setting, locate the &lt;httpErrors&gt; element and change as follows:  

    [!code-xml[Main](delegating-errormode-in-httperrors/samples/sample2.xml)]
  
 Your httpErrors section might look like this after the change:  

    [!code-xml[Main](delegating-errormode-in-httperrors/samples/sample3.xml)]
3. Now you as the hoster can use appcmd to set the errorMode setting to "Detailed" or "Custom" (see example below)  

    [!code-console[Main](delegating-errormode-in-httperrors/samples/sample4.cmd)]
  
 or you could ask your customers to put the following statement in their web.config files:  

    [!code-xml[Main](delegating-errormode-in-httperrors/samples/sample5.xml)]

### Resources

For more information see:

- [Delegated Administration](delegated-administration.md)
- [Introduction to ApplicationHost.config](../../get-started/planning-your-iis-architecture/introduction-to-applicationhostconfig.md)
- [How to Use HTTP Detailed Errors in IIS](../../troubleshoot/diagnosing-http-errors/how-to-use-http-detailed-errors-in-iis.md)
- [https://blogs.iis.net/thomad/archive/2008/03/14/delegating-iis7-settings-in-hosted-environments.aspx](https://blogs.iis.net/thomad/archive/2008/03/14/delegating-iis7-settings-in-hosted-environments.aspx)