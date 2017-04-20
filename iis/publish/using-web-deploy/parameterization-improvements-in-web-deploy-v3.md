---
title: "Parameterization improvements in Web Deploy V3 | Microsoft Docs"
author: rick-anderson
description: "Earlier versions of Web Deploy only supported replacing attribute values which already existed as part of the package. In Web Deploy V3 we have added support..."
ms.author: iiscontent
manager: soshir
ms.date: 07/26/2012
ms.topic: article
ms.assetid: 011d5bd7-aa56-4bab-9cb6-16a5b5977a98
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-web-deploy/parameterization-improvements-in-web-deploy-v3
msc.type: authoredcontent
---
Parameterization improvements in Web Deploy V3
====================
by [Harsh Mittal](https://twitter.com/harshmittal)

Earlier versions of Web Deploy only supported replacing attribute values which already existed as part of the package. In Web Deploy V3 we have added support for

1. Extend the current xml parameterization beyond attribute value replacements to a more complete xml modification story by allowing addition/deletion/replacement of new elements.
2. Accept the replacement data for parameters to come from the server, from the package itself or from the source.Here is one example of a parameters.xml file which will add newNode to all nodes including the root in target xml file:

> [!code-xml[Main](parameterization-improvements-in-web-deploy-v3/samples/sample1.xml)]


Below are some examples which demonstrate how to get the values from other placesGet values from remote server: 

> [!code-xml[Main](parameterization-improvements-in-web-deploy-v3/samples/sample2.xml)]


Get values from a file in the package that is being synced:

> [!code-xml[Main](parameterization-improvements-in-web-deploy-v3/samples/sample3.xml)]