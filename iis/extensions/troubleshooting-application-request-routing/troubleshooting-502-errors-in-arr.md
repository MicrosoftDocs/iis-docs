---
title: "Troubleshooting 502 Errors in ARR | Microsoft Docs"
author: rick-anderson
description: "IIS Failed Request Tracing Network Monitor Winhttp Tracing This material is provided for informational purposes only. Microsoft makes no warranties, express..."
ms.author: iiscontent
manager: soshir
ms.date: 04/09/2012
ms.topic: article
ms.assetid: 
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/troubleshooting-application-request-routing/troubleshooting-502-errors-in-arr
msc.type: authoredcontent
---
Troubleshooting 502 Errors in ARR
====================
by Richard Marr

#### Tools Used in this Troubleshooter:

- IIS Failed Request Tracing
- Network Monitor
- Winhttp Tracing

This material is provided for informational purposes only. Microsoft makes no warranties, express or implied.

## HTTP 502 - Overview

When working with IIS Application Request Routing (ARR) deployments, one of the errors that you may see is &quot;HTTP 502 - Bad Gateway&quot;. The 502.3 error means that - while acting as a proxy - ARR was unable to complete the request to the upstream server and send a response back to the client. This can happen for multiple reasons - for example: failure to connect to the server, no response from the server, or the server took too long to respond (time out). If you are able to reproduce the error by browsing the web farm from the controller, and [detailed errors](https://www.iis.net/learn/troubleshoot/diagnosing-http-errors/how-to-use-http-detailed-errors-in-iis) are enabled on the server, you may see an error similar to the following:

[![Click to Expand](troubleshooting-502-errors-in-arr/_static/image2.png)](troubleshooting-502-errors-in-arr/_static/image1.png)

Figure 1 *(Click image to expand)*


The root cause of the error will determine the actions you should take to resolve the issue.

### 502.3 Timeout Errors

The error code in the screenshot above is significant because it contains the return code from WinHTTP, which is what ARR uses to proxy the request and identifies the reason for the failure.

You can decode the error code with a tool like [err.exe](https://www.microsoft.com/download/en/details.aspx?displaylang=en&id=985). In this example, the error code maps to ERROR\_WINHTTP\_TIMEOUT. You can also find this information in the IIS logs for the associated website on the ARR controller. The following is an excerpt from the IIS log entry for the 502.3 error, with most of the fields trimmed for readability:


| `sc-status` | `sc-substatus` | `sc-win32-status` | `time-taken` |
| --- | --- | --- | --- |
| `502` | `3` | `12002` | `29889` |


The win32 status 12002 maps to the same ERROR\_WINHTTP\_TIMEOUT error reported in the error page.

#### What exactly timed-out?

We investigate this a bit further by enabling [Failed Request Tracing](https://www.iis.net/learn/troubleshoot/using-failed-request-tracing/troubleshooting-failed-requests-using-tracing-in-iis) on the IIS server. The first thing we can see in the failed request trace log is where the request was sent to in the ARR\_SERVER\_ROUTED event. The second item I have highlighted is what you can use to track the request on the target server, the X-ARR-LOG-ID. This will help if you are tracing the target or destination of the HTTP request:


| 77. | ARR\_SERVER\_ROUTED | RoutingReason=&quot;LoadBalancing&quot;, Server=&quot;192.168.0.216&quot;, State=&quot;Active&quot;, TotalRequests=&quot;3&quot;, FailedRequests=&quot;2&quot;, CurrentRequests=&quot;1&quot;, BytesSent=&quot;648&quot;, BytesReceived=&quot;0&quot;, ResponseTime=&quot;15225&quot; 16:50:21.033 |
| --- | --- | --- |
| 78. | GENERAL\_SET\_REQUEST\_HEADER | HeaderName=&quot;Max-Forwards&quot;, HeaderValue=&quot;10&quot;, Replace=&quot;true&quot; 16:50:21.033 |
| 79. | GENERAL\_SET\_REQUEST\_HEADER | HeaderName=&quot;X-Forwarded-For&quot;, HeaderValue=&quot;192.168.0.204:49247&quot;, Replace=&quot;true&quot; 16:50:21.033 |
| 80. | GENERAL\_SET\_REQUEST\_HEADER | HeaderName=&quot;X-ARR-SSL&quot;, HeaderValue=&quot;&quot;, Replace=&quot;true&quot; 16:50:21.033 |
| 81. | GENERAL\_SET\_REQUEST\_HEADER | HeaderName=&quot;X-ARR-ClientCert&quot;, HeaderValue=&quot;&quot;, Replace=&quot;true&quot; 16:50:21.033 |
| 82. | GENERAL\_SET\_REQUEST\_HEADER | HeaderName=&quot;X-ARR-LOG-ID&quot;, HeaderValue=&quot;dbf06c50-adb0-4141-8c04-20bc2f193a61&quot;, Replace=&quot;true&quot; 16:50:21.033 |
| 83. | GENERAL\_SET\_REQUEST\_HEADER | HeaderName=&quot;Connection&quot;, HeaderValue=&quot;&quot;, Replace=&quot;true&quot; 16:50:21.033 |


The following example shows how this might look on the target server's Failed Request Tracing logs; you can validate that you have found the correct request by matching up the &quot;X-ARR-LOG\_ID&quot; values in both traces.


| 185. | GENERAL\_REQUEST\_HEADERS Headers=&quot;Connection: Keep-Alive Content-Length: 0 Accept: \*/\* Accept-Encoding: gzip, deflate Accept-Language: en-US Host: test Max-Forwards: 10 User-Agent: Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0) X-Original-URL: /time/ X-Forwarded-For: 192.168.0.204:49247 X-ARR-LOG-ID: dbf06c50-adb0-4141-8c04-20bc2f193a61 |
| --- | --- |
| *&lt;multiple entries skipped for brevity&gt;* |
| 345. | GENERAL\_FLUSH\_RESPONSE\_END BytesSent=&quot;0&quot;, ErrorCode=&quot;An operation was attempted on a nonexistent network connection. (0x800704cd)&quot; 16:51:06.240 |


In the above example, we can see that the ARR server disconnected before the HTTP response was sent. The timestamp for GENERAL\_FLUSH\_RESPONSE\_END can be used as a rough guide to find the corresponding entry in the IIS logs on the destination server.


| `date` | `time` | `s-ip` | `cs-method` | `cs-uri-stem` | `cs-uri-query` | `s-port` | `cs-username` | `sc-status` | `sc-substatus` | `sc-win32-status` | `time-taken` |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| `2011-07-18` | `16:51:06` | `92.168.0.216` | `GET` | `/time/` | `-` | `80` | `-` | `200` | `0` | `64` | `45208` |


Note that IIS on the destination server logged an HTTP 200 status code, indicating that the request completed successfully. Also note that the win32 status has changed to 64, which maps to ERROR\_NETNAME\_DELETED. This generally indicates that the client (ARR being the 'client' in this case) had disconnected before the request completed.

#### What happened?

Only the ARR server is reporting a timeout, so that is where we should look first.

In the IIS log entry from the ARR server, we can see that the time-taken is very close to 30 seconds, but the member server log shows that it took 45 seconds (45208 ms) to send the response. This suggests that ARR is timing the request out, and if we check the proxy timeout in the server farm's proxy settings, we will see that it is set to 30 seconds by default.

So in this case we can clearly see that the ARR timeout was shorter than the execution of the request. Therefore, you would want to investigate whether this execution time was normal or whether you would need to look at why the request was taking longer than expected. If this execution time was expected and normal, increasing the ARR timeout should resolve the error.

Other possible reasons for **ERROR\_WINHTTP\_TIMEOUT** include:

- **ResolveTimeout**: This occurs if name resolution takes longer than the specified timeout period.
- **ConnectTimeout**: This occurs if it takes longer than the specified timeout period to connect to the server after the name resolved.
- **SendTimeout**: If sending a request takes longer than this time-out value, the send operation is canceled.
- **ReceiveTimeout**: If a response takes longer than this time-out value, the request is canceled.

Looking at the first two examples, ResolveTimeout and ConnectTimeout, the troubleshooting methodology outlined above would not work. This is because you would not see any traffic on the target server and therefore would not know the error code. Thus in this case of ResolveTimeout or ConnectTimeout you would want to capture a WinHTTP trace for additional insight. See the WinHTTP/WEBIO Tracing section of this troubleshooter as well as the following blogs for additional examples on troubleshooting and tracing:

- [502.3 Bad Gateway &quot;The operation timed out&quot; with IIS Application Request Routing (ARR)](https://blogs.iis.net/richma/archive/2010/07/03/502-3-bad-gateway-the-operation-timed-out-with-iis-application-request-routing-arr.aspx)
- [Winhttp Tracing Options for Troubleshooting with Application Request Routing](https://blogs.iis.net/richma/archive/2012/08/24/winhttp-tracing-options-for-troubleshooting-with-application-request-routing.aspx)

### 502.3 Connection Termination Errors

502.3 errors are also returned when the connection between ARR and the member server is disconnected mid-stream. To test this type of problem, create a simple .aspx page that calls Response.Close(). In the following example there is a directory called &quot;time&quot; which is configured with a simple aspx page as the default document of that directory. When browsing to the directory, ARR will display this error:

[![Click to Expand](troubleshooting-502-errors-in-arr/_static/image4.png)](troubleshooting-502-errors-in-arr/_static/image3.png)

Figure 2 *(Click image to expand)*


The error 0x80072efe corresponds to ERROR\_INTERNET\_CONNECTION\_ABORTED. The request can be traced to the server that actually processed it using the same steps used earlier in this troubleshooter, with one exception; while Failed Request Tracing on the destination server shows the request was processed on the server, the associated log entry does not appear in the IIS logs. Instead, this request is logged in the HTTPERR log as follows:

[!code-unknown[Main](troubleshooting-502-errors-in-arr/samples/sample-127559-1.unknown)]

The built-in logs on the destination server do not provide any additional information about the problem, so the next step would be to gather a network trace from the ARR server. In the example above, the .aspx page called Response.Close() without returning any data. Viewing this in a network trace would show that a **Connection: close** HTTP header was coming from the destination server. With this information you could now start an investigation into why the **Connection: close** header was sent.

The error below is another example of an invalid response from the member server:

[![Click to Expand](troubleshooting-502-errors-in-arr/_static/image6.png)](troubleshooting-502-errors-in-arr/_static/image5.png)

Figure 3 *(Click image to expand)*


In this example, ARR started to receive data from the client but something went wrong while reading the request entity body. This results in the 0x80072f78 error code being returned. To investigate further, use Network Monitor on the member server to get a network trace of the problem. This particular error example was created by calling Response.Close() in the ASP.net page after sending part of the response and then calling Response.Flush(). If the traffic between the ARR server and the member servers is over SSL, then [WinHTTP](https://technet.microsoft.com/en-us/library/cc731131(WS.10).aspx) tracing on Windows Server 2008 or [WebIO](https://blogs.msdn.com/b/jpsanders/archive/2009/08/24/using-netsh-to-analyze-wininet-problems-in-windows-7.aspx) tracing on Windows Server 2008 R2 may provide additional information. WebIO tracing is described later in this troubleshooter.

### 502.4 No appropriate server could be found to route the request

The HTTP 502.4 error with an associated error code of 0x00000000 generally indicates that all the members of the farm are either offline, or otherwise unreachable.

[![Click to Expand](troubleshooting-502-errors-in-arr/_static/image8.png)](troubleshooting-502-errors-in-arr/_static/image7.png)

Figure 4 *(Click image to expand)*


The first step is to verify that the member servers are actually online. To check this, go to the &quot;servers&quot; node under the farm in the IIS Manager.

[![Click to Expand](troubleshooting-502-errors-in-arr/_static/image10.png)](troubleshooting-502-errors-in-arr/_static/image9.png)

Figure 5 *(Click image to expand)*


Servers that are offline can be brought back online by right-clicking on the server name and choosing &quot;Add to Load Balancing&quot;. If you cannot bring the servers back online, verify the member servers are reachable from the ARR server. The &quot;trace Messages&quot; pane on the &quot;servers&quot; page may also provide some clues about the problem. If you are using Web Farm Framework (WFF) 2.0, you may receive this error if the application pool restarts. You will need to restart the Web Farm Service to recover.

### WinHTTP/WebIO Tracing

Usually, Network Monitor will provide you with the information you need to identify exactly what is timing out, however there are times (such as when the traffic is SSL encrypted) that you will need to try a different approach. On Windows 7 and Windows Server 2008R2 you can enable WinHTTP tracing using the netsh tool by running the following command from an administrative command prompt:

[!code-console[Main](troubleshooting-502-errors-in-arr/samples/sample2.cmd)]

Then, reproduce the problem. Once the problem is reproduced, stop the tracing by running the following command from the command prompt:

[!code-console[Main](troubleshooting-502-errors-in-arr/samples/sample3.cmd)]

The stop command will take a few seconds to finish. When it is done, you will find a net.etl file and a net.cab file in C:\temp. The .cab file contains event logs and additional data that may prove helpful in analyzing the .etl file.

To analyze the log, open it in Netmon 3.4 or later. Make sure you have set up your parser profile as described [here](https://blogs.msdn.com/b/jpsanders/archive/2009/08/24/using-netsh-to-analyze-wininet-problems-in-windows-7.aspx). Scroll through the trace until you find the w3wp.exe instance where ARR is running by correlating with the &quot;UT process name&quot; column. Right click on w3wp and choose &quot;Add UT Process name to display filter&quot;. This will set the display filter similar to:

[!code-console[Main](troubleshooting-502-errors-in-arr/samples/sample4.cmd)]

You can further filter the results by changing it to the following:

[!code-console[Main](troubleshooting-502-errors-in-arr/samples/sample5.cmd)]

You will need to scroll through the output until you find the timeout error. In the example below, a request timed out because it took more than 30 seconds (ARR's default timeout) to run.


| 336 | 2:32:22 PM | 7/22/2011 | 32.6380453 | w3wp.exe (1432) | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:32:23.123 ::sys-recver starts in \_INIT state |
| --- | --- | --- | --- | --- | --- | --- |
| 337 | 2:32:22 PM | 7/22/2011 | 32.6380489 | w3wp.exe (1432) | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:32:23.123 ::current thread is not impersonating |
| 340 | 2:32:22 PM | 7/22/2011 | 32.6380584 | w3wp.exe (1432) | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:32:23.123 ::sys-recver processing WebReceiveHttpResponse completion (error-cdoe = ? (0x5b4), overlapped = 003728F0)) |
| 341 | 2:32:22 PM | 7/22/2011 | 32.6380606 | w3wp.exe (1432) | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:32:23.123 ::sys-recver failed to receive headers; error = ? (1460) |
| 342 | 2:32:22 PM | 7/22/2011 | 32.6380800 | w3wp.exe (1432) | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:32:23.123 ::ERROR\_WINHTTP\_FROM\_WIN32 mapped (?) 1460 to (ERROR\_WINHTTP\_TIMEOUT) 12002 |
| 343 | 2:32:22 PM | 7/22/2011 | 32.6380829 | w3wp.exe (1432) | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:32:23.123 ::sys-recver returning ERROR\_WINHTTP\_TIMEOUT (12002) from RecvResponse() |
| 344 | 2:32:22 PM | 7/22/2011 | 32.6380862 | w3wp.exe (1432) | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:32:23.123 ::sys-req completes recv-headers inline (sync); error = ERROR\_WINHTTP\_TIMEOUT (12002) |


In this next example, the content server was completely offline:


| 42 | 2:26:39 PM | 7/22/2011 | 18.9279133 | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:26:39.704 ::WinHttpReceiveResponse(0x11d23d0, 0x0) | {WINHTTP\_MicrosoftWindowsWinHttp:4, NetEvent:3} |
| --- | --- | --- | --- | --- | --- | --- |
| 43 | 2:26:39 PM | 7/22/2011 | 18.9279633 | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:26:39.704 ::sys-recver starts in \_INIT state | {WINHTTP\_MicrosoftWindowsWinHttp:4, NetEvent:3} |
| 44 | 2:26:39 PM | 7/22/2011 | 18.9280469 | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:26:39.704 ::current thread is not impersonating | {WINHTTP\_MicrosoftWindowsWinHttp:4, NetEvent:3} |
| 45 | 2:26:39 PM | 7/22/2011 | 18.9280776 | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:26:39.704 ::sys-recver processing WebReceiveHttpResponse completion (error-cdoe = WSAETIMEDOUT (0x274c), overlapped = 003728F0)) | {WINHTTP\_MicrosoftWindowsWinHttp:4, NetEvent:3} |
| 46 | 2:26:39 PM | 7/22/2011 | 18.9280802 | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:26:39.704 ::sys-recver failed to receive headers; error = WSAETIMEDOUT (10060) | {WINHTTP\_MicrosoftWindowsWinHttp:4, NetEvent:3} |
| 47 | 2:26:39 PM | 7/22/2011 | 18.9280926 | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:26:39.704 ::ERROR\_WINHTTP\_FROM\_WIN32 mapped (WSAETIMEDOUT) 10060 to (ERROR\_WINHTTP\_TIMEOUT) 12002 | {WINHTTP\_MicrosoftWindowsWinHttp:4, NetEvent:3} |
| 48 | 2:26:39 PM | 7/22/2011 | 18.9280955 | WINHTTP\_MicrosoftWindowsWinHttp | WINHTTP\_MicrosoftWindowsWinHttp:12:26:39.704 ::sys-recver returning ERROR\_WINHTTP\_TIMEOUT (12002) from RecvResponse() | {WINHTTP\_MicrosoftWindowsWinHttp:4, NetEvent:3} |


### Other Resources

- [ERR.EXE](https://www.microsoft.com/download/en/details.aspx?displaylang=en&id=985)
- [Winhttp Error Codes](https://msdn.microsoft.com/en-us/library/aa383770(VS.85).aspx)
- [Failed Request Tracing](https://www.iis.net/learn/troubleshoot/using-failed-request-tracing/troubleshooting-failed-requests-using-tracing-in-iis)
- [Winhttp Tracing](https://technet.microsoft.com/en-us/library/cc731131(WS.10).aspx)
- [Network Monitor](https://www.microsoft.com/download/en/details.aspx?displaylang=en&id=4865)