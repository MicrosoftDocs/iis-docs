---
title: "How to Use HTTP Detailed Errors in IIS 7.0 | Microsoft Docs"
author: rick-anderson
description: "Every Web-Site Administrator or Web Developer has seen '404 - File not found' , '401 - Unauthorized' or '500 - Server Error' messages in his browser. This ar..."
ms.author: iiscontent
manager: soshir
ms.date: 12/12/2007
ms.topic: article
ms.assetid: 33897393-97b8-4ee1-836f-25b1348dc3a3
ms.technology: iis-troubleshoot
ms.prod: iis
msc.legacyurl: /learn/troubleshoot/diagnosing-http-errors/how-to-use-http-detailed-errors-in-iis
msc.type: authoredcontent
---
How to Use HTTP Detailed Errors in IIS 7.0
====================
by IIS Team

## Introduction

Every Web-Site Administrator or Web Developer has seen "404 - File not found" , "401 - Unauthorized" or "500 - Server Error" messages in his browser. This article helps you understand how and why IIS generates these errors and how they can be configured.

Many might think that generating error messages does not seem to justify a full article. But there is more to errors than meets the eye. Error messages are a sensitive topic, because every error reveals more about your web-site than you might want revealed. The more information someone can gather about your site, the likelier it is that you will be hacked. A search for "google hacking" or "cross-site scripting" reveals a wealth of information on this topic.

However, error messages are also a valuable tool to troubleshoot problems. Developers and Web-Site Administrators require as much detail as possible when an error occurs. Ideally the error message gives recommendations on how to fix the problem. Here is how IIS addresses these fundamentally opposed goals.

## Errors, What Errors?

This article talks about HTTP errors as specified in the HTTP RFC [(RFC 2616](http://www.ietf.org/rfc/rfc2616.txt) - section 6.1.1). An HTTP error is always expressed by sending a response with a status code greater than 400 back to the requesting client.

### Client Errors

Status codes between 400 and 500 specify an error that the client made, e.g. bad syntax or a request to a resource that doesn't exist. You can try this by requesting a bogus URL from the web-site of your choice, for example: http://&lt;IIS7Server&gt;/this\_resource\_does\_not\_exist. You get a "404 - File not found" error.

### Server Errors

Status codes starting with 500 are errors caused by the server. The most common causes for 500 errors on IIS systems are:

- An ASP or ASPX page that contains a syntax error
- The web server configuration or the application configuration cannot be read or is invalid
- The site is stopped

It is important to note that browsers like IE often replace errors returned from a web server with their own errors. This makes troubleshooting harder. In IE you can turn this feature off. Go to the "Tools" menu, select "Internet Options", click the "Advanced" tab and find the "Show friendly HTTP error messages" check box and uncheck it. To see the raw response, use HTTP tools like WFETCH in the IIS 6.0 Resource Kit (see "Related Links").

## HTTP Errors in IIS

There are two things that can happen when the httpError module (custerr.dll) encounters an error:

- A custom error is generated
- A detailed error is generated

Custom errors are error pages that the regular users of your web-site see. They contain a brief error description of why the error happened, but nothing else. Here is the custom error generated when you request a resource that does not exist, for example: http://&lt;IIS7Server&gt;/this\_resource\_does\_not\_exist

[![](how-to-use-http-detailed-errors-in-iis/_static/image2.jpg)](how-to-use-http-detailed-errors-in-iis/_static/image1.jpg)

Detailed errors are intended for local administrators and developers. They are supposed to provide information that helps to immediately fix the problem. Here is an example of the same request, but now returning a Detailed Error:

[![](how-to-use-http-detailed-errors-in-iis/_static/image5.jpg)](how-to-use-http-detailed-errors-in-iis/_static/image4.jpg)

This is dangerous, because Detailed Errors contain information about the inner workings of your web-site. Only trusted personel should see a Detailed Error. The only way to ensures this is to only generate a detailed error if the request comes from the local machine. As soon as the request is not local, a custom error is generated. Look at the following flow diagram:

[![](how-to-use-http-detailed-errors-in-iis/_static/image7.jpg)](how-to-use-http-detailed-errors-in-iis/_static/image6.jpg)

### Data Flow

*First: Error check*

The httpError module receives a notification if a response is about to be sent (RQ\_SEND\_RESPONSE notification). The httpError module checks the status code of this response and immediately returns if the status code is not greater than 400.

*Second: Custom Error or Detailed Error*

The next check is determined by the request origin (is the request a local or remote request) and the setting of the errorMode property. The errorMode property is set to DetailedLocalOnly, which means that Custom Errors are generated for every remote request. If errorMode is set to "Custom", then all error responses will become Custom Error. If errorMode is set to "Detailed" all error responses will become Detailed Errors. The following table clarifies this behavior:


| errorMode | Request origin | Action |
| --- | --- | --- |
| DetailedLocalOnly (default) | Local | Detailed Error |
| DetailedLocalOnly (default) | Remote | Custom Error |
| Custom | Local | Custom Error |
| Custom | Remote | Custom Error |
| Detailed | Local | Detailed Error |
| Detailed | Remote | Detailed Error |


If the httpError module determines that a Custom Error must be generated, it looks into its configuration to see if it can find a matching error. If a match is found, it sends the static file, redirects the request or executes the URL specified. If no match can be found, IIS send a basic one-line message containing the status code. The next section explains the Custom Error configuration in detail.

If custerr.dll determines that a Detailed Error must be generated, another check is needed. IIS does not touch the response if a module overrode the entity of the response with its own error description. It might contain valuable information. ASP.NET is a good example. The entity of an ASP.NET error response might contain the exception stack and its own error description. A Detailed Error is only generated if the entity body of the response is empty.

## &lt;httpErrors&gt; Configuration

Here is the IIS custom error section obtained on a clean install:

[!code-xml[Main](how-to-use-http-detailed-errors-in-iis/samples/sample1.xml)]

You see that if the status code of a response is 401, IIS will return a file named 401.htm.

### Sub-Status Codes

Many HTTP errors have a sub-status. The IIS default Custom Errors configuration does not differentiate based sub-status codes. It sends the same Custom Error page if you enter the wrong credentials (401.1), or if you get access denied based on invalid rights to access a file (401.3). You can see the different sub-status codes in the log files or via Detailed Errors. Here is a list of the different 404 sub-status codes that IIS produces:


| Status | Description |
| --- | --- |
| 404.1 | Site could not be found |
| 404.2 | Denied by Policy. The request ISAPI or CGI program is not allowed in the Restriction List. |
| 404.3 | The static file handler did not have the file in its MimeMap and therefore rejected the request. |
| 404.4 | No handler was found to serve the request. |
| 404.5 | The Request Filtering Module rejected an URL sequence in the request. |
| 404.6 | The Request Filtering Module denied the HTTP verb of the request. |
| 404.7 | The Request Filtering module rejected the file extension of the request. |
| 404.8 | The Request Filtering module rejected a particular URL segment (characters between two slashes). |
| 404.9 | IIS rejected to serve a hidden file. |
| 404.10 | The Request Filtering module rejected a header that was too long. |
| 404.11 | The Request Filtering module rejected a request that was double escaped. |
| 404.12 | The Request Filtering module rejected a request that contained high bit characters. |
| 404.13 | The Request Filtering module rejected a request that was too long (request + entity body). |
| 404.14 | The Request Filtering module rejected a request with a URL that was too long. |
| 404.15 | The Request Filtering module rejected a request with a too long query string. |


You can configure the httpErrors section to show a Custom Error for particular sub-status codes. If you add the following line to the httpErrors configuration section, IIS returns 404\_3.htm if a file with a file extension is requested that is not included in the IIS MimeMap (&lt;staticContent&gt; configuration section).

[!code-xml[Main](how-to-use-http-detailed-errors-in-iis/samples/sample2.xml)]

Here is how to make the example work:

1. Add the entry above to your httpErrors configuration section.
2. Create a file named 404\_3.htm in your c:\inetpub\custerr\en-us directory.
3. Create a file named test.yyy in you c:\inetpub\wwwroot directory.
4. Now request [http://localhost/test.yyy](http://localhost/test.yyy)

The file extension .yyy is not part of the IIS MimeMap and the static file handler will not serve it.

## New in IIS: Language-specific Custom Errors

Each more recent browser includes the language of the client as a request header. Here is an example of how this header might look:

[!code-console[Main](how-to-use-http-detailed-errors-in-iis/samples/sample3.cmd)]

The syntax and registry of accepted languages is specified in [RFC1766](http://www.ietf.org/rfc/rfc1766.txt).

When generating an error, IIS takes this header into account when it looks for the custom error file it returns. It generates the path for the custom error using the following logic:

prefixLanguageFilePath configuration setting (for example c:\inetpub\custerr)+   
Accept-Language header sent by the client (for example en-us) +   
Path configuration setting (for example 404.htm)

Example:

If the browser sends a request for an non-existing resource and the "Accept-Language" header has the value of "en-us," the file that gets returned will be "c:\inetpub\custerr\en-us\404.htm".

For example, if you are from Germany, you want your error messages in German. To do this, you must install the Windows Vista Language Pack for German. This creates the c:\inetpub\custerr\de-DE directory with custom error files in it. Now if the browser sends the "Accept-Language" header with the value of "de-DE, the file that gets returned will be "c:\inetpub\custerr\de-DE\404.htm".

IIS will always fall back to the system language if the directory "de-DE" does not exist.

> [!NOTE]
> Internet Explorer allows you to configure the Accept-Language header. Go to "Tools" - "Internet Option", select the "General" tab and click the "Languages" button.

## Custom Error Options

In the above examples, IIS sends the contents of the file as the custom error response. IIS has two other ways to respond to an error: by executing an URL or by redirecting the request.

## ExecuteUrl

If you want to do more in your custom error, e.g. sending an e-mail or logging the error to a database, you can execute an url. This allows you to execute dynamic content like an ASP.NET page. The example below replaces the 404 custom error. Now IIS executes /404.aspx whenever a 404 error occurs.

[!code-xml[Main](how-to-use-http-detailed-errors-in-iis/samples/sample4.xml)]

## Security Considerations

A word of caution: For architectural reasons, IIS can only execute the URL if it is located in the same Application Pool. Use the redirect feature to execute a Custom Error in a different Application Pool.


IIS can also return a 302 Redirect to the browser when a particular error occurs. Redirect is good if you have a server farm. For instance, you can redirect all your errors to a central location that you closely monitor.

There is risk however: responseMode="File" (which is the default) allows you to specify every file on the disk. This will not work if you are very security conscious.

A workable scenario might include only allowing the delegation of the errorMode setting. This enables a developer to receive Detailed Errors for his application even if he is using a remote client. All that is necessary is to set errorMode="Detailed". Here is how to configure this scenario:

Allow the delegation of the httpErrors section:

[!code-xml[Main](how-to-use-http-detailed-errors-in-iis/samples/sample5.xml)]

Second, go to the &lt;httpErrors&gt; section in applicationHost.config and change it so that only errorMode is delegated:

[!code-xml[Main](how-to-use-http-detailed-errors-in-iis/samples/sample6.xml)]

## Summary

Custom and Detailed Errors are powerful IIS features. They help you to troubleshoot problems without compromising the security of your IIS Server. Many configuration options help you to custom tailor your users' experience. Most importantly: experimenting with it is fun.


[Discuss in IIS Forums](https://forums.iis.net/1052.aspx)