---
title: "Microsoft WebMatrix: Database errors while publishing and downloading sites"
author: bilalaslam
description: "Microsoft WebMatrix includes the ability to transfer your site's database to and from a remote server. This article contains tips for when you encouter error..."
ms.date: 01/09/2011
ms.assetid: 3498e1fb-f467-46f4-bf44-60e8e7615905
msc.legacyurl: /learn/develop/troubleshooting-webmatrix/microsoft-webmatrix-database-errors-while-publishing-and-downloading-sites
msc.type: authoredcontent
---
Microsoft WebMatrix: Database errors while publishing and downloading sites
====================
by [Bilal Aslam](https://github.com/bilalaslam)

## Introduction

Microsoft WebMatrix includes the ability to transfer your site's database to and from a remote server. This article contains tips for when you encouter errors during a database transfer.

## Tips

Check that the username and password in the database connection string in Publish Settings is correct. Click 'Validate Connection' to verify that WebMatrix can connect to the database.

If you are transferring a MySQL database, ensure that MySQL has default collation of UTF-8. WebMatrix automatically sets this collation if it installs MySQL. Further reading: [http://dev.mysql.com/doc/refman/5.0/en/charset-server.html](http://dev.mysql.com/doc/refman/5.0/en/charset-server.html)

If you are still stuck, we recommending posting a question on the [WebMatrix Forum](https://forums.iis.net/1166.aspx).