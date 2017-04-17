---
title: "Issues with SQL Server Express or MySQL when using WebMatrix or WebPI | Microsoft Docs"
author: chrissfanos
description: "The following article will grow to cover issues when using SQL Server Express or MySQL and WebMatrix or WebPI (Web Platform Installer) Issue : The SA (SQL Ex..."
ms.author: iiscontent
manager: soshir
ms.date: 07/18/2012
ms.topic: article
ms.assetid: 
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/troubleshooting-webmatrix/issues-with-sql-server-express-or-mysql-when-using-webmatrix-or-webpi_1298
msc.type: authoredcontent
---
Issues with SQL Server Express or MySQL when using WebMatrix or WebPI
====================
by [Chris Sfanos](https://github.com/chrissfanos)

The following article will grow to cover issues when using SQL Server Express or MySQL and WebMatrix or WebPI (Web Platform Installer)

***Issue***: The SA (SQL Express) or root (MySQL) password you entered (or have stored) is not valid

***Error Message***: The specified password for user account 'SA'/'root' is not valid or failed to connect to the database server

***Potential solutions***

1. The password you entered may not match the required security settings of SQL Express or MySQL. The following articles detail the password strength requirements:

    1. SQL Express: [https://msdn.microsoft.com/en-us/library/ms161959.aspx](https://msdn.microsoft.com/en-us/library/ms161959.aspx)
    2. MySQL: No complexity requirements
2. The password that WebMatrix or WebPI has stored does not match the database you are trying to connect to

    1. Delete the reg key that is storing the password (hashed) and try the install again
    2. Delete the mysql\_pwd or sql\_pwd key stored at HKCU\Software\Microsoft\WebPlatformInstaller