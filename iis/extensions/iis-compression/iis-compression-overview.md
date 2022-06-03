---
title: "IIS Compression Overview"
author: bangbingsyb
description: "The article provides an overview of IIS Compression"
ms.author: yashi
ms.date: 05/15/2018
msc.type: authoredcontent
---

# IIS Compression Overview

By [Yanbing Shi](https://github.com/bangbingsyb)

This article provides an overview of IIS Compression.

## What is IIS Compression

**IIS Compression** is a bundle of two IIS compression scheme providers, *iisbrotli.dll* and *iiszlib.dll*, that expand IIS's capability to compress HTTP responses.
*iisbrotli.dll* supports **Brotli** compression, while *iiszlib.dll* supports both **Gzip** and **Deflate** compression.

#### What is a compression scheme provider

An IIS compression scheme provider:

- Is a pluggable extension of IIS `StaticCompressionModule` and `DynamicCompressionModule`.
- Provides an implementation for one or multiple HTTP compression schemes.

IIS `StaticCompressionModule` and `DynamicCompressionModule`:

- Load the registered compression scheme providers into worker processes at runtime.
- Leverage them to perform compression on static files and dynamically generated content, respectively.

## Why use IIS Compression

IIS ships a default compression scheme provider *gzip.dll*:

- That supports both **Gzip** and **Deflate** compression.
- Is registered as the **gzip** scheme in **applicationHost.config** by default.

The in-box *gzip.dll* is based on an internal implementation of Gzip and Deflate encoding, and it works properly. So why introduce new compression scheme providers in **IIS Compression**?

### Higher Compression Ratio with Brotli compression

Brotli compression:

- Is a relatively new addition to the HTTP compression.
- Encoding algorithm and format of Brotli are specified in [Requests For Comment (RFC) specification 7932](https://www.ietf.org/rfc/rfc7932.txt).
- Response data streams compressed with Brotli have the content encoding type "br".
- Is capable of offering higher compression ratio than **Gzip** and **Deflate**, with the cost of lower compression speed.

Brotli decompression on the client (browser) side is in general faster. Enabling Brotli compression can potentially improve performance, especially for serving static contents.

#### Better Gzip Compression Scheme Provider

While *iiszlib.dll* included in **IIS Compression** offers same **Gzip** and **Deflate** compression as the default provider *gzip.dll*, *iiszlib.dll*:

- Is more up-to-date.
- Has better performance in terms of CPU usage.
- Has better dynamic compression support owing to the zlib library.

#### Open Source

`IIS Compression`:

- Is a supported open-source product.
- Source code can be found in [IIS.Compression](https://github.com/Microsoft/IIS.Compression) Github repository.
- Uses the open-source [brotli](https://github.com/google/brotli) and [zlib](https://zlib.net/) compression libraries as the core encoders
- Bridges the `brotli` and `zlib` libraries with IIS compression modules through implementing the [IIS HTTP Compression API](https://msdn.microsoft.com/library/dd692872.aspx).

Making `IIS Compression` open-source provides transparency to the community and allows flexible and agile future enhancement, bug fixing, and customization. The project also serves a general reference for developing an IIS compression scheme provider to the community.

## Installing IIS Compression

### Before Installation

The *iiszlib.dll* and *iisbrotli.dll* compression scheme providers are not IIS modules, they are extensions of IIS `StaticCompressionModule` and `DynamicCompressionModule`. At runtime, `StaticCompressionModule` and `DynamicCompressionModule` load the compression scheme providers and pass the response content data to them for compression.

Therefore, one or both of the two compression modules need to be installed on the IIS server as a prerequisite. See [HTTP Compression](../../configuration/system.webserver/httpcompression/index.md) on how to install the features.
Once the modules are installed, ensure static and/or dynamic compression are enabled for a desired URL namespace. See [URL Compression](/iis/configuration/system.webserver/urlcompression) on how to enable the corresponding type of compression.

#### Installation

1. Download the Microsoft IIS Compression release from the following locations:

    - **Microsoft IIS Compression (x86)** [here](https://download.microsoft.com/download/6/1/C/61CC0718-ED0E-4351-BC54-46495EBF5CC3/iiscompression_x86.msi).

    - **Microsoft IIS Compression (x64)** [here](https://download.microsoft.com/download/6/1/C/61CC0718-ED0E-4351-BC54-46495EBF5CC3/iiscompression_amd64.msi).

2. Open a command prompt with administrator user rights.

3. Stop the **WAS** and **W3SVC** services by entering the following:

    [!code-console[Main](iis-compression-overview/samples/stop_was_w3svc.cmd)]

4. Run iiscompression\_&lt;architecture&gt;.exe; for example:

    [!code-console[Main](iis-compression-overview/samples/install_iiscompression_msi_x86.cmd)]

    [!code-console[Main](iis-compression-overview/samples/install_iiscompression_msi_x64.cmd)]

5. Accept the End User License Agreement (EULA).

6. Complete the installation.

7. Start the **WAS** and **W3SVC** services by entering the following:

    [!code-console[Main](iis-compression-overview/samples/start_was_w3svc.cmd)]

The **IIS Compression** installer drops *iisbrotli.dll* and *iiszlib.dll* to `%ProgramFiles%\IIS\IIS Compression`.
The installer registers *iisbrotli.dll* as the **br** (Brotli) compression scheme provider in **applicationHost.config**. It also replaces the default **gzip** compression scheme provider *gzip.dll* with *iiszlib.dll*. A sample `<httpCompression>` element in **applicationHost.config** is shown below:  

[!code-xml[Main](iis-compression-overview/samples/iiscompression-installer-config.xml)]
