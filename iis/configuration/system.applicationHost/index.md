 &lt;system.applicationHost&gt;
====================
<a id="001"></a>
## Overview

The `<system.applicationHost>` element contains global configuration settings that are used by the Windows Process Activation Service (WAS) in Internet Information Services (IIS) 7. This element defines many of the server-level configuration settings in the IIS 7 ApplicationHost.config file.

Of significant importance, the `<system.applicationHost>` element contains the configuration settings for the [&lt;applicationPools&gt;](https://www.iis.net/configreference/system.applicationhost/applicationpools) and [&lt;sites&gt;](https://www.iis.net/configreference/system.applicationhost/sites) collections, which respectively define the collection of application pools and Web sites on an IIS 7 server.

> [!NOTE]
> Unlike the settings that are found in [&lt;system.webServer&gt;](https://www.iis.net/configreference/system.webserver), settings in the `<system.applicationHost>` element cannot be delegated.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<system.applicationHost>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<system.applicationHost>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<system.applicationHost>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<serviceAutoStartProviders>` element was added in IIS 7.5. |
| IIS 7.0 | The `<system.applicationHost>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<system.applicationHost>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There are no examples that are specific to the `<system.applicationHost>` element. For examples that configure the settings that are found within the `<system.applicationHost>` element, see the child elements that are listed in the [configuration details](#005) section of this topic.

<a id="005"></a>
## Configuration

The `<system.applicationHost>` element is defined in the ApplicationHost.config file.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`applicationPools`](https://www.iis.net/configreference/system.applicationhost/applicationpools) | Optional element. Contains default configuration settings for all application pools on the server and defines configuration settings for specific application pools. |
| [`configHistory`](https://www.iis.net/configreference/system.applicationhost/confighistory) | Optional element. Specifies the configuration history settings for a server. |
| [`customMetadata`](https://www.iis.net/configreference/system.applicationhost/custommetadata) | Optional element. Contains settings that are used internally by the Admin Base Object (ABO) mapper component of IIS 7. |
| [`listenerAdapters`](https://www.iis.net/configreference/system.applicationhost/listeneradapters) | Optional element. Specifies configuration settings for listener adapters, which are components that establish communication between non-HTTP protocol listeners and WAS. |
| [`log`](https://www.iis.net/configreference/system.applicationhost/log) | Optional element. Specifies the logging mode for a server. |
| [`serviceAutoStartProviders`](https://www.iis.net/configreference/system.applicationhost/serviceautostartproviders) | Optional element. Specifies a collection of managed assemblies that will be loaded when the `AlwaysRunning` is specifed for an applocation pool's startMode. **Note:** This element was added in IIS 7.5. |
| [`sites`](https://www.iis.net/configreference/system.applicationhost/sites) | Optional element. Defines all sites on the server, and all applications and virtual directories in those sites. |
| [`webLimits`](https://www.iis.net/configreference/system.applicationhost/weblimits) | Optional element. Configures TCP/IP connection and bandwidth limits. |

### Configuration Sample

The following configuration sample defines a simple, static-content-only `<system.applicationHost>` element, with a single application pool ("DefaultAppPool") and a single Web site ("Default Web Site").

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

There are no code samples that are specific to the `<system.applicationHost>` element. For code samples that configure the settings that are found within the `<system.applicationHost>` element, see the child elements that are listed in the [configuration details](#005) section of this topic.