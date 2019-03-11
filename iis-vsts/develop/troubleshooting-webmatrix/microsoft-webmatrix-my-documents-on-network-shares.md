---
title: "Microsoft WebMatrix: My Documents on network shares"
author: rick-anderson
description: "When your 'My Documents' folder is pointing to a network share, Windows translates the location automatically. This is so that applications such as WebMatrix..."
ms.date: 01/11/2011
ms.assetid: 7ecaa7ab-e6d1-4b8b-8d74-6296e45b0d2d
msc.legacyurl: /learn/develop/troubleshooting-webmatrix/microsoft-webmatrix-my-documents-on-network-shares
msc.type: authoredcontent
---
Microsoft WebMatrix: My Documents on network shares
====================
by Faith A

When your "My Documents" folder is pointing to a network share, Windows translates the location automatically. This is so that applications such as WebMatrix or IIS Express can simply request the special folder and Windows takes care of the rest.

While this works fine in most circumstances, there are cases that do not work. When My Documents points to a network share, this is supported.

However it will not work when My Documents points to a mapped drive (like Z:), which then points to a network share.

This problem is due to the way that Windows calculates the path for the special folder. We block this case because IIS Express will not work properly in this case.

The workaround is to point your "My Documents" directly to the network share.