---
title: "Troubleshooting Forms Authentication"
author: apurvajo
description: "Tools Used in this Troubleshooter: LogParser 2.2 Fiddler Microsoft Network Monitor 3.4 This material is provided for informational purposes only. Microsoft m..."
ms.date: 04/09/2012
ms.assetid: 396f3ac6-fc21-4fa9-b607-1767b0929336
msc.legacyurl: /learn/troubleshoot/security-issues/troubleshooting-forms-authentication
msc.type: authoredcontent
---
# Troubleshooting Forms Authentication

by [Apurva Joshi](https://github.com/apurvajo)

#### Tools Used in this Troubleshooter:

- LogParser 2.2
- Fiddler
- Microsoft Network Monitor 3.4

This material is provided for informational purposes only. Microsoft makes no warranties, express or implied.

## Overview

Often, while using Forms Authentication in an ASP.NET web application; there is a need to troubleshoot a problem that occurs when a fresh or an ongoing request is intermittently redirected to the application's login page. You can easily debug this problem on Visual Studio IDE by attaching a debugger in a development environment. In production environments, however, the task becomes hectic and problematic. To troubleshoot a random problem like this one, you need to log information related to the problem so that you can narrow down the root cause.

In this troubleshooter guide, we'll briefly cover the Forms Authentication concept. We'll then look into which scenarios lead to a user being redirected to the login page and how to capture data that is relevant to isolating the problem. We'll also cover how to implement an IHttpModule interface to log the Forms Authentication information.

**ASP.NET Forms Authentication Overview**

Forms authentication lets you authenticate users by using your own code and then maintain an authentication token in a cookie or in the page URL. Forms authentication participates in the ASP.NET page life cycle through the FormsAuthenticationModule class. You can access forms authentication information and capabilities through the FormsAuthentication class.

To use forms authentication, you create a login page that collects credentials from the user and that includes code to authenticate the credentials. Typically you configure the application to redirect requests to the login page when users try to access a protected resource, such as a page that requires authentication. If the user's credentials are valid, you can call methods of the FormsAuthentication class to redirect the request back to the originally requested resource with an appropriate authentication ticket (cookie). If you do not want the redirection, you can just get the forms authentication cookie or set it. On subsequent requests, the user's browser passes the authentication cookie with the request, which then bypasses the login page.

By default, the FormsAuthenticationModule class is added in the Machine.config file. The FormsAuthenticationModule class manages the FormsAuthentication process.

The following is an entry from the Machine.config file:

[!code-xml[Main](troubleshooting-forms-authentication/samples/sample1.xml)]

You configure forms authentication by using the authentication configuration element. In the simplest case, you have a login page. In the configuration file, you specify a URL to redirect unauthenticated requests to the login page. You then define valid credentials, either in the Web.config file or in a separate file. The following example shows a section from a configuration file that specifies a login page and authentication credentials for the Authenticate method. The passwords have been encrypted by using the HashPasswordForStoringInConfigFile method.

[!code-xml[Main](troubleshooting-forms-authentication/samples/sample2.xml)]

After successful authentication, the FormsAuthenticationModule module sets the value of the User property to a reference to the authenticated user. The following code example shows how to programmatically read the identity of the forms-authenticated user.

[!code-console[Main](troubleshooting-forms-authentication/samples/sample3.cmd)]

A convenient way to work with forms authentication is to use ASP.NET membership and ASP.NET login controls. ASP.NET membership lets you store and manage user information and includes methods to authenticate users. ASP.NET login controls work with ASP.NET membership. They encapsulate the logic to prompt users for credentials, validate users, recover or replace passwords, and so on. In effect, ASP.NET membership and ASP.NET login controls provide a layer of abstraction over forms authentication. These features replace most or all the work that you would ordinarily have to do to use forms authentication

## Scenarios

**Reasons for a request to get redirected to login.aspx page**

The forms authentication cookie is lost

**Scenario 1:** 

A user logs on to the Web site. At some point, the client sends a request to the server, and the FormsAuthenticationModule class does not receive the cookie.

**Scenario 2:** 

The forms authentication cookie can also be lost when the client's cookie limit is exceeded. In Microsoft Internet Explorer, there is a limit of 20 cookies. After the 20th cookie is created on the client, previous cookies are removed from the client's collection. If the .ASPXAUTH cookie is removed, the user will be redirected to the login page when the next request is processed.

**Scenario 3:** 

After the request leaves the client, there are various layers that can affect the packets that are being sent. To determine if a network device is removing the cookie, you have to capture a network trace on the client and the server, and then look in the body of the request for the cookie. You want to look at the client request to make sure that the cookie was sent, and check the server trace to make sure that the server received the cookie.

Forms authentication ticket timed out

One thing to be aware of in ASP.NET 2.0 onwards applications, is that the forms authentication timeout value has changed to be 30 minutes by default. This means that after 30 minutes of inactivity, a user will be prompted to login again (**note:** every time they hit the site the 30 minute window clock gets reset -- so it is only if they are idle that it will timeout).

If you want to change the timeout value to be longer, you can easily change the timeout value in your local web.config file (the timeout value is in minutes):

[!code-xml[Main](troubleshooting-forms-authentication/samples/sample4.xml)]

**Scenario 4:** 

The forms authentication may time out before the timeout attribute value that is set in the configuration file.

If the forms authentication ticket is manually generated, the time-out property of the ticket will override the value that is set in the configuration file. Therefore, if that value is less than the value in the configuration file, the forms authentication ticket will expire before the configuration file timeout attribute value and vice-versa. For example, let's assume that the &lt;FORMS&gt; timeout attribute is set to 30 in the Web.config file and the Expiration value of the ticket is set to 20 minutes. In this case, the forms authentication ticket will expire after 20 minutes and the user will have to log on again after that.

[!code-console[Main](troubleshooting-forms-authentication/samples/sample5.cmd)]

**Scenario 5:** 

In ASP.NET 4 web application using forms authentication, the event log message says:

[!code-console[Main](troubleshooting-forms-authentication/samples/sample6.cmd)]

## Data Collection and Troubleshooting

**Troubleshooting Scenario 1:** 

You can determine if a request does not contain the cookie by enabling cookie logging in Microsoft Internet Information Services (IIS). To do so, follow these steps:

- Open the IIS Microsoft Management Console (MMC).
- Right-click the Web site and then click Properties.
- Click the Web Site tab, and then click Enable Logging.
- Make sure that the log format is W3C Extended Log File Format.
- Click Properties.
- Click the Advanced tab, and then click Extended Properties.
- Under Extended Properties, click to select the Cookie(cs(Cookie)) check box and the Referer (cs(Referer)) check box.

After this problem occurs, determine which client had the problem and that client's IP address. Filter the IIS log on that client's IP address, and view the &lt;COOKIE&gt; column.

> [!NOTE]
> You can use Log Parser to parse the IIS Logs. To download Log Parser, visit the following Microsoft Web site:

[https://www.microsoft.com/download/en/details.aspx?displaylang=en&amp;id=24659](https://www.microsoft.com/download/en/details.aspx?displaylang=en&amp;id=24659)

After you have the list of requests from that specific user, search for the requests to the login page. You know they were redirected to this page, and you want to see the requests before the redirection occurred. If you see something similar to the following, the client either did not send the cookie or the cookie was removed on the network between the client and server.

> [!NOTE]
> The first request from that user is not likely to have a forms authentication cookie unless you are creating a persistent cookie. The IIS Log will only show you the cookies that were received in the request. The first request to have the forms authentication cookie will be on the request after a successful login attempt.

**Troubleshooting Scenario 2:** 

Microsoft Internet Explorer complies with the following RFC 2109 recommended minimum limitations:

- at least 300 cookies
- at least 4096 bytes per cookie (as measured by the size of the characters that comprise the cookie non-terminal in the syntax description of the Set-Cookie header)
- at least 20 cookies per unique host or domain name

Use below article for further reference: [https://support.microsoft.com/kb/306070](https://support.microsoft.com/kb/306070)

The forms authentication cookie can also be lost when the client's cookie limit is exceeded. In Microsoft Internet Explorer, there is a limit of 20 cookies. After the 20th cookie is created on the client, previous cookies are removed from the client's collection. If the .ASPXAUTH cookie is removed, the user will be redirected to the login page when the next request is processed. You can use fiddler to see the http request/ response headers and to see if you are receiving the cookie from the client or not. Download fiddler from below URL:

[!code-console[Main](troubleshooting-forms-authentication/samples/sample7.cmd)]

Launch fiddler tool on the client machine, remove existing http traces, access your application implementing forms authentication and try to login into the application and observe the http traffic on the fiddler tool to see of you there is an exchange of forms authentication cookie happening between the client and server. After you capture the traffic, double-click a request, and then click Headers to see the Set-Cookie header. If you trace a successful login, you will see the Set-Cookie header in the response of a successful login.

By default, Internet Explorer can store a maximum of 20 cookies for each domain. If a server in the domain sends more than 20 cookies to a client computer, the browser on the client computer automatically discards some old cookies.

Each cookie consists of a single name-value pair. This pair may be followed by attribute-value pairs that are separated by semicolons. This limit has been increased to simplify the development and the hosting of Web applications on domains that must use many cookies. Installing update 937143 increases the number of cookies that Internet Explorer can store for each domain from 20 to 50. For more details on this, please refer the following article:

[https://support.microsoft.com/kb/941495](https://support.microsoft.com/kb/941495)

**Troubleshooting Scenario 3:** 

After the request leaves the client, there are various layers that can affect the packets that are being sent (firewalls, proxies and load balancers etc.). To determine if a network device is removing the cookie, you have to capture a network trace on the client and the server, and then look in the body of the request for the cookie. You want to look at the client request to make sure that the cookie was sent, and then check the server trace to make sure that the server received that cookie.

**Client request**

This is a GET request after the user has been authenticated. The forms authentication ticket information is highlighted in grey. This confirms that the cookie information left the client. When you use a network capture tool, like Netmon, you see the traffic that actually went through the adapter.

[!code-console[Main](troubleshooting-forms-authentication/samples/sample8.cmd?highlight=7-18)]

**Server-side request**

When you look at the request that reached the server, you want make sure that the server received the same information that the client sent. If the server did not receive the same information, you need to investigate other devices on the network to determine where the cookie was removed.

> [!NOTE]
> There have also been instances of ISAPI filters removing cookies. If you confirm that the Web server received the cookie, but the cookie is not listed in the IIS logs, check the ISAPI filters. You may have to remove the filters to see if the problem is resolved.

**Troubleshooting Scenario 5:** 

- If the scenario involves a web farm, then the Machinekeys should be same across everywhere. Use below machinekey to maintain the consistency on all the servers on the farm: 

    [!code-xml[Main](troubleshooting-forms-authentication/samples/sample9.xml)]
- Compare the timeout values for both forms authentication module and the session module on all of the web servers.
- Compare the System.Web.dll version under Framework folder for ASP.NET 4 between all of the web servers in the farm. Forms authentication failed for the request. Reason: The ticket supplied was invalid. This happens due to missing Reliability Update 1 for MS .NET framework 4 on one of the web server.
- Install the Reliability Update 1 for the .NET Framework 4 kb2533523 on the server that was missing it and rebooted the server. It fixed the issue. [https://support.microsoft.com/kb/2533523](https://support.microsoft.com/kb/2533523)

### Other Resources

- [FIX: Forms authentication cookies compatibility issue between .NET Framework 1.1 and .NET Framework 2.0 SP2 ASP.NET applications after you apply the security update from security bulletin MS10-070](https://support.microsoft.com/kb/2433751)
- [Troubleshoot Forms Authentication](https://support.microsoft.com/kb/910439)
- [Forms-based Authentication](https://quickstarts.asp.net/QuickStartv20/aspnet/doc/security/formsauth.aspx)
- [Internet Explorer increases the per-domain cookie limit from 20 to 50](https://support.microsoft.com/kb/941495)
