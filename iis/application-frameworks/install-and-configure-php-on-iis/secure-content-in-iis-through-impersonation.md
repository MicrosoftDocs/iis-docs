---
title: "Secure Content in IIS Through Impersonation | Microsoft Docs"
author: rick-anderson
description: "The access control list (ACL) is a list of permissions associated with an object. Each of these permission entries is called an access control entry (ACE); a..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: fadbe064-4cbf-49ec-9439-ce6633f3a155
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/secure-content-in-iis-through-impersonation
msc.type: authoredcontent
---
Secure Content in IIS Through Impersonation
====================
by Tali Smith

## Introduction

The access control list (ACL) is a list of permissions associated with an object. Each of these permission entries is called an access control entry (ACE); an ACE contains permissions associated with a particular object for a particular identity. For example, for file system objects, you can set ACLs on files/directories on an NTFS file system.

You can use graphical user interface (GUI) tools (such as My Computer or Windows® Explorer) to set or edit ACLs. Simply right-click any file or folder resource from one of these tools, select **Properties**, and then click the **Security tab** to see a graphical representation of the ACL on the resource you chose. From this dialog box, you can apply or remove group or user permissions to system resources such as files and folders. You can also use a command-line utility Cacl.exe to display or modify file ACLs.

For the basics of ACLs, see [Secure Content in IIS through File System ACLs](../../get-started/planning-for-security/secure-content-in-iis-through-file-system-acls.md).

## Impersonation and File System Access

It is recommended that you enable FastCGI impersonation in PHP when using IIS. This is controlled by the **fastcgi.impersonate** directive in the Php.ini file. When impersonation is enabled, PHP performs all the file system operations on behalf of the user account that has been determined by IIS authentication; this ensures that even if the same PHP process is shared across multiple IIS Web sites, the PHP scripts in those Web sites cannot access each other's files as long as different user accounts are used for IIS authentication on each Web site.

For example, in its default configuration, IIS has anonymous authentication enabled with the built-in user account IUSR used as a default identity. This means that in order for IIS to execute PHP scripts, it is necessary to grant the IUSR account read permission on those scripts. If PHP applications need to perform write operations on certain files or write files into some folders, then the IUSR account should have write permission to those.

To determine which user account is used as an anonymous identity in IIS, use the following command (replace the "Default Web Site" with the name of your IIS Web site). In the output XML configuration element, look for the userName attribute.


[!code-xml[Main](secure-content-in-iis-through-impersonation/samples/sample1.xml)]


Note that if the userName attribute is not present in the &lt;anonymousAuthentication&gt; element or is set to an empty string, then the application pool identity is used as an anonymous identity for that Web site.

To modify the permissions settings on files and folders, use the Windows Explorer user interface or the **icacls** command.


[!code-console[Main](secure-content-in-iis-through-impersonation/samples/sample2.cmd)]


*Note: This article uses material from "[Securing Content in IIS through File System ACLs](../../get-started/planning-for-security/secure-content-in-iis-through-file-system-acls.md)" by Nazim Lala*, *published on March 17, 2009.*


## Links for Further Information

- [Application Packaging Guide for the Windows Web Application Gallery](../../develop/windows-web-application-gallery/package-an-application-for-the-windows-web-application-gallery.md).
- [Understanding the Built-In User and Group Accounts in IIS 7 and Above](../../get-started/planning-for-security/understanding-built-in-user-and-group-accounts-in-iis.md).
- [PHP on Windows Training Kit (August 2009)](https://www.microsoft.com/downloads/details.aspx?FamilyID=c8498c9b-a85a-4afa-90c0-593d0e4850cb&amp;DisplayLang=en).
- [Access Control Lists](https://msdn.microsoft.com/en-us/library/aa374872(VS.85).aspx).