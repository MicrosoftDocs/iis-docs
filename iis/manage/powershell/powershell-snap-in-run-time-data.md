---
title: "PowerShell Snap-in: Run-time Data | Microsoft Docs"
author: thomasdeml
description: "The previous walkthroughs showed you how to query and change IIS configuration settings. There is one unexplored area left however: run-time data. Introducti..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-run-time-data
msc.type: authoredcontent
---
PowerShell Snap-in: Run-time Data
====================
by [Thomas Deml](https://github.com/thomasdeml)

The previous walkthroughs showed you how to query and change IIS configuration settings. There is one unexplored area left however: run-time data.

## Introduction

Things change, IIS is not different. Sites get started or stopped, Application Pools recycle or time out, requests come in and responses get sent, AppDomains get spawned or shut down. IIS implements an interface called RSCA (run-time state and control API) that allows you to monitor what's going on in the system.

The IIS PowerShell Snap-in uses this interface and exposes some of its data via the IIS Snap-in namespace. The state of Sites and Application Pools is configurable via the Get-WebItemState, Start-WebItem, Stop-WebItem and Restart-WebItem cmdlets. Run-time state like currently running worker processes, currently executing requests and loaded AppDomains is exposed via the IIS namespace.

This walkthrough uses the sites, applications and virtual directories that were created in a previous walkthrough.

## Sites and Application Pool State

We're starting by querying the state of our web-sites.

### Site State


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample1.ps1)]


Stopping DemoSite can be achieved with the Stop-WebItem cmdlet:


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample2.ps1)]


Starting works the same of course:


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample3.ps1)]


### AppPool State

We want to do the same for Application Pools


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample4.ps1)]


But there is also the state property you can read on the AppPools node. Let's have some fun with the next example. Turn your speakers on and execute the following command:


[!code-console[Main](powershell-snap-in-run-time-data/samples/sample5.cmd)]


Now start DemoAppPool again:


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample6.ps1)]


### Recycling AppPools

The one difference with AppPools is that they can be recycled. The cmdlet to recycle AppPools is called Restart-WebItem and not Recycle-WebItem. PowerShell has pretty strict naming rules and we had to settle for Restart-WebItem. Let's expand this example a little bit by

1. making a request to the default page of the 'Default Web Site'
2. querying the PID of the worker process is that handles the request
3. recycling the Application Pool
4. Requesting the PID again to confirm that the process was restarted

#### 1. Requesting the default page

We use the Net.WebClient class to request [http://localhost/](http://localhost/). Instead of displaying the output on the screen we are just looking at the length of the response.


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample7.ps1)]


#### 2. Querying the Worker Process PID

Assuming you have no other active web sites and applications on your machine the following command should return only one PID:


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample8.ps1)]


There is a better way to get to worker processes, handled a little later in this walkthrough.

#### 3. Recycling the Application Pool

We recycle the Application Pool by using the Restart-WebItem cmdlet:


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample9.ps1)]


4. Querying for the Worker Process PID

If the AppPool was successfully recycled your Process ID should have been changed.


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample10.ps1)]


## Worker Processes and Requests

The get-process cmdlet doesn't help you figuring out which Application Pool a particular worker process is serving. This can be easily done however:


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample11.ps1)]


### Currently Executing Requests

If your machine is not a production machine you will have a hard time looking at currently exeucting requests. The request is long gone until you make a request via Internet Explorer and get back into the PowerShell console. Here is a little helper; a request that takes a long time.


[!code-aspx[Main](powershell-snap-in-run-time-data/samples/sample12.aspx)]


If you want to look at the currently executing requests you can type the following command (NOTE: the process id you have to use for the get-item command will be different on your machine):


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample13.ps1)]


Or if you want to see how much time already passed since you started the request:


[!code-powershell[Main](powershell-snap-in-run-time-data/samples/sample14.ps1)]


## Summary

Done. In this walkthrough you learned how to query the state of IIS Application Pools and Sites. You found out how to start and stop them. You also learned how to look at worker processes and currently executing requests.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1151.aspx)