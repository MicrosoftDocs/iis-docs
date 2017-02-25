---
title: "Default Documents | Microsoft Docs"
author: rick-anderson
description: "The default document is for client requests to a Web site that do not specify a document name, such as www.microsoft.com. The default document specifies what..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/01/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/default-documents
msc.type: authoredcontent
---
Default Documents
====================
by Walter Oliver

The default document is for client requests to a Web site that do not specify a document name, such as www.microsoft.com. The default document specifies what file to serve. You can configure multiple default documents for a Web site, but there is a performance benefit to using fewer documents.

For each request, IIS must get the list of default documents and look for each file in the content path until it finds the first match. If you configure five documents and the site uses the last document, this increases the length of time spent that the system looks for the document. However, if you use one default document or use the first document in the list, this speeds up the request time.

Using the delegation functionality of IIS 7 and above, you can delegate this property to the site owner and encourage the site owner to use only one document.

**To configure the default documents globally using IIS Manager**

1. From the **Administrative Tools** menu, click **Internet Information Services (IIS) Manager**.

2. In IIS Manager, click the server name node, and then scroll to locate the **Default Document** icon.

3. Double click **Default Document**.

[![](default-documents/_static/image4.jpg)](default-documents/_static/image3.jpg)

4. In the Actions pane, click **Add**.

[![](default-documents/_static/image6.jpg)](default-documents/_static/image5.jpg)

5. In the **Add Default Document** dialog box, type the name of the default document.

6. Click **OK**.

> [!NOTE]
> Set this to as few default documents as possible. If the property is delegated, users can add specific documents and limit it to one document to get better performance for their sites.

**To add and remove the default documents globally using the [IIS PowerShell Provider](../../manage/powershell/installing-the-iis-powershell-snap-in.md)**

- To add file name foo.html, open the PowerShell prompt and type:


[!code-powershell[Main](default-documents/samples/sample1.ps1)]


- To remove file name foo.html type:


[!code-unknown[Main](default-documents/samples/sample-127083-2.unknown)]


Also see [C# and PowerShell Scripts Samples](../configuring-components/powershell-scripts.md) for a another sample script to configure default documents.

To configure the default document or other properties for delegation, see the topic "*Configuring Delegating Administration*" later in this section.

* * *