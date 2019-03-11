---
title: "Microsoft WebMatrix: Publish Compatibility"
author: bilalaslam
description: "Microsoft WebMatrix includes a feature called Publish Compatibility, which can help determine if your site is compatible with a web hosting provider. To chec..."
ms.date: 11/11/2010
ms.assetid: a0133dfc-265b-42b7-adc4-4f92421e2a8a
msc.legacyurl: /learn/develop/troubleshooting-webmatrix/microsoft-webmatrix-publish-compatibility
msc.type: authoredcontent
---
Microsoft WebMatrix: Publish Compatibility
====================
by [Bilal Aslam](https://github.com/bilalaslam)

Microsoft WebMatrix includes a feature called Publish Compatibility, which can help determine if your site is compatible with a web hosting provider. To check your site's compatibility with a web hosting provider:

1. Create or open a site in WebMatrix
2. Provide publish settings in the Publish Settings dialog
3. Click Publish &gt; Check Compatibility... in the ribbon dropdown menu.

Publish Compatibility will find out what components your site depends on, and then check if they are available on the web hosting provider. For example, if your site includes a Microsoft SQL Server database, then Publish Compatibility will verify that a Microsoft SQL Server database is available on the web hosting provider using the connection string you provided in the Publish Settings Dialog.

This is a summary of what Publish Compatibility checks:

| Site Dependency | Checked by Publish Compatibility? | What to do if the compatibility test fails |
| --- | --- | --- |
| Simple HTML page | **Y** | Check the Destination URL field in Publish Settings |
| ASP.NET | **Y**, but not checked if publishing protocol is FTP | Check if your hosting provider supports ASP.NETCheck if your hosting provider has given you permissions to change your IIS application pool's .NET framework version and pipeline mode |
| PHP | **Y** | Check if your hosting provider supports PHP |
| SQL Server database | **Y**, but not checked if publishing protocol is FTP since FTP does not support transferring SQL Server database | Check the database connection string in the Publish Settings dialog |
| MySQL database | **Y**, but not checked if publishing protocol is FTP since FTP does not support transferring MySQL databases | Check the database connection string in the Publish Settings dialog |
| MySQL driver for PHP | **Y** | Check if your hosting provider supports connecting to MySQL databases using PHP |
| SQL Server driver for PHP | **Y** | Check if your hosting provider supports connecting to SQL Server databases using PHP |
| URL Rewrite | **Y** | Check if your hosting provider supports URL Rewrite |
| ASP.NET MVC | N | Not currently checked by Publish Compatibility |

## Known Issues

**Issue:** If you publish an app (e.g. mysite/myapp) that has a different .NET version from the site (e.g. mysite), the Publish Compatibility check that runs on first publish does NOT set the .NET version. This may result is errors when you browse to your published application

**Workaround:** Run Publish Compatibility again, which will update the remote site's .NET version as needed.