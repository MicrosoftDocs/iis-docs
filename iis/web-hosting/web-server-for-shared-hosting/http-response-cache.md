---
title: "HTTP Response Cache"
author: walterov
description: "The IIS output cache is a feature that makes it possible to cache entire responses in memory, even from dynamic content. Unlike the caches in IIS 6.0, IIS 7...."
ms.date: 12/01/2007
ms.assetid: bc584e6a-d069-4abe-a503-6baa51a08077
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/http-response-cache
msc.type: authoredcontent
---
HTTP Response Cache
====================
by [Walter Oliver](https://github.com/walterov)

The IIS output cache is a feature that makes it possible to cache entire responses in memory, even from dynamic content. Unlike the caches in IIS 6.0, IIS 7.0 and above have a "smart" cache, which lets site owners and developers configure the output cache to cache separate copies of responses based on query string value. The output cache is also integrated with the HTTP.sys kernel cache that helps with fast performance. Kernel caching is unlocked by default. Developers can take advantage of this feature by configuring caching profiles within their application. You can run a command line tool that shows what content is in the HTTP.sys cache.

**To view the HTTP response cache using netsh**

- Open a command prompt and run the following:

netsh http show cache

**To Enable Caching using the [IIS PowerShell Provider](../../manage/powershell/installing-the-iis-powershell-snap-in.md)**

- Open the PowerShell prompt and type:

[!code-powershell[Main](http-response-cache/samples/sample1.ps1)]

**To add a new entry using the IIS PowerShell Provider**

- Add extra properties the hash -value @{...}

[!code-powershell[Main](http-response-cache/samples/sample2.ps1)]

**To change setting for caching entry**

- get specific entry:

[!code-powershell[Main](http-response-cache/samples/sample3.ps1)]

- change attribute

[!code-powershell[Main](http-response-cache/samples/sample4.ps1)]