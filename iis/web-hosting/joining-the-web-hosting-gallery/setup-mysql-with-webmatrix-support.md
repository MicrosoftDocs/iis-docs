---
title: "Setup MySQL with WebMatrix Support"
author: bilalaslam
description: "MySQL Installation WebPI supports installing MySQL in developer mode, but this is not suitable for a shared hosting environment. Instead, you should download..."
ms.date: 11/03/2010
ms.assetid: 29f4c760-525f-4c61-9e06-ab37014a7dc8
msc.legacyurl: /learn/web-hosting/joining-the-web-hosting-gallery/setup-mysql-with-webmatrix-support
msc.type: authoredcontent
---
# Setup MySQL with WebMatrix Support

by [Bilal Aslam](https://github.com/bilalaslam)

## MySQL Installation

WebPI supports installing MySQL in developer mode, but this is not suitable for a shared hosting environment.

Instead, you should download the latest stable version of MySQL from the [official website](http://www.mysql.com/ "MySQL website") and install it on a **dedicated database server** with these settings:

[![Image of My S Q L Server Instance Configuration Wizard displaying Dedicated My S Q L Server Machine option selected.](setup-mysql-with-webmatrix-support/_static/image3.png)](setup-mysql-with-webmatrix-support/_static/image2.png)[![Image of My S Q L Server Instance Configuration Wizard displaying INNO D B Table Space Settings and Drive Info box.](setup-mysql-with-webmatrix-support/_static/image5.png)](setup-mysql-with-webmatrix-support/_static/image4.png)

For concurrent connections, choose OLTP since that reflects the workload of a typical shared hosting database server:

[![Screenshot of My S Q L Server Instance Configuration Wizard with online Transaction Processing O L T P selected.](setup-mysql-with-webmatrix-support/_static/image7.png)](setup-mysql-with-webmatrix-support/_static/image6.png)

Enable TCP/IP networking, add the firewall exception and disable the strict mode:

[![Screenshot of My S Q L Server Instance Configuration Wizard with T C P slash forward I P Networking enabled and Enable Strict Mode option disabled.](setup-mysql-with-webmatrix-support/_static/image9.png)](setup-mysql-with-webmatrix-support/_static/image8.png)

Enable UTF-8 character set – ***this is very important***, because several applications in the Web Application Gallery require UTF-8 support in the database:

[![Image of My S Q L Server Instance Configuration Wizard with Best Support for Multiligualism enabled and latin 1 typed in the character set box.](setup-mysql-with-webmatrix-support/_static/image11.png)](setup-mysql-with-webmatrix-support/_static/image10.png)

[![Image of My S Q L Instance Configuration Wizard displaying My S Q L typed in the Service Name box and Include Bin Directory in Windows Path checked.](setup-mysql-with-webmatrix-support/_static/image13.png)](setup-mysql-with-webmatrix-support/_static/image12.png)

Since MySQL is installed on the database server, which is different than the web server which runs the Web Deploy web server component, you'll need to take a few extra steps to make sure Web Deploy can access the database server:

1. Copy mysqldump.exe (typically from `C:\Program Files\MySQL\MySQL Server 5.1\bin`) to your **web server** in `c:\mysqldump\mysqldump.exe`
2. On the **web server**, set a registry key (`HKEY\_LOCAL\_MACHINE\SOFTWARE\Microsoft\IIS Extensions\MSDeploy\2\mysqldumppath`) to string value == "c:\mysqldump\mysqldump.exe")

## Resetting Permissions

If you happen to lose the credentials to your MySQL database, this article may help:

[http://dev.mysql.com/doc/refman/5.1/en/resetting-permissions.html#resetting-permissions-windows](http://dev.mysql.com/doc/refman/5.1/en/resetting-permissions.html#resetting-permissions-windows)
