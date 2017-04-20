---
title: "Common UrlScan Scenarios | Microsoft Docs"
author: naziml
description: "This article provides a list of common usage scenarios for UrlScan Version 3.1, and how to enable the scenarios using the UrlScan.ini configuration. Creating..."
ms.author: iiscontent
manager: soshir
ms.date: 06/24/2008
ms.topic: article
ms.assetid: f159ad3c-db09-4c37-b563-746d824b4cb1
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/working-with-urlscan/common-urlscan-scenarios
msc.type: authoredcontent
---
Common UrlScan Scenarios
====================
by [Nazim Lala](https://github.com/naziml)

This article provides a list of common usage scenarios for UrlScan Version 3.1, and how to enable the scenarios using the UrlScan.ini configuration.

## Creating Rules to Disallow String Patterns in Parts of Requests

A new feature added for UrlScan Version 3.1 is the ability to create a rule list that will let you specify rules to disallow requests based on patterns matched against certain portions of an HTTP request. The main configuration for this is the **RuleList** key under the **[Options]** section. The value of this key is a comma delimited list of section names that define the rules. Here's what defining a rule "Foo" would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample1.cmd)]


**RuleList** under **[Options]** lists out all the rules to be run. In the case I have a rule "Foo" I need to evaluate. This could be multiple comma delimited rules as well. A section with the same name **[Foo]** will define the rule and if any item on the RuleList does not have a section declared the filter will log a configuration error to the log file. Under this section the **AppliesTo** key specifies which file extension this rule applies to. The **DenyDataSection** key specifies the section that contains the string patterns that are to be matched against for this rule. As you can see there is a **[Foo Strings]** section that has three patterns in it. This list is case insensitive and allows entering encoded values of the format %XX, where XX are hexadecimal digits. The other keys in the **[Foo]** section specify what parts of the request this rule applies to. Your choices include the Url (**ScanUrl**), the raw HTTP request (**ScanAllRaw**), the query string (**ScanQueryString**) or a list of particular headers (**ScanHeaders**). With the exception of **ScanHeaders**, all the other Scan keys expect a boolean value. **ScanHeaders** expects a list of comma delimited values of the actual headers including the colon. So in the case above we are only scanning the "Foo-Header" in a request for a particular string. The last setting in the rule before the data section called (**DenyUnescapedPercent**) is used to scan the specified parts of the request for a % character that is not used as an escape sequence and block requests where any such sequence is found. So setting **DenyUnescapedPercent** to 1 would trigger for a sequence %XX but not for %20 or %u0020, since the latter two represent an escaped [Space] character. This setting has been introduced in UrlScan Version 3.1 and is not present in UrlScan Version 3.0.

The request below would fail this rule since it has a header called Foo-Header that contains the '--' pattern.


[!code-console[Main](common-urlscan-scenarios/samples/sample2.cmd)]


The request below would fail this rule since Foo-Header contains the '%' character note used to denote an escape sequence.


[!code-console[Main](common-urlscan-scenarios/samples/sample3.cmd)]


## Rule to Block SQL injection Signatures

Before we proceed any further it is important to note that this is not the recommended way to prevent SQL injection in your applications. This is only a stopgap for servers that are under a malicious attack. Such a rule would give you breathing room to go fix your application using [recommended best practices](https://msdn.microsoft.com/en-us/library/cc676512.aspx). Also a rule similar to the one below is likely to encounter false positives and fail valid application requests. Another important point to note is that the rule below does nothing to block SQL injection attempts through the request entity body.

Having said that, if we were to write a generic rule to block SQL injection we could write something like this:


[!code-console[Main](common-urlscan-scenarios/samples/sample4.cmd)]


Since we would only want non-static pages to run this rule, I can list out the file extensions we want this apply to using **AppliesTo**. In this case this rule will be run only for classic ASP and ASP.NET requests. The only part we are interested in is the query string and the Cookie Header and we can set the scan options as above to reflect this. The **[Sql Injection Strings]** section defines all the patterns we want to disallow.

But the rule above is not checking any of the headers. If you wanted to check all headers you would need to trim the strings list to reduce false positives. The shorter sequences of characters and the semicolon could appear in the session cookie for instance and fail valid requests. Also, not all the headers are relevant and so we probably want to trim the headers to those that would actually be used for a SQL injection. The cookie header is a definite candidate for this. You could augment the rule above with something like what is shown below to deal with this.


[!code-console[Main](common-urlscan-scenarios/samples/sample5.cmd)]


**## Creating Safe-List For URLs and Query Strings**

UrlScan Version 3.1 allows you to specify safe URLs and query strings that will bypass all checks and rules. In UrlScan Version 3.0 they only bypassed URL or query string checks respectively, but in UrlScan Version 3.1 they will bypass all checks and rules. This feature must be used with caution, since wrong configuration in this section could let malicious requests bypass your deny rules. If a user always wants to allow the URL '/my.login.page.asp' for instance even though it might trigger a deny rule defined, you can add configuration as below to allow this.


[!code-console[Main](common-urlscan-scenarios/samples/sample6.cmd)]


It is important to note that the leading '/' is required for the URL to be accepted as a valid URL. If a user wants to allow a query string 'session&lt;1' which might otherwise trigger a deny rule defined, you can add configuration as below to allow this.


[!code-console[Main](common-urlscan-scenarios/samples/sample7.cmd)]


Note that you do not need to specify query strings leading with the '?' character.

## Setting Limits on Parts of Requests

### Limiting the Length of Header Values

Under **[RequestLimits]** section add the value Max-&lt;Header Name&gt;=&lt;N&gt;, where "Header Name" is the name of the particular header whose value's length you want limited, and "N" is the maximum number of bytes a valid header can be. If "N" is 0, that particular header is effectively disallowed.

For example, if you do not want the value of the Content-Type header to exceed 100 bytes the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample8.cmd)]


### Limiting Maximum Content Length for a Request

Under **[RequestLimits]** section add the value MaxAllowedContentLength=&lt;N&gt; where "N" is the maximum number of bytes allowed for the Content-Length header. If someone were to send more data than the value in the Content-Length header, the data after the length would be interpreted as a separate request.

For example, if you want to disallow content lengths greater than 1000 bytes the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample9.cmd)]


### Limiting Maximum Length of a URL

Under **[RequestLimits]** section add the value MaxUrl=&lt;N&gt; where "N" is the maximum number of characters allowed in the URL of the request.

For example, if you want to disallow URLs greater than 100 characters long the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample10.cmd)]


### Limiting Maximum Length of a Query String

Under **[RequestLimits]** section add the value MaxQueryString=&lt;N&gt; where "N" is the maximum number of characters allowed in the query string of the URL.

For example, if you want to disallow query strings greater than 100 characters long the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample11.cmd)]


## Disallowing Certain Types of Requests

### Creating an allow or deny list of allowed HTTP verbs

For an allow list create an **[AllowVerbs]** section and add the list of verbs you want to allow. The allow list is case sensitive and is evaluated before the deny list to remain conservative in the evaluation of rules.

For example, if you want to only allow GET, HEAD and POST verbs the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample12.cmd)]


For a deny list create a **[DenyVerbs]** section and add the list of verbs you want to disallow. The deny list is case insensitive.

For example, if you want to disallow WebDAV verbs the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample13.cmd)]


### Creating an allow or deny list of URI extensions

For an allow list create an **[AllowExtension]** section and add the list of extensions you want to allow. The allow list is case insensitive and is evaluated before the deny list.

For example, if you only want to allow .htm and .html files being served the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample14.cmd)]


For a deny list create a **[DenyExtensions]** section and add the list of extensions you want to disallow. The deny list is case insensitive.

For example, if you want to disallow executables in your requests the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample15.cmd)]


### Creating a Deny List of Headers

To deny a list of headers create a **[DenyHeaders]** section and add the list of headers that you want to disallow. The deny list is case insensitive.

For example, if you wanted to reject requests with the Transfer-Encoding header the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample16.cmd)]


### Creating a Deny List of URL Sequences

To deny a list of URL sequences for all requests create a **[DenyUrlSequences]** section and add the list of strings you want to disallow in the URL of your requests. The deny list is case insensitive and allows encoded values of the format %XX, where XX are hexadecimal digits.

For example, if you wanted to deny any URL with ".." or "./" or a carriage return and line feed (CRLF) sequence the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample17.cmd)]


You probably noticed the %0D%0A at the end of this list. UrlScan Version 3.1 lets you specify encoded values in your sequences and 0x0D is the carriage return character and 0x0A is the line feed character.

### Creating a Deny List of Query String Sequences

To deny a list of query string sequences for all requests create a **[DenyQueryStringSequences]** section and add the list of strings you want to disallow in the query string of your request. The deny list is case insensitive and allows encoded values of the format %XX, where XX are hexadecimal digits.

For example, if you wanted to deny &lt;script&gt; tags in your query string and want to allow for whitespaces in between the angle brackets, we can deny the angle bracket characters and the configuration would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample18.cmd)]


It is possible that you want to scan for both escaped and un-escaped versions of this pattern. So if someone were to send a request like http://www.foo.com/id=%3C%53%43%52%49%50%54%3E where the &lt;script&gt; sequence has been escaped, we would like to check the un-escaped version of this query string as well. To do this set **UnescapeQueryString=1** in the **[Options]** section. This will perform 2 passes when it checks for patterns in query string, one for raw query string and one for the un-escaped query string.

## Using UrlScan Logging

UrlScan Version 3.1 uses W3C format for its log files so that users can write SQL like queries against their UrlScan logs. This is especially useful for analyzing false positives for UrlScan configuration.

### Configuring UrlScan for Logging Only Mode

On a production server it is useful to see how a particular UrlScan configuration would behave, without actually failing requests. For this purpose you can use UrlScan's logging only mode. To set this up make the following configuration change in UrlScan.ini:


[!code-console[Main](common-urlscan-scenarios/samples/sample19.cmd)]


The RejectResponseUrl is used to send a custom response to something blocked by UrlScan. However when set to the value above, it notifies UrlScan to go into logging only mode, where UrlScan will not block any requests, but will log requests that would have been blocked otherwise.

### Using Log Parser with UrlScan Logs

Since UrlScanv3.1 uses W3C formatted logs, users can use Log Parser to query the log files. Log Parser comes with a .chm documentation file that has information on how to use it. This section will provide a few examples specific to UrlScan and will not attempt to cover everything possible using Log Parser.

> [!NOTE]
> For detailed information about querying UrlScan logs using LogParser, see the [Data Mining URLScan 3 Logs using LogParser 2.2](data-mining-urlscan-3-logs-using-logparser-22.md) topic.

To see all the data fields available in the logs you can run the command:


[!code-console[Main](common-urlscan-scenarios/samples/sample20.cmd)]


This command specifies that the log file specified by &lt;log filename&gt; is in W3C input format and will list out the fields available for query. A sample output for this would look like:


[!code-console[Main](common-urlscan-scenarios/samples/sample21.cmd)]


### Analyzing UrlScan Failures By Site

To issue a query to find out how many failures you have per site you could issue the command:


[!code-console[Main](common-urlscan-scenarios/samples/sample22.cmd)]


This query would yield results like those below and can be used to determine which site is getting more UrlScan failures.


[!code-console[Main](common-urlscan-scenarios/samples/sample23.cmd)]


### Analyzing UrlScan Failures By Reason

To issue a query to get a distribution for the reason of failure you could issue the command:


[!code-console[Main](common-urlscan-scenarios/samples/sample24.cmd)]


This query would yield results like those below and can be used to analyze false positives because of a rule.


[!code-console[Main](common-urlscan-scenarios/samples/sample25.cmd)]


### Analyzing UrlScan Failures for Malicious Clients

To issue a query to get a distribution of failures based on client IP addresses you could issue the command:


[!code-console[Main](common-urlscan-scenarios/samples/sample26.cmd)]


This query would yield results like those below and can be used to analyze malicious clients. You could then use IP restrictions list to block out these malicious clients.


[!code-console[Main](common-urlscan-scenarios/samples/sample27.cmd)]