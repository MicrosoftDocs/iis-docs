---
title: Using FTP Virtual Host Names in IIS 7
author: rmcmurray
description: Describes how to configure and use virtual host names with the FTP user interface and IIS configuration files.
ms.date: 01/22/2008
ms.assetid: 5cbadc78-6208-44ea-a71b-ec2bebd3e1a2
msc.legacyurl: /learn/publish/using-the-ftp-service/using-ftp-virtual-host-names-in-iis-7
msc.type: authoredcontent
---
# Using FTP Virtual Host Names in IIS 7

by [Robert McMurray](https://github.com/rmcmurray)

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 7.5 | The FTP 7.5 service ships as a feature for IIS 7.5 in Windows 7 and Windows Server 2008 R2. |
| IIS 7.0 | The FTP 7.0 and FTP 7.5 services were shipped out-of-band for IIS 7.0, which required downloading and installing the service from the following URL: <https://www.iis.net/downloads/microsoft/ftp>. |

<a id="00"></a>

## Introduction

Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable web authors to publish content better than before, and offers web administrators more security and deployment options.

One of the features of the new FTP service is the ability to configure virtual host names, which enables web hosters to configure multiple FTP sites on a single IP address. This document walks you through creating two FTP sites with unique virtual host names in two ways: using the new FTP user interface and by directly editing the IIS 7.0 configuration files. It contains:

- [Prerequisites](#01)
- [Creating Two Hostname-based FTP Sites Using the IIS 7.0 Manager](#02)
- [Creating New FTP Sites by Editing the IIS 7.0 Configuration Files](#03)

> [!NOTE]
> This walk-through contains a series of steps in which you log in to your FTP site using the local user account.

<a id="01"></a>

## Prerequisites

You must install the following items to complete the procedures in this article:

1. IIS 7.0 must be installed on your Windows Server 2008, and the Internet Information Services Manager must be installed.
2. The new FTP service. You can download and install the FTP service from the <https://www.iis.net/> web site using one of the following links:

    - [FTP 7.5 for IIS 7.0 (x64)](https://go.microsoft.com/fwlink/?LinkID=143197)
    - [FTP 7.5 for IIS 7.0 (x86)](https://go.microsoft.com/fwlink/?LinkID=143196)
3. You will need to create root folders for the FTP sites:

    - `%SystemDrive%\inetpub\www.example.com`
    - `%SystemDrive%\inetpub\www.contoso.com`

<a id="02"></a>

## Creating Two Hostname-based FTP Sites Using the IIS 7.0 Manager

### Step 1: Use the FTP Site Wizard to Create the First FTP Site

In this first step, we create a new FTP site using a unique virtual host name.

1. Open the Internet Information Services (IIS) Manager. In the **Connections** pane, click the **Sites** node in the tree.
2. Right-click the **Sites** node in the tree and click **Add FTP Site**, or click **Add FTP Site** in the **Actions** pane.  
   ![Screenshot of Sites page in the Connections pane with Add F T P Site option displayed in drop down menu.](using-ftp-virtual-host-names-in-iis-7/_static/image1.jpg)
3. When the **Add FTP Site** wizard displays:

    - Enter `www.example.com` in the **FTP site name** box.
    - Navigate to the `%SystemDrive%\inetpub\www.example.com` folder that you created in the Prerequisites section.

       > [!NOTE]
       > If you choose to type in the path to your content folder, you can use environment variables in your paths.

    - Click **Next**.  
    ![Screenshot of Add F T P Site dialog box with commands populating the fields for F T P site name and Physical path.](using-ftp-virtual-host-names-in-iis-7/_static/image5.jpg)
4. On the next page of the wizard:

   - Choose an IP address for your FTP site from the **IP Address** drop-down, or choose to accept the default selection of "All Unassigned."
   - You would normally enter the TCP/IP port for the FTP site in the **Port** box. For this walk-through, you will choose to accept the default port of 21.
   - Enter `www.example.com` in the Virtual Host box.
   - Make sure that the **SSL** **Certificate** drop-down is set to "Not Selected" and that either the **No SSL** or **Allow SSL** option is selected.
   - Click **Next**.  

     ![Screenshot of Binding and S S L Settings dialog box displaying I P Address box with S S L Certificate option set to Not Selected.](using-ftp-virtual-host-names-in-iis-7/_static/image11.jpg)
5. On the next page of the wizard:

    - In **Authentication** settings, select **Basic**.
    - In **Authorization** settings:

        - Choose "Specified users" from the **Allow access to** drop-down.
        - Type the user name for a local user in the field below; for example, you could type "MyUser".
        - In the **Permissions** option, select **read** and **Write**.
    - Click **Finish**.  
    ![Image of Wizard showing Basic selected for Authentication and Specified users chosen for Authorization with Read and Write options for Permissions.](using-ftp-virtual-host-names-in-iis-7/_static/image15.jpg)

#### Summary

You have successfully created a new FTP site using the new FTP service. To recap the items that you completed in this step:

- You created a new FTP site named `www.example.com`, with the site's content root at `%SystemDrive%\inetpub\www.example.com`.
- You bound the FTP site to `www.example.com` as the virtual host name.
- You enabled Basic Authentication and created an authorization rule for the a local user account for Read and Write access.

### Step 2: Use the FTP Site Wizard to Create the Second FTP Site

In this second step, we create another new FTP site using a unique virtual host name.

1. Open the Internet Information Services (IIS) Manager. In the **Connections** pane, click the **Sites** node in the tree.
2. Right-click the **Sites** node in the tree and click **Add FTP Site**, or click **Add FTP Site** in the **Actions** pane.  
   ![Screenshot of Sites page with Add F T P Site selected from the drop down menu.](using-ftp-virtual-host-names-in-iis-7/_static/image19.jpg)
3. When the **Add FTP Site** wizard appears:

    - Enter `www.contoso.com` in the **FTP site name** box.
    - Navigate to the `%SystemDrive%\inetpub\www.contoso.com` folder that you created in the Prerequisites section.

       > [!NOTE]
       > If you choose to type in the path to your content folder, you can use environment variables in your paths.

    - Click **Next**.  
        ![Screenshot of Add F T P Site Wizard displaying I P Address typed in the F T P site name box and a command populating the physical path field.](using-ftp-virtual-host-names-in-iis-7/_static/image23.jpg)
4. On the next page of the wizard: 

    - Choose an IP address for your FTP site from the **IP Address** drop-down, or choose to accept the default selection of "All Unassigned."
    - You would normally enter the TCP/IP port for the FTP site in the **Port** box. For this walk-through, choose to accept the default port of 21.
    - Enter `www.contoso.com` in the Virtual Host box.
    - Make sure that the **SSL** **Certificate** drop-down is set to "Not Selected" and that either the **No SSL** or **Allow SSL** option is selected.
    - Click **Next**.  
        ![Screenshot of Add F T P Site wizard displaying Binding and S S L Settings with S S L Certificate option set to Not Selected.](using-ftp-virtual-host-names-in-iis-7/_static/image29.jpg)
5. On the next page of the wizard:

    - In **Authentication** settings, select **Basic**.
    - In **Authorization** settings:

        - Choose "Specified users" from the **Allow access to** drop-down.
        - Type the user name for a local user in the field below; for example, you could type "MyUser".
        - In the **Permissions** option, select **read** and **Write**.
    - Click **Finish**.  
        ![Screenshot of Wizard displaying Authentication set to Basic and Specified users chosen for Authorization with Read and Write in Permissions.](using-ftp-virtual-host-names-in-iis-7/_static/image33.jpg)

#### Summary

You have successfully created a new FTP site using the new FTP service. To recap the items that you completed in this step:

1. You created a new FTP site named `www.contoso.com`, with the site's content root at `%SystemDrive%\inetpub\www.contoso.com`.
2. You bound the FTP site to `www.contoso.com` as the virtual host name.
3. You enabled Basic Authentication and created an authorization rule for a local user account for Read and Write access.

### Step 3: Logging in to Your FTP Site

In Steps 1 and 2, you created two FTP sites using unique virtual host names and configured the security settings to allow only the administrator account to log in. In this step, you log in using your administrator account.

> [!NOTE]
> In this step, you log in to your FTP site using the local administrator account. When creating the FTP sites in Steps 1 and 2, we bound the FTP sites to the local loopback IP address. If you did not use the local loopback address, use SSL to protect your account settings. If you prefer to use a separate user account instead of the administrator account, set the correct permissions for that user account for the appropriate folders.

#### Logging in to the First FTP Site Using Your Local User Account

1. On your FTP server, open a command prompt session.
2. Type the following command to connect to your FTP server; for example, you could type the following:

    `FTP www.example.com`
3. When prompted for a user name, enter the `www.example.com` virtual host name followed by the vertical line (|) character. For example: `www.example.com|MyUser`
4. When prompted for a password, enter your local user account password.
5. You should now be logged in to the `www.example.com` FTP site as the local user account.

#### Logging in to the Second FTP Site Using Your Local User Account

1. On your FTP server, open a command prompt session.
2. Type the following command to connect to your FTP server; for example, you could type the following:

    `FTP www.contoso.com`
3. When prompted for a user name, enter the `www.contoso.com` virtual host name followed by the vertical line (|) character.  For example: `www.contoso.com|MyUser`
4. When prompted for a password, enter your local user account password.
5. You should now be logged in to the `www.contoso.com` FTP site as the local user account.

<a id="03"></a>

## Creating Virtual Host FTP Sites by Editing the IIS 7.0 Configuration Files

You can also create FTP sites for the new FTP service by editing the IIS 7.0 configuration files.

> [!NOTE]
> Editing your applicationHost.config file requires full administrative permissions. Use one of two methods:

- Log in to your computer using the local "administrator" account.

Or

- If you are logged in using an account with administrative permissions that is not the local "administrator" account, open Notepad using the "Run as Administrator" option.

> [!NOTE]
> One of the above steps is required because the User Account Control (UAC) security component in the Windows Vista and Windows Server 2008 operating systems prevents access to your applicationHost.config file. For more information about UAC, see the [User Account Control](https://go.microsoft.com/fwlink/?LinkId=113664) article.

The following steps walk you through all of the required settings to create a new FTP site from scratch.

1. Using a text editor such as Windows Notepad, open your applicationHost.config file, which is located in your `%SystemRoot%\System32\inetsrv\config` folder by default.
2. Locate the `<sites>` section. Add the first FTP site inside the `<sites>` using syntax similar to the following.

    > [!NOTE]
    > You may need to choose a different number than "2" for the site ID if any site is currently using that site identifier.

    [!code-xml[Main](using-ftp-virtual-host-names-in-iis-7/samples/sample1.xml)]
3. Add the second FTP site inside the `<sites>` using syntax similar to the following.

    > [!NOTE]
    > You may need to choose a different number than "3" for the site ID if any site is currently using that site identifier.

    [!code-xml[Main](using-ftp-virtual-host-names-in-iis-7/samples/sample2.xml)]
4. Scroll to the bottom of your applicationHost.config file and add location sections for both of your FTP sites that contain your authorization settings.

    > [!NOTE]
    > As shown in this example, the authorization settings for the FTP sites are configured per URL, and these settings specifically enable Read/Write permissions for the local user account.

    [!code-xml[Main](using-ftp-virtual-host-names-in-iis-7/samples/sample3.xml)]
5. Save your applicationHost.config file.

You should now be able to log in to your newly created FTP sites using an FTP client. For additional details, see the *Step 3: Logging in to Your FTP Site* section of this walk-through.

#### Summary

To recap the items that you completed in this step:

- You created two FTP sites named `www.example.com` and `www.contoso.com`, with the sites' respective content roots at:

  - `%SystemDrive%\inetpub\www.example.com`
  - `%SystemDrive%\inetpub\www.contoso.com`.
- You bound both FTP sites to the local loopback IP address for your computer on port 21 using `www.example.com` and `www.contoso.com` as the virtual host names.
- You enabled Basic Authentication and created an authorization rule for the local user account for Read and Write access for each site.
