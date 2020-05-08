---
title: "UrlScan 1 Reference"
author: rmcmurray
description: "Note : UrlScan 1.0 has been replaced by UrlScan 3.1 and should not be used. If you are using UrlScan 1.0, you should download and install the latest version...."
ms.date: 07/15/2010
ms.assetid: f0de02bb-1fed-45d5-a674-c398d6cdadc5
msc.legacyurl: /learn/extensions/working-with-urlscan/urlscan-1-reference
msc.type: authoredcontent
---
UrlScan 1 Reference
====================
by [Robert McMurray](https://github.com/rmcmurray)

> [!NOTE]
> UrlScan 1.0 has been replaced by [UrlScan 3.1](urlscan-3-reference.md) and should not be used. If you are using UrlScan 1.0, you should download and install the latest version. The information on this page is included only as a reference.

UrlScan 1.0 was the first version of UrlScan that Microsoft released as an ISAPI filter sample that helped reduce the attack surface for IIS versions 4.0 and 5.0. UrlScan 1.0 allows Web server administrations to define the list of HTTP verbs, headers, file name extensions, and character sequences that are allowed or denied on their servers. UrlScan 1.0 consists of the UrlScan ISAPI filter named UrlScan.dll and a configuration file named UrlScan.ini.

#### On This Page

- [Installing UrlScan 1.0](urlscan-1-reference.md#InstallingUrlScan)
- [Using UrlScan 1.0](urlscan-1-reference.md#UsingUrlScan)
- [UrlScan.ini Sections](urlscan-1-reference.md#UrlScanIniSections)

    - [[Options] Section](urlscan-1-reference.md#OptionsSection)
    - [[AllowVerbs] Section](urlscan-1-reference.md#AllowVerbsSection)
    - [[DenyVerbs] Section](urlscan-1-reference.md#DenyVerbsSection)
    - [[DenyHeaders] Section](urlscan-1-reference.md#DenyHeadersSection)
    - [[AllowExtensions] Section](urlscan-1-reference.md#AllowExtensionsSection)
    - [[DenyExtensions] Section](urlscan-1-reference.md#DenyExtensionsSection)
    - [[DenyUrlSequences] Section](urlscan-1-reference.md#DenyUrlSequencesSection)

<a id="InstallingUrlScan"></a>

## Installing UrlScan 1.0

UrlScan 1.0 required manual installation for IIS. The following steps will lead you through the steps to install UrlScan as a global ISAPI filter.

> [!NOTE]
> UrlScan may be installed as a site filter, but Microsoft recommends that UrlScan is installed as a global filter so that its functionality applies to the entire server.

1. Copy UrlScan.dll and UrlScan.ini into a local directory on the server. While it is not required, the suggested directory is:  
 `%SystemRoot%\System32\Inetsrv\UrlScan`
2. Open the Internet Information Services (IIS) 
    - Open the Windows Control Panel.
    - Double-click **Administrative Tools**.
    - Double-click **Internet Information Services**.
3. Open the global-level properties for your version of IIS: 

    - For IIS 4.0 or IIS 5.0: 

        - Right-click the server name and select **Properties**.
        - Ensure that **WWW Service** is displayed in the **Master Properties** drop down list, and click **Edit**.
    - For IIS 5.1 or IIS 6.0: 

        - Right-click the **Web Sites** node and select **Properties**.
4. Choose the **ISAPI Filters** tab.
5. Click **Add**.
6. When the ISAPI filter properties dialog is displayed, enter the following information: 

    - Enter "UrlScan" in the **Filter Name** box.
    - Enter the full path to the UrlScan.dll file in the **Executable** box.
7. Click **OK** to close each dialog that is open.
8. Restart the web service.

<a id="UsingUrlScan"></a>

## Using UrlScan 1.0

You configure UrlScan's operation by setting options in the UrlScan.ini file. This file should reside in the same directory as UrlScan.dll, and it contains the sections and options that are listed below.

> [!NOTE]
> For performance reasons, UrlScan only reads the UrlScan.ini file when IIS first loads the ISAPI filter. If you make changes to the UrlScan.ini file, you will need to stop and start the World-Wide-Web Publishing Service before your changes will be effective.

**Warning**: The default options built into UrlScan.dll will result in a configuration that will reject all requests to the server, therefore it is necessary to provide a UrlScan.ini file for IIS to serve HTTP requests when you are using UrlScan. A sample UrlScan.ini file is provided that contains several recommended settings to defend against known attacks on IIS servers.

<a id="UrlScanIniSections"></a>

## UrlScan.ini Sections

<a id="OptionsSection"></a>

### [Options] Section

The [Options] section of a UrlScan.ini file contains a list of name/value pairs that define the general behavior for UrlScan. A few of the settings enable or disable other sections in the UrlScan.ini file.

#### Enabling or Disabling other UrlScan.ini Sections

| UseAllowVerbs | Allowed values are 0 or 1. The default value for UseAllowVerbs is 1. If set to 1, UrlScan will read the [AllowVerbs] section of the UrlScan.ini file and reject any request containing an HTTP verb that is not explicitly listed. If set to 0, UrlScan will read the [DenyVerbs] section of the UrlScan.ini file and reject any request containing an HTTP verb listed. **Note:** The [AllowVerbs] section is case sensitive, but the [DenyVerbs] section is not case sensitive. |
| --- | --- |
| UseAllowExtensions | Allowed values are 0 or 1. The default value for UseAllowExtensions is 1. If set to 1, UrlScan will read the [AllowExtensions] section of the UrlScan.ini file and reject any request where the file name extension associated with the URL is not explicitly listed. If set to 0, UrlScan will read the [DenyExtensions] section of the UrlScan.ini file and reject any request where the file name extension associated with the request is listed. **Note:** The [AllowExtensions] and [DenyExtensions] sections are both case insensitive. |

#### URL Scanning Options

| NormalizeUrlBeforeScan | Allowed values are 0 or 1. The default value for NormalizeUrlBeforeScan is 1. If set to 1, UrlScan will do all of its analysis on the request URLs after IIS decodes and normalizes them. If set to 0, UrlScan will do all of its analysis on the raw URLs as sent by the client. **Note:** Only advanced administrators who are very knowledgeable about URL parsing should set this option to 0, as doing so will likely expose the IIS server to canonicalization attacks that bypass proper analysis of the URL extensions. |
| --- | --- |
| VerifyNormalization | Allowed values are 0 or 1. The Default value for VerifyNormalization is 1. If set to 1, UrlScan verifies normalization of the URL. This action will defend against canonicalization attacks, where a URL contains a double encoded string in the URL. For example, the string "%252e" is a double encoded dot '.' character because "%25" decodes to a '%' character, the first pass decoding of "%252e" results in "%2e", which can be decoded a second time into a single dot '.' string. If set to 0, UrlScan will not verify normalization of the URL. **Note:** This option is dependent on the NormalizeUrlBeforeScan option. |
| AllowHighBitCharacters | Allowed values are 0 or 1. The default value for AllowHighBitCharacters is 1. If set to 1, then UrlScan will allow any byte to exist in the URL. If set to 0, then UrlScan will reject any request where the URL contains a character outside of the ASCII character set. **Note:** This feature can defend against UNICODE or UTF-8 based attacks, but will also reject legitimate requests on IIS servers that use a non-ASCII code page. |
| AllowDotInPath | Allowed values are 0 or 1. The default value for AllowDotInPath is 1. If set to 1, UrlScan will allow requests that contain multiple instances of the dot (.) character in the URL. If set to 0, UrlScan will reject requests that contain multiple instances of the dot (.) character in the URL. **Note:** Because UrlScan operates at a level where IIS has not yet parsed the URL, it is not possible to determine in all cases whether a dot character denotes the extension or whether it is a part of the directory path or filename of the URL. For the purposes of extension analysis, UrlScan will always assume that an extension is the part of the URL beginning after the last dot in the string and ending at the first question mark or slash character after the dot or the end of the string. Setting AllowDotInPath to 0 defends against the case where an attacker uses path info to hide the true extension of the request; for example, "/path/TruePart.asp/FalsePart.htm". Setting AllowDotInPath to 0 also causes UrlScan to deny any request that contains a dot in a directory or file name. |

#### Logging Options

| EnableLogging | Allowed values are 0 or 1. The default value for EnableLogging is 1. If set to 1, UrlScan will log its actions in a file called UrlScan.log that will be created in the same directory that contains UrlScan.dll. If set to 0, UrlScan will not log any activity. |
| --- | --- |
| PerProcessLogging | Allowed values are 0 or 1. The default value of PerProcessLogging is 0. If set to 1, UrlScan will append the process ID of the IIS process that is hosting UrlScan.dll to the log file name; for example, UrlScan.1234.log. This feature is helpful for IIS versions that can host filters in more than 1 process concurrently, such as IIS 6.0 and later. If set to 0, UrlScan will log all activity in UrlScan.log. |

#### HTTP Server Header Manipulation

| RemoveServerHeader | Allowed values are 0 or 1. The default value for RemoveServerHeader is 1. If set to 1, UrlScan will remove the server header on all responses, and the value of AlternateServerName will be ignored. If set to 0, IIS will return the default server header on all responses. **Note:** This feature is only available if UrlScan is installed on IIS 4.0 or later. |
| --- | --- |
| AlternateServerName | Allowed value is a string. The default value for AlternateServerName is an empty string. If you specify a value for AlternateServerName and RemoveServerHeader is set to 0, then IIS will replace its default "Server:" header in all responses with the AlternateServerName value. If RemoveServerHeader is set to 1, the value of AlternateServerName will be ignored. **Note:** This feature is only available if UrlScan is installed on IIS 4.0 or later. |

##### Example [Options] Section

The following example [Options] section configures several recommended settings for UrlScan:

[!code-console[Main](urlscan-1-reference/samples/sample1.cmd)]

<a id="AllowVerbsSection"></a>

### [AllowVerbs] Section

The [AllowVerbs] section contains a list of HTTP verbs or methods. If UseAllowVerbs is set to 1 in the [Options] section, UrlScan will reject any request that contains an HTTP verb that is not explicitly listed in this section. The entries in this section are case sensitive.

##### Example [AllowVerbs] Section

The following example [AllowVerbs] section configures UrlScan to allow basic HTTP functionality:

[!code-console[Main](urlscan-1-reference/samples/sample2.cmd)]

To use this example, you would need to set UseAllowVerbs to 1 in the [Options] section.

<a id="DenyVerbsSection"></a>

### [DenyVerbs] Section

The [DenyVerbs] section contains a list of HTTP verbs or methods. If UseAllowVerbs is set to 0 in the [Options] section, UrlScan will reject any request that contains a verb that is listed in this section. The entries in this section are not case sensitive.

##### Example [DenyVerbs] Section

The following example [DenyVerbs] section configures UrlScan to deny several of the HTTP methods that are not required for basic HTTP functionality, such as WebDAV methods:

[!code-console[Main](urlscan-1-reference/samples/sample3.cmd)]

To use this example, you would need to set UseAllowVerbs to 0 in the [Options] section.

<a id="DenyHeadersSection"></a>

### [DenyHeaders] Section

The [DenyHeaders] section contains a list of request headers in the form "header-name:". Any request containing a request header listed in this section will be rejected. The entries in this section are not case sensitive.

##### Example [DenyHeaders] Section

The following example [DenyHeaders] section configures UrlScan to deny several HTTP headers that are used with WebDAV requests:

[!code-console[Main](urlscan-1-reference/samples/sample4.cmd)]

<a id="AllowExtensionsSection"></a>

### [AllowExtensions] Section

The [AllowExtensions] section contains a list of file name extensions in the form of ".ext". If UseAllowExtensions=1 is set in the [Options] section, then any request containing a URL with an extension not explicitly listed here is rejected. The entries in this section are not case sensitive.

##### Example [AllowExtensions] Section

The following example [AllowExtensions] section configures UrlScan to allow several static content types:

[!code-console[Main](urlscan-1-reference/samples/sample5.cmd)]

To use this example, you would need to set UseAllowExtensions to 1 in the [Options] section.

<a id="DenyExtensionsSection"></a>

### [DenyExtensions] Section

The [DenyExtensions] section contains a list of file name extensions in the form of ".ext". If UseAllowExtensions=0 is set in the [Options] section, then any request containing a URL with an extension listed here is rejected. The entries in this section are not case sensitive.

##### Example [DenyExtensions] Section

The following example [DenyExtensions] section configures UrlScan to allow several static content types:

[!code-console[Main](urlscan-1-reference/samples/sample6.cmd)]

To use this example, you would need to set UseAllowExtensions to 0 in the [Options] section.

<a id="DenyUrlSequencesSection"></a>

### [DenyUrlSequences] Section

The [DenyUrlSequences] section contains a list of character sequences that UrlScan will deny if they appear in a URL. For example, two dots ".." indicate a parent path, which a hacker might try to use to gain access to files outside of a Web site's content area.

##### Example [DenyUrlSequences] Section

The following example [DenyUrlSequences] section configures UrlScan to deny several URL sequences that could be used to attack your server:

[!code-console[Main](urlscan-1-reference/samples/sample7.cmd)]
