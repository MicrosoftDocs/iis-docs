---
title: "How Do I Configure FTP Security in IIS? | Microsoft Docs"
author: rmcmurray
description: "This page is an experiment in a new approach to presenting annotated lists of links on specific subjects of interest to developers. Please send me an email w..."
ms.author: iiscontent
manager: soshir
ms.date: 04/23/2013
ms.topic: article
ms.assetid: b64a3952-9952-45f7-8a14-890506209dc2
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-the-ftp-service/cse-curated-view-ftp-security-settings
msc.type: authoredcontent
---
How Do I Configure FTP Security in IIS?
====================
by [Robert McMurray](https://github.com/rmcmurray)

> This page is an experiment in a new approach to presenting annotated lists of links on specific subjects of interest to developers. Please [send me an email with your comments](mailto:aspnetue@microsoft.com?subject=New curated content view for FTP Settings) indicating what you think of the content and the way it is presented.


The Internet presents a formidable set of security challenges for today's server administrators; hackers, malware, and other cyber-threats require administrators to keep up-to-date with the growing number of threats. To help counter these challenges, Microsoft's FTP service provides a variety of security features to help administrators keep their FTP sites secure.

## CONFIGURING FTP AUTHENTICATION

- [Article](https://www.iis.net/configreference/system.applicationhost/sites/site/ftpserver/security/authentication) | Source: IIS Configuration Reference, Microsoft
- Applies To: IIS 7.0, IIS 7.5, IIS 8.0

At the most basic level, FTP administrators need to configure their FTP sites for the correct form of authentication. The Ftp service in IIS 7.0, IIS 7.5, and IIS 8.0 support the following authentication types: Anonymous, Basic, Client Certificate, and Custom. This article from the official IIS configuration reference provides a detailed description for how to configure your FTP authentication settings.

## CONFIGURING FTP AUTHORIZATION

- [Article](https://www.iis.net/configreference/system.ftpserver/security/authorization) | Source: IIS Configuration Reference, Microsoft
- Applies To: IIS 7.0, IIS 7.5, IIS 8.0

In addition to authentication, FTP administrators need to configure their FTP sites so their users have the right level of access that is necessary for them to accomplish their publishing tasks. This article from the official IIS configuration reference provides a detailed description for how to configure your FTP authorization settings.

## CONFIGURING FTP USER ISOLATION

- [Article](https://www.iis.net/configreference/system.ftpserver/security/authorization) | Source: Robert McMurray, Microsoft
- Applies To: IIS 7.0, IIS 7.5, IIS 8.0

One of the challenges for FTP administrators that use a single FTP site for all of their users it how to keep individual accounts restricted to their own content directories. Microsoft's FTP service makes this possible through User Isolation, which allows administrators to restrict users to their individual content folders. This walkthrough will teach you how to configure FTP User Isolation and the different options for restricting users.

## ENABLING FTP OVER SSL TO SECURE DATA OR USER CREDENTIALS

- [Article](using-ftp-over-ssl-in-iis-7.md) | Source: Robert McMurray, Microsoft
- Applies To: IIS 7.0, IIS 7.5, IIS 8.0

The initial design of the FTP protocol did not allow for secure communications, so one of the challenges that FTP administrators often ask is: "How do I secure my FTP sessions?" These questions are usually based on one of two conditions: 1) administrators want to secure their usernames and passwords, or 2) administrators want to keep their data secure. With FTP 7 and later, administrators can configure the FTP service to use FTP over SSL to secure the data channel, the control channel, or just their user credentials. This walkthrough/tutorial will walk you through the steps to configure FTP over SSL.

## CONFIGURING THE FTP SERVICE TO USE IIS MANAGERS ACCOUNTS FOR FTP ACCESS

- [Video](http://dotnetslackers.com/articles/iis/IIS-FTP-and-IIS-Manager-Users-Week-45.aspx) | Source: Scott Forsyth, DotNetSlackers.com
- Applies To: IIS 7.0, IIS 7.5, IIS 8.0

IIS 7 introduced a new type of user account, which are called IIS Manager Accounts. Administrators can delegate management tasks to these user accounts, which allows remote users who are not administrators on the web server to manage their site's settings. Beginning with FTP 7, you can also use these IIS Manager Accounts for FTP access; this provides an extra level of security for your server, because these accounts are not mapped to server or Active Directory accounts. This video walks you through setting up the FTP service to use IIS Managers Accounts for FTP access.

## CONFIGURING THE FTP SERVICE TO USE .NET MEMBERSHIP ACCOUNTS FOR FTP ACCESS

- [Article](configuring-ftp-with-net-membership-authentication-in-iis-7.md) | Source: Robert McMurray, Microsoft
- Applies To: IIS 7.0, IIS 7.5, IIS 8.0

ASP.NET provides a user store that is separate from Active Directory or local server accounts through .NET Membership and Role providers. Beginning with FTP 7, server administrators can take advantage of this architecture to provide FTP access to .NET Membership accounts. These membership accounts are not stored on the local server or in Active Directory, so this provides an extra level of security for your FTP server. This walkthrough will illustrate the steps that are required to set up the FTP service to use .NET Membership for FTP access.

## DENYING FTP ACCESS TO BRUTE-FORCE ATTACKERS

- [Article](../../get-started/whats-new-in-iis-8/iis-80-ftp-logon-attempt-restrictions.md) | Source: Robert McMurray, Microsoft
- Applies To: IIS 8.0

One of the most-widely-used areas of attack for the FTP service is brute-force attacks by attempting to guess the passwords for well-known Windows accounts. For example, the "administrator" account exists on most web servers, so hackers can automate brute-force attacks in an attempt to guess the password for that account. To help reduce this surface area of attack, FTP 8 introduced FTP Logon Attempt Restrictions, which allows administrators to configure the number of failed logon attempts before a particular client is temporarily blocked. This offers administrators an additional advantage over account lockout policies in Active Directory, because the attacker is blocked while the physical account is not locked out and the valid user can still access your system. This walkthrough will show you how to configure the FTP service to deter brute-force attackers from accessing your system.

## CREATING A CUSTOM FTP AUTHENTICATION PROVIDER

- [Code Sample](../../develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-using-an-xml-database.md) | Source: Robert McMurray, Microsoft
- Applies To: IIS 7.5, IIS 8.0

Beginning with IIS 7.5, the FTP service in IIS allows developers to create their own authentication providers, thereby eliminating the need to use Active Directory or Windows local accounts to provide access for FTP users. This code sample illustrates how to create a custom FTP authentication provider that uses an XML file that defines the list of users and roles which administrators can use to provide FTP access.