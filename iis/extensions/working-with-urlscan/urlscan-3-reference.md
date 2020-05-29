---
title: "UrlScan 3 Reference"
author: rmcmurray
description: "Note : UrlScan 3.0 has been replaced by UrlScan 3.1. If you are using UrlScan 3.0, you should download and install the latest version. Microsoft released Url..."
ms.date: 07/15/2010
ms.assetid: 919552f3-f3ec-4fde-aa55-85e5ee3b5164
msc.legacyurl: /learn/extensions/working-with-urlscan/urlscan-3-reference
msc.type: authoredcontent
---
# UrlScan 3 Reference

by [Robert McMurray](https://github.com/rmcmurray)

> [!NOTE]
> UrlScan 3.0 has been replaced by UrlScan 3.1. If you are using UrlScan 3.0, you should download and install the latest version.

Microsoft released UrlScan 3.0 as a separate download, which added features to create filtering rules, to always allow specific URLs to bypass UrlScan filtering, and to allow or deny requests that contained user-defined query string elements. This feature helps prevent server attacks that use query strings, such as SQL injection attacks. UrlScan 3.0 added change notifications for the UrlScan.ini file, so it is no longer necessary to restart IIS after updating your UrlScan.ini file.

Microsoft later released UrlScan 3.1 as a separate download, which added enhanced parsing of escape sequences in URLs and query strings.

<a id="InstallingUrlScan"></a>

## Installing UrlScan 3.1

UrlScan 3.1 installs as a clean install on a computer running IIS 5.1 or later. Upgrade scenarios are also supported.

**To Install UrlScan 3.1**

1. Download the setup MSI file for UrlScan 3.1 from one of the following URLs to your computer: 

    - x86: [https://www.microsoft.com/downloads/details.aspx?FamilyID=ee41818f-3363-4e24-9940-321603531989](https://www.microsoft.com/downloads/details.aspx?FamilyID=ee41818f-3363-4e24-9940-321603531989)
    - x64: [https://www.microsoft.com/downloads/details.aspx?FamilyID=361e5598-c1bd-46b8-b3e7-3980e8bdf0de](https://www.microsoft.com/downloads/details.aspx?FamilyID=361e5598-c1bd-46b8-b3e7-3980e8bdf0de)
2. Double-click the MSI file to begin the installation process.
3. Review the agreement in the UrlScan Installer Package End User Agreement and then click **Yes** to accept the agreement and continue. If you click **No**, the installer will close.
4. When the installer completes, a dialog box stating that UrlScan has been successfully installed will be displayed. Click **Finish** to close the installer.

**To Uninstall UrlScan**

1. In Control Panel, double-click **Add or Remove Programs**.
2. Select **Microsoft UrlScan Filter v3.1** and then click the **Remove** button.
3. Click **Yes** when prompted to remove UrlScan 3.1 from your computer.
4. When UrlScan 3.1 has been removed from your server, a dialog box stating that UrlScan has been successfully uninstalled may be displayed. If so, click **Finish** to close the installer.

**Understanding the UrlScan 3.1 Installer**

When installing UrlScan 3.1, the UrlScan 3.1 installer does the following:

- Installs the UrlScan.dll and UrlScan.ini files in the `%windir%\system32\inetsrv\UrlScan` directory. If UrlScan is already installed on the computer, the UrlScan.ini file is updated with any new settings that are not present in the current configuration file.
- Adds UrlScan as a global filter to IIS.
- Creates a `%windir%\system32\inetsrv\UrlScan\Logs` directory.

When installing UrlScan on a server running IIS 6.0, the UrlScan 3.1 installer makes some additional changes that enable UrlScan 3.1 to work with the new IIS 6.0 process model. These changes are as follows:

- **PerProcessLogging** is set to 1 in the UrlScan.ini file. This ensures that two UrlScan processes do not write to the log file at the same time.
- UrlScan is marked as cache-aware in the metabase. This ensures that two or more worker processes that are running UrlScan do not write to the log file at the same time.
- The new log directory, which is a subdirectory located under the ..\inetsrv\UrlScan directory, ensures that the UrlScan directory does not get cluttered with all of the log files that the **PerProcessLogging** option will create.

When installing UrlScan 3.1 on IIS, the installer sets permissions for UrlScan.dll, UrlScan.ini, and the log file. When installing UrlScan 3.1 on IIS 6.0, the installer sets additional permissions on the same files to allow UrlScan 3.1 to work with IIS 6.0 worker process isolation mode. Table 2 lists the IIS permissions that are set when UrlScan 3.1 is installed.

**Table 2: UrlScan 3.1 IIS 6.0 Permissions**

| **File/Directory** | **Permissions** |
| --- | --- |
| ..\inetsrv\UrlScan\UrlScan.dll | Read and Execute (set on IIS 6.0 only): LocalService, IIS\_WPG, and NetworkService Full: Administrators, and LocalSystem |
| ..\inetsrv\UrlScan\UrlScan.ini | Read (set on IIS 6.0 only): IIS\_WPG, LocalService, and NetworkService Full: Administrators, and LocalSystem |
| ..\inetsrv\UrlScan\logs | Read and Write (set on IIS 6.0 only): IIS\_WPG, LocalService, and NetworkService Full: Administrators, and LocalSystem |

If a version of UrlScan is detected on the computer, the installation will be considered an upgrade. In the upgrade scenario, the changes that the installer makes will be the same as for a clean installation unless you have configured a custom log directory. If you have defined a different location for the UrlScan logs, then the new logs directory will not be created.

<a id="UsingUrlScan"></a>

## Using UrlScan 3.1

You configure UrlScan's operation by setting options in the UrlScan.ini file. This file should reside in the same directory as UrlScan.dll, and it contains the sections and options that are listed below.

> [!NOTE]
> UrlScan 3.0 added change notifications for the UrlScan.ini file, so it is no longer necessary to restart IIS after updating your UrlScan.ini file.

**Warning**: The default options built into UrlScan.dll will result in a configuration that will reject all requests to the server, therefore it is necessary to provide a UrlScan.ini file for IIS to serve HTTP requests when you are using UrlScan. A sample UrlScan.ini file is provided that contains the recommended settings to defend against known attacks against IIS servers at the time of writing.

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
| VerifyNormalization | Allowed values are 0 or 1. The Default value for VerifyNormalization is 1. If set to 1, UrlScan verifies normalization of the URL. This action will defend against canonicalization attacks, where a URL contains a double encoded string in the URL. For example, the string "%252e" is a double encoded dot '.' character because "%25" decodes to a '%' character, the first pass decoding of "%252e" results in "%2e", which can be decoded a second time into a single dot '.' string. If set to 0, then UrlScan will not verify normalization of the URL. **Note:** This option is dependent on the NormalizeUrlBeforeScan option. |
| AllowHighBitCharacters | Allowed values are 0 or 1. The default value for AllowHighBitCharacters is 1. If set to 1, then UrlScan will allow any byte to exist in the URL. If set to 0, UrlScan will reject any request where the URL contains a character outside of the ASCII character set. **Note:** This feature can defend against UNICODE or UTF-8 based attacks, but will also reject legitimate requests on IIS servers that use a non-ASCII code page. |
| AllowDotInPath | Allowed values are 0 or 1. The default value for AllowDotInPath is 1. If set to 1, UrlScan will allow requests that contain multiple instances of the dot (.) character in the URL. If set to 0, UrlScan will reject requests that contain multiple instances of the dot (.) character in the URL. **Note:** Because UrlScan operates at a level where IIS has not yet parsed the URL, it is not possible to determine in all cases whether a dot character denotes the extension or whether it is a part of the directory path or filename of the URL. For the purposes of extension analysis, UrlScan will always assume that an extension is the part of the URL beginning after the last dot in the string and ending at the first question mark or slash character after the dot or the end of the string. Setting AllowDotInPath to 0 defends against the case where an attacker uses path info to hide the true extension of the request (for example, something like "/path/TruePart.asp/FalsePart.htm"). Setting AllowDotInPath to 0 also causes UrlScan to deny any request that contains a dot in a directory or file name. |
| AllowLateScanning | Allowed values are 0 or 1. The default value for AllowLateScanning is 0. If set to 1, UrlScan will register itself as a low priority filter. This will allow other ISAPI filters to modify the URL before UrlScan performs any analysis. If set to 0, UrlScan runs as a high priority filter. **Note:** In addition to the value of AllowLateScanning, it may be necessary to ensure that UrlScan is listed lower on the list of ISAPI filters for the server. For example, the FrontPage Server Extensions require that AllowLateScanning is set to 1 and that UrlScan is lower on the filter load order list than the Fpexedll.dll ISAPI filter. **Note:** This feature was introduced in UrlScan 2.0. |
| UseFastPathReject | Allowed values are 0 or 1. The default value for UseFastPathReject is 0. If set to 1, UrlScan will return a short 404 response to the client in cases where it rejects a request. **Note:** Using UseFastPathReject is faster than using the RejectResponseUrl option, but IIS cannot return a custom 404 response or log many parts of the request into the IIS log, even though the UrlScan log file will contain complete information about the rejected request. **Note:** This feature was introduced in UrlScan 2.0. |
| RejectResponseUrl | Allowed value is a string. The default value for RejectResponseUrl is /&lt;Rejected-By-UrlScan&gt;. The value for RejectResponseUrl is a URL in the form "/path/filename.ext". When UrlScan rejects a request, it will process the specified URL, which needs to be local to the Web site for the request that is being analyzed by UrlScan. The specified URL can have the same extension as the rejected URL; for example, ".asp". **Note:** UrlScan creates the following server variables that can be used by the specified URL in determining the nature of the rejected request and to allow flexibility in returning the actual response to the client: - HTTP\_UrlScan\_STATUS\_HEADER - Contains the reason the request is being rejected. - HTTP\_UrlScan\_ORIGINAL\_VERB - Contains the original verb from the request that is being rejected. - HTTP\_UrlScan\_ORIGINAL\_URL - Contains the original URL from the request that is being rejected. UrlScan appends the URL of the request that is being rejected as a query string to the location specified by RejectResponseUrl. If IIS is configured to log request query strings, the URL of the rejected request can be found in the IIS log in addition to the UrlScan log. There is a special value for RejectResponseUrl that can be used to put UrlScan into "Logging Only Mode." If you set the value of RejectResponseUrl to /~\*, UrlScan performs all of the configured scanning and logs the results, however, it will allow IIS to serve the page even if it would normally be rejected. This mode is useful if you would like to test UrlScan.ini settings without actually rejecting any requests, and the log entries in the UrlScan log file will indicate that requests are not being rejected. **Note:** This feature was introduced in UrlScan 2.0. |
| UnescapeQueryString | Allowed values are 0 or 1. The default value for UnescapeQueryString is 1. If set to 1, UrlScan will perform two passes on each query string scan. The first pass will scan the raw query string, and the second pass will scan the query string after IIS has decoded any escape sequences. If set to 0, UrlScan will only look at the raw query string as sent by the client. **Note:** If this property is set to 0, then checks based on the query string will be unreliable. **Note:** This feature was introduced in UrlScan 3.0. |
| RuleList | Allowed value is a string. The default value is a blank string. RuleList specifies a comma-separated list of custom rules that UrlScan will apply in addition to the other checks and options that are specified in the UrlScan.ini file. Each rule in the list corresponds to two sections in this configuration file, one containing the options for the rule, and one containing deny strings for the rule. **Note:** This feature was introduced in UrlScan 3.0. |

#### Logging Options

| EnableLogging | Allowed values are 0 or 1. The default value for EnableLogging is 1. If set to 1, UrlScan will log its actions in a file called UrlScan.log that will be created in the same directory that contains UrlScan.dll. If set to 0, UrlScan will not log any activity. |
| --- | --- |
| PerProcessLogging | Allowed values are 0 or 1. The default value of PerProcessLogging is 0. If set to 1, UrlScan will append the process ID of the IIS process that is hosting UrlScan.dll to the log file name; for example, UrlScan.1234.log. This feature is helpful for IIS versions that can host filters in more than 1 process concurrently, such as IIS 6.0 and later. If set to 0, UrlScan will log all activity in UrlScan.log. |
| PerDayLogging | Allowed values are 0 or 1. The default value of PerDayLogging is 1. If set to 1, UrlScan creates a new log file each day and appends a date to the log file name; for example, UrlScan.101501.log. If set to 0, UrlScan opens a single file called UrlScan.log, or UrlScan.nnnn.log, where nnnn is the process ID when PerProcessLogging is set to 1. **Note:** When PerDayLogging is set to 1, a log file is created for the current day when the first log entry is written for that day. If no UrlScan activity occurs, a log file will not be created for that day. If both PerDayLogging and PerProcessLogging are set to 1, the log file name contains the date and a process ID in the name; for example, UrlScan.101501.123.log. **Note:** This feature was introduced in UrlScan 2.0. |
| LogLongUrls | **Note:** This feature was deprecated in UrlScan 3.0; UrlScan 3.x will always include the complete URL in its log file. |
| LoggingDirectory | Allowed value is a string. The default value for LoggingDirectory is `C:\WINDOWS\system32\inetsrv\UrlScan\logs`. Use LoggingDirectory to specify the absolute path to the directory where the UrlScan log files will be created. If you do not specify a path, UrlScan will create log files in the same directory where the UrlScan.dll file is located. **Note:** This feature was introduced in UrlScan 3.1. |

#### HTTP Server Header Manipulation

| RemoveServerHeader | Allowed values are 0 or 1. The default value for RemoveServerHeader is 1. If set to 1, UrlScan will remove the server header on all responses, and the value of AlternateServerName will be ignored. If set to 0, IIS will return the default server header on all responses. **Note:** This feature is only available if UrlScan is installed on IIS 4.0 or later. |
| --- | --- |
| AlternateServerName | Allowed value is a string. The default value for AlternateServerName is an empty string. If you specify a value for AlternateServerName and RemoveServerHeader is set to 0, then IIS will replace its default "Server:" header in all responses with the AlternateServerName value. If RemoveServerHeader is set to 1, the value of AlternateServerName will be ignored. **Note:** This feature is only available if UrlScan is installed on IIS 4.0 or later. |

##### Example [Options] Section

The following example [Options] section configures several recommended settings for UrlScan:

[!code-console[Main](urlscan-3-reference/samples/sample1.cmd)]

<a id="AllowVerbsSection"></a>

### [AllowVerbs] Section

The [AllowVerbs] section contains a list of HTTP verbs or methods. If UseAllowVerbs is set to 1 in the [Options] section, UrlScan will reject any request that contains an HTTP verb that is not explicitly listed in this section. The entries in this section are case sensitive.

##### Example [AllowVerbs] Section

The following example [AllowVerbs] section configures UrlScan to allow basic HTTP functionality:

[!code-console[Main](urlscan-3-reference/samples/sample2.cmd)]

To use this example, you would need to set UseAllowVerbs to 1 in the [Options] section.

<a id="DenyVerbsSection"></a>

### [DenyVerbs] Section

The [DenyVerbs] section contains a list of HTTP verbs or methods. If UseAllowVerbs is set to 0 in the [Options] section, UrlScan will reject any request that contains a verb that is listed in this section. The entries in this section are not case sensitive.

##### Example [DenyVerbs] Section

The following example [DenyVerbs] section configures UrlScan to deny several of the HTTP methods that are not required for basic HTTP functionality, such as WebDAV methods:

[!code-console[Main](urlscan-3-reference/samples/sample3.cmd)]

To use this example, you would need to set UseAllowVerbs to 0 in the [Options] section.

<a id="DenyHeadersSection"></a>

### [DenyHeaders] Section

The [DenyHeaders] section contains a list of request headers in the form "header-name:". Any request containing a request header listed in this section will be rejected. The entries in this section are not case sensitive.

##### Example [DenyHeaders] Section

The following example [DenyHeaders] section configures UrlScan to deny several HTTP headers that are used with WebDAV requests:

[!code-console[Main](urlscan-3-reference/samples/sample4.cmd)]

<a id="AllowExtensionsSection"></a>

### [AllowExtensions] Section

The [AllowExtensions] section contains a list of file name extensions in the form of ".ext". If UseAllowExtensions=1 is set in the [Options] section, then any request containing a URL with an extension not explicitly listed here is rejected. The entries in this section are not case sensitive.

##### Example [AllowExtensions] Section

The following example [AllowExtensions] section configures UrlScan to allow several static content types:

[!code-console[Main](urlscan-3-reference/samples/sample5.cmd)]

To use this example, you would need to set UseAllowExtensions to 1 in the [Options] section.

<a id="DenyExtensionsSection"></a>

### [DenyExtensions] Section

The [DenyExtensions] section contains a list of file name extensions in the form of ".ext". If UseAllowExtensions=0 is set in the [Options] section, then any request containing a URL with an extension listed here is rejected. The entries in this section are not case sensitive.

##### Example [DenyExtensions] Section

The following example [DenyExtensions] section configures UrlScan to allow several static content types:

[!code-console[Main](urlscan-3-reference/samples/sample6.cmd)]

To use this example, you would need to set UseAllowExtensions to 0 in the [Options] section.

<a id="DenyUrlSequencesSection"></a>

### [DenyUrlSequences] Section

The [DenyUrlSequences] section contains a list of character sequences that UrlScan will deny if they appear in a URL. For example, two dots ".." indicate a parent path, which a hacker might try to use to gain access to files outside of a Web site's content area.

##### Example [DenyUrlSequences] Section

The following example [DenyUrlSequences] section configures UrlScan to deny several URL sequences that could be used to attack your server:

[!code-console[Main](urlscan-3-reference/samples/sample7.cmd)]

<a id="RequestLimitsSection"></a>

### [RequestLimits] Section

The [RequestLimits] section impose limits on the length of user-defined parts of HTTP requests, such as the maximum content length or maximum URL length for HTTP requests.

> [!NOTE]
> This feature was introduced in UrlScan 3.1.

You can specify the maximum length of the value for a specific request header by adding "Max-" to the name of the header. For example, the following entry would impose a limit of 100 bytes to the value of the 'Content-Type' header:

> Max-Content-Type=100

To list a header and not specify a maximum value, use 0. For example, "Max-User-Agent=0". Note: Any HTTP request headers that are not listed in this section will not be checked for length limits.

The [RequestLimits] section can contain the following three special-case limits:

| MaxAllowedContentLength | Specifies the maximum allowed numeric value, in bytes, of the Content-Length request header. For example, setting this to 1000 would cause any request with a content length that exceeds 1000 to be rejected. The default value for MaxAllowedContentLength is 30000000. |
| --- | --- |
| MaxUrl | Specifies the maximum length, in bytes, of the request URL, not including the query string. The default value for MaxUrl is 260, which is equivalent to the MAX\_PATH constant. |
| MaxQueryString | Specifies the maximum length, in bytes, of the query string. The default value for MaxQueryString is 4096. |

##### Example [RequestLimits] Section

The following example [RequestLimits] section configures UrlScan to specify the maximum lengths for several HTTP headers and the maximum content length for a request:

[!code-console[Main](urlscan-3-reference/samples/sample8.cmd)]

<a id="AlwaysAllowedUrlsSection"></a>

### [AlwaysAllowedUrls] Section

The [AlwaysAllowedUrls] section contains a list of URLs that UrlScan will always allow.

> [!NOTE]
> These URLs will bypass all URL-based checks, and URLs must be listed with a leading '/' character.

##### Example [AlwaysAllowedUrls] Section

The following example [AlwaysAllowedUrls] section configures UrlScan to deny several URL sequences that could be used to attack your server:

[!code-console[Main](urlscan-3-reference/samples/sample9.cmd)]

<a id="AlwaysAllowedQueryStringsSection"></a>

### [AlwaysAllowedQueryStrings] Section

The [AlwaysAllowedQueryStrings] section contains a list of query strings that will always be explicitly allowed by UrlScan and bypass all checks.

<a id="DenyQueryStringSequencesSection"></a>

### [DenyQueryStringSequences] Section

The [DenyQueryStringSequences] section contains a list of character sequences that UrlScan will deny if they appear in a query string.

##### Example [DenyQueryStringSequences] Section

The following example [DenyQueryStringSequences] section configures UrlScan to deny several query string sequences that could be used to attack your server:

[!code-console[Main](urlscan-3-reference/samples/sample10.cmd)]

<a id="RuleSections"></a>

### Rule Sections

Individual rule sections contain the settings for rules that are specified in the RuleList setting in the [Options] section, and each rule section can specify an additional rule data section that contains a list of strings to deny.

Each rule section can contain the following settings:

| AppliesTo | Allowed value is a string. The default value is blank. The AppliesTo setting may contain comma separated list of file extensions to which the rule applies. For example, .asp, .aspx., .php, etc. **Note:** If no AppliesTo setting is specified, the rule will be applied to all requests. **Note:** This feature was introduced in UrlScan 3.0. |
| --- | --- |
| DenyDataSection | Allowed value is a string. The default value is blank. The DenyDataSection setting may contain the name of a section that contains the strings to deny for this rule. **Note:** This feature was introduced in UrlScan 3.0. |
| ScanURL | Allowed values are 0 or 1. The default value of ScanURL is 0. If set to 1, the URL will be scanned for deny strings. **Note:** This feature was introduced in UrlScan 3.0. |
| ScanAllRaw | Allowed values are 0 or 1. The default value of ScanAllRaw is 0. If set to 1, then the raw request header data will be scanned for deny strings. **Note:** This feature was introduced in UrlScan 3.0. |
| ScanQueryString | Allowed values are 0 or 1. The default value of ScanQueryString is 0. If set to 1, the query string will be scanned for deny strings. **Note:** If UnescapeQueryString is set to 1 in the [Options] section, then two scans will be made of the query string, one with the raw query string and one with the query string unescaped. **Note:** This feature was introduced in UrlScan 3.0. |
| ScanHeaders | Allowed value is a string. The default value is no headers. A comma separated list of request headers to be scanned for deny strings. **Note:** This feature was introduced in UrlScan 3.0. |
| DenyUnescapedPercent | Allowed values are 0 or 1. The default value of DenyUnescapedPercent is 0. If set to 1, UrlScan will scan the specified part of the raw request for a % character that is not used as an escape sequence. If found, the request will be rejected. This check can be used with ScanQueryString=1, ScanAllRaw=1, or the list of ScanHeaders. **Note:** If you want to deny non-escaped % characters in the URL, you can set VerifyNormalization=0 in the [Options] section and then add % as a [DenyUrlSequences] entry. **Note:** This feature was introduced in UrlScan 3.1. |

##### Example Rule Section

The following example rule section configures UrlScan with two custom rules that will configure custom settings for \*.asp/\*.aspx and \*.php files. In this example, the two rules share a common data section for the DenyDataSection, but you can configure your rules to use separate data sections as well.

[!code-console[Main](urlscan-3-reference/samples/sample11.cmd)]
