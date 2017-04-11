---
title: "Troubleshooting HTTP 400 Errors in IIS | Microsoft Docs"
author: rick-anderson
description: "This article describes the troubleshooting steps to identify the cause of various HTTP 400 errors when using IIS."
ms.author: iiscontent
manager: soshir
ms.date: 11/27/2012
ms.topic: article
ms.assetid: 
ms.technology: iis-troubleshoot
ms.prod: iis
msc.legacyurl: /learn/troubleshoot/diagnosing-http-errors/troubleshooting-http-400-errors-in-iis
msc.type: authoredcontent
---
Troubleshooting HTTP 400 Errors in IIS
====================
by Mike Laing

### Tools Used in this Troubleshooter:

- Network Monitor
- HTTP Error logging

This material is provided for informational purposes only. Microsoft makes no warranties, express or implied.

## Overview

After sending an HTTP request to an IIS server, an HTTP client (such as Internet Explorer) may display the following type of error message:


| ![](troubleshooting-http-400-errors-in-iis/_static/image1.png) | The webpage cannot be found. HTTP 400 Most likely causes: - There might be a typing error in the address. - If you clicked on a link, it may be out of date. What you can try: - Retype the address. - Go back to the previous page. - Go to Bing and look for the information you want. |
| --- | --- |


If the HTTP client is Internet Explorer, and the Show Friendly HTTP Error Messages option is turned off, the error may resemble the following:

Bad Request

In these scenarios, IIS has rejected the client's HTTP request because the request did not meet the server's HTTP parsing rules, or it exceeded time limits, or failed some other rule that IIS or HTTP.sys require incoming requests to adhere to. IIS sends the HTTP 400 - Bad Request status back to the client, and then terminates the TCP connection.

## Troubleshooting Methods

When troubleshooting an HTTP 400 condition, it is important to remember that the underlying problem is that the client has sent a request to IIS that breaks one or more rules that HTTP.sys is enforcing. With that in mind, you will want to see exactly what the client is sending to IIS; to do this, capture a network trace of the client sending the bad request. You can analyze the trace to see the raw data that the client sends to IIS, and to see the raw response data that IIS sends back to the client. You can also use an HTTP sniffer tool called Fiddler; this is a great tool as it allows you to see the HTTP headers even if the client and server are communicating over SSL.

The next data item you will want to use is the C:\Windows\System32\LogFiles\HTTPERR\httperr.log file. Beginning in IIS 6.0, the HTTP.sys component handles incoming HTTP requests before they are passed along to IIS, and is the component responsible for blocking requests that don't meet the IIS requirements. When HTTP.sys blocks the request, it will log information to its httperr.log file concerning the bad request and why it was blocked.

NOTE: For more information on the HTTP API error logging that HTTP.sys provides, see the following article:

- **Error logging in HTTP API**  
    [https://support.microsoft.com/kb/820729](https://support.microsoft.com/kb/820729)

It is technically possible, although not very likely, that a client will receive an HTTP 400 response which does not have an associated log entry in the httperr.log. This could happen if an ISAPI filter or extension or an HTTP module in IIS sets the 400 status, in which case you could look at the IIS log for more information. It could also happen if an entity between the client and the server, such as a proxy server or other network device, intercepts a response from IIS and overrides it with its own 400 status and/or &quot;Bad Request&quot; error.

## Sample Scenario

Following is an example of an HTTP 400 scenario, where a client sends a bad request to IIS and the server sends back an HTTP 400 - Bad Request message.

When the client sends its request, the browser error it gets back looks like this:

Bad Request (Header Field Too Long)

Capturing a network trace of the request and response, we see the following raw request/response:

REQUEST:

[!code-console[Main](troubleshooting-http-400-errors-in-iis/samples/sample1.cmd)]

RESPONSE:

[!code-console[Main](troubleshooting-http-400-errors-in-iis/samples/sample2.cmd)]

You'll notice that the response headers don't tell us as much as the error message in the browser. However if we look at the raw data in the response body, we'll see more:


| `00000030` |  |  |  |  |  |  |  |  |  |  |  |  |  |  | `48` | `54` | `HT` |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| `00000040` | `54` | `50` | `2F` | `31` | `2E` | `31` | `20` | `34` | `30` | `30` | `20` | `42` | `61` | `64` | `20` | `52` | `TP/1.1.400.Bad.R` |
| `00000050` | `65` | `71` | `75` | `65` | `73` | `74` | `0D` | `0A` | `43` | `6F` | `6E` | `74` | `65` | `6E` | `74` | `2D` | `equest..Content-` |
| `00000060` | `54` | `79` | `70` | `65` | `3A` | `20` | `74` | `65` | `78` | `74` | `2F` | `68` | `74` | `6D` | `6C` | `0D` | `Type:.text/html.` |
| `00000070` | `0A` | `44` | `61` | `74` | `65` | `3A` | `20` | `57` | `65` | `64` | `2C` | `20` | `32` | `38` | `20` | `4A` | `.Date:.Wed,.28.J` |
| `00000080` | `61` | `6E` | `20` | `32` | `30` | `30` | `39` | `20` | `32` | `30` | `3A` | `33` | `36` | `3A` | `33` | `36` | `an.2009.20:36:36` |
| `00000090` | `20` | `47` | `4D` | `54` | `0D` | `0A` | `43` | `6F` | `6E` | `6E` | `65` | `63` | `74` | `69` | `6F` | `6E` | `.GMT..Connection` |
| `000000A0` | `3A` | `20` | `63` | `6C` | `6F` | `73` | `65` | `0D` | `0A` | `43` | `6F` | `6E` | `74` | `65` | `6E` | `74` | `:.close..Content` |
| `000000B0` | `2D` | `4C` | `65` | `6E` | `67` | `74` | `68` | `3A` | `20` | `34` | `34` | `0D` | `0A` | `0D` | `0A` | `3C` | `-Length:.44....<` |
| `000000C0` | `68` | `31` | `3E` | `42` | `61` | `64` | `20` | `52` | `65` | `71` | `75` | `65` | `73` | `74` | `20` | `28` | `h1>Bad.Request.(` |
| `000000D0` | `48` | `65` | `61` | `64` | `65` | `72` | `20` | `46` | `69` | `65` | `6C` | `64` | `20` | `54` | `6F` | `6F` | `Header.Field.Too` |
| `000000E0` | `20` | `4C` | `6F` | `6E` | `67` | `29` | `3C` | `2F` | `68` | `31` | `3E` | `01` | `02` | `03` | `04` | `05` | `.Long)</h1>.....` |
| `000000F0` | `05` | `06` | `0E` | `94` | `63` | `D6` | `68` | `37` | `1B` | `8C` | `16` | `FE` | `3F` | `D5` |  |  | `....c.h7....?.` |


You can see that the error message text displayed in the browser is also viewable in the raw response data in the network trace.

The next step is to look at the httperr.log file in the C:\Windows\System32\LogFiles\HTTPERR directory for the entry that corresponds to the bad request:

[!code-console[Main](troubleshooting-http-400-errors-in-iis/samples/sample3.cmd)]

In this scenario, the Reason field in the httperr.log file gives us the exact information we need to diagnose the problem. We see here that HTTP.sys logged FieldLength as the reason phrase for this request's failure. Once we know the reason phrase, we can use the Error Logging in HTTP API article mentioned above to get its description:

[!code-console[Main](troubleshooting-http-400-errors-in-iis/samples/sample4.cmd)]

So at this point we know from the browser error message and the HTTP API error logging that the request contained data in one of its HTTP headers that exceeded the allowable length limits. For the purpose of this example, the HTTP: Uniform Resource Identifier header is purposefully long: /1234567890123456789012345678901234567890/time.asp.

The final stage of troubleshooting this example is to use the following article to see the HTTP.sys registry keys and default settings for IIS:

- **Http.sys registry settings for IIS**  
    [https://support.microsoft.com/kb/820129](https://support.microsoft.com/kb/820129)

Since we know the reason phrase and error are suggesting a header field length exceeding limits, we can narrow our search in KB820129 as such. The prime candidate here is:

MaxFieldLength: Sets an upper limit for each header. See MaxRequestBytes. This limit translates to approximately 32k characters for a URL.

To reproduce this error for this example, the MaxFieldLength registry key was set with a value of 2. Since the requested URL had a HTTP: Uniform Resource Identifier header field with more than 2 characters, the request was blocked with the FieldLength reason phrase.

Another common HTTP 400 scenario is one where the user making the HTTP request is a member of a large number of Active Directory groups, and the web site is configured to user Kerberos authentication. When this occurs, an error message similar to the following will be displayed to the user:

Bad Request (Request Header Too Long)

In this scenario, the authentication token that is included as part of the client's HTTP request is too big and exceeds size limits that http.sys is enforcing. This problem is discussed in detail, along with the solution, in the following Knowledge Base article:

- **&quot;HTTP 400 - Bad Request (Request Header too long)&quot; error in Internet Information Services (IIS)**  
    [https://support.microsoft.com/kb/2020943](https://support.microsoft.com/kb/2020943)

### Other Resources

- **Error logging in HTTP API**  
    [https://support.microsoft.com/kb/820729](https://support.microsoft.com/kb/820729)
- **Http.sys registry settings for IIS**  
    [https://support.microsoft.com/kb/820129](https://support.microsoft.com/kb/820129)