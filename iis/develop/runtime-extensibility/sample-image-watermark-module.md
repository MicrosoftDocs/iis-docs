---
title: "Sample: Image Watermark Module"
author: fabioy
description: "This is a sample of how to write a native (C++) module that will dynamically insert an user-configured watermark into an image being served, as well as how t..."
ms.date: 05/21/2008
ms.assetid: ec5755cd-8a66-44c1-b94e-dbde807c3072
msc.legacyurl: /learn/develop/runtime-extensibility/sample-image-watermark-module
msc.type: authoredcontent
---
# Sample: Image Watermark Module

by [Fabio Yeon](https://github.com/fabioy)

This is a sample of how to write a native (C++) module that will dynamically insert an user-configured watermark into an image being served, as well as how to extend the configuration and the inetmgr UI tool to provide easy administration of the new module.

The watermark module has the following capabilities:

- It can be enabled/disabled at any configuration level (i.e. site, application, virtual directory, etc).
- It can watermark the JPG, GIF and PNG image formats.
- The watermark image can be of JPG, GIF or PNG format. The watermark image doesn't have to be the same type as the image to be watermarked (i.e. a GIF watermark image can be used to watermark a PNG image request).
- One can configure the location of the watermark image ("upper left", "upper right", "lower left", "lower right", "center", as well as the options of "tile" and "stretch"). Only the "stretch" option will change/modify the watermark image if needed.
- One can also select the transparency level of the watermark image, from 0 to 100%.

In order to compile the sample, you must install the Platform SDK for Windows Vista or Windows Server 2008. The project file included in the sample can be loaded in either Visual Studio 2005 or 2008.

The source code for these samples is available [here](sample-image-watermark-module/_static/sample-image-watermark-module-455-nativewatermarkmodule1.zip).

## Watermark Module

The first component of this sample is the watermark module itself. It's a native C++ module that watches as requests are served, and if the MIME type of the request indicates it's an image, it will dynamically apply an user-configured watermark to the image, and replace the outgoing image. This is all done transparently in a module that runs after the request handler. To illustrate it:

[![Diagram that shows a decision tree from Request Handler to Image Water marker. If there is an image from the Request Handler, a new image is sent, otherwise the original image is sent.](sample-image-watermark-module/_static/image3.jpg)](sample-image-watermark-module/_static/image1.jpg)

1. The logic of the code is pretty straightforward:
2. When the module is first loaded, it registers for the post-RQ\_EXECUTE\_REQUEST\_HANDLER event, which indicates to the system that it wants to be notified right after the request handler is run.
3. Now, when the post-RQ\_EXECUTE\_REQUEST\_HANDLER event is fired, it will retrieve the configuration for its path. If it's not enabled, it will not do anything further to the request and bail.
4. If it's enabled, it will check the "Content-Type" response header and see if it's an image type. If it's not, it will bail.
5. If it's an image, it will then see if the response is a buffer or a file handle. If it's the later, it will load the image into memory, apply the watermark based upon the user-configured settings (i.e. image file, position, transparency), save the resulting image into an in-memory buffer, replace the response data with the in-memory buffer and return.
6. The in-memory buffer will be released in the module's "Dispose" method.

Using the ATL's CImage classes makes loading and processing the image very simple, especially since it can manipulate various image formats easily.

Now, there are a few caveats in this sample and should be considered, especially if one wishes to use it in a "real" production environment:

- The code only works for image types where the response is in a file handle. The HTTP\_RESPONSE object may instead contain the image in a series of buffers. An interesting exercise would be to create an in-memory IStream implementation that wraps the buffers in the response object (watch out for the multiple buffer responses!).
- The module makes no attempts to modify or update the "ETag" response header. This means that the resulting watermarked image will be considered the "real" image as far as the client is concerned (as it should), but can also confuse the client caching logic. A correct implementation of this would have to modify the "ETag" to take into account the configuration of the watermarked image. For example, in the current implementation, if you watermarked an image with "WatermarkFileA" in the "UpperLeft" position with a transparency of "50%", and then made a request with a browser (i.e. Internet Explorer), IE would cache that image based upon the various response headers. If you were to change the configuration of the watermark module (i.e. changed the image, position, or the transparency), and requested the file again (via "F5"), because the image has been cached by IE, instead of requesting the image, it would simply do a "HEAD" request, sending the info it has about the image. The request handler, not knowing that the image has changed, will respond that the response that it sent earlier is still valid and end the request processing. Unfortunately, in this case, the watermark module won't have a chance to run and re-watermark the image with its new configuration, so the client will happily keep showing the old watermarked image. A proper fix for this would have the watermark module somehow incorporate its configuration in the "ETag" of the response so that any changes to the image or the watermark module will cause an invalidation of any client cached image and reprocessing of it.

## Configuration

The configuration of the watermark module is done via a new section in the "system.webServer" namespace. The schema file is as follow:

[!code-xml[Main](sample-image-watermark-module/samples/sample1.xml)]

The file "watermark.xml" should be dropped in the `%windir%\system32\inetsrv\config\schema` directory for it to take effect, as well as adding the section definition in the "applicationhost.config" file, under the "system.webServer" namespace:

[!code-xml[Main](sample-image-watermark-module/samples/sample2.xml)]

To use the module, one must then install the module in the global module list, "system.webServer\globalModules":

[!code-xml[Main](sample-image-watermark-module/samples/sample3.xml)]

And to the module list for the application, "system.webServer\modules":

[!code-xml[Main](sample-image-watermark-module/samples/sample4.xml)]

## Inetmgr

Along with the module sample, is a set of managed classes that are management plug ins to the new "Inetmgr" UI administration tool. There are various other documentations on how to write and extend the new "Inetmgr", which are available here. In short, to use them, one needs to build, add the dlls to the GAC (Global Assembly Cache), and add the following configuration to the `%windir%\system32\inetsrv\config\administration.config` file:

In the &lt;moduleProviders&gt; collection, add the following entry:

[!code-xml[Main](sample-image-watermark-module/samples/sample5.xml)]

And add the following line to the `<modules>` collection:

[!code-xml[Main](sample-image-watermark-module/samples/sample6.xml)]

Restart the tool and a new icon should be available in your site.
