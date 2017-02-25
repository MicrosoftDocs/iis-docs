---
title: "Active Directory DS Forest | Microsoft Docs"
author: rick-anderson
description: "A Windows Deployment Services server must be either a member of an Active Directory Domain Services domain or a domain controller for an Active Directory Dom..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/02/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/installing-infrastructure-components/active-directory-ds-forest
msc.type: authoredcontent
---
Active Directory DS Forest
====================
by Walter Oliver

## Introduction

A Windows Deployment Services server must be either a member of an Active Directory Domain Services domain or a domain controller for an Active Directory Domain Services domain. The Active Directory Domain Services domain and forest versions are irrelevant; all domain and forest configurations support Windows Deployment Services.

## Installation Methods

When installing Active Directory Domain Services Forest on a machine that already is running Windows Server® 2008 or Windows Server 2008 R2, use any of the following methods:

- [Installing a New Windows Server 2008 Forest by Using the Windows Interface](http://technet2.microsoft.com/WindowsServer2008/en/library/e398ac0c-0e73-494f-954c-f98fb04624c91033.mspx)
- [Installing a New Windows Server 2008 Forest by Using the Command Line](http://technet2.microsoft.com/WindowsServer2008/en/library/a68eae0d-ec73-4792-9e51-65167c76a4841033.mspx)
- [Installing a New Windows Server 2008 Forest by Using an Answer File](http://technet2.microsoft.com/WindowsServer2008/en/library/020fb9f5-3597-4adc-a5c3-63e94fc78e891033.mspx)

For detailed Step-by-step guidance on installing Active Directory for all the Directory Services (Forest, Child Domain, and Domain Tree), refer to "[Steps for Installing AD DS](http://technet2.microsoft.com/windowsserver2008/en/library/f349e1e7-c3ce-4850-9e50-d8886c866b521033.mspx?mfr=true)". This guide provides step-by-step instructions for installing Active Directory Domain Services (AD DS) in all configurations, including instructions for installing it on a full installation or a Server Core installation of Windows Server 2008 R2. It provides the Windows interface, command-line, and answer file methods for performing installations.

The process for performing an unattended installation of AD DS is the same for a server that is running a full installation of Windows Server 2008 R2 or a Server Core installation. The unattended method of installation is required for a Server Core installation.