---
title: "Preparation Activities for WDS"
author: walterov
description: "This article provides an overview of the preparation activities needed when deploying with Windows Deployment Services. The Deployment preparations activitie..."
ms.date: 12/01/2007
ms.assetid: ca577ecb-1d82-4e47-a4f9-3d41e702d3a8
msc.legacyurl: /learn/web-hosting/installing-infrastructure-components/preparation-activities-for-wds
msc.type: authoredcontent
---
# Preparation Activities for WDS

by [Walter Oliver](https://github.com/walterov)

This article provides an overview of the preparation activities needed when deploying with Windows Deployment Services. The Deployment preparations activities may involve writing and testing the PowerShell scripts used in configuration and backup / restore tasks, preparing the servers used to back up computers, create and store operating system images, install applications, and migrate existing user data if needed. This article concentrates o using WDS and the PowerShell scripts provided in this guide.

For detailed information on the preparation activities for Microsoft Deployment [download and install MD](https://www.microsoft.com/downloads/details.aspx?familyid=3bd8561f-77ac-4400-a0c1-fe871c461a89&amp;displaylang=en&amp;tm), within the Deployment Workbench documentation find the section, "Prepare the Deployment Environment," in the *Preparing for LTI Tools* document.

<a id="Prepare"></a>

## Prepare the Deployment Environment Using WDS

1. The first step is to install Windows Deployment Services and [Infrastructure Components](index.md).
2. Proceed to [Configure the Reference Machines](../configuring-servers-in-the-windows-web-platform/index.md). You can either manually setup the reference computers with operating system, drivers, and applications or utilize the sample configuration PowerShell scripts provided in this guidance to run "as is" or modify them in accordance to your needs. See [Quick Guide for Shared Hosting Deployment](../configuring-servers-in-the-windows-web-platform/quick-guide-for-shared-hosting-deployment.md) for information on setting up a Web Server and File Server roles.
3. Once WDS and the reference machine are ready you can configure WDS, see following section for information. You should also review the "Configure Required Permissions" section below to ensure you have access to the required resources.

<a id="ConfigureServer"></a>

## Configure the Windows Deployment Services Server

After installing Windows Deployment Services (WDS), configure WDS by using the Windows Deployment Services MMC snap-in or by using WDSUTIL at the command prompt. Configuring WDS does the following to your server:

- Create a shared folder that contains the files necessary for PXE boot, the files for booting Windows PE into RAMDISK, Windows PE boot images, and install images.
- Configure the answer settings of the PXE listener to control whether and how the server services incoming client boot requests.
- If Microsoft DHCP is installed on the same physical computer as Windows Deployment Services, the configuration wizard does the following (if you configure Windows Deployment Services by using WDSUTIL, you have to manually make these changes):

  - Adds DHCP option tag 60, with the PXE client setting selected, to all DHCP scopes (as a DHCP global option). This is necessary so that a booting PXE client can be notified that there is a listening PXE server on the network.
  - Selects the Do not Listen on port 67 option. This is necessary so that booting clients can find the DHCP server on the network
- The guide also mentions the known issues when configuring WDS.

<a id="ConfigurePermissions"></a>

## Configure Required Permissions

In some cases the users performing the deployment are Domain Administrators and as such have full access to the resources in the domain. This is not necessarily the case in your marginalization, if not, you need to understand the set of permissions needed to execute the deployment process.

| **Section** | **Tasks** |
| --- | --- |
| General Permissions |  |
| Permissions for Common Management Tasks | - Add or Remove an Image Group - Add or Remove an Install Image - Disable an ImageAdd a Boot Image - Remove a Boot Image - Set Properties on an Image - Add a Prestaged Device - Approve a Pending Device - Domain Join Rights for Prestaged Devices - Convert a RIPREP image - Create a Discover or Capture image - Create or modify a Multicast Transmission |
| Permissions for Client Installations | - PXE Boot a Client - Select a Boot Image - Select an Install Image - Permissions Required to Join a Domain - ResetBootProgram Functionality - Disabling Shift+F10 and CTRL Functionalities |
| Permissions for Server Properties |  |

<a id="Creating"></a>

## Creating the Reference Machine Image

Windows Deployment Services uses two image types. Both use the Windows Image (.wim) format.

- **Boot image**: The image that you boot a client computer into to perform an operating system installation.
- **Install image**: The operating system image that you deploy to the client computer.

You can create a custom Install Image to deploy across a set of server in the data center.

### Creating Custom Install Images

To create an install image of your reference computer, create a Capture Image and use it to create the reference machine Install Image:

&lt;!--[if !supportLists]--&gt;**Capture images**. Boot images that you boot a client computer into in order to capture the operating system into a .wim file.

The following is a summary of this process:

#### To create a capture image using the Windows interface

1. In the Windows Deployment Services MMC snap-in, expand the Boot Images node.
2. Right-click the image to use it as a capture image.
3. Click Create Capture Boot Image.
4. Type a name, description, and the location to save a local copy of the file. You must specify a location in case there is a problem with the network when you deploy the capture image.
5. Continue to follow the instructions in the wizard, and when it is complete, click Finish.
6. Right-click the boot image folder.
7. Click Add Boot Image.
8. Browse and select the new capture image, and then click Next.
9. Follow the instructions in the Windows Deployment Services Capture Utility.
10. Once you have created the capture image, follow the instructions in the "Install Image" section to boot a client computer into the capture image and capture the operating system.

#### To create a capture image at a command prompt

1. Click Start, right-click Command Prompt, and then click Run as administrator.
2. Type the following where &lt;bootimage&gt; is the name of the boot image you want to use to create the capture image, and &lt;captureimage&gt; is the file path and file name of the new capture image: WDSUTIL /New-CaptureImage /Image:&lt;bootimage&gt; /Architecture:x86 /Filepath:&lt;captureimage&gt;
3. Type the following where &lt;captureimage&gt; is the file path and file name of the capture image you want to add to the image store:

    [!code-console[Main](preparation-activities-for-wds/samples/sample1.cmd)]

    [!code-console[Main](preparation-activities-for-wds/samples/sample2.cmd)]
4. Once you have created the capture image, follow the instructions in the "Install Image" section to boot a client computer into the capture image and capture the operating system.