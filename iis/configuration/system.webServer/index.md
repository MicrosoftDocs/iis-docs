 &lt;system.webServer&gt;
====================
<a id="001"></a>
## Overview

The `<system.webServer>` element specifies the root element for many of the site-level and application-level configuration settings for Internet Information Services (IIS) 7 in the ApplicationHost.config file, and contains configuration elements that define the settings used by the Web server engine and modules.

> [!NOTE]
> Unlike settings that are found in &lt;[`system.applicationHost`](/system.applicationhost.md)&gt;, settings in the `<system.webServer>` element can be delegated.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<applicationInitialization>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<system.webServer>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<applicationInitialization>` and `<webSocket>` elements were added as child elements. |
| IIS 7.5 | The `<system.webServer>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<system.webServer>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<system.webServer>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There are no examples that are specific to the `<system.webServer>` element. For examples that configure the settings that are found within the `<system.webServer>` element, see the child elements that are listed in the [configuration details](#005) section of this topic.

<a id="005"></a>
## Configuration

The `<system.webServer>` element is defined in the ApplicationHost.config file, although settings in `<system.webServer>` element can be delegated to Web.config files.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`applicationInitialization`](/system.webserver/applicationinitialization.md) | Optional element. Configures settings for application initialization that is performed proactively before a request is received. |
|| [`asp`](/system.webserver/asp.md) | Optional element. Configures settings for Active Server Pages (ASP) applications. |
| [`caching`](/system.webserver/caching.md) | Optional element. Configures output cache settings. |
| [`cgi`](/system.webserver/cgi.md) | Optional element. Configures default settings for Common Gateway Interface (CGI) applications. |
| [`defaultDocument`](/system.webserver/defaultdocument.md) | Optional element. Configures settings for returning a default document to a client browser when the client does not specify a file name in a request. |
| [`directoryBrowse`](/system.webserver/directorybrowse.md) | Optional element. Configures whether directory browsing is enabled or disabled on the Web server, and specifies the information to include in a directory listing. |
| [`fastCgi`](/system.webserver/fastcgi.md) | Optional element. Contains a collection of fastCgi application pool definitions. |
| [`globalModules`](/system.webserver/globalmodules.md) | Optional element. Specifies configuration settings for global modules on a Web server. |
| [`handlers`](/system.webserver/handlers.md) | Optional element. Specifies handlers to process requests made to sites and applications. |
| [`httpCompression`](/system.webserver/httpcompression.md) | Optional element. Configures HTTP compression settings for a Web server. |
| [`httpErrors`](/system.webserver/httperrors.md) | Optional element. Configures HTTP error messages for a Web server. |
| [`httpLogging`](/system.webserver/httplogging.md) | Optional element. Specifies configuration settings for HTTP.sys logging. |
| [`httpProtocol`](/system.webserver/httpprotocol.md) | Optional element. Configures custom and redirect response headers to be sent from the server to the client. |
| [`httpRedirect`](/system.webserver/httpredirect.md) | Optional element. Configures settings for redirecting client requests to a new location. |
| [`httpTracing`](/system.webserver/httptracing.md) | Optional element. Specifies configuration settings for HTTP.sys tracing. |
| [`isapiFilters`](/system.webserver/isapifilters.md) | Optional element. Specifies configuration settings for ISAPI filters on a Web server. |
| [`management`](/system.webserver/management.md) | Optional element. Configures a Web server for remote management by using IIS Manager. |
| [`modules`](/system.webserver/modules.md) | Optional element. Specifies configuration settings for modules on a Web server. |
| [`odbcLogging`](/system.webserver/odbclogging.md) | Optional element. Configures Open Database Connectivity (ODBC) logging. |
| [`security`](/system.webserver/security.md) | Optional element. Specifies the section group that contains security-related sections. |
| [`serverRuntime`](/system.webserver/serverruntime.md) | Optional element. Configures request limits for applications on a Web server. |
| [`serverSideInclude`](/system.webserver/serversideinclude.md) | Optional element. Specifies whether server-side includes (SSI) #exec directives are disabled. |
| [`staticContent`](/system.webserver/staticcontent.md) | Optional element. Configures static file request handler settings. |
| [`tracing`](/system.webserver/tracing.md) | Optional element. Configures request trace settings. |
| [`urlCompression`](/system.webserver/urlcompression.md) | Optional element. Configures compression of static and dynamic content. |
| [`validation`](/system.webserver/validation.md) | Optional element. Configures IIS 7 to detect whether an ASP.NET application that is set up to run in ISAPI mode needs any migration in order to function correctly in Integrated mode. |
| [`webdav`](/system.webserver/webdav.md) | Optional element. Configures WebDAV publishing settings. |
| [`webSocket`](/system.webserver/websocket.md) | Optional element. Configures communications over the WebSocket protocol. |

### Configuration Sample

The following configuration sample defines a simple, static-content-only `<system.webServer>` element.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

There are no code samples that are specific to the `<system.webServer>` element. For code samples that configure the settings that are found within the `<system.webServer>` element, see the child elements that are listed in the [configuration details](#005) section of this topic.