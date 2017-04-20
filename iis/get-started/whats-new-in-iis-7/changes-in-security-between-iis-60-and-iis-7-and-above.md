---
title: "Changes in Security Between IIS 6.0 and IIS 7 and Above | Microsoft Docs"
author: rick-anderson
description: "IIS 7 and above bring many new security improvements from IIS 6.0. This document overviews these improvements with respect to Authentication, Authorization,..."
ms.author: iiscontent
manager: soshir
ms.date: 11/16/2007
ms.topic: article
ms.assetid: ec979d77-5a26-4b9b-9da2-ab445e6bdf73
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/whats-new-in-iis-7/changes-in-security-between-iis-60-and-iis-7-and-above
msc.type: authoredcontent
---
Changes in Security Between IIS 6.0 and IIS 7 and Above
====================
by IIS Team

## Introduction

IIS 7 and above bring many new security improvements from IIS 6.0. This document overviews these improvements with respect to Authentication, Authorization, SSL, Web Service Extension Restriction List and IP restrictions.

<a id="Authentication"></a>

## Authentication

For ASP.NET application developers there had been, before IIS 7, two authentication models you needed to program against. These models were the IIS and ASP.NET pipelines. First, IIS would examine the request and perform its authentication routines and then afterwards pass it to ASP.NET so it could do a similar task.

In IIS 7 and above we have unified these two models to produce a new robust pipeline that does the best that both older models did. IIS still supports all the old authentication protocols but also now supports forms authentication which can protect against all content types and does not rely on Windows accounts. In addition to supporting all the old features you have come to know and love we have also enhanced some of them such as the Anonymous Authentication feature.

These changes will be discussed in the upcoming sections.

### Anonymous Authentication Changes

In IIS 7 and above, Anonymous Authentication behaves in a similar manner as it had in previous versions with only one change - the ability to run under the content of the worker process identity. Each application pool is configured to run under the content of a user account and the default value for this account is NETWORKSERVICE.

It was very common for ASP.NET applications to turn off impersonation and run under the application pool identity by using the following code in their web.config files:


[!code-xml[Main](changes-in-security-between-iis-60-and-iis-7-and-above/samples/sample1.xml)]


There are several scenarios where applications would need to run under the context of the process identity:


- The process identity is a low privilege account and administrators have locked down their systems for that account
- The process identity has been granted network access and is used to access back end resources such as databases


As part of the redesign for IIS 7 and above, we wanted to make this scenario secure and easy to do. To implement this scenario, in IIS requires:

- Installing and enabling the Anonymous Authentication module
- Setting the anonymous username and password to an empty string

To do this, modify your configuration for anonymous authentication so it appears as follows:

[!code-xml[Main](changes-in-security-between-iis-60-and-iis-7-and-above/samples/sample2.xml)]

This configuration will tell IIS to run always under the context of the worker process identity.

By default, the anonymous authentication identity in IIS 7.0 and above is the IUSR account. This account is a low privilege identity with minimal rights and privileges. To learn more about the new built-in account refer to the [Understanding the Built-in Account and Group in IIS 7 and Above](../planning-for-security/understanding-built-in-user-and-group-accounts-in-iis.md) article.

### Passport Changes

Support for legacy Passport authentication was built into IIS 5/6 and Windows Server 2000 and 2003. Passport support in IIS 5 &amp; 6 was exposed as a checkbox in the Directory Security tab in the IIS service manager for "Enable Passport Authentication". This checkbox provided IIS the ability to send legacy Tweener protocol challenges. In addition to this, it was still necessary to register the Web site with the Passport service provisioning portal, obtain an encryption key, and configure the legacy Passport Manager on the server before the IIS integration would be functional.

In Windows Server 2008 and beyond, the legacy Passport binaries and integration with IIS were removed.

The Passport service has since changed into Windows Live ID. While the new Live ID service certainly grew out of the legacy Passport service, there are major changes. One of the biggest changes is how a partner site integrates with Live ID. You can add Live ID authentication by using the publicly available [Windows Live ID Web Authentication SDK](https://www.microsoft.com/downloads/details.aspx?FamilyId=E565FC92-D5F6-4F5F-8713-4DD1C90DE19F&amp;displaylang=en). While the Windows Live ID service also supports identity Federation and ADFS, that capability is new functionality for specific cases, and is not a replacement for "Passport".

### Forms authentication

Forms authentication has been part of ASP.NET and allows both Windows and non Windows identities to authenticate themselves and get a user object that applications can later use. IIS 7 and above now fully support forms authentication and can be configured to protect access to all content types.

<a id="How"></a>

## How IIS 7 and Above Determine the Authenticated Identity

In IIS 7 and above, the authentication rules are processed by the core engine in a similar manner as they were in previous versions of IIS with only some minor changes. To better understand the processing order, here are the rules based on the order IIS evaluates them:

- First, IIS determines if a username and password has been configured at the virtual directory. If a set of credentials have been defined, those credentials will be used. For pre-IIS 7 administrators, these credentials are the UNC credentials
- If no credentials are configured at the virtual directory then IIS will use the credentials provided during authentication. These credentials can belong to the identity that is configured for anonymous authentication or the credentials provided by the user during the authentication handshake when Basic, Digest, or Windows authentication is enabled
- If no authenticated user was established (for example, forms authentication is enabled) we will determine if the process identity should be used
- If we do not have an identity at this point, IIS will return an access denied

<a id="Authorization"></a>

## Authorization

### AzMan Support

In IIS 6.0, we introduced a new authorization model based on AZMan rules. In IIS 7 and above we have deprecated this feature in favor of a new model that is very similar to the ASP.NET authorization model (see URL authorization topic below).

### URL Authorization

In IIS 7 and above, you have two authorization solutions. The first is to use the ASP.NET authorization model. This method requires defining all your authorization rules in the &lt;system.web&gt; configuration and requires zero changes for applications that already have rules written for ASP.NET. The second model is to move to the new IIS authorization architecture. This model is very similar to ASP.NET's model with some minor changes:

- Rules are not order dependent
- Deny rules are sorted to the top of the list
- Rules are processed in the opposite manner of ASP.NET, mainly in the order: grandparent, parent, then child; ASP.NET authorization processes rules in the opposite order:child, parent, then grandparent

To better understand the differences between the ASP.NET authorization model, and the IIS authorization model, let's first look at an ASP.NET authorization configuration:

[!code-xml[Main](changes-in-security-between-iis-60-and-iis-7-and-above/samples/sample3.xml)]

In this example we are allowing Vik\_Malhotra but we are denying everyone else. In IIS, the configuration is very similar:

[!code-xml[Main](changes-in-security-between-iis-60-and-iis-7-and-above/samples/sample4.xml)]

The reason for the syntax change was that we wanted to make sure application developers knew these two models are in fact different, but at the same time they could move rules from one implementation to the other with minimal effort.

<a id="SSL"></a>

## SSL

In IIS 6.0, IIS had stored SSL related information in the metabase and had managed a large part of the SSL negotiation process in conjunction with HTTP.SYS. In IIS 7 and above, we have moved most of this configuration into HTTP.SYS's store.

To illustrate how each of the IIS 6.0 configuration settings are carried over into the IIS 7 and above configuration (or HTTP.SYS configuration), the following chart has been constructed below.


| IIS 6.0 Metabase configuration | Description of property | IIS 7.0 and above Architecture |
| --- | --- | --- |
| **AccessSSLFlags** | AccessSSLFlags is bitmask of AccessSSL AccessSSL128 AccessSSLNegotiateCert AccessSSLRequireCert AccessSSLMapCert 0 value means *no SSL.* | Property still supported in IIS 7.0 and above configuration in the &lt;access&gt; section |
| **CertCheckMode** | Enable or disable CRL (certificate revocation list) checking. | This value will now be stored in http.sys in the PHTTP\_SERVICE\_CONFIG\_SSL\_PARAM object. |
| **RevocationFreshnessTime** | If the RevocationFreshnessTime property is set to 1 (true), then the certificate revocation list (CRL) on the certificate client is updated by the CRL from the remote location, even if the CRL that is cached on the certificate client is valid. The default timeout interval is one day unless you use the RevocationURLRetrievalTimeout to specify a different timeout interval (in minutes). | This value will now be stored in http.sys in the PHTTP\_SERVICE\_CONFIG\_SSL\_PARAM object. |
| **SecureBindings** | The SecureBindings property specifies a string that is used by IIS to determine which secure network endpoints are used by the server instance. | This property is still supported in IIS 7.0 and above configuration under the &lt;binding&gt; section for &lt;sites&gt;. The protocol used needs to by "https". |
| **SSLAlwaysNegoClientCert** | The SSLAlwaysNegoClientCert property controls SSL client connection negotiations. If this property is set to true, any time SSL connections are negotiated, the server will immediately negotiate a client certificate, preventing an expensive renegotiation. Setting SSLAlwaysNegoClientCert also helps eliminate client certificate renegotiation deadlocks, which may occur when a client is blocked on sending a large request body when a renegotiation request is received. | This value will now be stored in http.sys in the PHTTP\_SERVICE\_CONFIG\_SSL\_PARAM object. |
| **SSLCertHash** | The SSLCertHash property is used to store the hash of the SSL certificate being used. | This value will now be stored in http.sys in the PHTTP\_SERVICE\_CONFIG\_SSL\_PARAM object. |
| **SslCtlIdentifier** | The SslCtlIdentifier property contains a unique value that identifies a specific certificate trust list (CTL). It must be used with SslCtlStoreName to accurately reference a CTL. | This value will now be stored in http.sys in the PHTTP\_SERVICE\_CONFIG\_SSL\_PARAM object. |
| **SslCtlStoreName** | The SslCtlStoreName property contains the name of the CryptoAPI store that contains certificate trust lists (CTL). It must be used with SslCtlIdentifier to accurately reference a CTL. | This value will now be stored in http.sys in the PHTTP\_SERVICE\_CONFIG\_SSL\_PARAM object. |
| **SSLStoreName** | The SSLStoreName property is used to store the name of the store where the key pair of the certificate resides. | This value will now be stored in http.sys in the PHTTP\_SERVICE\_CONFIG\_SSL\_PARAM object. |
| **SslUseDsMapper** | The SslUseDsMapper property specifies whether IIS is to use the Windows Directory Service certificate mapper or IIS certificate mapper. If SSLUseDSMapper is set to false, IIS uses the IIS certificate mapper. | This value will now be stored in http.sys in the PHTTP\_SERVICE\_CONFIG\_SSL\_PARAM object. |


For more information on the HTTP.SYS PHTTP\_SERVICE\_CONFIG\_SSL\_PARAM object refer to the following [documentation](https://msdn.microsoft.com/en-us/library/aa364647.aspx).

All these changes are handled transparently under the covers so as a server Administrator there is nothing special you need to do--IIS will do everything for you. If you have applications that are accessing the old IIS 6.0 properties now located in HTTP.SYS's configuration store, our ABO mapper interface will ensure that correct values are read/written so your applications will not fail, but instead will continue to work.

<a id="WebService"></a>

## Web Service Extension Restriction List

In IIS 7 and above this feature has been slightly modified so that its name now reads **"isapiCgiRestrictionList"** -- but otherwise it acts and behaves as it had in IIS 6.0.

The reason for this change was to stress its true usage. In IIS 6.0 this feature was added to ensure rogue ISAPI or CGI binaries could not copied to your IIS servers and then be allowed to execute. With the redesign for IIS 7 and above we have two supported models:

- The "classic" ISAPI pipeline
- The new Integrated pipeline

If we are in the "classic" ISAPI pipeline, everything will continue to work as you would expected it to when using IIS 6.0. To illustrate this point, consider how ASP.NET works when running in ISAPI mode. First you will need to add the full path of the aspnet\_isapi.dll and set it allowed="true" as shown below:

[!code-xml[Main](changes-in-security-between-iis-60-and-iis-7-and-above/samples/sample5.xml)]

Now and only now will this code (aspnet\_isapi.dll) be allowed to execute. If we switched our pipeline mode to integrated and changed allowed="false" the ASP.NET code will still be executed.

Why? The reason is the isapiCgiRestrictionList only applies to ISAPI and CGI code. In integrated mode, ASP.NET is now part of the new architecture and as a result is not affected by the isapiCgiRestrictionList. If you do not want to run ASP.NET code in the new integrated pipeline you will simply need to remove the managedEngine from the modules list.

<a id="IP"></a>

## IP Restrictions

IP Restrictions works in the exact same manner as it had in the past except we now support a new property called "allowUnlisted". This property was added to make it easier to configure security policies for your system at a global level. For example, if your policy required only certain IP addresses to be allowed but to reject all others that are not listed was not very easy to do in the past. Similarly, rejecting only a given set of IP addresses and allowing all that are not listed can easily be done now. As a server administrator you can set a global policy and then lock this value so it cannot be changed on your server by application or site administrators.

To illustrate, consider a development machine you only want users to access locally. The following configuration implements that policy by setting the allowUnlisted="false" and then explicitly only allows localhost (127.0.0.1) access:

[!code-xml[Main](changes-in-security-between-iis-60-and-iis-7-and-above/samples/sample6.xml)]