---
title: "Data Mining UrlScan 3 Logs using LogParser 2.2 | Microsoft Docs"
author: rmcmurray
description: "Microsoft has released version 3.1 of UrlScan , and one of the great new features in this version is log files that conform to the W3C Extended Log File Form..."
ms.author: iiscontent
manager: soshir
ms.date: 10/22/2008
ms.topic: article
ms.assetid: 92f717d4-cf5a-4ba9-9e49-6d0062849958
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/working-with-urlscan/data-mining-urlscan-3-logs-using-logparser-22
msc.type: authoredcontent
---
Data Mining UrlScan 3 Logs using LogParser 2.2
====================
by [Robert McMurray](https://github.com/rmcmurray)

Microsoft has released version 3.1 of [UrlScan](index.md), and one of the great new features in this version is log files that conform to the [W3C Extended Log File Format](http://www.w3.org/TR/WD-logfile). What this means to administrators is that they can now parse their UrlScan activity using almost any common log utilities, including Microsoft's [LogParser 2.2](https://www.microsoft.com/en-us/download/details.aspx?id=24659) utility, which is a freeware utility from Microsoft that allows you to write SQL-style queries to extract useful information.

### In this Walkthrough

- [Getting Started](data-mining-urlscan-3-logs-using-logparser-22.md#001)

    - [Downloading and Installing UrlScan and LogParser](data-mining-urlscan-3-logs-using-logparser-22.md#001a)
    - [UrlScan Log Files](data-mining-urlscan-3-logs-using-logparser-22.md#001b)
- [Querying Data](data-mining-urlscan-3-logs-using-logparser-22.md#002)

    - [Simple Queries](data-mining-urlscan-3-logs-using-logparser-22.md#002a)
    - [Filtering Queries](data-mining-urlscan-3-logs-using-logparser-22.md#002b)
    - [Grouping, Tabulating, and Sorting Queries](data-mining-urlscan-3-logs-using-logparser-22.md#002c)
- [Putting it All Together](data-mining-urlscan-3-logs-using-logparser-22.md#003)

    - [Counting Requests by Client IP and Sorting Data by Request Count](data-mining-urlscan-3-logs-using-logparser-22.md#003a)
    - [Counting Rejected Requests based on the Reason for Rejections](data-mining-urlscan-3-logs-using-logparser-22.md#003b)
    - [Splitting Requests into Separate Log Files based on Site ID](data-mining-urlscan-3-logs-using-logparser-22.md#003c)

<a id="001"></a>

## Getting Started

<a id="001a"></a>

### Downloading and Installing UrlScan and LogParser

The download locations for UrlScan are listed in the "Getting UrlScan" section of the following topic:


[https://www.iis.net/learn/extensions/working-with-urlscan](index.md)

> [!NOTE]
> There are separate downloads for 32-bit and 64-bit Windows.


LogParser is available from the following URL:


[https://www.iis.net/go/1287](https://www.microsoft.com/en-us/download/details.aspx?id=24659)

> [!NOTE]
> LogParser is a 32-bit application, but you can use it on a 64-bit Windows system.


While it's not essential, copying LogParser.exe to a folder in your PATH will allow you to run LogParser from any folder on your system.

<a id="001b"></a>

### UrlScan Log Files

#### Locating your UrlScan Log Files

By default UrlScan installs to %WinDir%\System32\Inetsrv\UrlScan, and this is where your UrlScan.ini file should be located. (If you installed to a different location, you would need to locate your installation by searching for your UrlScan.ini file.) In the **[Options]** section of the UrlScan.ini file you should see an entry for **LoggingDirectory** that is set "Logs" by default, which means that your default directory for UrlScan log files is %WinDir%\System32\Inetsrv\UrlScan\Logs.

#### Log File Names

UrlScan log files are named using the following syntax:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample1.cmd)]


Where:


| mm | = | Month |
| --- | --- | --- |
| dd | = | Day |
| yy | = | Year |


#### Log File Fields

The following table lists the fields that are available:


| Field | Description |
| --- | --- |
| Date | Request date in YYYY-MM-DD format |
| Time | Request time in UTC time |
| c-ip | IP address of the client that made the request |
| s-siteid | ID of the web site that received the request |
| cs-method | HTTP method for the request |
| cs-uri | URL for the request |
| x-action | Action taken; for example: - Logged and allowed - Rejected |
| x-reason | Reason for action; for example: - a request header was too long - content length too long - disallowed header detected - disallowed query string sequence detected - disallowed url sequence detected - dot in path detected - extension not allowed - failed urlscan rules - high bit character detected - query string too long - second pass normalization failure - url too long - verb not allowed |
| x-context | Part of request that triggered the action; for example: - Content-Length - file extension - HTTP\_ALL\_RAW - HTTP method - query string - request headers - URL |
| cs-data | The request data that triggered the action. |
| x-control | Config control data that caused the trigger. For example, if a request was rejected because of a deny string from a UrlScan rule, the specific deny string will be listed. |


<a id="002"></a>

## Querying Data

<a id="002a"></a>

### Simple Queries

#### Selecting Everything

The simplest (and least useful) query that you can issue is the following, which is listed here just to get us started:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample2.cmd)]


Let's analyze what this query does:

1. Selects all fields ("SELECT \*") from all records in all log files ("FROM UrlScan.\*.log")
2. Specifies the log file input type as "W3C Format" ("-i:w3c")

> [!NOTE]
> Specifying the input file format as "W3C Format" is essential - without that step you would not be able to parse your UrlScan logs.

#### Selecting Specific Fields to Query

You can restrict the amount of data that you see by specifying which fields to return:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample3.cmd)]


Here's what this query does:

1. Selects only four specific fields ("SELECT date,time,c-ip,x-action") from all records in all log files ("FROM UrlScan.\*.log")
2. Specifies the log file input type as "W3C Format" ("-i:w3c")

This allows you to greatly reduce the amount of information that you see in your results.

#### Exporting Logs into a Different Format

As mentioned earlier, selecting all of the records in all of your logs is probably not all that helpful, unless you were interested in parsing your UrlScan information using another application, like Microsoft Excel, Microsoft Access, SQL Server, etc. In which case, you might want to export all of your data into a comma-delimited file like the following example:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample4.cmd)]


Here's what this query does:

1. Selects all fields ("SELECT \*") from all records in all log files ("FROM UrlScan.\*.log")
2. Inserts from all records into a comma-delimited file ("INTO UrlScan.csv")
3. Specifies the input file type as "W3C Format" ("-i:w3c")
4. Specifies the output file type as "CSV Format" ("-o:csv")

You could just as easily export into a tab-separated file using the following syntax:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample5.cmd)]


<a id="002b"></a>

### Filtering Queries

One of the great things about LogParser and SQL queries in general is that you can filter the amount of data that you see by specifying criteria using a WHERE clause. The following

#### Filtering based on IP Address

For example, to see all of the requests from a specific client IP address, you could use the following syntax:


[!code-sql[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample6.sql)]


Here's what this query does:

1. Selects all fields ("SELECT \*") from all records in all log files ("FROM UrlScan.\*.log")
2. Filters the results based on a specific client IP address ("WHERE c-ip='192.168.1.1'")
3. Specifies the input file type as "W3C Format" ("-i:w3c")

#### Filtering based on UrlScan Action

You can also filter based on UrlScan rejections using the following syntax:


[!code-sql[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample7.sql)]


Here's what this query does:

1. Selects all fields ("SELECT \*") from all records in all log files ("FROM UrlScan.\*.log")
2. Filters the results where UrlScan rejected the request ("WHERE x-action='Rejected'")
3. Specifies the input file type as "W3C Format" ("-i:w3c")

#### Filtering based on Uniqueness

You can filter the amount of data that you see by specifying which fields to return and grouping the data based on uniqueness. This is done by adding the DISTINCT clause as seen in the following syntax:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample8.cmd)]


Here's what this query does:

1. Selects only the unique client IP addresses ("SELECT DISTINCT c-ip") from all records in all log files ("FROM UrlScan.\*.log")
2. Specifies the input file type as "W3C Format" ("-i:w3c")

<a id="002c"></a>

### Grouping, Tabulating, and Sorting Queries

#### Counting Requests by Fields

Another great feature of SQL-style queries is the ability to tabulate data. The following example shows how retrieve a count of requests based on the client IP address:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample9.cmd)]


Here's what this query does:

1. Selects only the client IP address and request count ("SELECT c-ip, COUNT(\*)") from all records in all log files ("FROM UrlScan.\*.log")
2. Groups the request count based on the client IP address ("GROUP BY c-ip")
3. Specifies the input file type as "W3C Format" ("-i:w3c")

#### Sorting Data by Fields

You can reorder your results into something more useful using the ORDER BY clause, as illustrated in the following example:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample10.cmd)]


Here's what this query does:

1. Selects four specific fields ("SELECT x-action,x-reason,c-ip,cs-uri") from all records in all log files ("FROM UrlScan.\*.log")
2. Sorts the data in ascending order based on the UrlScan action and reason for the action ("ORDER BY x-action,x-reason")
3. Specifies the input file type as "W3C Format" ("-i:w3c")

<a id="003"></a>

## Putting it All Together

<a id="003a"></a>

#### Counting Requests by Client IP and Sorting Data by Request Count

Starting with the request count query from a previous example, you can rename the request count field to something more useful using the AS clause, as illustrated in the following example:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample11.cmd)]


This helps reorder the data based on the count, as shown in the following example:


[!code-console[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample12.cmd)]


Here's what this query does:

1. Selects only the client IP address and request count ("SELECT c-ip, COUNT(\*)") from all records in all log files ("FROM UrlScan.\*.log")
2. Groups the request count based on the client IP address ("GROUP BY c-ip")
3. Sorts the data in descending order based on the request count ("ORDER BY c-request-count DESC")
4. Specifies the input file type as "W3C Format" ("-i:w3c")

<a id="003b"></a>

#### Counting Rejected Requests based on the Reason for Rejections

While somewhat similar to the previous example, the following syntax will filter the results based on rejections and count the number of times that each reason occurs:


[!code-sql[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample13.sql)]


Here's what this query does:

1. Selects only the reason and request count ("SELECT x-reason, COUNT(\*)") from all records in all log files ("FROM UrlScan.\*.log")
2. Filters the results based on rejections ("WHERE x-action='Rejected'")
3. Groups the request count based on the reason ("GROUP BY x-reason")
4. Sorts the data in descending order based on the request count ("ORDER BY c-request-count DESC")
5. Specifies the input file type as "W3C Format" ("-i:w3c")

<a id="003c"></a>

#### Splitting Requests into Separate Log Files based on Site ID

UrlScan writes all log entries to a common log file, but you may want to see your data separated by site. The following example splits your UrlScan logs into separate files by site by creating unique log files that are named for each site ID. This example is a little more complex than previous examples, and is written as a batch file.


[!code-sql[Main](data-mining-urlscan-3-logs-using-logparser-22/samples/sample14.sql)]


Here's what this batch file does:

1. Creates a tab-separated file that contains a list of unique site IDs
2. Creates a loop to step through the tab-separated file containing the site IDs
3. Selects all fields for the specific site ID and creates a new W3C format file for each site