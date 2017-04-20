---
title: "Advanced Logging for IIS - Real-Time Logging | Microsoft Docs"
author: rick-anderson
description: "IIS Advanced Logging can extend the web platform to support real-time analytics, helping you to provide real-time reports to customers or work with partners..."
ms.author: iiscontent
manager: soshir
ms.date: 03/18/2009
ms.topic: article
ms.assetid: c67c1a64-fd08-491e-bd19-7aa19279c84d
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/advanced-logging-module/advanced-logging-for-iis-real-time-logging
msc.type: authoredcontent
---
Advanced Logging for IIS - Real-Time Logging
====================
by [Vishal Sood](https://twitter.com/vishalsood)

IIS Advanced Logging can extend the web platform to support real-time analytics, helping you to provide real-time reports to customers or work with partners to do the same. The Advanced Logging feature contains an option that enables consumption of log entries in real-time. It aggregates all of the events sent to it during each request and the log definition property ***publishLogEvent*** controls whether real-time events are raised for consumption by other applications.

<a id="requirements"></a>

## Requirements

- This article is intended for developers and assumes basic native code writing skills.
- An understanding of the IIS pipeline isn't required; however, it might help to review the articles listed in the [References](advanced-logging-for-iis-real-time-logging.md#references) section to learn more about the methods and data structures that are used.
- For information about how to install and use IIS Advanced Logging, see [Advanced Logging for IIS - Custom Logging](advanced-logging-for-iis-custom-logging.md).

## Enabling Real-time Logging

Real-time logging is a per-log-definition setting in IIS Advanced Logging. To enable real-time logging for a log definition, do the following:

1. In IIS Manager, open the Advanced Logging feature. Click the server in the **Connections** pane, and then double-click the **Advanced Logging** icon on the **Home** page.  
    [![](advanced-logging-for-iis-real-time-logging/_static/image2.jpg)](advanced-logging-for-iis-real-time-logging/_static/image1.jpg)
2. Enable the Advanced Logging feature. In the **Actions** pane, click **Enable Advanced Logging**.  
    [![](advanced-logging-for-iis-real-time-logging/_static/image4.jpg)](advanced-logging-for-iis-real-time-logging/_static/image3.jpg)
3. Select the log definition for which you want to enable real-time logging.

    1. In IIS Manager, open the Advanced Logging feature at the server, website, directory, or application level.
    2. In the **Advanced Logging** feature page, click the log definition, and then in the **Actions** pane, click **Edit Log Definition**.  
        [![](advanced-logging-for-iis-real-time-logging/_static/image6.jpg)](advanced-logging-for-iis-real-time-logging/_static/image5.jpg)
4. Enable real-time logging of events for the selected log definition by selecting the **Publish real-time events** check box.  
    [[![](advanced-logging-for-iis-real-time-logging/_static/image9.jpg)](advanced-logging-for-iis-real-time-logging/_static/image8.jpg)](advanced-logging-for-iis-real-time-logging/_static/image7.jpg)
5. Write an IIS module that consumes the events in real time, as described in the following [section](advanced-logging-for-iis-real-time-logging.md#module).

<a id="module"></a>

## Writing an IIS Module to Consume Real-Time Events

To log the real-time events raised by the Advanced Logging feature, you must create an IIS module. This section reviews the IIS tracing infrastructure and provides sample code in a compressed (zipped) folder for creating a simple module that you can use as a reference.

> [!NOTE]
> The sample code hasn't been tested for memory leaks and other issues and is intended to be used as a reference only.


### IIS Tracing Infrastructure

This section describes some IIS tracing concepts that are used for logging real-time events.

#### IGlobalTraceEventProvider::GetTraceEvent Method

To consume the real-time events raised by Advanced Logging, the IIS module that you create must register for global events. The **OnGlobalTraceEvent** method should be called for every event that is raised by the system. Registering for it gives you access to the real-time logging events. For more information, see [CGlobalModule::OnGlobalTraceEvent Method](https://go.microsoft.com/?linkid=9656643).

#### Data Structures

##### HTTP\_TRACE\_EVENT Structure

The **HTTP\_TRACE\_EVENT** structure forms the backbone of the real-time logging infrastructure. The real-time logging information is passed in the form of this structure.


[!code-console[Main](advanced-logging-for-iis-real-time-logging/samples/sample1.cmd)]


For more information about this structure, see [HTTP\_TRACE\_EVENT Structure](https://go.microsoft.com/?linkid=9656644).

##### HTTP\_TRACE\_EVENT\_ITEM Structure

The **HTTP\_TRACE\_EVENT** structure contains one or more **HTTP\_TRACE\_EVENT\_ITEM** structures, depending on the number of logging fields included in the log definition for which a log was generated.


[!code-console[Main](advanced-logging-for-iis-real-time-logging/samples/sample2.cmd)]


For more information about this structure, see [HTTP\_TRACE\_EVENT\_ITEM Structure](https://go.microsoft.com/?linkid=9656645).

#### pProviderGuid

The HTTP\_TRACE\_EVENT structure contains the **pProviderGuid** property, an LPCGUID that contains the provider identifier. It's important to understand its significance.

As described in [CAnalyticsGlobalModule::OnGlobalTraceEvent](advanced-logging-for-iis-real-time-logging.md#canalyticsglobalmodule), **OnGlobalTraceEvent** is called for every event that is raised by the system. This means that you must filter unwanted events from the incoming events so that only the events of interest (real-time logging events) are available for consumption. You can do this by using the **pProviderGuid** property value **3C729B22-F9A9-4096-92A4-07E0DDF403EB**.


[!code-csharp[Main](advanced-logging-for-iis-real-time-logging/samples/sample3.cs)]


The [Sample Code](advanced-logging-for-iis-real-time-logging.md#samplecode) uses this value to filter out the unwanted events.

<a id="samplecode"></a>

### Sample Code

This section displays sample code that illustrates the real-time logging concepts described previously in this article. Download [CAnalyticsGlobalModule.zip](advanced-logging-for-iis-real-time-logging/_static/advanced-logging-for-iis---real-time-logging-581-canalyticsglobalmodule1.zip), a copy of the sample code in a compressed (zipped) folder.

> [!NOTE]
> The sample code hasn't been tested for memory leaks and other issues and is intended to be used as a reference only.


<a id="canalyticsglobalmodule"></a>

#### CAnalyticsGlobalModule::OnGlobalTraceEvent


[!code-csharp[Main](advanced-logging-for-iis-real-time-logging/samples/sample4.cs)]


#### ProcessLogEvent

The **ProcessLogEvent** method copies the logging data into a local data structure so that it can be used later to push data to a web service or database.

> [!NOTE]
> The data in the request itself shouldn't be processed as that might cause the request to slow responses to clients.
> 
> [!NOTE]
> The code for **ProcessLogEvent** should be aware that memory used by events might be temporary memory allocated by **AllocateRequestMemory**. To unblock the thread, the data should be copied.


[!code-csharp[Main](advanced-logging-for-iis-real-time-logging/samples/sample5.cs)]

<a id="summary"></a>

## Summary

In this walkthrough, we reviewed how real-time logging works in the IIS Advanced Logging feature and how to consume logging data in real-time by creating a simple IIS module.

<a id="references"></a>

## References

- [Creating Native-Code HTTP Modules](https://go.microsoft.com/?linkid=9656646)
- [IGlobalTraceEventProvider::GetTraceEvent Method](https://go.microsoft.com/?linkid=9656647)
- [HTTP\_TRACE\_EVENT Structure](https://go.microsoft.com/?linkid=9656644)
- [HTTP\_TRACE\_EVENT\_ITEM Structure](https://go.microsoft.com/?linkid=9656645)
- [CGlobalModule::OnGlobalTraceEvent Method](https://go.microsoft.com/?linkid=9656643)
- [Develop a Native C\C++ Module for IIS](https://go.microsoft.com/?linkid=9656651)
- [CAnalyticsGlobalModule.zip](advanced-logging-for-iis-real-time-logging/_static/advanced-logging-for-iis---real-time-logging-581-canalyticsglobalmodule2.zip) (copy of sample code)