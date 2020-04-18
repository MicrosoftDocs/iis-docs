---
title: "Using Failed Request Tracing to Trace Rewrite Rules"
author: ruslany
description: "IIS 7.0 and above Failed Request Tracing (FRT) is a powerful tool for troubleshooting request-processing failures. FRT can be used with the URL rewrite modul..."
ms.date: 05/30/2008
ms.assetid: 5177e3be-c050-4330-bcad-0ac77b785254
msc.legacyurl: /learn/extensions/url-rewrite-module/using-failed-request-tracing-to-trace-rewrite-rules
msc.type: authoredcontent
---
Using Failed Request Tracing to Trace Rewrite Rules
====================
by [Ruslan Yakushev](https://github.com/ruslany)

IIS 7.0 and above Failed Request Tracing (FRT) is a powerful tool for troubleshooting request-processing failures. FRT can be used with the URL rewrite module to trace how rewrite rules were applied to the request URL. This walkthrough will guide you through how to use FRT to troubleshoot and debug URL rewriting rules. For more information about Failed Request Tracing, see [this article](../../troubleshoot/using-failed-request-tracing/troubleshooting-failed-requests-using-tracing-in-iis.md "FRT").

## Prerequisites

This walkthrough requires the following prerequisites:

1. IIS 7.0 or above with ASP.NET and "Tracing" role services enabled
2. URL rewrite Go Live release installed

## Setting up a test Web page

To demonstrate how the URL rewrite module works, we will be using a simple test ASP.NET page. This page reads the Web server variables and outputs their values in the browser.

Copy the following ASP.NET code and put it in the `%SystemDrive%\inetpub\wwwroot\` folder in a file called article.aspx:

[!code-aspx[Main](using-failed-request-tracing-to-trace-rewrite-rules/samples/sample1.aspx)]

After copying this file, browse to `http://localhost/article.aspx` and check that the page was rendered correctly in a browser.

[![](using-failed-request-tracing-to-trace-rewrite-rules/_static/image3.png)](using-failed-request-tracing-to-trace-rewrite-rules/_static/image1.png)

## Configuring rewrite rules

Locate a web.config file in `%SystemDrive%\inetpub\wwwroot\` folder or create one if it does not exist. Open web.config file and add the following section inside of the `<system.webServer>` element:

[!code-xml[Main](using-failed-request-tracing-to-trace-rewrite-rules/samples/sample2.xml)]

- The "Fail bad requests" rule aborts HTTP connection if the host header of HTTP request does not match "localhost"
- The "Rewrite to article.aspx" rule rewrite urls from this format `http://localhost/article/234/some-title` to this format `http://localhost/article.aspx?id=234&title=some-title`.

Check that the rules are configured correctly by opening a browser and making a request to `http://localhost/article/234/some-title`. If rules were setup correctly then you should see the following response in browser:

[![](using-failed-request-tracing-to-trace-rewrite-rules/_static/image7.png)](using-failed-request-tracing-to-trace-rewrite-rules/_static/image5.png)

## Configure Failed Request Tracing

Now enable failed request tracing for a "Default Web Site" (see [this article](../../troubleshoot/using-failed-request-tracing/troubleshooting-failed-requests-using-tracing-in-iis.md "FRT Documentation") for step by step instructions on how to enable FRT). After you enable failed request tracing, we will create an FRT rule for tracing events specific to the URL rewrite module.

To create an FRT rule in IIS Manager follow these steps:

1. Click on "Failed Request Tracing Rules" icon to get to the list of FRT rules.  
    [![](using-failed-request-tracing-to-trace-rewrite-rules/_static/image11.png)](using-failed-request-tracing-to-trace-rewrite-rules/_static/image9.png)
2. Click on the "Add …" action to bring up the FRT rule creation wizard.[![](using-failed-request-tracing-to-trace-rewrite-rules/_static/image15.png)](using-failed-request-tracing-to-trace-rewrite-rules/_static/image13.png)
3. On first page of the wizard choose "All content (\*)"
4. Click "Next" and specify the status code(s) as "200-399"  
    [![](using-failed-request-tracing-to-trace-rewrite-rules/_static/image19.png)](using-failed-request-tracing-to-trace-rewrite-rules/_static/image17.png)
5. Click Next and then uncheck all the trace providers except "WWW Server" and then uncheck all the provider areas except "Rewrite"[![](using-failed-request-tracing-to-trace-rewrite-rules/_static/image23.png)](using-failed-request-tracing-to-trace-rewrite-rules/_static/image21.png)
6. Click on Finish to save the FRT rule.

[![](using-failed-request-tracing-to-trace-rewrite-rules/_static/image3.gif)](using-failed-request-tracing-to-trace-rewrite-rules/_static/image1.gif) If the Failed Request Tracing was installed after URL rewrite module, the "Rewrite" area in Trace Providers may not be available. If you do not see "Rewrite" area listed there, go to Add/Remove programs and then run URL rewrite module installer in repair mode.

## Analyzing Failed Request Tracing log file

After the FRT rule has been created, make a request to `http://localhost/article/234/some-title`. This will create an FRT log in `%SystemDrive%\inetpub\Logs\FaileReqLogFiles\`. You can open this log by using Internet Explorer, and it will be rendered as an HTML document that can be easily browsed. Following is an example of the URL rewrite specific events that can be found in the trace log file:

[![](using-failed-request-tracing-to-trace-rewrite-rules/_static/image27.png)](using-failed-request-tracing-to-trace-rewrite-rules/_static/image25.png)

These events show how the rewrite rules were evaluated and how requested URL was modified by rewrite module. Let's walk through some of the events to better understand the rule evaluation logic:

**URL\_REWRITE\_START** - This event indicates the start of the URL rewrite events. The event properties provide the following information:

- The input URL string is "/article/234/some-title".
- There was no query string.
- Scope="Distributed" indicates that rules are local (that is, the rules are defined in the Web.config for the site) as opposed to global (that is, defined on the server level).

**RULE\_EVALUATION\_START** - This event indicates the start of rule evaluation logic. The event properties provides the following information:

- Rule uses regular expressions for pattern syntax (patternSyntax="ECMAScript")
- Subsequent rules will be evaluated (StopProcessing = "false")
- The rule is defined on the site root level (RelativePath = "/")

**PATTERN\_MATCH** - This event provides information on how URL was matched with the rule pattern. The event properties provide the following information:

- Rule pattern was "." (that is, matches any character)
- Input url matched the pattern successfully

**CONDITIONS\_EVALUATION\_START** - Since the input URL matched the pattern the conditions evaluation started

**CONDITION\_EVALUATION** - This event provides the following information:

- The value of HTTP\_HOST was "localhost" and it matched the pattern
- Since the condition negation was specified in the rule (i.e. Negated="true") the condition evaluation did not succeed.

**CONDITIONS\_EVALUATION\_END** - This event shows that evaluation of conditions for this rule did not succeed

**RULE\_EVALUATION\_END** - This event shows that the rule did not modify the URL (Succeeded="false"). This is because rule condition evaluation failed.

**RULE\_EVALUATION\_START** - This even shows that URL string was passed to the second rule

**PATTERN\_MATCH** - This event provides information on how URL was matched with the rule pattern. The event properties tell us that:

- The rule pattern was: "^article/([0-9]+)/([0-9a-z]+)"
- The input URL matched the pattern successfully

**REWRITE\_ACTION** - This event indicates that the rule evaluation succeeded and the URL was rewritten to "/article.aspx" with query string "id=234&amp;title=some-title"

## Summary

URL rewrite specific events logged by FRT provide very detailed information that can be used for troubleshooting and debugging of URL rewrite rules as well as just for understanding how rules evaluation logic is applied to a URL string.