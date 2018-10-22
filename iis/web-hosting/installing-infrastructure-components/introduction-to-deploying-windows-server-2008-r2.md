---
title: "Introduction to Deploying Windows Server 2008 R2 | Microsoft Docs"
author: walterov
description: "This article provides a road map for the various Windows Server ® 2008 deployment technologies. There are three main technologies available: Windows Deployme..."
ms.author: iiscontent
manager: soshir
ms.date: 02/12/2008
ms.topic: article
ms.assetid: 153f2926-e078-4aa4-96a7-cb6f70bdb156
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/installing-infrastructure-components/introduction-to-deploying-windows-server-2008-r2
msc.type: authoredcontent
---
Introduction to Deploying Windows Server 2008 R2
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

This article provides a road map for the various Windows Server® 2008 deployment technologies. There are three main technologies available:

- Windows Deployment Services role (WDS) - Microsoft Deployment Solutions Accelerator (MD) - System Center Configuration Manager (SCCM)

These components provide a complete deployment upgrade path starting with WDS, going through MD, and culminating with SCCM. Each provides a superset of features with respect to its predecessor.

Hosting Guidance provides PowerShell Scripts samples and guidance to set up key server roles such as Web and File Server for particular Hosting scenarios (initially for Shared Hosting; more to come on this subject). After you have executed the scripts to build the server machine, proceed with WDS to continue your deployment.

Assuming that the goal is to deploy a particular Server Role to a large set of available machines, the simplest approach consists of three steps:

1. Prepare an initial server with the OS and the software configuration required for the Server Role. - Use WDS to create an image of the server. - Use WDS to deploy such image onto the target machines.

However, there will be cases in which this simple approach is not enough. For example, in some organizations there are multiple data centers situated in different environments, each with specific settings to satisfy locale/geography, security, network, and/or functionality requirements for which a common base image of particular Server Roles is desired to enforce organizational policies, but is not sufficient for full deployment due to the complexity of the post deployment configuration steps.

In such cases, it is recommended to use the Microsoft Deployment Solutions Accelerator (MD) or the more complete System Center Configuration Manager (SCCM). A first step would be to evaluate using MD, since:

- It provides an end-to-end solution to deployment and configuration with minimal user intervention (also referred to as "light touch") which is sufficient for most hosting scenarios. - It is available for download, providing rich documentation and C# source code to aid integration into custom systems. - The user interface, process, and resources are consistent with the more sophisticated SCCM. Moreover, all the deployment data created through MD can be easily upgraded and used within SCCM, constituting an ideal upgrade path. - It provides a [detailed guide](https://technet.microsoft.com/en-us/library/bb960434.aspx) based on the Microsoft Solutions Framework for Planning, Preparing, Testing, and Deploying.

<a id="DeploymentProject"></a>

## Deployment Project

Assuming that WDS is appropriate for your needs, the general approach to manage a deployment project includes:

1. **Planning:** Decide what the deployment scenario is and how you will accomplish the deployment.  
- **Preparing:** Prepare the environment, setup the WDS machine and required components, build the Server Role machine to make an image of, run the configuration scripts, and create the image to be used by WDS.  
- **Testing:** It is strongly recommended to test your image in a lab and run the appropriate tests on the deployed machines to ensure that results are as expected.  
- **Deploying:** Use WDS to execute the network deployment across the target set of servers.

This section of the Hosting Guidance provides details for each of these project phases. Notice that they are consistent with those found within the MD documentation. If you are working on a large deployment (multiple environments and/or large deployment team), review the [MD guide](https://technet.microsoft.com/en-us/library/bb960434.aspx "Microsoft Deployment Guide")

<a id="UsingWDS"></a>

## Using WDS

Windows Deployment Services is the updated and redesigned version of Remote Installation Services (RIS). Windows Deployment Services assists with the rapid adoption and deployment of Microsoft Windows operating systems. Use it to set up new computers through a network-based installation without having to be physically present at each computer and without having to install directly from CD or DVD media.

The Windows Deployment Services components work together to enable you to deploy Windows images, including Windows Vista® and Windows Server 2008. The components of Windows Deployment Services are organized into the following three categories:

- **Server components:** These components include a Pre-Boot Execution Environment (PXE) server and a Trivial File Transfer Protocol (TFTP) server for booting a client from the network. Also included is a shared folder and image repository that contains boot images, install images, and files that you need. There is also a networking layer, a multi-cast component, and a diagnostics component. - **Client components:** These components include a graphical user interface (GUI) that runs within the Windows Pre-Installation Environment (Windows PE). When a user selects an operating system image, the client components communicate with the server components to install the image. - **Management components:** These components are a set of tools that you use to manage the server, the operating system images, and the client computer accounts.

Read the [WDS Guide](http://technet2.microsoft.com/windowsserver2008/en/library/7d837d88-6d8e-420c-b68f-a5b4baeb52481033.mspx?mfr=true "WDS Guide") for in depth coverage on the functionality of the complete installation, or the [Windows Deployment Services Role Step-by-Step Guide](http://technet2.microsoft.com/windowsserver2008/en/library/7d837d88-6d8e-420c-b68f-a5b4baeb52481033.mspx?mfr=true) for a quick set of deployment instructions.

<a id="UsingMD"></a>

## Using MD

Microsoft Deployment unifies the tools and processes required for server and desktop deployment into a common deployment console and collection of guidance documentation. This fourth generation deployment accelerator adds integration with recently released Microsoft deployment technologies (such as WDS) to create a single path for image creation and automated installation.

Microsoft Deployment tools and end-to-end guidance:

- Reduce deployment time
- Standardize desktop and server images
- Limit service disruptions
- Reduce post-deployment support costs
- Improve security and ongoing configuration management

MD is the recommended process and tool set to automate server and desktop deployment. You can [download the Microsoft Deployment](https://www.microsoft.com/downloads/details.aspx?familyid=3bd8561f-77ac-4400-a0c1-fe871c461a89&amp;displaylang=en&amp;tm) complete solution and corresponding source code at no cost.

The following [video](https://mediadl.microsoft.com/mediadl/IISNET/Media/HDA20-IIS/Deployment%20Overview.wmv "Deployment Overview") provides an overview of Microsoft Deployment with key features demostrations.

<a id="UsingSCCM"></a>

## Using SCCM

System Center Configuration Manager 2007 provides adaptive, policy-based automation to manage the full deployment, update and extension life cycle for servers, clients and handheld devices, across physical, virtual, distributed, or mobile systems. It packs the most complete feature set for deployment.

- <a id="ctl00_mainContentContainer_ctl01"></a>[Download the 120-day trial software today](https://technet.microsoft.com/en-us/configmgr/bb736730.aspx)- [Listen to audiocasts](https://technet.microsoft.com/en-us/configmgr/bb727202.aspx)