---
title: "Using WSRM to manage IIS 7 AppPool CPU Utilization | Microsoft Docs"
author: walterov
description: "Introduction In the past administrators used CPULimit Metabase Property in IIS to configure the maximum percentage of CPU time that the worker processes in a..."
ms.author: iiscontent
manager: soshir
ms.date: 04/17/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/managing-performance-settings/using-wsrm-to-manage-iis-7-apppool-cpu-utilization
msc.type: authoredcontent
---
Using WSRM to manage IIS 7 AppPool CPU Utilization
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

In the past administrators used [CPULimit Metabase Property in IIS](https://www.microsoft.com/technet/prodtechnol/WindowsServer2003/Library/IIS/1b82ca25-5ea4-48b0-9ce7-a1c36765f1e2.mspx?mfr=true) to configure the maximum percentage of CPU time that the worker processes in an application pool are allowed to consume over a period of time. With the availability of Windows System Resource Manager (WSRM), setting CPULimit is no longer needed, moreover, it is not recommended.

WSRM enables administrators to control how CPU and memory resources are allocated to applications, services, and processes. Managing resources in this way improves system performance and reduces the chance that applications, services, or processes will interfere with the rest of the system. It also creates a more consistent and predictable experience for users of applications and services running on the computer.

WSRM integrates resource management with Web pools through a built-in policy called Equal\_Per\_IISAppPool. Policies in WSRM automatically switch to different resource allocations in response hardware hot-add changes or cluster changes if running in a cluster configuration.

For more information see [Overview of Windows System Resource Manager](http://technet2.microsoft.com/windowsserver2008/en/library/c5b76d56-99b1-4ad7-875c-417b631184541033.mspx?mfr=true).

## Turning Off the CPULimit Metabase Property

1. Start the IIS Manager and connect to the target server
2. Click on the Application Pools node to view the available application pools, for each application pool open the **Advanced Settings** dialog by clicking **Advanced Settings** in the Actions panel.

    [![](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image2.jpg)](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image1.jpg)
3. Under the CPU section ensure that the CPU Limit property is set to 0 (default value).

    [![](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image4.jpg)](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image3.jpg)

## Using the Built-in IIS Policy

1. After installing the Web Role proceed to [install Windows System Resource Manager](http://technet2.microsoft.com/windowsserver2008/en/library/497d620a-3c40-4236-ae9a-5c4e565787171033.mspx?mfr=true)
2. Start WSRM by clicking the Windows Start button, select "Administrative Tool", and select "Windows System Resource Manager"

    [![](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image6.jpg)](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image5.jpg)
3. Start the Equal\_Per\_IISAppPool built-in policy

    - Open the Resource Allocation Policies node in the left-hand pane

        [![](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image8.jpg)](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image7.jpg)
    - Right click on Equal\_Per\_IISAppPool in the left-hand pane
    - Select Set as Managing Policy
    - If prompted to disable the calendar, click OK

        [![](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image10.jpg)](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image9.jpg)
    - Observe the behavior of the system under an IIS load. You could use WCAT for simulating a load on the server. This tools is part of IIS 6.0 Resource Kit which can be downloaded from the following link: [https://www.microsoft.com/downloads/details.aspx?FamilyID=56fc92ee-a71a-4c73-b628-ade629c89499&amp;DisplayLang=en](https://www.microsoft.com/downloads/details.aspx?FamilyID=56fc92ee-a71a-4c73-b628-ade629c89499&amp;DisplayLang=en)

## Creating a Custom IIS Policy (Optional)

1. Create at least 2 process matching criteria (PMC) for different AppPools

    - Right-click on the Process Matching Criteria node in the left-hand pane
    - Select New Process Matching Criteria...
    - The New Process Matching Criteria dialog appears

        [![](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image12.jpg)](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image11.jpg)
    - Enter a name for the PMC and click Add...
    - The Add Rule dialog appears
    - Select the Files or Command Lines tab
    - Click in the area labeled "Included files or command lines" and type in a matching criteria.
    - Use the following format (without the quotes): ["@w3wp.exe.\*&lt;AppPoolName](mailto:)&gt;"

        [![](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image14.jpg)](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image13.jpg)
    - Add lines to match additional AppPools (or any other processes) to this PMC
    - Click OK
    - Repeat the above steps for each additional PMC
2. Create a resource allocation policy (RAP)

    - Right click on the Resource Allocation Policy node in the left-hand pane
    - Select New Resource Allocation Policy
    - The New Resource Allocation Policy dialog appears
    - Enter a name for the RAP

        [![](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image16.jpg)](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image15.jpg)
    - Click Add
    - The Add or Edit Resource Allocation dialog appears
    - Select the PMC (from the dropdown) this allocation should go to
    - Enter the processor percentage to be allocated to the PMC

        [![](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image18.jpg)](using-wsrm-to-manage-iis-7-apppool-cpu-utilization/_static/image17.jpg)
    - Click OK
    - Add Resource Allocations for all other PMCs to be managed by RAP
    - Click OK
- Activate the policy

    - Right click on the RAP created above
    - Select Set as Managing Policy
    - If prompted to disable the calendar, click Yes
    - Observe the behavior of the system while running an IIS load