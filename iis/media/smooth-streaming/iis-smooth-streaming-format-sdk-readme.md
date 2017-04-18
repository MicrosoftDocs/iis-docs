---
title: "IIS Smooth Streaming Format SDK Readme | Microsoft Docs"
author: rick-anderson
description: "June 2010 These release notes are for the Beta 2 release of the IIS Smooth Streaming Format Software Development Kit 1.0. This release is provided under the..."
ms.author: iiscontent
manager: soshir
ms.date: 06/23/2011
ms.topic: article
ms.assetid: 52d02cba-d167-41fe-8a43-b7689d899f11
ms.technology: iis-media
ms.prod: iis
msc.legacyurl: /learn/media/smooth-streaming/iis-smooth-streaming-format-sdk-readme
msc.type: authoredcontent
---
IIS Smooth Streaming Format SDK Readme
====================
by Dave Nelson

June 2010

These release notes are for the Beta 2 release of the IIS Smooth Streaming Format Software Development Kit 1.0.

This release is provided under the IIS Smooth Streaming Format SDK license terms that accompany this package.

The package makes it easy for authorized developers to wrap encoded video and audio bitstreams into fragmented-MP4 (f-MP4) formats that conform to Smooth Streaming requirements.

Updated documentation for the Smooth Streaming Format SDK is available on [MSDN>](https://go.microsoft.com/fwlink/?LinkID=183331).

<a id="requirements"></a>

## System requirements

**Operating system**

- A computer with either an x86 or x64-based processor that is running Windows® 7 or Windows Server® 2008. The latest updates available from Windows Update should be installed.

**Software**

- Microsoft Visual C++® 2008 SP1 or higher, with the latest available service packs, is required to use the library and to compile the sample application.
- Microsoft Visual Studio 2008 with Service Pack 1 (SP1).

**Disk space**

- The sample source code, library, and related documentation require about 40 megabytes (MB) of hard disk space.

<a id="package"></a>

## What's in the Package?

When the package is installed, directories are created by default under `%ProgramFiles%\IIS\Media\Smooth Streaming Format SDK`.

The root directory contains the following files:

- **IIS Smooth Streaming Format SDK Eula.rtf**. The End-User License Agreement (EULA).
- **ReadMe.htm**. This document.
- **Smooth Streaming Format SDK MSDN Documentation.url**. A shortcut to the latest Smooth Streaming Format SDK documentation on MSDN.

The **include** subdirectory contains the following files:

- **ssfsdkapi.h**. The header file for the Smooth Streaming Format SDK Application Programming Interface (API).

The **lib** subdirectory contains the following files:

- **ssfsdk.lib**. The static library that implements the methods associated with ssfsdkapi.h and provides the functionality to create f-MP4 formats.

The **Samples\SSFBasicMuxer** subdirectory contains the following files:

- **main.cpp**. The sample basic muxer Smooth Streaming Format SDK application C++ file.
- **SSFBasicMuxer.vcproj**. The Microsoft Visual Studio 2008 project file.
- **dshowhlp.lib**. The static library intended only for use by the sample application. It should not be redistributed.
- **dshowhlp.h**. The header file for the sample application.

> [!NOTE]
>  
> 
> See the license terms that accompany this package for more information about redistribution rights.


<a id="issues"></a>

## Known Issues in this Release

- You can currently only target platforms that match the installed SDK. That is, if you install the x86–based package, you can only target x86-based applications. If you install the x64-based package, you can only target x64-based applications.
- If Visual Studio 2008 fails to open the BasicMux project from the x64-based package, it is likely that Visual Studio 2008 was installed with the x64-based compiler and tools. By default, Visual Studio 2008 must be installed with the x86- based compiler, even on x64-based operating systems. You must explicitly select the x86-based compiler option when installing Visual Studio 2008, or you can reinstall Visual Studio 2008, and select the option.

<a id="support"></a>

## Support Information

The IIS Smooth Streaming Format SDK is provided with direct support from the Microsoft product team that created the package. For technical questions or to report issues, send an e-mail message to [smooth@microsoft.com](mailto:smooth@microsoft.com).

<a id="history"></a>

## Release History

- Beta 1: 2/28/2010
- Beta 2: 6/17/2010

<a id="legal"></a>

## Legal Notice

Information in this document, including URL and other Internet Web site references, is subject to change without notice. Unless otherwise noted, the companies, organizations, products, domain names, e-mail addresses, logos, people, places, and events depicted in examples herein are fictitious. No association with any real company, organization, product, domain name, e-mail address, logo, person, place, or event is intended or should be inferred.

Complying with all applicable copyright laws is the responsibility of the user. Without limiting the rights under copyright, no part of this document may be reproduced, stored in or introduced into a retrieval system, or transmitted in any form or by any means (electronic, mechanical, photocopying, recording, or otherwise), or for any purpose, without the express written permission of Microsoft Corporation.

Microsoft may have patents, patent applications, trademarks, copyrights, or other intellectual property rights covering subject matter in this document. Except as expressly provided in any written license agreement from Microsoft, the furnishing of this document does not give you any license to these patents, trademarks, copyrights, or other intellectual property.

Copyright © 2011 by Microsoft Corporation. All rights reserved.

Microsoft, MS-DOS, Windows, Windows NT, Windows Server, Windows Vista, Active Directory, ActiveSync, ActiveX, Direct3D, DirectDraw, DirectInput, DirectMusic, DirectPlay, DirectShow, DirectSound, DirectX, Expression, FrontPage, HighMAT, Internet Explorer, JScript, Microsoft Press, MSN, Outlook, PlaysForSure logo, PowerPoint, SideShow, Visual Basic, Visual C++, Visual InterDev, Visual J++, Visual Studio, WebTV, Windows Media, Silverlight, Win32, and Win32s are either registered trademarks or trademarks of Microsoft Corporation in the United States and/or other countries.

The name of actual companies and products mentioned herein may be the trademarks of their respective owners.

Some of the links in this document might let you leave the Microsoft site. The linked sites are not under the control of Microsoft and Microsoft is not responsible for the contents of any linked site or any link contained in a linked site, or any changes or updates to such sites. Microsoft is not responsible for webcasting or any other form of transmission received from any linked site. Microsoft is providing these links to you only as a convenience, and the inclusion of any link does not imply endorsement by Microsoft of the site.