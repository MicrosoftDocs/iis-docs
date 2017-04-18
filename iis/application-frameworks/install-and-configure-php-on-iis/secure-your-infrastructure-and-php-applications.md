---
title: "Secure Your Infrastructure and PHP Applications | Microsoft Docs"
author: rick-anderson
description: "Security is always a consideration; it is critical to make careful security considerations when you implement and maintain your Web sites, infrastructure, an..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 3a346c3c-f9cc-49a5-9768-8ddd497935bb
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/secure-your-infrastructure-and-php-applications
msc.type: authoredcontent
---
Secure Your Infrastructure and PHP Applications
====================
by Tali Smith

## Introduction

Security is always a consideration; it is critical to make careful security considerations when you implement and maintain your Web sites, infrastructure, and PHP applications. Internet Information Services 7 (IIS 7) and above offers many ways to [configure security](../../manage/configuring-security/index.md), including [dynamic IP restrictions](../../manage/configuring-security/using-dynamic-ip-restrictions.md), [application pool identities](../../manage/configuring-security/application-pool-identities.md), and [Secure Sockets Layer (SSL)](../../manage/configuring-security/how-to-set-up-ssl-on-iis.md).

The following techniques are some additional ways to secure PHP on IIS.

## Secure File Access

You can secure your IIS sites through access control list (ACL)–based security measures:

- Structure your Web application folders in a logical manner. Create new directories for each file type, setting ACLs on each directory, and let the files inherit the ACLs. Managing and maintaining a Web application with individual ACLs for each file in the system is more difficult. For greater control, isolate separate folders that might need read-write access from anonymous users.
- By default, ACLs on the FTP and SMTP directories (C:\inetpub\ftproot and C:\inetpub\mailroot, respectively) are set at Everyone (Full Control); consider modifying these ACLs with tighter security. To save space on your IIS volume, place the FTP and SMTP folders on a different volume than the IIS server if you want to support Everyone (Write). Alternately, use Windows® 2000 disk quotas to limit the amount of data you can write to the FTP and SMTP folders.
- Mark the ACLs on the IIS-generated log files (%systemroot%\system32\logfiles) Administrators (Full Control), System (Full Control), Everyone (Read-Write Control); this helps prevent intruders from deleting information to cover their tracks.
- Disable or remove all IIS-installed sample Web applications. (Sample sites to help developers learn are not installed by default.) Never install sample sites on a production server because of the many well-identified security risks they present. Though some sample Web applications are installed so that you can access them only from http://localhost or IP address 127.0.0.1, remove them. For example, the IISSamples, IISHelp, and Data Access virtual directories and their associated folders are sample sites that should not reside on production servers.

See [Secure Content in IIS Through File System ACLs](../../get-started/planning-for-security/secure-content-in-iis-through-file-system-acls.md) for more information.

## Use Per-Site PHP Configuration

The FastCGI handler makes it possible to use a different Php.ini file for every application mapping. You can customize your PHP configuration around the specific requirements of your users or your PHP applications, letting you tighten configuration.

## Separate IIS User Accounts and Application Pools

Segregate users and PHP applications by using different user accounts and application pools; this helps keep users and PHP applications from interfering with each other. Keeping user accounts and application pools separate also helps isolate PHP crashes to the specific user or application that caused the issue.

## Limit NTFS Permissions

Consider using the NTFS Deny permission to restrict access for your IIS users; configure your IIS user account so that it only has permissions to the files and directories it needs to access, and everything else is set to Deny. If you have also separated IIS user accounts and application pools, you can make it nearly impossible for one user or application to access files of another user or application like the **safe\_mode** PHP directive used by many UNIX-based Web hosts. Note that it is more common to exclude the user or group from the ACL instead of configuring them to have explicit Deny permissions. It is best to plan your permission structure very carefully and make a backup of your system state.

## Use URL Rewriting

You can improve security with URL rewriting. To avoid the possibility of session hijacking or fixation, keep the session ID in a cookie instead of rewriting the session ID into the URL, and add a second unique token into the URL. Associate this new token value with the session ID, and store it in server session state. Whenever the user makes a request back to the server, the request must include the matching second token or the server considers the request a forgery. For more information, see [Improving Security with URL Rewriting](https://blogs.msdn.com/sdl/archive/2009/04/09/improving-security-with-url-rewriting.aspx).

## Modify Configuration Settings

You can configure PHP settings to tighten the security of a PHP installation and help protect the Web site from malicious attacks. The Php.ini file specifies the configuration settings PHP uses when it is running on your Web site. The Php.ini file determines what the PHP scripts are allowed to do and what the scripts are prohibited from doing.

- Enable only the PHP extensions that your applications are going to use. Some PHP directives, such as register\_globals and allow\_url\_fopen, can pose security risks and should be disabled, if possible. Also, ensure the expose\_php directive is off so that PHP does not expose that it is installed on your server.
- Customize your PHP configuration so that only the functions and classes used by your application are enabled. Use the disable\_functions and disable\_classes PHP directives to supply a list of comma-separated functions and classes that you want to disable.
- Limit the **max\_execution\_time**, **max\_input\_time**, **memory\_limit**, **post\_max\_size** and **upload\_max\_filesize** to only what you need and what your server can handle.

## Restrict HTTP Verbs and Use Request Filtering

Consider restricting which HTTP verbs can be used by enabling only the verbs needed when configuring your PHP application mapping in IIS. For most PHP applications, you only need to enable GET, HEAD, and POST. You can use URLScan v3.1, a security tool that restricts the types of HTTP requests processed by IIS. By blocking specific HTTP requests, URLScan helps prevent potentially harmful requests from being processed by Web applications on the server. URLScan v3.1 can scan query strings and can customize rules to scan parts of your HTTP requests. URLScan v3.1 is installed as an Internet Server Application Programming Interface (ISAPI) filter on IIS. See [Using URLScan](../../extensions/working-with-urlscan/index.md) for more information.

All the core features of URLScan into the Request Filtering module, which also includes a Hidden Segments feature which lets you define which segments are "servable." The Request Filtering module inspects known malicious patterns in the requests and prevents such requests from being serviced if the module determines that the requests may be harmful. For example, this module lets you filter requests that are double escaped, filter requests that use certain HTTP verbs, or block requests to specific folders. You can enforce tighter security policies on your Web servers with the Request Filtering module. You can also [configure WebDAV with request filtering](../../publish/using-webdav/how-to-configure-webdav-with-request-filtering.md).

## Links for Further Information

[IIS Security Checklist](http://windows.stanford.edu/docs/IISsecchecklist.htm).

[Secure Content Publishing](https://www.iis.net/overview/security/securecontentpublishing).

[Discuss in IIS Forums](https://forums.iis.net/1102.aspx)