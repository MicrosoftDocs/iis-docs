---
title: "How to Secure the Microsoft Web Platform"
author: rick-anderson
description: "Security is always a consideration; it is critical to make careful security considerations when you implement and maintain your Web sites, infrastructure, an..."
ms.date: 11/15/2009
ms.assetid: d4dd559d-5b26-4da8-a639-184b8742b2d2
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/how-to-secure-the-microsoft-web-platform
msc.type: authoredcontent
---
# How to Secure the Microsoft Web Platform

by Tali Smith

Security is always a consideration; it is critical to make careful security considerations when you implement and maintain your Web sites, infrastructure, and applications. Internet Information Services 7 (IIS 7) and above offers many ways to [configure security](../../manage/configuring-security/index.md), including [dynamic IP restrictions](../../manage/configuring-security/using-dynamic-ip-restrictions.md), [application pool identities](../../manage/configuring-security/application-pool-identities.md), and [Secure Sockets Layer (SSL)](../../manage/configuring-security/how-to-set-up-ssl-on-iis.md). IIS also provides a comprehensive set of authentication and authorization features that can be used to create the desired access control scheme for PHP applications without writing any custom code. You can use features such as Forms Authentication, Role Manager, and URL Authorization to quickly deploy access control solutions that are easily manageable through IIS Manager and other tools.

The following articles provide guidance:

- [Secure Your Infrastructure and Applications](secure-your-infrastructure-and-php-applications.md). This article provides an overview of techniques to secure PHP on IIS.
- [Secure Content in IIS Through File System ACLs](../../get-started/planning-for-security/secure-content-in-iis-through-file-system-acls.md). This article, provides guidance for using access control lists (ACLs) to secure content.
- [Secure Content in IIS Through Impersonation](secure-content-in-iis-through-impersonation.md). This article describes how to use impersonation to help secure content.
- [Set ACLs Through the Manifest.xml File](../../get-started/planning-for-security/set-acls-through-the-manifestxml-file.md). While hosters typically use the command line to set ACLs, it is also possible to use the Manifest.xml file.
- [Secure Your SQL Server Database](secure-your-sql-server-database.md). If you use Microsoft® SQL Server® as your database, you must create and implement an effective security plan. This article touches on a few areas of particular interest to Web hosters.
- [Ensure Security Isolation for Web Sites](../../manage/configuring-security/ensure-security-isolation-for-web-sites.md). The recommendation for isolating PHP Web sites in a shared hosting environment is consistent with all general security isolation recommendations for IIS. Isolating Web sites is particularly important in a shared hosting environment.
- [Use Request Filtering](../../manage/configuring-security/use-request-filtering.md). Request filtering is designed and optimized for security scenarios.
- [Secure PHP with Configuration Settings](secure-php-with-configuration-settings.md). You can configure PHP settings to tighten the security of a PHP installation; this article recommends settings you can use.
- [Enable PHP Applications to Make Application-Level Access Control Decisions](enable-php-applications-to-make-application-level-access-control-decisions.md). You can expose key access control information to a PHP application to facilitate application-level access control.
