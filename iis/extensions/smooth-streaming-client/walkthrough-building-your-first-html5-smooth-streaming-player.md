---
title: 'Walkthrough: Building Your First HTML5 Smooth Streaming Player'
TOCTitle: 'Walkthrough: Building Your First HTML5 Smooth Streaming Player'
ms:assetid: 0aadb8fd-c8d1-419d-9462-c13ae7f927d7
ms:mtpsurl: https://msdn.microsoft.com/library/JJ573656(v=VS.90)
ms:contentKeyID: 49080898
ms.date: 11/19/2012
mtps_version: v=VS.90
---

# Walkthrough: Building Your First HTML5 Smooth Streaming Player

The Microsoft Smooth Streaming Client SDK for Windows 8 enables development of HTML5 Smooth Streaming applications. You can use the Microsoft Media Platform Player Framework and Smooth Streaming Client SDK to build rich media experiences on Windows 8 using the same back-end infrastructure you use for Smooth Streaming applications for the browser, set-top boxes, Windows Phone, and other mobile devices.

This walkthrough shows how to use the Microsoft Smooth Streaming Client SDK for Windows 8 to build a basic HTML5 Smooth Streaming player application. The application uses an HTML5 \<Video\> tag to handle media streaming.

For more information about the Microsoft Media Platform Player Framework, see [Player Framework: an open source component of the Microsoft Media Platform](http://playerframework.codeplex.com/).

The walkthrough illustrates the following tasks:

- How to create a JavaScript Windows 8 project.

- How to register a Smooth Streaming byte stream handler.

- How to add an HTML5 video element.

- How to compile and run the application.

## Prerequisites

- Windows 8 (32-bit or 64-bit) OS.

- Either Visual Studio 2012 or Visual Studio Express 2012 for Windows 8.

- The [Microsoft Smooth Streaming Client SDK for Windows 8](https://go.microsoft.com/fwlink/?linkid=246146&clcid=0x409).

## Creating a JavaScript Windows 8 Project

To develop a Smooth Streaming application for Windows 8, start by creating a new JavaScript Windows project in Visual Studio.

### To create a JavaScript Windows 8 project

1. Open Visual Studio Express 2012 for Windows 8 or Visual Studio 2012.

2. On the **File** menu, select **New Project**.

3. Choose **JavaScript** as the project type.

4. Choose **Blank App**, supply a name for the application in the **Name** box, and then click **OK**.

5. Add the appropriate references to your project. On the **Project** menu, select **Add Reference**. In Reference Manager, add "Microsoft Smooth Streaming Client SDK Beta 2 for Windows 8", "Microsoft Visual C++ Runtime Package" and "Windows Library for JavaScript 1.0" to the references.

6. If you want to support local source URLs, add "Private Network (Client & Server)" capabilities to your application. In Solution Explorer, double-click "package.appxmanifest" and then select **Capabilities**. In the **Capabilities** list, click the **Private Network (Client & Server)** check box.

    > [!CAUTION]  
    > If you want to support enterprise authentication protected sources, consider adding **Enterprise Authentication** to capabilities. For more information, see [App capability declarations (Windows 8 apps)](https://msdn.microsoft.com/library/windows/apps/hh464936.aspx).

## Registering a Smooth Streaming Byte Stream Handler

To identify the URL or MIME-type combination that is sent to the Smooth Streaming extension, you must register the Smooth Streaming Byte Stream handler.

### To register a Smooth Streaming byte stream handler

- In Solution Explorer, in the **js** folder, open default.js, and then add the following code:

```js
var plugins = new Windows.Media.MediaExtensionManager();
try {
    plugins.registerByteStreamHandler("Microsoft.Media.AdaptiveStreaming.SmoothByteStreamHandler", ".ism", "text/xml");
    plugins.registerByteStreamHandler("Microsoft.Media.AdaptiveStreaming.SmoothByteStreamHandler", ".ism", "application/vnd.ms-sstr+xml");
}
catch (e) {
    alert.message(e.message);
}
```

## Adding an HTML5 Video Element

To stream the video in HTML5, add an HTML5 Video element to the project's default.html file.

### To add an HTML5 video element

- Open default.html and add the following Video element to the `<body>` section:

```html
<body>
    <video id="Video1" autoplay="autoplay" controls="controls"  
           src="http://mediadl.microsoft.com/mediadl/iisnet/smoothmedia/Experience/BigBuckBunny_720p.ism/Manifest" style="height: 100%; width: 100%; margin: auto"></video>
</body>
```

The video tag specifies a manifest file for the Big Buck Bunny sample video. The Video element includes default controls such as Play, Pause, Seek, and Volume that can be applied to a Smooth Streaming media source.

## Compiling and Running the Application

Finally, use standard Visual Studio tools to compile and run the application. You must specify a specific platform environment for the application.

### To compile and run the Application

1. On the **Build** menu, select **Configuration Manager**.

2. In the **Configuration Manager** dialog box, in the **Active solution platform** dropdown list, select the specific target platform (ARM, x64, or x86).

    > [!NOTE]  
    > Choosing the **Any CPU** option will cause the following the following compilation errors to be displayed in the **Error List** in Visual Studio:
    >
    > 1 The processor architecture of the project being built "Any CPU" is not supported by the referenced SDK "Microsoft.Media.AdaptiveStreamingClient, Version=1.0". Please consider changing the targeted processor architecture of your project (in visual studio this can be done through the Configuration Manager) to one of the architectures supported by the SDK: "x86, x64, ARM".
    >
    > 2 The processor architecture of the project being built "Any CPU" is not supported by the referenced SDK "Microsoft.VCLibs, Version=11.0". Please consider changing the targeted processor architecture of your project (in visual studio this can be done through the Configuration Manager) to one of the architectures supported by the SDK: "x86, x64, ARM".

3. On the Build menu, select **Build Solution**.

4. Press **F5** to run the application.

## Summary

In this walkthrough, we reviewed how to create a basic HTML5 Smooth Streaming player with default controls for playback of Smooth Streaming content.
