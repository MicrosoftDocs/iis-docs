---
title: "IIS Thread Pool Ideal CPU Optimization for NUMA hardware | Microsoft Docs"
author: bangbingsyb
description: ""
ms.author: yashi
msc.type: authoredcontent
---
IIS Thread Pool Ideal CPU Optimization for NUMA hardware
====================

### Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | IIS Thread Pool Ideal CPU Optimization for NUMA hardware was introduced in IIS 10.0 |
| IIS 8.5 and earlier | IIS Thread Pool Ideal CPU Optimization for NUMA hardware was not supported prior to IIS 10.0 |

## Ideal CPU setting for NUMA hardware

Starting from Windows Server 2016, IIS 10.0 supports automatic ideal CPU assignment for its thread pool threads to enhance the performance and scalability on NUMA hardware. This feature is enabled by default and can be configured through the following registry key:

```
HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\InetInfo\Parameters\ThreadPoolUseIdealCpu
```

With this feature enabled, IIS thread manager makes its best effort to evenly distribute IIS thread pool threads across all CPUs in all NUMA nodes based on their current loads. In general, it is recommended to keep this optimization enabled for NUMA hardware.

> [!NOTE]
> The ideal CPU setting is different from the worker process NUMA node assignment settings (numaNodeAssignment and numaNodeAffinityMode) introduced in [CPU Settings for an Application Pool](https://www.iis.net/configreference/system.applicationhost/applicationpools/add/cpu). The ideal CPU setting affects how IIS distributes its thread pool threads, while the worker process NUMA node assignment settings determine on which NUMA node a worker process starts.

## Summary

IIS 10.0 has added thread pool ideal CPU optimization for NUMA hardware.
