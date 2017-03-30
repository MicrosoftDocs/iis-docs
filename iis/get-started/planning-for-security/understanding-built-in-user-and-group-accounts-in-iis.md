---
title: "Understanding Built-In User and Group Accounts in IIS 7 | Microsoft Docs"
author: rick-anderson
description: "Introduction In earlier versions of IIS, a local account called IUSR_MachineName is created during installation. IIS used the IUSR_MachineName account by def..."
ms.author: iiscontent
manager: soshir
ms.date: 11/22/2007
ms.topic: article
ms.assetid: 
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/planning-for-security/understanding-built-in-user-and-group-accounts-in-iis
msc.type: authoredcontent
---
Understanding Built-In User and Group Accounts in IIS 7
====================
by [Saad Ladki](https://twitter.com/saadladki)

## Introduction

In earlier versions of IIS, a local account called IUSR\_MachineName is created during installation. IIS used the IUSR\_MachineName account by default whenever anonymous authentication was enabled. This was used by both the FTP and HTTP services.

There was also a group called IIS\_WPG, which was used as a container for all the application pool identities. During IIS setup, all the appropriate resources on the system were granted the correct user rights for the IIS\_WPG group so that an administrator only needed to add their identity to that group when they created a new application pool account.

This model worked well, but had its drawbacks: the IUSR\_MachineName account and the IIS\_WPG group were both local to the system that they were created on. Every account and group within Windows is given a unique number called a security identifier (SID) that distinguishes it from other accounts. When an ACL is created only the SID is used. As part of the design in earlier versions of IIS, IUSR\_MachineName was included in the metabase.xml file so that if you tried to copy the metabase.xml from one computer to another, it would not work. The account on the other computer would have a different name.

In addition, you could not 'xcopy /o' ACLs from one computer to another since the SIDs were different from computer to computer. One workaround was to use domain accounts, but that required adding an active directory to the infrastructure. The IIS\_WPG group had similar issues with user rights. If you set ACLs on one computer's file system for IIS\_WPG and tried to 'xcopy /o' those over to another computer, it would fail. This experience has been improved in IIS 7 and above by using a built-in account and group.

A built-in account and group are guaranteed by the operating system to always have a unique SID. IIS 7 and above have taken this further and ensured that the actual names that are used by the new account and group will never be localized. For example, regardless of the language of Windows that you install, the IIS account name will always be IUSR and the group name will be IIS\_IUSRS.

In summary, IIS 7 and above offer the following:

- The IUSR built-in account replaces the IUSR\_MachineName account.
- The IIS\_IUSRS built-in group replaces the IIS\_WPG group.

The IUSR account no longer needs a password because it is a built-in account. Logically, you can think of it as being the same as the NETWORKSERVICE or LOCALSERVICE accounts. Both the new IUSR account and the IIS\_IUSRS group are discussed in greater depth in the sections below.

## Understanding the New IUSR Account

The IUSR account replaces the IUSR\_MachineName account in IIS 7 and above. The IUSR\_MachineName account will still be created and used if you install the FTP 6 compatible server that is included in Windows Server 2008. If you do not install the FTP server that is included with Windows Server 2008, then this account will not be created.

This built-in account does not need a password and will be the default identity that is used when anonymous authentication is enabled. If you look in the applicationHost.config file you will see the following definition:

[!code-unknown[Main](understanding-built-in-user-and-group-accounts-in-iis/samples/sample-127008-1.unknown)]

This tells IIS to use the new built-in account for all anonymous authentication requests. The biggest advantages are that you can:

- Set file system permissions for the IUSR account by using Windows Explorer or any of the many command line tools.
- No longer need to worry about passwords expiring for this account.
- Use xcopy /o to copy files along with their ownership and ACL information to different computers seamlessly.

> [!NOTE]
> The IUSR account is similar to LOCALSERVICE in the manner in which it acts anonymously on the network. The NETWORKSERVICE and LOCALSYSTEM accounts can act as the machine identity, but the IUSR account cannot because it would require an elevation of user rights. If you need the anonymous account to have rights on the network, you must create a new user account and set the user name and password manually, as you did in the past for anonymous authentication.

**To grant an anonymous account rights on the network by using IIS Manager:** 

1. Click **Start**, type **INetMgr.exe**, and then click **Enter**. If prompted, click **Continue** to elevate your permissions.
2. In the **Connections** section, click the **+** button next to the name of your computer.
3. In IIS Manager, double-click the site that you want to administer.
4. In the Features View, double-click **Authentication**.
5. Select **Anonymous Authentication**, and then click **Edit** in the **Actions** pane.
6. In the **Edit Anonymous Authentication Credentials** dialog box, click the **Specific user** option, and then click **Set**.
7. In the **Set Credentials** dialog box, input the user name and password desired, and then click **OK**.

## Understanding the New IIS\_IUSRS Group

The IIS\_IUSRS group replaces the IIS\_WPG group. This built-in group has access to all the necessary file and system resources so that an account, when added to this group, can seamlessly act as an application pool identity.

As with the built-in account, this built-in group solves several xcopy deployment obstacles. If you set permissions on your files for the IIS\_WPG group (that was available on IIS 6.0 systems) and tried to copy those files to another Windows computer, the group's SID would be different across the computers and your site's configurations would be broken.

Since the group SID in IIS 7 and above is the same on all systems that are running Windows Server 2008, you can use 'xcopy /o' to preserve the ACL's and ownership information as you move files from computer to computer. This makes xcopy deployments easy.

IIS 7 and above also makes the process of configuring an application pool identity and making all necessary changes easier. When IIS starts a worker process, it needs to create a token that the process will use. When this token is created, IIS automatically adds the IIS\_IUSRS membership to the worker processes token at runtime. The accounts that run as 'application pool identities' no longer need to be an explicit part of the IIS\_IUSRS group. This change helps you to set up your systems with fewer obstacles and makes your overall experience more favorable.

If you want to disable this feature and manually add accounts to the IIS\_IUSRS group, disable this new feature by setting the **manualGroupMembership** value to '**true**'. The following example shows how this can be done to the **defaultAppPool**:

[!code-xml[Main](understanding-built-in-user-and-group-accounts-in-iis/samples/sample2.xml)]


[Discuss in IIS Forums](https://forums.iis.net/1043.aspx)