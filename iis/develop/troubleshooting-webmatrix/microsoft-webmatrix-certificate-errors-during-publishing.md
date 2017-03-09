---
title: "Microsoft WebMatrix: Certificate errors during publishing | Microsoft Docs"
author: bilalaslam
description: "If you are publishing using Web Deploy, WebMatrix helps you publish your site securely by checking the certificate of the remote server and prompting you if..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/11/2010
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/develop/troubleshooting-webmatrix/microsoft-webmatrix-certificate-errors-during-publishing
msc.type: authoredcontent
---
Microsoft WebMatrix: Certificate errors during publishing
====================
by [Bilal Aslam](https://github.com/bilalaslam)

If you are publishing using Web Deploy, WebMatrix helps you publish your site securely by checking the certificate of the remote server and prompting you if any issues are detected. For example, you may see the following security prompt when publishing a site:

[![](microsoft-webmatrix-certificate-errors-during-publishing/_static/image3.png)](microsoft-webmatrix-certificate-errors-during-publishing/_static/image1.png)

If you wish to continue publishing your site, click 'Accept Certificate'. You will not be prompted again while WebMatrix is open, but you will be prompted if you close and reopen WebMatrix. If you do not want to be prompted about certificate errors for this site, click "Save this certificate for future sessions of WebMatrix".

If you do NOT wish to continue publishing your site, click 'Reject Certificate'. Publishing will stop immediately.