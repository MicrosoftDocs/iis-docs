---
title: "Set ACLs Through the Manifest.xml File | Microsoft Docs"
author: rick-anderson
description: "There are several ways to set access control lists (ACLs), including command-line tools such as Icacls.exe. PHP hosters generally use the command line. It is..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/planning-for-security/set-acls-through-the-manifestxml-file
msc.type: authoredcontent
---
Set ACLs Through the Manifest.xml File
====================
by Tali Smith

## Introduction

There are several ways to set access control lists (ACLs), including command-line tools such as Icacls.exe. PHP hosters generally use the command line. It is also possible, however, to set ACLs in the Manifest.xml file; these are the mechanisms that are applied when you install an application through the Web Deployment Tool (WDT) or the Microsoft® Web Platform Installer (Web PI).

By default, the WDT installs all files and directories without changing any of the existing permissions. In most cases, this means that the application only has read access to the installed files and directories. If your application needs to be able to write to any file or directory, you can specify which files or directories with a setAcl directive in the Manifest.xml file. The setAclResourceType element defines whether the path represents a file or a directory.


[!code-xml[Main](set-acls-through-the-manifestxml-file/samples/sample1.xml)]


To ensure that the ACL gets applied to the proper directory, you should also provide a hidden parameter to make sure the ACL gets applied to the named directory relative to the AppPath where it is installed.


[!code-xml[Main](set-acls-through-the-manifestxml-file/samples/sample2.xml)]


If no ACL is set on a file or directory, the ACL is most likely set to allow read access to the file or directory. The ACLs are specific, so granting write access does not necessarily grant read access. If you must write to a file or directory, you should add "read, write". If you need to be able to enumerate the files in a directory, you should add "ListDirectory". Note that write access does not grant modify access. If you need to change files once they are written to disk, you must explicitly set modify access. There are some permissions that are combinations of other permissions; for example, "Modify" includes "Read", "Write", "Execute", and "Delete".

To give read, execute, and write permissions to the **MyApp** file system directory for the user **Test**, add the following line to your **Manifest.xml** file:


[!code-xml[Main](set-acls-through-the-manifestxml-file/samples/sample3.xml)]


To set the ACL on the path **MyApp/Upload** to allow anonymous users to upload content, add the following line to your **Manifest.xml** file:


[!code-xml[Main](set-acls-through-the-manifestxml-file/samples/sample4.xml)]


Note that anonymousAuthenticationUser is a special token that resolves to your configured anonymous authentication identity.

To grant read access to the **MyApp\Data** folder for the application pool identity, add the following line to the **Manifest.xml** file:


[!code-xml[Main](set-acls-through-the-manifestxml-file/samples/sample5.xml)]


Note that the setAclUser is not used here. The default value for this is Application Pool Identity, so it is possible to skip that line.

Note that it is considered a risky security practice to grant "Write" or "Modify" access to the entire application tree by applying an ACL at the root of the application. ACLs need to be as limiting and granular as possible without restricting applications functionality.

If you are familiar with UNIX or Linux permissions, the privileges discussed are the equivalent of "Owner" permissions. While Group and World privileges can be set through various ACLs outside of the WDT, only "Owner" class permissions are set here. The table below shows the Windows® operating system equivalents of various Linux bit-masked permissions:

| Linux | Windows | Linux | Windows |
| --- | --- | --- | --- |
| 0 | No equivalent to None | 4 | Read |
| 1 | Execute | 5 | ReadAndExecute |
| 2 | Write | 6 | Read,Write |
| 3 | Write, Execute | 7 | Modify |

See the full list of the [various user rights and their descriptions](https://msdn.microsoft.com/en-us/library/system.security.accesscontrol.filesystemrights.aspx). In addition, there is some [Internet Information Services (IIS)–specific ACL guidance](secure-content-in-iis-through-file-system-acls.md).

The token anonymousAuthenticationUser is automatically compared to the ID that the Web site has configured and that will be used for anonymous authentication. As this ID is configured by the Web Site administrator, it is best to use anonymousAuthenticationUser for PHP applications and not to use setAclUser for Microsoft® ASP.NET applications (unless your application has a specific need for a user to handle file ownership).

PHP applications are typically run as the anonymous user because the FastCGI settings usually set the impersonation to be True(run as anonymous user). ASP.NET applications typically run as the worker process identity (application pool identity). If setAclUseris not specified, then the setAcldirective uses the application's Application Pool Identity as the ID for authorization.


> [!NOTE]
> *This article is based on information from: "[Application Packaging Guide for the Windows Web Application Gallery](../../develop/windows-web-application-gallery/package-an-application-for-the-windows-web-application-gallery.md)" by the IIS team, published on September 24, 2009.*


## Links for Further Information

[Understanding the Built-In User and Group Accounts in IIS 7.0 and Above](understanding-built-in-user-and-group-accounts-in-iis.md).
  
  
[Discuss in IIS Forums](https://forums.iis.net/1043.aspx)