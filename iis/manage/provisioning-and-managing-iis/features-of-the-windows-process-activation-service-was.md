---
title: "Features of the Windows Process Activation Service (WAS) | Microsoft Docs"
author: thomasdeml
description: "The Windows Process Activation Service (WAS) of IIS 7 is the key component that provides process model and configuration features to Web Applications and Web..."
ms.author: iiscontent
manager: soshir
ms.date: 08/15/2012
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/features-of-the-windows-process-activation-service-was
msc.type: authoredcontent
---
Features of the Windows Process Activation Service (WAS)
====================
by [Thomas Deml](https://github.com/thomasdeml)

The Windows Process Activation Service (WAS) of IIS 7 is the key component that provides process model and configuration features to Web Applications and Web Services. WAS major task is to manage Application Pools. Application Pools are configuration containers that represent the hosting environment for groups of URLs.

When an HTTP client requests a URL HTTP.SYS maps the request to an Application Pool request queue. A worker process for the Application Pool request queue is spawned by WAS and the worker process executes the code necessary to send a response. One of WAS's main tasks is to manage the worker processes it spawned, i.e. WAS monitors their health, recycles them if necessary and makes sure none of them consume more resources than specified in the corresponding AppPool configuration. WAS is also the arbiter and collector for run-time and state data, e.g. performance counters, site and Application Pool state.

## Architectural Diagram

![IIS 7.0 Architecture](features-of-the-windows-process-activation-service-was/_static/image1.jpg "IIS 7.0 Architecture")

## Process Model Features

Supporting 10000 or more web sites to be hosted on the same physical machine is a core requirement for today's mass hosting environments. The code running on these web-sites is usually not well tested, if at all. To support these requirements WAS needs to provide a powerful process model and efficient resource management.

### Efficient Resource Management

#### On-Demand Activation

Resources like RAM and CPU are scarce in multi-tenant scenarios. WAS will start an IIS worker process only once requests for a particular web site or web application arrive.

#### Idle-timeout

Because resources are usually scarce WAS can shutdown web applications based on a configurable idle-timeout.

#### Health Monitoring

To ensure their health WAS monitors the worker processes it spawned. Health messages are periodically sent to each running worker process. If the worker process doesn't respond in a configurable time interval the worker process will be recycled or killed. This way undetected deadlocks in worker processes get automatically fixed by restarting the worker process.

#### Startup Limit

Part of the Rapid-Fail Protection feature is the Startup limit. If a worker process doesn't report back to WAS within the configurable startup-limit it will be killed and the Rapid-Fail-Protection counter is incremented. Application Pools are stopped, i.e. restarting the worker process will not be tried anymore, if the Rapid-Fail-Protection counter reaches a configurable limit within a configurable time limit. This prevents scenarios where worker processes hang or crash during startup.

#### Shutdown Limit

A worker process also has to shutdown in a configurable limit. If the shutdown doesn't happen in this time the worker process gets killed by WAS. This prevents resource overuse due to processes hanging in their shut-down phase. Additional shutdown settings allow an executable to be started (e.g. a debugger) when the shutdown doesn't complete within the allotted time.

#### CPU affinity

Configuration settings allow WAS to start worker processes that are affinitized to one or more CPUs. This prevents tenants from interfering with each other if they share the same physical machine.

#### User Profile

WAS can start worker processes with or without loading the user profile.

### Security

#### Customizable User Account

IIS worker processes can run as a preconfigured process identity or built-in accounts (LocalService, LocalSystem, NetworkService). Built-in accounts are advantages because they don't require password management. If a custom user identity is used the password is automatically encrypted. Configuration settings can be replicated to multiple machines by sharing the configuration encryption keys across machines.

#### Job Object Features

Job objects allow administrators to restrict worker processes to a particular CPU limit. A configurable action is taken if this CPU limit is exceeded. Job objects will also make sure that processes spawned by the worker process get terminated.

## Configuration Isolation and Security

Before WAS starts an Application Pool and its worker process it generates a unique configuration file for this Application Pool. Application Pools also have configuration settings to run Application Pools under unique identities. Isolation can be achieved however even if the same identity is used. WAS creates a unique Security Identifier (SID) for each Application Pool. The Application Pool configuration file is then secured with this unique SID. This ensures that Application Pool configuration files can only be read by Administrators and the Application Pool itself. Even file permissions can be configured using this unique SID.

### Application Pool Identities

In Windows Server 2008 SP2 and Windows Server 2008 R2 Application Pools can now run as an unique Application Pool Identity. More about this topic can be found here.

## Diagnostics and Monitoring

#### Event Logging

Events regarding invalid configuration, recycling, startup or shutdown of worker processes are reported to the System Eventlog.

#### Currently Executing Requests

WAS exposes a run-time and state control interface that allows scripts and tools to query for the currently executing requests of a particular worker process. This is useful to find requests that hang or requests that take a very long time to complete.

#### Performance Counters

All IIS performance counters get funneled through WAS. WAS gathers these performance counters because IIS counters are site-based and web applications can live in different Application Pools.

## Recycling

Recycling allows the refresh of worker processes without losing a single request due to down-time. This is done via a feature called "overlapping recycling".

#### Overlapping Recycling

WAS does this by spawning up a new worker process parallel to the old one that is still handling requests. Once the new worker process is up it starts picking up requests from the request queue while the old worker process is instructed by WAS to stop picking up requests. Once the old worker process finishes all executing requests it shuts down. This feature is called "overlapping recycling". It ensures that no requests are lost during a recycle.

### Recycling Configuration

Recycling parameters are configurable in the IIS configuration system.

#### Scheduled Recycling

Customers might want to recycle their applications based on a regular schedule. Via configuration settings recycling can be scheduled periodically, e.g. every 4 hours, every day at 1am etc.

#### Recycling based on Memory Consumption

Applications might leak memory over time. WAS can monitor the memory consumption of each worker processes to ensure that no worker process uses more than its preconfigured limit. Reaching a configured virtual or private memory threshold will trigger the recycling of a worker process.

#### Recycling Based on Number of Requests

Recycling can also be configured based on the number of requests a particular worker process handled.

#### Custom Recycling

Custom code can custom health statistics and trigger a recycling via an API call to the WAS run-time and state API's.

#### Process Orphaning

Some errors only happen in a production environment. Killing worker processes ensures up-time but troubleshooting of these errors becomes difficult, e.g. if the failing worker process needs to be debugged. The process orphaning feature in WAS allows worker processes to be recycled without killing the failed worker process. Now a debugger can be attached to it. Additional process orphaning settings allow the execution of a process (e.g. a debugger) if orphaning happens.

## Application Pool State Management

Application Pools can be stopped, recycled or started via publicly available API's, e.g. if an application has to be taken offline or if recycling has to be done based on parameters different from what's configurable in the applicationhost.config file.

## Additional WAS Features

#### Load-Balancer Features

HTTP.SYS still listens on the network and will return a 500 HTTP error message if requests are not picked up by an Application Pool. This is a problem because for a Level 5 Load Balancers (TCP/IP) a 500 HTTP error looks like a valid TCP/IP connection. A WAS configuration setting can enable HTTP.SYS to reject connections instead of sending HTTP responses.

WAS can be configured to start worker processes with the following settings:

#### WoW64 Support

WAS can start 32-Bit or 64-Bit worker processes.

#### .NET Framework Preload

WAS can be configured to preload a particular version of the .NET Framework. This can make the troubleshooting of version conflicts much easier.

#### Web Gardens

A Web Garden is the term for an Application Pool that runs with multiple worker processes. Requests get distributed among these worker process instances using a round-robin mechanism.

## WAS Multi Protocol Support

WAS not only host the HTTP stack. It can also host other protocols via its Listen Adapter and Worker Process Framework. WCF services take advantage of the WAS Multi-Protocol support. WCF protocols come with their own Listeners (e.g. the NET.TCP, NET.MSMQ or NET.PIPE Listener). These Listeners connect to WAS using the Listener Adapter Interfaces WAS provides.

Application protocols that take advantage of this infrastructure can host custom application code in the same .NET Application Domain as regular ASP.NET applications. They can also take advantage of the protocol-independent services the ASP.NET Hosting Environment provides, for example on-demand compilation, configuration support etc.