---
title: New Features Introduced in IIS 10.0 Version 1709
description: Describes the new features and enhancements to existing features that are introduced in version 1709 of IIS 10.0.
ms.date: 10/24/2017
msc.type: authoredcontent
---
# New Features Introduced in IIS 10.0 Version 1709

IIS 10.0 Version 1709 is the latest version of Internet Information Services (IIS) which shipped with Windows 10 Fall Creators Update and Windows Server 2016 Version 1709. This article describes the new functionality of IIS and provides links to resources to learn more about these features.

## HTTP Strict Transport Security (HSTS)

HTTP Strict Transport Security (HSTS), specified in [RFC 6797](https://tools.ietf.org/html/rfc6797), allows a website to declare itself as a secure host and to inform browsers that it should be contacted only through HTTPS connections. IIS 10.0 Version 1709 introduces turn-key support for enabling HSTS without the need for error-prone URL rewrite rules.

Learn more: [HSTS](iis-10-version-1709-hsts.md)

## Container Enhancements

IIS 10.0 Version 1709 introduces improvements that allow you to run the IIS worker process (w3wp.exe) directly as well as changes to the Central Certificate Provider (CCS) that makes it more amenable for running in containers.

## IISAdministration PowerShell cmdlets

IIS 10.0 introduced the IIS Administration PowerShell cmdlets. Version 1709 ships with iterative improvements and three new cmdlets: `Get-IISSiteBinding`,`New-IISSiteBinding`, and `Remove-IISSiteBinding`. Additionally, we've done work to ship the latest version of IISAdministration on PowerShell Gallery available for use with Windows Server 2012 and above.

Learn more: [IIS Administration in the PowerShell Gallery](https://blogs.iis.net/iisteam/introducing-iisadministration-in-the-powershell-gallery)

## Logging Enhancements

In IIS 10.0 Version 1709, we introduced new server variables for the Cryptographic Protocol, the Cipher algorithm, the Key Exchange Algorithm, and the Message Authentication Algorithm. These new variables have been documented in the list of [IIS Server Variables](../../web-dev-reference/server-variables.md)

Learn more: [IIS functionality to identify weak TLS usage](https://cloudblogs.microsoft.com/microsoftsecure/2017/09/07/new-iis-functionality-to-help-identify-weak-tls-usage/)
