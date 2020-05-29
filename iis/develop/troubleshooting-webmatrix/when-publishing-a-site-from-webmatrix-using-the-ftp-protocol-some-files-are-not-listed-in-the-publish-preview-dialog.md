---
title: "When publishing a site from WebMatrix, some files are not listed in the dialog"
author: bilalaslam
description: "When publishing a site from WebMatrix using the FTP protocol, some files are not listed in the Publish Preview dialog. How to reproduce Publish site from to..."
ms.date: 02/07/2011
ms.assetid: 693e4539-1261-4ad7-afa7-a876fdc4135e
msc.legacyurl: /learn/develop/troubleshooting-webmatrix/when-publishing-a-site-from-webmatrix-using-the-ftp-protocol-some-files-are-not-listed-in-the-publish-preview-dialog
msc.type: authoredcontent
---
# When publishing a site from WebMatrix, some files are not listed in the dialog

by [Bilal Aslam](https://github.com/bilalaslam)

When publishing a site from WebMatrix using the FTP protocol, some files are not listed in the Publish Preview dialog.

## How to reproduce

- Publish site from to Remote Server 1 using the FTP protocol.
- Change a single file associated, foo.html, with the site on Remote Server 1 (for example, by using an FTP client to download the file, modify it, and upload it again).
- Publish site to Remote Server 1 using the FTP protocol. Notice that foo.html does not show up in the Publish Preview dialog because WebMatrix does not recognize it as being changes.

## Resolution

When publishing using the FTP protocol, WebMatrix by default keeps track of files that are changed on the local computer. This makes all FTP transfers after the first transfer faster because WebMatrix does not need to obtain a folder list from the remote server to determine what files are different.

There are two resolutions available:

### 1) (Recommended) Clear the cached list of changed files

1. Close WebMatrix.
2. Open the IIS Express configuration directory in Explorer: %USERPROFILE%\IISExpress\config\PublishUI
3. Open the folder named after your site. For example, if your site is named Bakery, open the bakery folder.
4. Open the folder named after your remote server. For example, if you are publishing to [ftp.contoso.com](ftp://ftp.contoso.com/), open the [ftp.contoso.com](ftp://ftp.contoso.com/) folder.
5. Delete the CSV file in this folder.
6. Open WebMatrix and try publishing again.

### 2) Disable the feature

1. Open WebMatrix.
2. Click the Application Menu in the top-left corner of the window.
3. Click Options.
4. Click Publishing.
5. Uncheck "Make FTP faster by only publishing the files that have changed on this computer".

    > [!NOTE]
    > This will make FTP transfers significantly slower.
