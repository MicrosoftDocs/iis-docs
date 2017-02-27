---
title: "IIS 8.0 CPU Throttling: Sand-boxing Sites and Applications | Microsoft Docs"
author: rick-anderson
description: "Version Notes IIS 8.0 CPU throttling was updated in IIS 8.0 to include additional throttling options. IIS 7.5 CPU throttling was not modified in IIS 7.5. IIS..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 02/29/2012
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/get-started/whats-new-in-iis-8/iis-80-cpu-throttling-sand-boxing-sites-and-applications
msc.type: authoredcontent
---
IIS 8.0 CPU Throttling: Sand-boxing Sites and Applications
====================
by Shaun Eagan

### Compatibility


| Version | Notes |
| --- | --- |
| IIS 8.0 | CPU throttling was updated in IIS 8.0 to include additional throttling options. |
| IIS 7.5 | CPU throttling was not modified in IIS 7.5. |
| IIS 7.0 | CPU throttling was introduced in IIS 7.0. |


<a id="TOC301258515"></a>

## Problem

In a multi-tenanted deployment, such as a shared hosting environment, it is important to create a sand-box for each tenant. Without the sand-box, a tenant could intentionally or unintentionally impact other tenants negatively by accessing other tenants' contents or by monopolizing resources, such as memory, CPU, and bandwidth.

<a id="TOC301258516"></a>

## Solution

On Internet Information Services (IIS) on Windows Server 2012, the sand-box is scoped to an IIS application pool. It offers both security boundaries at the Windows process level by running each tenant in separate user identity and the resource limitations are also enforced at the process.

On Windows Server 2012, IIS CPU Throttling feature enables customers to truly limit how much CPU each tenant can consume as a percentage of CPU. Furthermore, this feature is configurable per IIS application pool, which means each tenant could have different limits, which can lead to a new business model in which tenants can pay more for higher limits.

It is important to clarify that IIS CPU Throttling is not a ***reservation*** of a CPU resource. Rather it is a way to ***limit*** the maximum usage.

<a id="TOC301258517"></a>

## Step by Step Instructions

#### Prerequisites:

- IIS is installed on Windows Server 2012. 

    - IIS CPU Throttling is part of IIS application pool configuration. Therefore, a default install of IIS will have this feature installed. There is no specific IIS feature that needs to be installed from Server Manager.
- There is at least one site with a corresponding IIS application pool. 

    - Default Web Site and DefaultAppPool can be used for this exercise.

#### Workarounds for known bugs:

There are no known bugs for this feature at this time.

### Configure CPU Throttling

1. Open **IIS Manager**.
2. Select **Application Pools** in the left navigation window:  
    ![](iis-80-cpu-throttling-sand-boxing-sites-and-applications/_static/image1.png)
3. Select **DefaultAppPool**:  
    ![](iis-80-cpu-throttling-sand-boxing-sites-and-applications/_static/image3.png)
4. In the **Action** pane, select **Advanced Settings**:  
    ![](iis-80-cpu-throttling-sand-boxing-sites-and-applications/_static/image5.png)
5. Under **CPU** group, locate the following configurations:  
    ![](iis-80-cpu-throttling-sand-boxing-sites-and-applications/_static/image7.png)

    - **Limit**: Indicates the maximum CPU usage (in 1000th of a percent) for this application pool. If there are multiple processes associated to this application pool, the limit is applied to the total ***sum*** of all processes under this application pool.
    - **LimitAction**: Indicates what action to take when the limit value is met above. 

        - For Windows Server 8, new actions, **Throttle** and **ThrottleUnderLoad** have been added:  
            ![](iis-80-cpu-throttling-sand-boxing-sites-and-applications/_static/image9.png)
        - **Throttle**: The feature will throttle the CPU consumption to the value set for **Limit**.
        - **ThrottleUnderLoad**: The feature will throttle the CPU consumption to the value set for **Limit**, but only if there is a contention on the CPU. This means that the application pool may consume more CPU activity when the CPU is idle.
    - **LimitInterval**: Not used for both **Throttle** and **ThrottleUnderLoad**. This configuration attribute is carried over from previous versions of Windows for backward compatibility.
6. To set the maximum limit of 30%, enter: 

    1. **Limit**: 30000 (30% in 1000th of a percent)
    2. **LimitAction**: Throttle  
        ![](iis-80-cpu-throttling-sand-boxing-sites-and-applications/_static/image11.png)
7. That's it. Using a load generating tool, send requests to the Default Web Site. A tool such as WCAT can be used ([https://www.iis.net/community/default.aspx?tabid=34&amp;g=6&amp;i=1467](https://www.iis.net/downloads/community)) to generate traffic.
8. Note that the configuration settings in question can be set as default values so that they don't have to be configured individually per application pool. To configure the application pool defaults, select **Set Application Pool Defaults** under **Actions** pane:  
    ![](iis-80-cpu-throttling-sand-boxing-sites-and-applications/_static/image13.png)
9. The same settings are exposed there to configure the application pool defaults:  
    ![](iis-80-cpu-throttling-sand-boxing-sites-and-applications/_static/image15.png)

### Scenarios

Try deploying the following scenarios:

- IIS CPU Throttling feature is designed for a multi-tenanted environment. Try these settings in an environment where there are thousands of sites and applications, like a shared hosting deployment.
- Set different limits for different "groups" of tenants to simulate those customers who are allowed to consume more CPU resources than others.
- Set **ThrottleUnderLoad** as **LimitAction** to observe the behavior. It functions like **Throttle**, if there are contentions on the CPU. If there aren't any contentions on the CPU, the application pool is allowed to use more CPU resources than the value set for **Limit**.
- Create a sand-box with memory and bandwidth limits, along with IIS CPU Throttling feature on Windows Server 2012. Memory and bandwidth limits are not discussed specifically in this documentation because these features exist on Windows Server 2008 and Windows Server 2008 R2.

<a id="TOC301258518"></a>

## Summary

You have successfully explored IIS CPU Throttling feature in Windows Server 2012.