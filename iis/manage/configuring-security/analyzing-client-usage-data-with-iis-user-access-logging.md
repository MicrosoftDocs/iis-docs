---
title: "Analyzing Client Usage Data with IIS User Access Logging | Microsoft Docs"
author: rmcmurray
description: "User Access Logging (UAL) is a built-in feature of Windows Server 2012 which allows administrators to collect data about client usage."
ms.author: iiscontent
manager: soshir
ms.date: 04/01/2013
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/configuring-security/analyzing-client-usage-data-with-iis-user-access-logging
msc.type: authoredcontent
---
Analyzing Client Usage Data with IIS User Access Logging
====================
by [Robert McMurray](https://github.com/rmcmurray)

> User Access Logging (UAL) is a built-in feature of Windows Server 2012 which allows administrators to collect data about client usage.


### Overview

User Access Logging (UAL) is a built-in feature of Windows Server 2012 which allows administrators to collect data about client usage; you can find more information about UAL in the following article:

**User Access Logging Overview**  
[https://technet.microsoft.com/en-us/library/hh849634.aspx](https://technet.microsoft.com/en-us/library/hh849634.aspx)

Internet Information Services 8 ships with a command-line tool, IISUAL.EXE, which helps network administrators analyze the W3C log data from their web servers to determine the number of authenticated and anonymous users for their websites. The IISUAL.EXE utility will provide the user access information that it collects to the UAL APIs in Windows Server 2012 so that the data will be available through the UAL methods that are provided through WMI and PowerShell.

> [!NOTE]
> The IISUAL.EXE utility is designed for use only with log files that are in W3C format; it will not work with log files in NCSA, IIS, or ODBC formats.


That being said, because log file analysis can be CPU-intensive, it is recommended that you do not analyze your log data on a production server; the article listed above contains the following note:

> [!NOTE]
>  
> 
> UAL is not recommended for use on servers that are connected directly to the Internet, such as web servers on an Internet-accessible address space, or in scenarios where extremely high performance is the primary function of the server (such as in HPC workload environments). UAL is primarily intended for small, medium, and enterprise intranet scenarios where high volume is expected, but not as high as many deployments of Windows Server 2012 that serve Internet-facing traffic volume on a regular basis.


### Using the IISUAL.EXE Utility

The IISUAL.EXE utility is located in the following directory:

`%SystemRoot%\System32\inetsrv`

When you run the IISUAL.EXE utility with no command-line switches, it will return the following help message:

[!code-csharp[Main](analyzing-client-usage-data-with-iis-user-access-logging/samples/sample1.cs)]

As indicated by the example, IISUAL.EXE supports two command-line switches:

- ***logfile*** - This switch defines the name of a specific W3C log file to analyze.
- ***outputpostfix*** - This switch specifies a character string that will be appended to the input W3C log file name in order to create the output statisics.

For example, if you specify the following options:

`IISUAL.EXE -logfile u_ex130319.log -outputpostfix UAL`

IISUAL.EXE will analyze the W3C log file named &quot;u\_ex130319.log&quot; for client usage data and write the statistics to a file named &quot;u\_ex130319\_UAL.log&quot;.

> [!NOTE]
>  
> 
> For performance reasons, IISUAL.EXE is designed to be used with a single W3C log file; IISUAL.EXE will not work with wildcard characters. For example, the following command will return an error:
> 
> `IISUAL.EXE -logfile *.log -outputpostfix UAL`
> 
> If you need to process more than one log file, you can use the following batch file to loop through all of the log files in a directory:
> 
> [!code-console[Main](analyzing-client-usage-data-with-iis-user-access-logging/samples/sample2.cmd)]


### Examining the IISUAL.EXE Results

When you use IISUAL.EXE to analyze a W3C log file, it will search through all of the log file entries and use the information in the &quot;cs-username&quot; and &quot;c-ip&quot; fields to generate statistics that will be written to an output file that resembles the following format:

[!code-console[Main](analyzing-client-usage-data-with-iis-user-access-logging/samples/sample3.cmd)]

This User Access Logging information provides administrators with the statistics for authenticated versus anonymous users for the time period that is defined by the W3C log file. As mentioned earlier, this information is useful for small, medium, and enterprise scenarios where administrators are interested in tracking the number of users who are accessing an intranet website.