---
title: "Bit Rate Throttling Extensibility Walkthrough | Microsoft Docs"
author: rick-anderson
description: "Bit Rate Throttling for Internet Information Services (IIS) provides the ability to throttle progressive downloads of media files (in which audio/video playb..."
ms.author: iiscontent
manager: soshir
ms.date: 11/23/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-media
ms.prod: iis
msc.legacyurl: /learn/media/bit-rate-throttling/bit-rate-throttling-extensibility-walkthrough
msc.type: authoredcontent
---
Bit Rate Throttling Extensibility Walkthrough
====================
by [Vishal Sood](https://twitter.com/vishalsood)

Bit Rate Throttling for Internet Information Services (IIS) provides the ability to throttle progressive downloads of media files (in which audio/video playback starts as soon as sufficient data has been buffered on the client) based on the content bit rate. For sites that deliver audio and video files that may not be watched in their entirety, this module can significantly reduce your media-related bandwidth costs. A secondary feature of Bit Rate Throttling is that it can also be used to throttle non-media ("data") file types at specified bit rates.

For media files, automatic bit rate detection and throttling are executed according to settings specified in the IIS configuration settings. New settings can be added, and existing settings can be adjusted, to achieve significant bandwidth savings without compromising the client experience. The media throttle settings can only be applied to defined media file types, so Bit Rate Throttling also provides a way to extend support to other media file types, or to override the definitions for existing file types, through an extensible XML schema interface.

The list of supported media file types is determined by the settings in the IIS configuration file. By default, Bit Rate Throttling comes with pre-configured support for the following media file types:

- .asf
- .avi
- .flv
- .m4v
- .mov
- .mp3
- .mp4
- .rm
- .rmvb
- .wma
- .wmv

This article describes the steps needed to effectively use the Bit Rate Throttling extensibility interface. It also describes the schema elements and steps on how to add support for a media file type.

This article contains the following sections:

- [Prerequisites](bit-rate-throttling-extensibility-walkthrough.md#Prerequisites)
- [Creating a Media Format Rule (MFR)](bit-rate-throttling-extensibility-walkthrough.md#Creating)
- [Applying the MFR to the Configuration Store](bit-rate-throttling-extensibility-walkthrough.md#Applying)
- [Throttling with Server Variables](bit-rate-throttling-extensibility-walkthrough.md#Variables)
- [Appendix: Bit Rate Throttling Schema](bit-rate-throttling-extensibility-walkthrough.md#Appendix)

<a id="Prerequisites"></a>

## Prerequisites

To install the Bit Rate Throttling extension for IIS 7.0 and above, see the **Installation Notes** section in the [IIS Media Services Readme](../iis-media-services/iis-media-services-readme.md).

<a id="Creating"></a>

## Creating a Media Format Rule (MFR)

Bit Rate Throttling provides support for throttling a media format based on the encoded bit rate of the media content. As a first step towards this goal, we must determine the bit rate of the media content in question.

Bit Rate Throttling has a concept of media format rules. These rules are expressed in XML format and provide the information necessary to retrieve the bit rate information for the media content file. The bit rate information can be present in the media file either as some form of bit rate field, or in the form of a duration field, which can be used to divide the file size and approximate the encoded bit rate. Bit Rate Throttling supports both methods of retrieving bit rate information. There are two kinds of Media Format rules: Bit Rate and Duration. Before discussing these two rules, there are useful general guidelines to keep in mind.

### MFR Guidelines

Keep these guidelines in mind when dealing with Media Format rules.


1. **Rules are format specific** – A rule is applicable to only a particular media format type per the configuration schema. Media format types are determined by the file name extensions.
2. **There can be multiple rules for a particular format**– A particular media format can have multiple rules. This is necessary, as some formats may store separate bit rate information for audio and video. This is also useful for Multiple Bit Rate (MBR) content.
3. **Multiple rules add up** – When there are multiple rules for a particular media format, the computed bit rate is based on the sum of all the individual rules.
4. **Bit Rate rules override Duration rules** – When you specify both Bit Rate and Duration rules for a particular format, Bit Rate rules apply and Duration rules are ignored.
5. **Do not play with rules unless you know what you are doing***–* This is very important to note. These rules are very useful and provide great benefits. At the same time, these rules impact all files with a particular file name extension. Thus, it is very important that you understand the possible impact when you create custom media format rules. As a best practice, create a backup copy of the IIS ApplicationHost.config file before you begin creating or editing Media Format rules.


### Bit Rate Rules

The Bit Rate rules tell Bit Rate Throttling how to directly retrieve the bit rate information from the media file format. The rule supports the attributes shown in the following table. The bit rate information is stored in different ways in different formats.

A Bit Rate rule contains the following fields:


| Rule Attribute | Required | Type | Permissible Values | Default Value | Description |
| --- | --- | --- | --- | --- | --- |
| searchPattern | N | String | Any string | NA | The search string to locate the bit rate information. The interpretation of searchPattern string depends on the searchPatternType attribute. The searchPattern will only be searched in the search range defined by searchRangeStart and searchRangeEnd. |
| searchPatternType | N | Enum | hexValue, stringValue | NA | The type of the searchPattern – hex or string. **hexValue**: The search pattern represents the actual hex value in the file. For example, if you want to look for string "bitrate" in the file, you need to set searchPattern to "62697472617465" ("0x62" is 'b', "0x69" is 'i' and so on). **stringValue**: The search pattern represents the string value to be searched. Only ASCII characters are allowed here and it is case-sensitive. For example, if you want to look for string "bitrate" in the file, you need to set searchPattern to "bitrate". |
| searchRangeStart | N | Int64 | Any 64-bit integer | 0 | The start offset for the search relative to the beginning of the file or the end of the file (Also see "searchFrom"). This should be a positive number only. |
| searchRangeEnd | N | Int64 | Any 64-bit integer | 4096 | The end offset for the search relative to the beginning of the file or the end of the file (Also see "searchFrom"). This should be a positive number only. |
| searchFrom | N | Enum | beginning, end, both | beginning | Specifies the search direction relative to the file. **beginning**: This is for forward search. This means the search is calculated from the beginning of the file. For example, if you want to search for data in the first 1000 bytes in the file, you set searchRangeStart to 0 and searchRangeEnd to 1000 with searchFrom being "beginning". **end:** This is for backward search. This means the search is started from the end of the file towards the beginning. For example, if you want to search for data in the last 1000 bytes in the file, you set searchRangeStart to 0 and searchRangeEnd to 1000 with searchFrom being "end". **both:** means the search will be executed both from the beginning of the file and the end of the file. For example, if you set searchRangeStart to 0 and searchRangeEnd to 1000 with searchFrom being "both", it will first search through the first 1000 bytes of the file and then search through the last 1000 bytes of the file. Note that if the search in the beginning of the file succeeded, the module would skip the search from the end of the file. |
| dataOffset | N | Uint | Any unsigned integer | 0 | The offset bit from the search location. If the searchPattern is specified, this value would specify the offset from the end of the search pattern. |
| dataType | Y | Enum | uint16, uint32, float, double | NA | The type of the data located at the dataOffset (see dataOffset above). **unit16**: 16-bit unsigned **uint32**: 32-bit unsigned **float**: 32-bit single point float **double**: 64-bit double point double |
| endianness | N | Enum | bigEndian, littleEndian | bigEndian | The byte order. |
| unitBitPerSecond | N | Uint | Any unsigned integer | 1 | The bit rate multiplier. For example, a value of **1** means the bit rate data is expressed in bits per second (bps), while a value of **1000** for this parameter means the bit rate data is expressed in kilobits per second (kbps). |


**Table 1: Bit Rate Rule attributes**

Here are some examples of the bit rate rules:


[!code-xml[Main](bit-rate-throttling-extensibility-walkthrough/samples/sample1.xml)]


### Duration Rules

Duration rules are similar to the Bit Rate rules, but the value obtained from the media file depicts the duration of the content rather than the bit rate. In terms of the attributes, Duration rules are also similar to the Bit Rate rules, with just one difference. In the case of Duration rule, we do not have a **unitBitPerSecond** attribute; the unit is instead determined by the **timeScale** element. The **timeScale** element essentially specifies the unit of the Duration field and can also be searched and obtained from the file, just as it is possible with Duration and Bit Rate. Alternatively, **timeScale** could also be a constant value specified by the **constScale** attribute.

There are two parts to a Duration rule: **duration** and **timeScale**.


- **duration** – This sub-rule contains all the information to determine the duration value for a media format, in units of time.
- **timeScale**– This sub-rule contains all the information to determine the units of time in which **duration** is expressed, which can then be used as a multiplier to convert the search results of the duration rule into seconds.


These two parts are represented as separate elements in the schema. The element attributes are defined in following tables.


| Rule Attribute | Required | Type | Permissible Values | Default Value | Description |
| --- | --- | --- | --- | --- | --- |
| searchPattern | N | String | Any string | NA | The search string to locate the duration information. The interpretation of searchPattern string depends on the searchPatternType attribute. |
| searchPatternType | N | Enum | hexValue, stringValue | NA | The type of the searchPattern – hex or string. **hexValue**: The search pattern represents the actual hex value in the file. **stringValue**: The search pattern represents the string value to be searched. Only ASCII characters are allowed here and it is case-sensitive. |
| searchRangeStart | N | Int64 | Any 64-bit integer | 0 | The start offset for the search relative to the beginning of the file or the end of the file (also see "searchFrom"). |
| searchRangeEnd | N | Int64 | Any 64-bit integer | 4096 | The end offset for the search relative to the beginning of the file or the end of the file (see "searchFrom"). |
| searchFrom | N | Enum | beginning, end, both | beginning | Specifies the search direction relative to the file. **beginning**: This is for forward search. This means the search is calculated from the beginning of the file. For example, if you want to search for data in the first 1000 bytes in the file, you set searchRangeStart to 0 and searchRangeEnd to 1000 with searchFrom being "beginning". **end:** This is for backward search. This means the search is started from the end of the file towards the beginning. For example, if you want to search for data in the last 1000 bytes in the file, you set searchRangeStart to 0 and searchRangeEnd to 1000 with searchFrom being "end". **both:** means the search will be executed both from the beginning of the file and the end of the file. For example, if you set searchRangeStart to 0 and searchRangeEnd to 1000 with searchFrom being "both", it will first search through the first 1000 bytes of the file and then search through the last 1000 bytes of the file. Note that if the search in the beginning of the file succeeded, the module would skip the search from the end of the file. |
| dataOffset | N | Uint | Any unsigned integer | 0 | The offset bit from the search location. If the searchPattern is specified, this value would specify the offset from the end of the search pattern. |
| dataType | Y | Enum | uint16, uint32, float, double | NA | The type of the data located at the dataOffset (see dataOffset above). **unit16**: 16-bit unsigned; **uint32**: 32-bit unsigned **float**: 32-bit single point float **double**: 64 -bit double point double |
| endianness | N | Enum | bigEndian, littleEndian | bigEndian | The byte order. |


**Table 2: Duration Element attributes**


| Rule Attribute | Required | Type | Permissible Values | Default Value | Description |
| --- | --- | --- | --- | --- | --- |
| constScale | N | Uint | Any unsigned integer | 0 | Specifies whether to use a constant **timeScale** for all files of this type, or whether to calculate the **timeScale** for each file of this type. If any non-zero value is specified for this attribute, then all the other attributes will be ignored and this would be taken as the **timeScale**. The specified number would then be used as a multiplier to convert the duration data into seconds. For example, if the parsed number from the "duration" element will stand for milliseconds in all files of this type, the timeScale should be specified as 1000. |
| searchPattern | N | String | Any string | NA | The search string to locate the time scale information. The interpretation of searchPattern string depends on the searchPatternType attribute. |
| searchPatternType | N | Enum | hexValue, stringValue | NA | The type of the searchPattern – hex or string. **hexValue**: The search pattern represents the actual hex value in the file. **stringValue**: The search pattern represents the string value to be searched. Only ASCII characters are allowed here and it is case-sensitive. |
| searchRangeStart | N | Int64 | Any 64-bit integer | 0 | The start offset for the search relative to the beginning of the file or the end of the file (also see "searchFrom"). |
| searchRangeEnd | N | Int64 | Any 64-bit integer | 4096 | The end offset for the search relative to the beginning of the file or the end of the file (see "searchFrom"). |
| searchFrom | N | Enum | beginning, end, both | beginning | This specifies the search direction relative to the file. **beginning**: This is for forward search. This means the search is calculated from the beginning of the file. For example, if you want to search for data in the first 1000 bytes in the file, you set searchRangeStart to 0 and searchRangeEnd to 1000 with searchFrom being "beginning". **end:** This is for backward search. This means the search is started from the end of the file towards the beginning. For example, if you want to search for data in the last 1000 bytes in the file, you set searchRangeStart to 0 and searchRangeEnd to 1000 with searchFrom being "end". **both:** means the search will be executed both from the beginning of the file and the end of the file. For example, if you set searchRangeStart to 0 and searchRangeEnd to 1000 with searchFrom being "both", it will first search through the first 1000 bytes of the file and then search through the last 1000 bytes of the file. Note that if the search in the beginning of the file succeeded, the module would skip the search from the end of the file. |
| dataOffset | N | Uint | Any unsigned integer | 0 | The offset bit from the search location. If the searchPattern is specified, this value would specify the offset from the end of the search pattern. |
| dataType | Y | Enum | uint16, uint32, float, double | NA | The type of the data located at the dataOffset (see dataOffset above). **unit16**: 16-bit unsigned; **uint32**: 32-bit unsigned **float**: 32-bit single point float **double**: 64-bit double point double |
| endianness | N | Enum | bigEndian, littleEndian | bigEndian | The byte order. |


**Table 3: timeScale attributes**

Here are some examples of Duration rules:


[!code-xml[Main](bit-rate-throttling-extensibility-walkthrough/samples/sample2.xml)]

<a id="Applying"></a>

## Applying the MFR to the Configuration Store

These rules are stored in the IIS configuration file ApplicationHost.config. After you create rules to support additional media formats, they must be added to the ApplicationHost.config file. There are two recommended ways to do this:

### Manual Edit


1. Using a text editor, open the file located under your IIS install root directory (%*windir*%\system32\inetsrv\config\ApplicationHost.config).
2. Locate the media formats section under the System.webserver -&gt; media section.
3. Manually add the new media format rule (&lt;add&gt; …. &lt;/add&gt;) just before the &lt;/mediaformats&gt; tag in the file.


### AppCmd

Add the rule using AppCmd.exe. For example, add the following rule:


[!code-xml[Main](bit-rate-throttling-extensibility-walkthrough/samples/sample3.xml)]


The AppCmd commands then look like:


[!code-console[Main](bit-rate-throttling-extensibility-walkthrough/samples/sample4.cmd)]

<a id="Variables"></a>

## Throttling with Server Variables

In certain circumstances, it may be desirable or necessary to programmatically specify an explicit throttling rate on a per-request basis. This can be achieved by setting the server variables described in this section via the SetServerVariable method. The values in the server variables override the config for the particular response they are specified for.

### Server Variables

- **ResponseThrottler-Enabled** - Enables/Disables throttling for the particular request. A value of **0** indicates disabled while any other value means Bit Rate Throttling is enabled.
- **ResponseThrottler-InitialSendSize** - The initial send size, specified in kilobytes (KB), that is initially sent to the client at an unthrottled rate to provide the Fast Start experience. This can be used together with ***ResponseThrottler-Rate***.
- **ResponseThrottler-Rate**- The throttle rate, specified in kilobits per second (kbps), at which the response will be throttled after any specified Fast Start burst is delivered. This may be used together with ***ResponseThrottler-InitialSendSize***.
- **ResponseThrottler-FileExtension** - A string that specifies the file name extension for the request (for example, ***wmv***). This must be specified along with ***ResponseThrottler-EncodedBitRateKbps***. This is applicable for media responses only.
- **ResponseThrottler-EncodedBitRateKbps -** The encoded bit rate for the content being served in the response (for example, 1000). This must be specified along with ***ResponseThrottler-FileExtension.*** This is applicable to media responses only.
- **ResponseThrottler-ThrottleRatePercentage** - Specifies the throttle rate, in percent. to be applied to the request (for example, 110). This is applicable for media responses only. This may be used together with ***ResponseThrottler-InitialBufferTimeSeconds.***
- **ResponseThrottler-InitialBufferTimeSeconds** - Specifies the initial buffer time during which the response in unthrottled for fast startup (for example, 20). This is applicable for media responses only. This may be used together with ***ResponseThrottler-ThrottleRatePercentage***.

> [!NOTE]
> For any of the server variables to work, Bit Rate Throttling must be enabled.

### Precendence Order

A throttle rate specified via SetServerVariable overrides any throttling values already set in the ApplicationHost.config or web.config files. However, the new throttle rate is still subject to the Maximum Throttle Rate value (if specified). Again, a throttle rate specified via SetServerVariable is per-request only. The rate is not be persisted across requests.

The precedence order is in the following sequence:

1. If Bit Rate Throttling is disabled, none of the server variables apply.
2. If **ResponseThrottler-Enabled** has a value of **0**, none of the other server variables are considered and response goes unthrottled. All values other than **0** for this variable mean throttling is enabled for the response.
3. When **ResponseThrottler-Rate** is specified, it is used as the throttle rate for the request. The variable **ResponseThrottler-InitialSendSize** may be additionally specified and used. All other variables below are not evaluated when these are specified.
4. When **ResponseThrottler-Rate** is not specified, other media-specific variables may be specified in the following order:

    1. **ResponseThrottler-FileExtension** and **ResponseThrottler-EncodedBitRateKbps** must be specified together. This overrides content detection in Bit Rate Throttling. The file name extensions are used to look up the rules from the config and encoded bit rate is used when computing throttle rate.
    2. When **ResponseThrottler-ThrottleRatePercentage** is specified, it is used and value in the config is disabled. In addition, **ResponseThrottler-InitialBufferTimeSeconds** may be used to specify the Fast Start interval.
5. When none of the server variables are present, the stored configuration is used to determine throttling behavior.

### Setting the Server Variables Programmatically

To control the Bit Rate Throttling dynamically, you can use either C++ or managed code:

1. Build an IIS module, which is similar to the ISAPI filter in previous IIS versions. Use a module if you want programmatic throttling to apply to some or all requests based on arbitrary rules.
2. Build an IIS handler, which is similar to the ISAPI extension in previous IIS versions. Use a handler if you want programmatic throttling to apply only to requests for a specific URL or file type.

If you want to write a module with managed code, use the **HttpRequest.ServerVariables** property. The module would look something like the following code sample, where:

- In **BeginRequest**, you would read the **app.Context.Request.PhysicalPath** to determine the appropriate throttling rate, probably based on the file type.
- "foo" is either **ResponseThrottler-InitialSendSize** or **ResponseThrottler-Rate**.
- "bar" is the corresponding initial send size or throttling rate respectively (for example, 6000 or 300).


[!code-csharp[Main](bit-rate-throttling-extensibility-walkthrough/samples/sample5.cs)]


For C++, the API is similar, but you build a CHttpModule using the **IHttpContext::SetServerVariable** method. If you are building a managed handler, use the **System.Web.IHttpHandler** interface to produce an HTTP response for the specific content you want to throttle.

For performance, using C++ is recommended, because this will likely save you some unnecessary managed code transitions. However, in terms of simplicity, building the managed code module requires very little code and no compilation – just save it inside the %*systemdrive*%\inetpub\wwwroot\App\_Code directory.

<a id="Appendix"></a>

## Appendix: Bit Rate Throttling Schema

The following is the schema for specifying the Bit Rate Rules and Duration Rules:


[!code-xml[Main](bit-rate-throttling-extensibility-walkthrough/samples/sample6.xml)]


[Discuss in IIS Forums](https://forums.iis.net/1145.aspx)