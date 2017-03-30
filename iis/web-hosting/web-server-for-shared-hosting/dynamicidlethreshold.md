---
title: "dynamicIdleThreshold | Microsoft Docs"
author: walterov
description: "When Windows Server ® 2008 R2 starts paging heavily (this could be at 1.5x ram), the response time of HTTP requests goes down. This is particularly common in..."
ms.author: iiscontent
manager: soshir
ms.date: 12/01/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/dynamicidlethreshold
msc.type: authoredcontent
---
dynamicIdleThreshold
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

When Windows Server® 2008 R2 starts paging heavily (this could be at 1.5x ram), the response time of HTTP requests goes down. This is particularly common in shared hosting scenarios. A feature in IIS 7 and above allows page file usage (total commit) to affect worker process idle timeout and thus reduce the degradation in request response time as memory is allocated.

By default, the idle timeout is 20 minutes. This timeout value is configured by the Windows Process Activation Service (WAS). If the current idle timeout value is greater than the WAS-configured value, the worker process initiates a shutdown.

The IIS **dynamicIdleThreshold** property allows the administrator to dynamically reduce this idle timeout when a configurable memory limit is reached. The unit of the setting is "% of RAM committed". In shared hosting tests, peak performance was reached at a value of 130. Notice that when 80% of the setting is reached, idle timeouts start being reduced dramatically.

**To configure dynamicIdleThreshold**

- To set this property to a particular value, for example 130%, open a command prompt and run the following:


[!code-console[Main](dynamicidlethreshold/samples/sample1.cmd)]


**To configure dynamicIdleThreshold using the [IIS PowerShell Provider](../../manage/powershell/installing-the-iis-powershell-snap-in.md)**

Open a PowerShell prompt and run the following:


[!code-powershell[Main](dynamicidlethreshold/samples/sample2.ps1)]


For more information about this property, see [http://technet2.microsoft.com/windowsserver2008/en/library/43e91f73-f0b4-4320-9d46-3f8f4905edd81033.mspx?mfr=true](http://technet2.microsoft.com/windowsserver2008/en/library/43e91f73-f0b4-4320-9d46-3f8f4905edd81033.mspx?mfr=true).

## Event Log Entries

The following describes some of the event log entries that WAS can generate.

### 80% of configured memory threshold is reached

| **Event Log ID** | **Level** | **Message** |
| --- | --- | --- |
| 5192 | Informational | The amount of committed memory is approaching the demand start limit. The Windows Process Activation Service (WAS) will start to decrement the idle timeout value for all worker processes. Worker processes may start idling out before the configured time. Current physical memory usage: '%2' MB, current physical memory free: '%3' MB. |


### 90% of configured memory threshold is reached

| **Event Log ID** | **Level** | **Message** |
| --- | --- | --- |
| 5193 | Warning | The amount of committed memory is near or at the configured limit. The Windows Process Activation Service (WAS) will aggressively decrement the idle timeout value for the worker processes. Worker processes may start idling out before the configured time. Current physical memory usage: '%2' MB, current physical memory free: '%3' MB. |


### 75% of configured memory threshold regained

| **Event Log ID** | **Level** | **Message** |
| --- | --- | --- |
| 5194 | Informational | The amount of committed memory has dropped below the high load level, so the Windows Process Activation Service (WAS) will reset the idle timeout value for the worker processes to their original settings. Current physical memory usage: '%2' MB, current physical memory free: '%3' MB. |


### New Worker Process Idle Timeout Event Log Message

WAS generates the following event log error message if a worker process times out during the system is in the 80% to 100% **dynamicIdleThreshold** range.  The event log message stays the same if the **dynamicIdleThreshold** percentage is &lt; 80%.

| **Event Log ID** | **Level** | **Message** |
| --- | --- | --- |
| 5195 | Informational | A worker process with process id of '%1' serving application pool '%2' was shut down due to inactivity. The system is under high load and has decreased the idle timeout of this worker process to '%4' minutes from its original '%3' minutes. A new worker process will be started when needed. |