---
title: "IIS7 Security Improvements"
author: rick-anderson
description: "This article contains the following: Reduced Surface Area Simplified Security Management Security Enhancements Reduced Surface Area IIS 6.0 introduced the lo..."
ms.date: 11/22/2007
ms.assetid: 6fd5adaa-0356-4fee-bfb1-c9d73a6b6c2f
msc.legacyurl: /learn/get-started/whats-new-in-iis-7/iis7-and-above-security-improvements
msc.type: authoredcontent
---
IIS7 Security Improvements
====================
by [Saad Ladki](https://twitter.com/saadladki)

<a id="Reduced"></a>

## Reduced Surface Area

IIS 6.0 introduced the ***lockdown by default*** approach. This was a significant shift from previous versions of IIS which installed and enabled nearly all features out of the box, resulting in a fully capable, yet maximally exposed Web server by default. With IIS 6.0, several features were removed from the default install, and many others, while installed, were disabled in the default install.

IIS 7.0 and above takes this approach the next step by introducing the ***minimum install by default*** approach. IIS includes a completely modular Web server that has been componentized into more than *four to five* *times* the number of installable components as previous versions of IIS. With IIS, only the bare minimum number of components are installed and enabled. This has several key benefits:

- Fewer components installed means lower potential surface area available to attackers
- Fewer components installed means less to manage, patch and maintain
- Fewer components lowered in memory means increased performance, scalability and reliability

<a id="Simplified"></a>

## Simplified Security Management

IIS provides several key simplifications of security management, to make it easier to get and stay secure. These management improvements include:

- Rich delegated administration support, enabling scoped configuration and management tasks to be delegated to non-Administrators in a simple and secure manner
- Unified authentication and authorization management, allowing for all types of authentication and authorization, including Forms authentication and URLAuthorization, to be managed in a single place, for all types of content
- Built-in user and group accounts dedicated to the Web server, enabling a common security identifier (SID) to be used across machines which simplifies NTFS ACL management, and simplifies on Application Pool sandboxing and identity management

## Security Enhancements

IIS also provides several new security features which enhance the security capabilities of the Web server, including Request Filtering. The new built-in IIS request filtering can filter requests on-the-fly based on verb, file extension, size, namespace and sequences. Much of this functionality, previously delivered in URLScan (an ISAPI filter available as a web download) is now available as a built-in IIS module.

### Rich Delegation Infrastructure

In the past, it was very difficult to setup delegation of administrative tasks for non administrative users in IIS.

In IIS 5.0 the administration tool allowed you to specify [Web operators](https://www.microsoft.com/windows2000/en/server/iis/default.asp?url=/windows2000/en/server/iis/htm/core/iiwbsop.htm) and in IIS 6.0 the IIS team introduced modification of [metabase ACL's](https://support.microsoft.com/?id=326902) to address this scenario.

Each of these solutions had their benefits and drawbacks that the IIS team learned from. Using customer feedback, the team developed the new IIS rich delegation model. With the new architecture, administrators can:

- Setup a delegated administration infrastructure using both Windows and non-Windows principals
- Configure setting at a server, site, and application scope. Site and application administrators do not need to be a box administrator to manage sites and applications

To ensure IIS is secure out of the box, delegation has been locked down by default. To help understand what this means, this section covers:

- The secure IIS defaults for locking
- How the default IIS permissions enable secure delegation out of the box

From the beginning, the goal was to ensure that IIS 7.0 and above was as secure as its predecessor, IIS 6.0. In IIS 6.0, there was one primary configuration file called the metabase -- but setting up delegation scenarios using metabase ACL's was not very common or easy.

With the delegation model in IIS 7.0 and above, the product team needed to ensure we locked down the applicationHost.config (the metabase replacement) as tightly as possible. At the same time, the team made it extremely easy to use for administrators who wanted to setup delegation without having to jump through many hoops.

When a section is 'locked', it means the section cannot be redefined by an application or site administrator. When a section is 'unlocked', it means the section is allowed to be changed by site or application administrator. The above document reviews each section from a security, performance and reliability aspect and shows why we choose to unlock certain sections and not others. Based on the environments requirements, you may choose to either unlock or further lock down sections.

### How the Default IIS Permissions Enable Secure Delegation Out of the Box

These sections provide an overview about how delegation and permissions relate to one another on IIS on Vista and Server. They also show how non-administrative users (both Windows and non Windows identities) can easily be setup to manage both sites and applications without any changes to the default permissions.

First, we examine Vista client and then review Server. To ensure a clear understanding of what is happening, detailed walkthrough are provided that touch on the key points being discussed.

### Vista Client

Vista client was designed based on two primary goals:

- Delegation on client via the UI is not a supported feature on Windows Vista
- Delegation via configuration files is fully supported for non-administrative Windows user accounts with LUA enabled. Using administrator accounts requires LUA to be turned off to function correctly and is not recommended

This section now discusses the second point and examines how you can easily setup delegation using non-administrative Windows account.

### Delegation Using Non-administrative Windows Accounts

This is a common scenario when administrators want to implement a delegated model on their systems where the users are:

Windows accounts that reside in the local account database or active directory.

- Not part of the administrators group
- Part of the users group

### Windows Server® 2008

Windows Server 2008 takes delegation to the next level by providing the following:

- Full support for all client delegation scenarios on server
- Full support for delegation via the UI, which includes the use of non-windows principals

To better understand how the UI supports delegation with secure permissions and the use of non-windows principals, the following walkthrough provides an overview on:

- Delegation using non-administrative Windows accounts and the UI
- Delegation using non Windows accounts and the UI

### Unified Security Architecture

In previous versions of IIS that supported ASP.NET applications, we had two rich security architectures that provided an end-to-end solution for application developers. The first model was provided by IIS and the second was provided by ASP.NET.

When the IIS team was redesigning IIS 7.0, they saw an opportunity to unify these two models and did so. Now in IIS 7.0 and above we have one pipeline that will:

- Fully support Windows principals that reside in the local account database or Active Directory (as it had in the past)
- Fully support non-Windows principals
- Provide one place for doing all authentication and authorization

Some additional benefits to the IIS 7.0 and above architecture is that it can now leverage the rich membership system that ASP.NET 2.0 provides. Using the new membership system, we can support all those that ASP.NET 2.0 suppports (example SQL) or create custom providers and have them 'just work' with IIS 7.0 and above.

### Fully Support Windows Principals

As in previous versions of IIS, all the previous authentication schemes are still available in IIS 7.0 and above, mainly:

- Windows Authentication
- Anonymous Authentication
- Basic Authentication
- Digest Authentication
- Certificate Authentication

When a token is created from any of these authentication types, it can still be used by an IIS application as well as any ASP.NET application without any additional configuration.

### Fully Support Non-Windows Principals

The Forms Authentication feature was introduced in IIS 7.0. In the past, this was only available to ASP.NET applications but because of IIS 7.0 and above's architecture, forms authentication can be used to authenticate non-Windows identities like any of the other authentication schemes described in the previous section.

### Provide One Place for Doing All Authentication and Authorization

When using either the IIS administration tool or configuration files, note that all authentication and authorization policies (for both ASP.NET and IIS 7.0 and above) can be configuration in the &lt;authentication&gt; and &lt;authorization&gt; sections respectively under the `<system.webServer>` group.

This now makes it easy for administrators to define rules and see what is happening on their servers.

**Start Learning**

- [Security Changes in IIS 7.0 and Above](changes-in-security-between-iis-60-and-iis-7-and-above.md)
- [Understanding the Built-In Anonymous Account and Groups in IIS 7.0 and Above](../planning-for-security/understanding-built-in-user-and-group-accounts-in-iis.md)
- [Using Encryption to Protect Passwords](../../manage/configuring-security/using-encryption-to-protect-passwords.md)
- [Understanding IIS 7.0 and Above URL Authorization](../../manage/configuring-security/understanding-iis-url-authorization.md)

**Begin Using the IIS 7.0 and Above Security Features**

- [How to Use Request Filtering](../../manage/configuring-security/use-request-filtering.md)
- [Delegating Administrative Tasks](../../manage/managing-your-configuration-settings/an-overview-of-feature-delegation-in-iis.md)
- [How to Setup SSL on IIS 7.0 and Above](../../manage/configuring-security/how-to-set-up-ssl-on-iis.md)
