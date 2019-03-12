---
title: "Active Directory DS Forest"
author: walterov
description: "A Windows Deployment Services server must be either a member of an Active Directory Domain Services domain or a domain controller for an Active Directory Dom..."
ms.date: 12/02/2007
ms.assetid: efdf12f5-51e2-42c0-bf1e-647c8fa19ff0
msc.legacyurl: /learn/web-hosting/installing-infrastructure-components/active-directory-ds-forest
msc.type: authoredcontent
---
Active Directory DS Forest
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

A Windows Deployment Services server must be either a member of an Active Directory Domain Services domain or a domain controller for an Active Directory Domain Services domain. The Active Directory Domain Services domain and forest versions are irrelevant; all domain and forest configurations support Windows Deployment Services.

## Installation Methods

When installing Active Directory Domain Services Forest on a machine that already is running Windows Server® 2008 or Windows Server 2008 R2, use any of the following methods:

- Installing a New Windows Server 2008 Forest by Using the Windows Interface
- Installing a New Windows Server 2008 Forest by Using the Command Line
- Installing a New Windows Server 2008 Forest by Using an Answer File

For detailed Step-by-step guidance on installing Active Directory for all the Directory Services (Forest, Child Domain, and Domain Tree), refer to "Steps for Installing AD DS in all configurations, including instructions for installing it on a full installation or a Server Core installation of Windows Server 2008 R2. It provides the Windows interface, command-line, and answer file methods for performing installations.

The process for performing an unattended installation of AD DS is the same for a server that is running a full installation of Windows Server 2008 R2 or a Server Core installation. The unattended method of installation is required for a Server Core installation.