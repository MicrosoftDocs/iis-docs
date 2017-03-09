---
title: "Planning the Deployment | Microsoft Docs"
author: walterov
description: "The primary focus in this phase is on selecting the appropriate deployment scenarios and methods, ensuring that the required infrastructure exists, determini..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/30/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/installing-infrastructure-components/planning-the-deployment
msc.type: authoredcontent
---
Planning the Deployment
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

The primary focus in this phase is on selecting the appropriate deployment scenarios and methods, ensuring that the required infrastructure exists, determining the appropriate configuration settings and/or scripts, the monitoring plan, and training team members. Table 1 shows the high-level steps in the Planning Phase.

<a id="Checklist"></a>

## Checklist

**Table 1. Planning Checklist**

| **High-level steps in the deployment Planning Phase** |
| --- |
| 1 | **Select the appropriate deployment scenarios.** The environment typically requires more than one deployment scenario. You would need to determine which combination of deployment scenarios that apply: - New Computer - Upgrade Computer - Refresh Computer - Replace Computer |
| 2 | **Select the deployment methods.** Determine which computers in the environment can be migrated to the new operating system using which method WDS, MD, or SCCM. The level of automation is required as well: PowerShell Scripts in this Hosting Guidance, Light Touch Installation (LTI), or Zero Touch Installation (ZTI) are provided by MD and SCCM. The environment can use one or several of these methods. |
| 3 | **Ensure that the required infrastructure****exists.** Ensure that the appropriate infrastructure exists for the tools you are using before beginning deployment. The requirements for WDS, MD, or SCCM are different. See below for details. |
| 4 | **Determine the appropriate processing rules. Only needed if you are using MD or SCCM** Before using ZTI or LTI to deploy the operating system, configure the processing rules. The processing rules help determine which operating system images are deployed and their configuration settings. |
| 5 | **Determine the monitoring plan.** As you are deploying the operating system in the test and production environments, monitor the progress of the deployment. This is particularly important in complex deployments that require SCCM. |
| 6 | **Train the team members.** Before beginning deployment in the test and production environments, ensure that all team members are properly trained. This helps the team deploy, manage, operate, troubleshoot, and support target computers throughout the entire deployment process. |

<a id="SelectScenarios"></a>

## Select Deployment Scenarios

As the first step in the Planning Phase, select the deployment scenarios that are appropriate for the environment. These are: new, upgrade, refresh, or replace computer. Table 2 lists the deployment scenarios and provides a brief description of each.

**Table 2. Deployment Scenarios and Descriptions**

| Scenario | Description | User state migrated | Uses existing target computer | File system preserved |
| --- | --- | --- | --- | --- |
| New Computer | A new installation of Windows is deployed to a new computer. This scenario assumes that there is no user data or profile to preserve. | No | No | No |
| Upgrade Computer | The current Windows operating system on the target computer is upgraded to the deployed operating system. The existing user state migration data, user profile, and applications are retained (as supported by the deployed operating system). | Yes | Yes | Yes |
| Refresh Computer | A computer currently running a supported Windows operating system is refreshed. This scenario includes computers that must be re-imaged for image standardization or to address a problem. This scenario assumes that the team is preserving the existing user state data on the computer. | Yes | Yes | No |
| Replace Computer | A computer currently running a supported Windows operating system is replaced with another computer. The existing user state migration data is saved from the original computer. Then, a new installation of Windows is deployed to a new computer. Finally, the user state data is restored to the new computer. | Yes | No | No |

<a id="SelectTools"></a>

## Select Deployment Tools and Methods

Based on the existing environment and combination of scenarios, you can decide which tools and Methods are more appropriate. For example:

- When installing Windows in new computers, use WDS and the scripts provided in this guide.
- When refreshing or replacing a computer, use a combination of PowerShell scripts to backup the user data, use WDS to re-image the machine, and finally, scripts again to restore the user data.
- When upgrading a large set of computers preserving user data and file systems, evaluate using MD or SCCM. When using MD or SCCM, you can use a combination of the LTI and ZTI methods to deploy operating systems to the target computers. Microsoft Deployment, LTI and ZTI use the same common set of scripts and configuration files (such as CustomSettings.ini) for deploying the operating system. However, there are instances in which one method of deployment might be more advantageous. (For more information [download and install MD](https://www.microsoft.com/downloads/details.aspx?familyid=3bd8561f-77ac-4400-a0c1-fe871c461a89&amp;displaylang=en&amp;tm) and read the *Preparing for LTI Tools* document.)

    1. **Deploy Operating Systems Using LTI**. LTI requires the MD Toolkit and minimal infrastructure to operate. The team can deploy operating systems over the network using a shared folder, or locally using removable storage (such as a CD, DVD, USB flash drive [UFD], or other device). You can initiate the deployment process automatically (using Windows Deployment Services) or manually. Initially configure LTI using Deployment Workbench, and then further customize CustomSettings.ini for the specific environment. In LTI deployment, the team provides configuration settings for groups of computers. The configuration settings for each individual computer are usually provided manually during the deployment process. As a result, customizing LTI usually requires less effort than customizing ZTI.
    2. **Deploy Operating Systems Using ZTI**. ZTI requires System Center Configuration Manager or Systems Management Server 2003 with SP2, and the SMS 2003 OSD Feature Pack. The team deploys operating systems from System Center Configuration Manager or Systems Management Server 2003 distribution points. The installation process can be initiated by System Center Configuration Manager, Systems Management Server 2003, or Windows Deployment Services. The ZTI deployment process is always initiated automatically. Like LTI, the team initially configures ZTI using Deployment Workbench, and then further customizes CustomSettings.ini for their environment. In ZTI deployment, the team must provide all configuration settings for each target computer being migrated using ZTI. By definition, there is no manual configuration in ZTI. As a result, customizing ZTI usually requires more effort than customizing LTI.

<a id="Understand"></a>

## Understand the Benefits of WDS

Windows Deployment Services provides many benefits. Specifically, it:

- Reduces the complexity of deployments and the costs associated with inefficient manual installation processes.
- Enables you to do network-based installations of Windows operating systems, including Windows Vista and Windows Server 2008.
- Deploys Windows images to computers without operating systems.
- Supports mixed environments that include Windows Vista, Windows Server 2008, Windows XP, and Windows Server 2003.
- Provides an end-to-end solution for deploying Windows operating systems to client computers and servers.
- Uses standard Windows Server 2008 setup technologies, including Windows PE, .wim files, and image-based setup.
- Makes use of multicast technology to enable you to do multiple deployments concurrently.

<a id="ContrastLTI"></a>

## Contrast LTI(MD Toolkit)and ZTI(SCCM)

Table 3 provides a contrasting view of the use of LTI and ZTI in the deployment.

**Table 3. Contrast of LTI (MD Toolkit) and ZTI (SCCM) Deployments**

| **LTI deployment** | **ZTI deployment** |
| --- | --- |
| Provides configuration settings that are common to a group of target computers. | Provides all necessary configuration settings for each target computer. |
| Requires less upfront configuration time. | Requires more upfront configuration time. |
| Can be used with slow-speed connections or in instances where no network connectivity exists. | Requires a high-speed, persistent connection. |
| Requires little or no infrastructure to support deployment. | Requires an infrastructure sufficient to deploy operating system images using either the SMS 2003 OSD Feature Pack or System Center Configuration Manager. |
| Supports deployment over the network or locally. | Supports only network deployments. |
| Target computers are not required to be managed using either System Center Configuration Manager or Systems Management Server 2003 (or other software-management tools). | Target computers must be managed using either System Center Configuration Manager or Systems Management Server 2003. |
| Supports security policies where automatic software installation is prohibited. | Supports only security where automatic software installation is allowed. |
| Supports deployment to target computers isolated by firewalls. | Requires Remote Procedure Call (RPC) communication with target computers (and so usually requires too many ports to be opened through firewalls). |
| Supports Upgrade Computer deployment scenarios. | Upgrade Computer scenarios are not supported. |

## Ensure That the Required Infrastructure Exists

For most production environments, the majority of services required for deployment already exists. However, you must verify that all of the required components are in place before continuing the deployment process. Before installing WDS you need to review the [prerequisites for installing Windows Deployment Services](http://technet2.microsoft.com/WindowsServer2008/en/library/32bf3c54-f0e4-4867-9452-c0d472f013151033.mspx#BKMK_Pre "WDS Prerequisites").

### Prerequisites for Installing Windows Deployment Services


The following are requirements for installing this role, depending on if you install Deployment Server or Transport Server.

> [!NOTE]
> The Windows Deployment Services server service is not cluster-aware and should not be run on a Microsoft Windows Cluster Server.

| **Deployment Server** | **Transport Server** |
| --- | --- |
| | **Active Directory Domain Services**. A Windows Deployment Services server must be either a member of an Active Directory Domain Services (AD DS) domain or a domain controller for an AD DS domain. The AD DS domain and forest versions are irrelevant; all domain and forest configurations support Windows Deployment Services. | | --- | | **DHCP**. You must have a working Dynamic Host Configuration Protocol (DHCP) server with an active scope on the network because Windows Deployment Services uses Pre-Boot Execution Environment (PXE), which relies on DHCP for IP addressing. | | **DNS**. You must have a working Domain Name System (DNS) server on the network to run Windows Deployment Services. | | **NTFS volume**. The server running Windows Deployment Services requires an NTFS file system volume for the image store. | | **Credentials**. To install the role, you must be a member of the Local Administrators group on the Windows Deployment Services server. To start the Windows Deployment Services client, you must be a member of the Domain Users group. | | There are no requirements for installing Transport Server. |

If you are planning to use Microsoft Deployment, see the detailed listing of required infrastructure:

- Microsoft Deployment and LTI deployment: See "[System Requirements](https://technet.microsoft.com/en-us/library/bb891793.aspx)," in the *Getting Started Guide.*
- ZTI: See "Ensure that the Required Infrastructure Exists for ZTI ," in *Infrastructure Remediation Feature Team Guide.*

<a id="DetermineRules"></a>

## Determine the Appropriate Processing Rules (MD and SCCM only)

This is important if you are using MD Toolkit or SCCM. The ZTI and LTI deployment use processing rules that determine the steps and configuration parameters during the process of deploying the images to target computers. These settings are stored and managed in CustomSettings.ini.

[Download and install MD](https://www.microsoft.com/downloads/details.aspx?familyid=3bd8561f-77ac-4400-a0c1-fe871c461a89&amp;displaylang=en&amp;tm) to find more information about:

- Determining the processing rules required for minimal functionality in LTI: See "Configure the Appropriate Processing Rules," in *Preparing for LTI Tools.*
- Determining the processing rules required for minimal functionality in ZTI: See "Configuring the Appropriate Processing Rules," in *Preparing for Microsoft Systems Management Server 2003* or *Preparing for Microsoft Systems Center Configuration Manager 2007.*
- Extending functionality in LTI and ZTI: See *Deployment Customization Guide.*
- Examples for configuring the processing rules in LTI and ZTI: See the *Deployment Customization Desktop Samples Guide.*

<a id="DeterminePlan"></a>

## Determine the Monitoring Plan

This is particularly important in complex deployments that require SCCM. The ZTI Management Pack for System Center Operations Manager monitors the deployment of operating system images to the target computers and collects data. You can also use it to monitor the ZTI and LTI deployment processes. Using Microsoft System Center Operations Manager 2007 Reporting Services, you can generate reports about the deployment process. For more information on the ZTI Management Pack, see the Microsoft Deployment document, *Zero Touch Installation Management Pack.*

<a id="TrainTeam"></a>

## Train Team Members

For complex deployments that require MD Toolkit and/or SCCM, ensure that all team members are properly trained to deploy, manage, operate, troubleshoot, and support the deployment process and the migrated computers. Customize the training for each team.

See details at: [https://technet.microsoft.com/en-us/library/bb960436.aspx#EBAA](https://technet.microsoft.com/en-us/library/bb960436.aspx#EBAA)