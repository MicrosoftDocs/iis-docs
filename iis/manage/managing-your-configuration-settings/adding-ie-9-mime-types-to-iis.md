---
title: "Adding IE 9 MIME Types to IIS 7 | Microsoft Docs"
author: rick-anderson
description: "The preview release of Microsoft Internet Explorer (IE) version 9 includes support for additional MIME Types for rich media applications. To support the addi..."
ms.author: iiscontent
manager: soshir
ms.date: 04/23/2010
ms.topic: article
ms.assetid: 58cade70-6cd2-48e2-9550-98b053e4fcae
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/managing-your-configuration-settings/adding-ie-9-mime-types-to-iis
msc.type: authoredcontent
---
Adding IE 9 MIME Types to IIS 7
====================
by Randall DuBois

The preview release of Microsoft Internet Explorer (IE) version 9 includes support for additional MIME Types for rich media applications. To support the additional MIME Types, the MIME types must be added to your IIS server.

The following additonal MIME types are supported in IE 9:

| File name extension | MIME type |
| --- | --- |
| .svg | image/svg+xml |
| .xht | application/xhtml+xml |
| .xhtml | application/xhtml+xml |

To learn more about the preview release of IE 9, see [http://ie.microsoft.com/testdrive/](http://ie.microsoft.com/testdrive/). The [Release Notes](http://ie.microsoft.com/testdrive/info/ReleaseNotes/Default.html) contain information about the new features supported in IE 9.

To add these MIME types to your IIS server, you can:

- Manually add them by using the IIS Manager. For more information, see [Configuring MIME Types in IIS 7 and Above](https://go.microsoft.com/fwlink/?LinkId=64365).
- Update your web.config file as discussed in Bill Staple's blog post [How to add mime types with IIS7 Web.config](https://blogs.iis.net/bills/archive/2008/03/25/how-to-add-mime-types-with-iis7-web-config.aspx).
- Use the script included in this article.

## Using the AddMimeTypes Script

You can also use the script included in this article to add the MIME Types on versions of Windows including Windows 2000 and later. The script uses WMI, and will add the MIME types on either a local or remote server.

**To add MIME types for IE 9 to your IIS server using the AddMimeTypes script:** 

1. Create a new script file using your authoring tool or a text editor.
2. Copy the contents of the script file from the following section.
3. Paste the contents of the script into your new script file.
4. Save the script file as AddMimeTypes.vbs.
5. At a Command Prompt, type the following command: 

    [!code-console[Main](adding-ie-9-mime-types-to-iis/samples/sample1.cmd)]

    Replace `[RemoteServerName]`> with the name of the remote computer you want to add the MIME types to.

    > [!NOTE]
    > If the folder in which the script file is saved is not included in your **Path** environment variable, you must specify the full path to the script in the command, or change directories to the folder before running the command.
6. Verify the MIME types were added either by using the IIS Manager.

## The AddMimeTypes.vbs Script

[!code-vb[Main](adding-ie-9-mime-types-to-iis/samples/sample2.vb)]