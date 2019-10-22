---
title: "Creating a New FTP Site in IIS 7"
author: rmcmurray
description: "Version Notes IIS 7.5 The FTP 7.5 service ships as a feature for IIS 7.5 in Windows 7 and Windows Server 2008 R2. IIS 7.0 The FTP 7.0 and FTP 7.5 services we..."
ms.date: 01/15/2008
ms.assetid: 21bd94c3-1e1b-4fa4-9e90-6de4f62135e8
msc.legacyurl: /learn/publish/using-the-ftp-service/creating-a-new-ftp-site-in-iis-7
msc.type: authoredcontent
---
# Creating a New FTP Site in IIS 7

by [Robert McMurray](https://github.com/rmcmurray)

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 7.5 | The FTP 7.5 service ships as a feature for IIS 7.5 in Windows 7 and Windows Server 2008 R2. |
| IIS 7.0 | The FTP 7.0 and FTP 7.5 services were shipped out-of-band for IIS 7.0, which required downloading and installing the service from the following URL: <https://www.iis.net/downloads/microsoft/ftp>. |

<a id="00"></a>

## Introduction

Microsoft has updated the FTP service for Windows Server® 2008 and above. This updated FTP service incorporates many new features that enable Web authors to publish content better than before, and offers Web administrators more security and deployment options.

This document walks you through creating FTP sites from scratch using the new FTP user interface and by directly editing the IIS configuration files. It contains:

- [Creating a New FTP Site Using the IIS Manager](creating-a-new-ftp-site-in-iis-7.md#01)
- [Creating a New FTP Site by Editing the IIS Configuration Files](creating-a-new-ftp-site-in-iis-7.md#02)

> [!NOTE]
> This walk-through contains a series of steps in which you log in to your FTP site using the local administrator account. These steps should only be followed on the server itself using the loopback address or over SSL from a remote server. If you prefer to use a separate user account instead of the administrator account, you will need to create the appropriate folders and set the correct permissions for that user account when necessary.

### Prerequisites

The following items are required to complete the procedures in this article:

1. IIS must be installed on your Windows 2008 Server, and the Internet Information Services Manager must be installed.
2. The new FTP service must be installed. You can download and install the FTP service from the <https://www.iis.net/> Web site using one of the following links:

    - [FTP 7.5 for IIS 7 (x64)](https://go.microsoft.com/fwlink/?LinkID=143197)
    - [FTP 7.5 for IIS 7 (x86)](https://go.microsoft.com/fwlink/?LinkID=143196)
3. You must create a root folder for FTP publishing.

<a id="01"></a>

## Creating a New FTP Site Using IIS Manager

The new FTP service makes it easy to create new FTP sites by providing you with a wizard that walks you through all of the required steps to create a new FTP site from scratch.

### Step 1: Use the FTP Site Wizard to Create an FTP Site

In this first step you will create a new FTP site that anonymous users can open.

> [!NOTE]
> The settings listed in this walkthrough specify `%SYSTEMDRIVE%\inetpub\ftproot` as the path to your FTP site. You are not required to use this path; however, if you change the location for your site you will have to change the site-related paths that are used throughout this walkthrough.

1. Open IIS Manager. In the **Connections** pane, click the **Sites** node in the tree.
2. As shown in the image below, right-click the **Sites** node in the tree and click **Add FTP Site**, or click **Add FTP Site** in the **Actions** pane.

    - Create a folder at `%SystemDrive%\inetpub\ftproot`
    - Set the permissions to allow anonymous access:

        1. Open a command prompt.
        2. Type the following command:

            [!code-console[Main](creating-a-new-ftp-site-in-iis-7/samples/sample1.cmd)]
        3. Close the command prompt.

    ![](creating-a-new-ftp-site-in-iis-7/_static/image1.jpg)
3. When the **Add FTP Site** wizard appears:

    - Enter "My New FTP Site" in the **FTP site name** box, then navigate to the `%SystemDrive%\inetpub\ftproot` folder that you created in the Prerequisites section. Note that if you choose to type in the path to your content folder, you can use environment variables in your paths.
    - When you have completed these items, click **Next**.

    ![](creating-a-new-ftp-site-in-iis-7/_static/image5.jpg)
4. On the next page of the wizard:

    - Choose an IP address for your FTP site from the **IP Address** drop-down, or choose to accept the default selection of "All Unassigned." Because you will be using the administrator account later in this walk-through, you must ensure that you restrict access to the server and enter the local loopback IP address for your computer by typing "127.0.0.1" in the **IP Address** box.

       > [!NOTE]
       > If you are using IPv6, you should also add the IPv6 localhost binding of "::1".

    - Enter the TCP/IP port for the FTP site in the **Port** box. For this walk-through, choose to accept the default port of 21.
    - For this walk- through, do not use a host name, so make sure that the **Virtual Host** box is blank.
    - Make sure that the **Certificates** drop-down is set to "Not Selected" and that the **Allow SSL** option is selected.
    - When you have completed these items, click **Next**.

    ![](creating-a-new-ftp-site-in-iis-7/_static/image11.jpg)
5. On the next page of the wizard:

    - Select **Anonymous** for the **Authentication** settings.
    - For the **Authorization** settings, choose "Anonymous users" from the **Allow access to** drop-down, and select **Read** for the **Permissions** option.
    - When you have completed these items, click **Finish**.

    ![](creating-a-new-ftp-site-in-iis-7/_static/image13.jpg)

#### Summary

You have successfully created a new FTP site using the new FTP service. To recap the items that you completed in this step:

1. You created a new FTP site named "My New FTP Site", with the site's content root at `%SystemDrive%\inetpub\ftproot`.
2. You bound the FTP site to the local loopback address for your computer on port 21, and you chose not to use Secure Sockets Layer (SSL) for the FTP site.
3. You created a default rule for the FTP site to allow anonymous users "Read" access to the files.

### Step 2: Adding Additional FTP Security Settings

Creating a new FTP site that anonymous users can browse is useful for public download sites, but web authoring is equally important. In this step, you add additional authentication and authorization settings for the administrator account. To do so, follow these steps:

1. In IIS Manager, click the node for the FTP site that you created earlier, then double-click **FTP Authentication** to open the FTP authentication feature page.  
    ![](creating-a-new-ftp-site-in-iis-7/_static/image1.png)
2. When the **FTP Authentication** page displays, highlight **Basic Authentication** and then click **Enable** in the **Actions** pane.  
    ![](creating-a-new-ftp-site-in-iis-7/_static/image5.png)
3. In IIS Manager, click the node for the FTP site to re-display the icons for all of the FTP features.
4. You must add an authorization rule so that the administrator can log in. To do so, double-click the **FTP Authorization Rules** icon to open the FTP authorization rules feature page.  
    ![](creating-a-new-ftp-site-in-iis-7/_static/image9.png)
5. When the **FTP Authorization Rules** page is displayed, click **Add Allow Rule** in the **Actions** pane.  
    ![](creating-a-new-ftp-site-in-iis-7/_static/image13.png)
6. When the **Add Allow Authorization Rule** dialog box displays:

    - Select **Specified users**, then type "administrator" in the box.
    - For **Permissions**, select both **Read** and **Write**.
    - When you have completed these items, click **OK**.  
        ![](creating-a-new-ftp-site-in-iis-7/_static/image17.png)

#### Summary

To recap the items that you completed in this step:

1. You added Basic authentication to the FTP site.
2. You added an authorization rule that allows the administrator account both "Read" and "Write" permissions for the FTP site.

### Step 3: Logging in to Your FTP Site

In Step 1, you created an FTP site that anonymous users can access, and in Step 2 you added additional security settings that allow an administrator to log in. In this step, you log in anonymously using your administrator account.

> [!NOTE]
> In this step log in to your FTP site using the local administrator account. When creating the FTP site in Step 1 you bound the FTP site to the local loopback IP address. If you did not use the local loopback address, use SSL to protect your account settings. If you prefer to use a separate user account instead of the administrator account, set the correct permissions for that user account for the appropriate folders.

#### Logging in to your FTP site anonymously

1. On your FTP server, open a command prompt session.
2. Type the following command to connect to your FTP server:

    [!code-console[Main](creating-a-new-ftp-site-in-iis-7/samples/sample2.cmd)]
3. When prompted for a user name, enter "anonymous".
4. When prompted for a password, enter your email address.

You should now be logged in to your FTP site anonymously. Based on the authorization rule that you added in Step 1, you should only have Read access to the content folder.

#### Logging in to your FTP site using your administrator account

1. On your FTP server, open a command prompt session.
2. Type the following command to connect to your FTP server:

    [!code-console[Main](creating-a-new-ftp-site-in-iis-7/samples/sample3.cmd)]
3. When prompted for a user name, enter "administrator".
4. When prompted for a password, enter your administrator password.

You should now be logged in to your FTP site as the local administrator. Based on the authorization rule that you added in Step 2 you should have both Read and Write access to the content folder.

#### Summary

To recap the items that you completed in this step:

1. You logged in to your FTP site anonymously.
2. You logged in to your FTP site as the local administrator.

<a id="02"></a>

## Creating a New FTP Site by Editing the IIS Configuration Files

You can also create FTP sites for the new FTP service by editing the IIS configuration files.

> [!NOTE]
> Editing your ApplicationHost.config file requires full administrative permissions. This is best accomplished using one of two methods:

- Log in to your computer using the local "administrator" account. - If you are logged in using an account with administrative permissions that is not the local "administrator" account, open Notepad using the "Run as Administrator" option.

> [!NOTE]
> The above steps are required because the User Account Control (UAC) security component in the Windows Vista and Windows Server 2008 operating systems prevent access to your ApplicationHost.config file. For more information about UAC, please see the following documentation:

[https://go.microsoft.com/fwlink/?LinkID=113664](https://go.microsoft.com/fwlink/?LinkID=113664)

The following steps walk you through all of the required settings to create a new FTP site from scratch.

1. Using a text editor such as Windows Notepad, open your ApplicationHost.config file, which is located in your `%SystemRoot%\System32\inetsrv\config` folder by default.
2. Locate the `<sites>` section. This section contains your Default Web Site and should begin with something like the following:  

    [!code-xml[Main](creating-a-new-ftp-site-in-iis-7/samples/sample4.xml)]
3. Copy the entire section for the Default Web Site and paste it on a new line just below the closing &lt;/site&gt; tag.
4. Change the site's settings to create a unique FTP site:

    - Modify the **name** and **id** attributes for the new site to respectively contain "Default FTP Site" and "2".  

        > [!NOTE]
        > You may need to choose a different number than "2" for the site ID if any site is currently using that site identifier.

    - Change the value of the **protocol** attribute on the binding element to contain "ftp".
    - Change the **physicalPath** attribute to `%SystemDrive%\inetpub\ftproot`.
    - Change the **port** value of the **bindingInformation** attribute to contain "21".
5. Add an &lt;ftpServer&gt; section beneath the closing bindings tag that will contain your authentication settings.  

   [!code-xml[Main](creating-a-new-ftp-site-in-iis-7/samples/sample5.xml)]
  
   > [!NOTE]
   > The authentication settings for FTP sites are configured at the site-level, unlike authentication for Web sites, which can be configured per URL.  
  
   Your `<sites>` section should now contain something similar to the following example:  

   [!code-xml[Main](creating-a-new-ftp-site-in-iis-7/samples/sample6.xml)]
6. Scroll to the bottom of your ApplicationHost.config file and add a location section for your Default FTP Site that will contain your authorization settings.  

   [!code-xml[Main](creating-a-new-ftp-site-in-iis-7/samples/sample7.xml)]
  
   > [!NOTE]
   > In this example, the authorization settings for FTP sites are configured per URL, and these settings specifically enable Read permissions for all users, and Read/Write permissions for the administrator account.

7. Save your ApplicationHost.config file.

You should now be able to log in to your newly created FTP site using an FTP client. To use Internet Explorer anonymously on your IIS server, enter ftp://localhost in the Internet Explorer address bar. You should be logged in and see your files anonymously; you should not be prompted for user credentials.

### Summary

In this task you created an FTP site by editing the IIS configuration files. To recap the items that you completed in this step:

1. You created a new FTP site by using the Default Web Site's settings as a template.
2. You configured the following authorization rules for the FTP site:

    - All users have Read permissions.
    - The administrator account had Read/Write permissions.