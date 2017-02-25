---
title: "PowerShell Snap-in: Run-time Data | Microsoft Docs"
author: rick-anderson
description: "The previous walkthroughs showed you how to query and change IIS configuration settings. There is one unexplored area left however: run-time data. Introducti..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 04/14/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-run-time-data
msc.type: authoredcontent
---
PowerShell Snap-in: Run-time Data
====================
by Thomas Deml

The previous walkthroughs showed you how to query and change IIS configuration settings. There is one unexplored area left however: run-time data.

## Introduction

Things change, IIS is not different. Sites get started or stopped, Application Pools recycle or time out, requests come in and responses get sent, AppDomains get spawned or shut down. IIS implements an interface called RSCA (run-time state and control API) that allows you to monitor what's going on in the system.

The IIS PowerShell Snap-in uses this interface and exposes some of its data via the IIS Snap-in namespace. The state of Sites and Application Pools is configurable via the Get-WebItemState, Start-WebItem, Stop-WebItem and Restart-WebItem cmdlets. Run-time state like currently running worker processes, currently executing requests and loaded AppDomains is exposed via the IIS namespace.

This walkthrough uses the sites, applications and virtual directories that were created in a previous walkthrough.

## Sites and Application Pool State

We're starting by querying the state of our web-sites.

### Site State


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-1.unknown)]


Stopping DemoSite can be achieved with the Stop-WebItem cmdlet:


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-2.unknown)]


Starting works the same of course:


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-3.unknown)]


### AppPool State

We want to do the same for Application Pools


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-4.unknown)]


But there is also the state property you can read on the AppPools node. Let's have some fun with the next example. Turn your speakers on and execute the following command:


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-5.unknown)]


Now start DemoAppPool again:


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-6.unknown)]


### Recycling AppPools

The one difference with AppPools is that they can be recycled. The cmdlet to recycle AppPools is called Restart-WebItem and not Recycle-WebItem. PowerShell has pretty strict naming rules and we had to settle for Restart-WebItem. Let's expand this example a little bit by

1. making a request to the default page of the 'Default Web Site'
2. querying the PID of the worker process is that handles the request
3. recycling the Application Pool
4. Requesting the PID again to confirm that the process was restarted

#### 1. Requesting the default page

We use the Net.WebClient class to request [http://localhost/](http://localhost/). Instead of displaying the output on the screen we are just looking at the length of the response.


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-7.unknown)]


#### 2. Querying the Worker Process PID

Assuming you have no other active web sites and applications on your machine the following command should return only one PID:


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-8.unknown)]


There is a better way to get to worker processes, handled a little later in this walkthrough.

#### 3. Recycling the Application Pool

We recycle the Application Pool by using the Restart-WebItem cmdlet:


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-9.unknown)]


4. Querying for the Worker Process PID

If the AppPool was successfully recycled your Process ID should have been changed.


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-10.unknown)]


## Worker Processes and Requests

The get-process cmdlet doesn't help you figuring out which Application Pool a particular worker process is serving. This can be easily done however:


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-11.unknown)]


### Currently Executing Requests

If your machine is not a production machine you will have a hard time looking at currently exeucting requests. The request is long gone until you make a request via Internet Explorer and get back into the PowerShell console. Here is a little helper; a request that takes a long time.


[!code-aspx[Main](powershell-snap-in-run-time-data/samples/sample12.aspx)]


If you want to look at the currently executing requests you can type the following command (NOTE: the process id you have to use for the get-item command will be different on your machine):


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-13.unknown)]


Or if you want to see how much time already passed since you started the request:


[!code-unknown[Main](powershell-snap-in-run-time-data/samples/sample-127219-14.unknown)]


## Summary

Done. In this walkthrough you learned how to query the state of IIS Application Pools and Sites. You found out how to start and stop them. You also learned how to look at worker processes and currently executing requests.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1151.aspx)