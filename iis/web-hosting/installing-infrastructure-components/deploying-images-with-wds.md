---
title: "Deploying Images with WDS | Microsoft Docs"
author: walterov
description: "Once the environment is setup with Windows Deployment Services, a reference machine has been created, and an image of it is available for deployment, you are..."
ms.author: iiscontent
manager: soshir
ms.date: 12/01/2007
ms.topic: article
ms.assetid: f84a3bc2-3d0d-43dc-bd97-eaa3ba27a27b
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/installing-infrastructure-components/deploying-images-with-wds
msc.type: authoredcontent
---
Deploying Images with WDS
====================
by [Walter Oliver](https://github.com/walterov)

Once the environment is setup with Windows Deployment Services, a reference machine has been created, and an image of it is available for deployment, you are ready to start deploying it to other machines. There are three basic methods to accomplish this through WDS:

1. **Manual Deployment:** It is possible to use this method for deploying into a single machine, though it is tedious for deploying into a large set of machines. For instructions, see [Installing an operating system](http://technet2.microsoft.com/WindowsServer2008/en/library/7d837d88-6d8e-420c-b68f-a5b4baeb52481033.mspx#BKMK_PXEBooting) in the "Windows Deployment Services Role Step-by-Step Guide".
2. **Unattended Deployment**. This method automates the Windows Deployment Services client and the latter stages of Windows Setup. For instructions, see [Using unattend files](http://technet2.microsoft.com/WindowsServer2008/en/library/7d837d88-6d8e-420c-b68f-a5b4baeb52481033.mspx#BKMK_UsingUnattendFiles) in the "Windows Deployment Services Role Step-by-Step Guide". For examples, see "Sample Unattended Files" in the unattended installation chapter at [https://go.microsoft.com/fwlink/?LinkId=88439](https://go.microsoft.com/fwlink/?LinkId=88439) . This two-stage approach is accomplished by using two different unattend files:

> a. **Windows Deployment Services client unattend file:** This file uses the Unattend.xml format and is stored on the Windows Deployment Services server in the \WDSClientUnattend folder. It is used to automate the Windows Deployment Services client user interface screens (such as entering credentials, choosing an install image, and configuring the disk).  
>   
> b. **Image unattend file:** This file uses the Unattend.xml or Sysprep.inf format, depending upon the version of the operating system in the image. It is stored in a subfolder (either $OEM$ structure or \Unattend) in the per-image folder. It is used to automate the remaining phases of setup (for example, offline servicing, Sysprep specialize, and mini-setup).


3. **Multicast Transmission Deployment**. Multicast transmissions allow you to deploy an image to a large number of client computers without overburdening the network. When you create a multicast transmission, the image is sent over the network only once, which can drastically reduce the network bandwidth that is used. For instructions, see [Creating a multicast transmission](http://technet2.microsoft.com/WindowsServer2008/en/library/7d837d88-6d8e-420c-b68f-a5b4baeb52481033.mspx#BKMK_MulticastDS) in the "Windows Deployment Services Role Step-by-Step Guide".

You can also deploy images through [Microsoft Deployment](https://technet.microsoft.com/en-us/solutionaccelerators/bb963909.aspx) or SCCM.
  