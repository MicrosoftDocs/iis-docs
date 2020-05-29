---
title: "Using Enhanced Request Filtering Features in IIS7"
author: rick-anderson
description: "This article provides a list of common usage scenarios for enhanced Request Filtering features, which is shipped with Windows Server 2008 SP2 or can be downl..."
ms.date: 09/30/2008
ms.assetid: ed011e8b-e721-41b3-8e50-56cde29cfafa
msc.legacyurl: /learn/manage/configuring-security/using-enhanced-request-filtering-features-in-iis
msc.type: authoredcontent
---
# Using Enhanced Request Filtering Features in IIS7

by Suditi Lahiri

This article provides a list of common usage scenarios for enhanced Request Filtering features, which is shipped with Windows Server 2008 SP2 or can be downloaded from [https://www.microsoft.com/downloads/](https://www.microsoft.com/downloads/) for Windows Server 2008 RTM. In the absence of a corresponding UI to configure these features, appcmd.exe is used to enable and configure the scenarios in this article.

## Creating Rules to Disallow String Patterns in Parts of Requests

 A new feature, added to IIS Request Filtering feature, is the ability to create a rule list that will let you specify rules to disallow requests based on patterns matched against certain portions of an HTTP request. The main configuration for this is the **filteringRules** section under the **system.webServer/security/requestFiltering** section. In the event of a denied condition **HTTP Error 404.19** is raised. 

### Example

 In this example a server administrator wishes to block strings &quot;Foo&quot; and &quot;Bar&quot; in header &quot;Foo-Header&quot; using appcmd.exe:

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample1.cmd)]

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample2.cmd)]

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample3.cmd)]

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample4.cmd)]
 
### Config

[!code-xml[Main](using-enhanced-request-filtering-features-in-iis/samples/sample5.xml)]

The request below would fail this rule since it has a header called Foo-Header that contains the 'Foo' pattern

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample6.cmd)]

### Example

In this example a server administrator wishes to block strings &quot;Insert&quot; and &quot;Table&quot; in the query string sent with any &quot;.asp&quot; page:

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample7.cmd)]

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample8.cmd)]

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample9.cmd)]

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample10.cmd)]

### Config

[!code-xml[Main](using-enhanced-request-filtering-features-in-iis/samples/sample11.xml)]

The asp request below would fail this rule since it has string &quot;Insert&quot; in Query String:

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample12.cmd)]

It is important to note that the whole header will be scanned for the string patterns listed under &quot;**denyString**&quot; section and not the header value only.

## Creating Safe-List for URLs and Query Strings

This new feature allows you to specify safe URLs and query strings that will bypass all the deny rules defined. This feature must be used with caution, since wrong configuration in this section could let malicious requests bypass your deny rules. If a user always wants to allow the URL '/my.login.page.asp' for instance even though it might trigger a deny rule defined, you can add configuration as below to allow this.The feature can be configured using **alwaysAllowedUrls** and **alwaysAllowedQueryStrings** under **system.webServer/security/requestFiltering** section.

### Example

 In the following example appcmd.exe is used to configure page &quot;Login.asp&quot; as a white listed URL and &quot;Allow=true&quot; as a white listed Query string sequence.

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample13.cmd)]

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample14.cmd)]

### Config

[!code-xml[Main](using-enhanced-request-filtering-features-in-iis/samples/sample15.xml)]

It is important to note that the leading '/' is required for the URL to be accepted as a valid URL. If a user wants to allow a query string 'session&lt;1' which might otherwise trigger a deny rule defined, you can add configuration as below to allow this. Note that you do not need to specify query strings leading with the '?' character.

## Creating a Deny List of URL Sequences

 To deny a list of URL sequences for all requests create a **denyQueryStringSequences** section and add the list of strings you want to disallow in the URL of your requests. The deny list is case insensitive and allows encoded values of the format %XX, where XX are hexadecimal digits. In the event of a denied condition **HTTP Error 404.18** is raised.

### Example

 For example, if you wanted to deny any URL with &quot;..&quot; or &quot;./&quot; sequence, appcmd.exe command will be:

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample16.cmd)]

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample17.cmd)]

### Config

[!code-xml[Main](using-enhanced-request-filtering-features-in-iis/samples/sample18.xml)]

The request below would fail this rule since it has a &quot;..&quot; in its Query String:

[!code-console[Main](using-enhanced-request-filtering-features-in-iis/samples/sample19.cmd)]

## Checking for both Escaped and unEscaped Query String

 It is possible that you want to scan for both escaped and un-escaped versions of this pattern using **unescapeQueryString** attribute in the &quot;**system.webServer/security/requestFiltering**&quot; section. 

### Example

 So if someone were to send a request like [http://www.foo.com/id=%3C%53%43%52%49%50%54%3E](http://www.foo.com/id=%3CSCRIPT%253E) where the &lt;script&gt; sequence has been escaped, we would like to check the un-escaped version of this query string as well:

`appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /unescapeQueryString:"True"`

### Config

[!code-xml[Main](using-enhanced-request-filtering-features-in-iis/samples/sample20.xml)]

This will perform 2 passes when it checks for patterns in query string, one for raw query string and one for the un-escaped query string.
