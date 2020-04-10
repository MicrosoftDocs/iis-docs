---
title: Installing a Custom Web Playlist Provider
TOCTitle: Installing a Custom Web Playlist Provider
ms:assetid: 4c7c8c01-7e55-41af-ac27-fe1bedc8d344
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146269(v=VS.90)
ms:contentKeyID: 19132340
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Installing a Custom Web Playlist Provider

Installing a Web Playlist provider written in managed code is simple. This procedure requires that you use Regasm.exe to register your provider assembly, and then add the provider to the Playlist module.

## Installation

Installation of a managed-code Web Playlist provider is done in two steps. The first step is to register the provider assembly by using the Regasm.exe utility. The second step requires that you add the provider to the Web Playlist module configuration. The sections below describe these steps.

### Registering the Provider Assembly

  - 32–bit system installation

<!-- end list -->

1.  Launch an SDK command prompt with administrator privileges.

2.  In the command prompt, navigate to the .NET framework directory (for example, c:\\windows\\microsoft.net\\Framework\\v2.0.50727\\).

3.  Type the following command:Regasm.exe \<providerassemblysample.dll\>where \<providerassemblysample.dll\> is the path to the assembly you want to register.

<!-- end list -->

  - 64–bit system installation, running as 64–bit

<!-- end list -->

1.  Launch an SDK command prompt with administrator privileges.

2.  In the command prompt, navigate to the .NET framework directory (for example, c:\\windows\\microsoft.net\\Framework64\\v2.0.50727\\).

3.  Type the following command:Regasm.exe \<providerassemblysample.dll\>where \<providerassemblysample.dll\> is the path to the assembly you want to register.

<!-- end list -->

  - 64–bit system installation, running as 32–bit

<!-- end list -->

1.  Launch an SDK command prompt with administrator privileges.

2.  In the command prompt, navigate to the .NET framework directory (for example, c:\\windows\\microsoft.net\\Framework\\v2.0.50727\\)

3.  Type the following command:Regasm.exe \<providerassemblysample.dll\>where \<providerassemblysample.dll\> is the path to the assembly you want to register.

### Add Configuration Entries for Custom Provider

1.  In Internet Information Services (IIS) Manager, at the site level, click **Playlists.**

2.  In the **Actions** pane, click **Configure Providers**. You will see the list of providers that are registered for the site.

3.  In the **Actions** pane, click **Add**.

4.  In the **Add Playlist Provider** dialog box, fill in the following details. Click **OK** when you are done.
    
    1.  **Provider name**. Enter a friendly name for the provider. It is only used to identify the provider in the **Playlist providers** page.
    
    2.  **Description**. Enter a description for the provider. You can use this field to briefly describe what the provider does. It is only used by the administrator to help identify the provider.
    
    3.  **Program ID**. Enter the COM ProgID that is used in the provider code. It is used to detect and load the provider at run time. If you used the sample code created in [Writing a Managed Web Playlist Provider](writing-a-managed-web-playlist-provider.md), the ProgId attribute found in the sample code is "SamplePlaylistProvider.ProviderSample".
    
    4.  **File name extension**. Enter the file name extension that will be used for Playlists that the provider will work with. The Playlist feature already handles Web Playlists with the .ISX file name extension. This field adds the handler mapping configuration that allows the Playlist feature to handle requests for the file name extension that you choose.
    
    5.  **File-based handler**. This is an optional field. If your provider stores the Playlist in a file, checking this option allows the IIS 7 pipeline to provide the needed file details and a stream to access file contents.
    
    6.  **Bitness**. (64–bit systems only) Select whether the provider works as a 32–bit system through the WOW layer, as a 64–bit system, or both. The relevant configuration entries are added to the IIS 7 configuration to handle the requests.

## See Also

### Concepts

[Creating a Web Playlist Interop Assembly](creating-a-web-playlist-interop-assembly.md)

[Writing a Managed Web Playlist Provider](writing-a-managed-web-playlist-provider.md)

[Creating a Managed Playlist Provider](creating-a-managed-playlist-provider.md)
