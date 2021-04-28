---
title: "Package an Application for the Windows Web Application Gallery"
author: rick-anderson
description: "Introduction The Windows ® Web Application Gallery gives Web site builders an easy way to discover, learn about, and install freely available and community a..."
ms.date: 03/18/2009
ms.assetid: d88db0b1-a662-47a4-8978-ae8a4042ea2f
msc.legacyurl: /learn/develop/windows-web-application-gallery/package-an-application-for-the-windows-web-application-gallery
msc.type: authoredcontent
---
# Package an Application for the Windows Web Application Gallery

by IIS Team

> [!NOTE]
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

## Introduction

The Windows® Web Application Gallery gives Web site builders an easy way to discover, learn about, and install freely available and community applications on an Internet Information Services (IIS) Web server. To have your application included in the Gallery, you must add a couple of configuration files to your existing distribution package.

This article provides everything you need to prepare your application for the Windows Web App Gallery.

## Packaging Overview

When users find an application in the Gallery, they want to be able to see that application running on their systems as simply and quickly as possible. Microsoft provides two products to assist users in setting up their environments and applications.

[Microsoft® Web Platform Installer (Web PI)](https://www.microsoft.com/web/downloads/platform.aspx) is a free tool that makes it simple to download, install, and keep up to date with the latest components of the Microsoft® Web Platform. Web PI is the main interface for the users who are installing applications. It is responsible for ensuring that all of the prerequisite software is installed and configured on the system. Web PI installs and configures applications based on data supplied by the user. The Web Deployment Tool is used by Web PI to install these applications.

[Web Deploy (Web Deployment Tool)](../../publish/deploying-application-packages/index.md) is a tool for deploying and installing Microsoft®ASP.NET and PHP applications, which are available from the Gallery. Web Deploy is responsible for setting up files and directories, working with the database, setting up file access control lists (ACLs), and substituting user- entered data (parameters) in appropriate places. Most of the information in this article is geared towards helping application developers configure their applications to work with Web Deploy. Web Deploy also has significant capabilities that go beyond the usage described here.

### Packaging Process

The following procedure is a summary of the most common process for preparing a working application for inclusion in the Windows Web App Gallery. The steps are described in more detail in the sections that follow.

1. Review the [Web Application Gallery Principles](windows-web-application-gallery-principles.md). All applications in the Windows Web App Gallery must follow these principles.
2. Read and use this article to create and test a Web Deploy application package.
3. Refer to the article "[Best Practices for PHP on Windows](../../application-frameworks/running-php-applications-on-iis/best-practices-for-php-on-the-microsoft-web-platform.md)" for guidance in running your PHP application.
4. Submit the package to the Gallery for testing using the [submission form](https://www.microsoft.com/web/gallery/myapps.aspx "submission form").
5. Resolve any issues with the Application Gallery team.
6. See your application on the [Windows Web Application Gallery](http://www.microsoft.con/web/gallery).

## Create a Basic Package

To create your application package, start with a simple Manifest.xml file that describes what is in the package.

***Tip: A manifest is an XML file that says what your package contains and how to install it. [https://www.iis.net/learn/develop/windows-web-application-gallery/reference-for-the-web-application-package](reference-for-the-web-application-package.md) has more information about format of manifest.xml file.***

[!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample1.xml)]

This manifest will copy the contents of "application" and make it an application in IIS. Include this file in the root directory of your distribution package and your application can be installed by Web PI. In this example, the value of the *path* is used both as the name of the directory in the package where the application files are stored and as the name of the Web site where the application is installed.

The next step would be to ask the user where they would like to install the application. For this, you use parameters.

***Tip: The parameters.xml file has a list of parameters (or questions) to ask the user during installation.[https://www.iis.net/learn/develop/windows-web-application-gallery/reference-for-the-web-application-package](reference-for-the-web-application-package.md) has more information about format of parameters.xml file.***

By default, the application is installed in a Web site that has the same name as the path element of the iisapp directive in the Manifest.xml file. You must add a parameter similar to this one into your Parameters.xml file. The parameterEntry must have a type of "ProviderPath" and a scope of "iisapp." This parameter is used to ask the user to specify a Web site and application name.

[!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample2.xml)]

The **scope** here identifies the type of directive in the Manifest.xml file being parameterized (for example, iisApp), and the **match** contains a regular expression to specify which directive is being modified. The regular expression is evaluated based on the "path" attribute of the "iisApp" provider.

(Note that users installing applications on IIS 5.1 do not have a choice for the Web site portion of this path. IIS 5.1 only supports a single Web site, which is always "Default Web Site.")

Here are some tips for creating parameters.xml: 

1. Use regular expressions for TextFile matches:  

    Consider this entry in your application package's parameters.xml file:

    [!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample3.xml)]

    This parameter effectively treats config.php as a text file, looks for "putyourdbnamehere" inside the file and replaces it with what the user specifies on install time of the application. Hence in your app's config.php, it replaces the text in the following line:define('DB\_NAME', 'putyourdbnamehere');This prevents config.php from ever being updated again through parametrization, because the string ‘putyourdbnamehere' is no longer present, so the parameter match will no longer work. One downside is that the application will install correctly in Microsoft WebMatrix, but will not be parameterized correctly when the user tries to publish it to a remote location.Instead, you should use regular expressions so config.php can be updated at a future date:

    [!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample4.xml)]

    Notice that the parameter match will continue to work because of the regular expression.
2. Never use parameter type TextFilePosition: This is a deprecated parameter type. TextFilePosition allows you to specify matches at specific character positions. This is an inherently fragile approach, you should use TextFile parameter type with regular expression scope.
3. Constraint parameter scopes as much as possible: Consider this entry in your application package's parameters.xml file:  

    [!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample5.xml)]

   The $ at the end of the scope regular expression is important - it indicates that we only want to match files names web.config and not, for example, files named web.config.bak. Constraining parameter scopes in this manner can help avoid unintentional changes to files which are difficult to diagnose.
4. If you store the local application URL in a file or database, parameterize it appropriately. Some applications store a base URL aka Local Application URL in a file or database. For example, a blog application may store "<http://localhost:80>" in the database and used this as a base URL to generate application-wide URLs. If your application does this, you need to create a parameter and tag it as "AppURL".  

    [!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample6.xml)]

   The above parameter will let the user specify a value for Local Application URL for the destination so the application works correctly on the remote server. It works by matching two different regular expressions in database scripts generated by the dbFullSql and dbMySql providers.
5. Tag one-time parameters with "NoStore". Some parameters that are only required to be filled in once e.g. a salt value for generating strong passwords. Such parameters should be tagged as ‘noStore'. Parameters tagged in this manner are not stored in Web Deploy's application definition store and the user will be not be prompted for them when the application is published to a remote server.  

    [!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample7.xml)]

   Note that it's okay to use a flat text replace with noStore parameters.

**Add a Database**

Most Web applications use a database to store information. Application packages installed through Web PI can support MS SQL or MySQL data stores and run a database script or create a database. To add a SQL database check to your Manifest.xml, add the dbfullsql directive. For MySQL, use dbmysql.

[!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample8.xml)]

The Install.sql script would be in the root of the package, and it can contain any SQL script or be empty if all that you want to do is verify that the database is there. You may use as many scripts as your application needs for setup. If you use more than one SQL script, you must specify a database provider in the Manifest.xml file for each one. We require that you use a single set of database credentials for executing all of the scripts.

The following example shows how to connect to a database that has commonly used parameters stored in the Parameters.xml file. Four of these parameters are used to build the Connection String used for connecting to the database. The Connection String and the four parameters used to build it are all required parameters.

*NEW* Note that all of the parameters in the examples below have changes from the earlier versions. The most notable changes are:

- All descriptions have been removed. All of these parameters have default descriptions that are associated with their tags.
- There are additional tags, and many of them are now mandatory.
- The concept of parameter validation is introduced. The comments are greatly expanded for many of the parameters. If you choose to bypass the defaults, some of the detail in the comments might be suitable for descriptions of these parameters

For more information, see the [Reference for the Web Application Guide](reference-for-the-web-application-package.md).

[!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample9.xml)]

For additional information about adding the database, see the article "[Database Notes for packaging applications for use with the Windows Web App Gallery](database-notes-for-packaging-applications-for-use-with-the-web-application-gallery.md)."

**Copy Files**

If your application includes a configuration file that has to be copied to a new name or location before it is set up, you can do that with the **alias** directive in the Manifest.xml file. The paths are both relative to the locations of the files in the package. The destination file is specified as the location where the file would have come from if it was in the original package.

[!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample10.xml)]

**Set File and Directory Permissions**

By default, the WDT installs all files and directories without changing any of the existing permissions. In most cases, this means that the application only has read access to the installed files and directories. If your application needs to be able to write to any file or directory, you can specify which ones with a **setAcl** directive in the Manifest.xml file. The setAclResourceType element defines whether the path represents a file or a directory.

[!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample11.xml)]

To ensure that the ACL gets applied to the proper directory, you should also provide a hidden parameter so that the ACL gets applied to the named directory relative to the AppPath where it is installed.

[!code-xml[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample12.xml)]

If no ACL is set on a file or directory, the ACL is most likely to be "Read." The ACLs are specific, so granting write access does not necessarily grant read access. If you must write to a file or directory, you should add "Read, Write". If you need to be able to enumerate the files in a directory, you should add "ListDirectory". Note that write access does not grant modify access. If you must change files once they are written to disk, you must explicitly set "Modify" access. There are some permissions that are combinations of other permissions. For example, "Modify" includes "Read," "Write," "Execute," and "Delete."

Note that it is considered a risky security practice to grant "Write" or "Modify" access to the entire application tree by applying an ACL at the root of the application. ACLs need to be as limiting and granular as possible, while still allowing all required functionality of the application.

*NEW* If you are familiar with UNIX or Linux style permissions, the privileges being set here are the equivalent of "Owner" permissions. While Group and World privileges can be set through various ACLs outside of the Web Deployment Tool, only "Owner" class permissions are set here. The table below shows the Windows® equivalents of various Linux bit-masked permissions:

| Linux | Windows | Linux | Windows |
| --- | --- | --- | --- |
| 0 | No equivalent to None | 4 | Read |
| 1 | Execute | 5 | ReadAndExecute |
| 2 | Write | 6 | Read,Write |
| 3 | Write,Execute | 7 | Modify |

For a full list of the various user rights and their descriptions, see [FileSystemRights Enumeration](https://msdn.microsoft.com/library/system.security.accesscontrol.filesystemrights.aspx).

For IIS-specific ACL guidance, see the article "[Securing Content in IIS through File System ACLs](../../get-started/planning-for-security/secure-content-in-iis-through-file-system-acls.md)."

The token "anonymousAuthenticationUser" is automatically compared to the ID that the Web Site has configured that is used for anonymous authentication. As this ID is configured by the Web site administrator, it is best to use anonymousAuthenticationUser for PHP applications and no setAclUser for ASP.NET applications, unless your application has a specific need for a user of its own for handling file ownership.

PHP applications are typically run as the anonymous user because the FastCGI settings usually set the impersonation to be **True**(run as anonymous user). ASP.NET applications typically run as the worker process identity (application pool identity). If **setAclUser** is not specified, then the **setAcl** directive uses the application's Application Pool Identity as the ID for authorization.

## Pack the Application

Create a compressed file (Zip) package of the application if you don't already have one. You can create the Zip file with Windows® Explorer, WinZip, or the Linux zip command. The Manifest.xml, Parameters.xml, and Install.sql files all go in the root directory of the package. The rest of your application goes in a sub folder of the root as in the diagram below.

[!code-console[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample13.cmd)]

Note that the layout of the subdirectory tree is up to you. This example illustrates where the WDT XML files go for an application, and it is not prescriptive for how your sub tree should look.

When you have a complete package, you should generate a SHA-1 hash signature of the file. This signature is used by the Web Platform Installer to ensure that the package that gets downloaded onto users' systems is the one you intended it to be. If you don't have a tool for generating a SHA-1 hash, you can get the [Microsoft® File Checksum Integrity Verifier](https://www.microsoft.com/downloads/details.aspx?FamilyID=B3C93558-31B7-47E2-A663-7365C1686C08&amp;displaylang=en).

*NEW* Note that all packages in the Gallery will be switched to use SHA-1 instead of MD5 hashes.

## Test Your Package

You can test your package by using the Web Deployment Tool. You can get the latest release of the Web Deployment Tool using the [Web Platform Installer](https://www.microsoft.com/web/downloads). The Web Deployment Tool runs on Windows® XP and later versions of the Windows operating system. Note that the Web Deployment Tool uses the MySQL Connector for .Net 5.2 to communicate with MySQL. You can download this from the [MySQL Web site](http://dev.mysql.com/downloads/connector/net/5.2.html).

### Use Web Platform Installer

You can test your package by using Web Platform Installer. You can refer to this guide : [Testing a Web Application Zip Package for Inclusion with the Web Application Gallery](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery.md)

### Use the Web Deployment Tool UI

If you are running on Windows Vista®, Windows® 7, Windows Server® 2008, or Windows Server® 2008 R2, you can use the Web Deployment Tool from within IIS Manager to test your package. For all other versions of Windows, you must use the command-line version for testing.

1. Always make a backup prior to changing your system. Run the following command to backup an IIS server:  

    [!code-console[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample14.cmd)]

   This creates a backup of the `%windir%\system32\inetsrv\config` directory, which contains the main IIS configuration files. If you are testing your package on a server that also has other applications or Web sites running, back up those applications and Web sites prior to starting your testing.
2. Open the IIS Manager by clicking **Start** &gt; **Run**, and then typing: **inetmgr**
3. In **IIS Manager**, expand the **Server** node, expand the **Sites** node, and then select the **Default Web Site**.
4. In the **Actions** pane on the right, click the **Import Application** link to launch the packaging wizard.
5. Select the package that you created.
6. In the Install an Application Package dialog box, you see the application and the database.
7. On the **Parameters** page, review the parameters and their descriptions to make sure that they match your intent and provide enough information for a user to be able to fill them all in.
8. Click **Next** to install the package.
9. The Summarypage provides a high-level overview of some items that were installed from the package. The Detailstab provides details of exactly what was added.

### Use the Web Deployment Tool Command Line

You can also test your package by using the Web Deployment Tool at the command prompt. This is the only testing method available on Windows XP and Windows Server® 2003. The simplest way to test your application from the command prompt is by using a batch file that calls the Web Deployment Tool and sets values for the parameters.

*NEW* Following is the shorthand syntax.

[!code-console[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample15.cmd)]

**Batch File Usage Notes**

The parameter names used match the parameter names from the Parameters.xml file.

- Ensure that all of the values match your environment.
- Parameters that have DefaultValues defined can be skipped if you want to use the default.
- Parameters that are tagged "Hidden" still must be set if they don't have DefaultValues defined.
- The Web site used in the Application Path must exist before you can run this batch file.
- The Command Prompt session from which you run the script must be run with administrator user rights.
- The '^' at the end of each line tells the batch file processor that the command continues on the next line.

You can see full documentation of all of the Web Deployment Tool command-line arguments by running msdeploy.exe -help.

## Submit the Application

When your package is ready, submit a form to the Windows Web Application Gallery describing your application.

### CodePlex Notes

If your application is being hosted on CodePlex, you must have a special URL for your package. This URL looks similar to:

[!code-console[Main](package-an-application-for-the-windows-web-application-gallery/samples/sample16.cmd)]

You must substitute the name of your application at the beginning of the URL and the DownloadID for your package in place of the "nnnnn."

## Next Steps

If your application has been accepted in to the Gallery, you can provide a direct link on your Web site to your application's Gallery page. In addition, you can provide a link that starts the Web Platform Installer with your application and all of its prerequisites selected to be installed.

You can learn more about these links and the graphics that are available to use with them in the article "[Using the Microsoft Web Platform Installer Badge](using-the-microsoft-web-platform-installer-badge.md)."

## Update Your Application

When you release an update to your application, please follow this procedure:

1. Advise the Windows Web App Gallery in advance of the new package, if your schedule allows.
2. Do not remove the old version until you receive a confirmation that all links are pointing to the new version.
3. Create and test your new application package.
4. Ensure that the new package has a different name than the previous package.
5. Generate a SHA-1 hash for the new package.
6. Click [here](https://www.microsoft.com/web/gallery/myapps.aspx) to update your existing submission with the following information for the new package:  

   - App Version
   - URL
   - SHA-1 hash
   - A link to any Release Notes or Changelog for the update (optional)

     Note that it takes up to a week to test and roll out the new package. You will be informed when all testing has been completed and the new package is live; you may then remove the old package (optional).

For more information, see the [Reference for the Web Application Guide](reference-for-the-web-application-package.md).

## Links for Further Information

- [Windows Web App Gallery](https://www.microsoft.com/web/gallery/).
- [Web App Gallery principles](windows-web-application-gallery-principles.md).
- [Web App Gallery submission form](https://login.iis.net/login/signin.aspx?ReturnUrl=TODO%20-%20get%20the%20URL%20for%20%20%20%20the%20new%20form).
- [Using the Microsoft Web Platform Installer Badge](using-the-microsoft-web-platform-installer-badge.md).
- [Web Platform Installer](https://www.microsoft.com/web/downloads/).
- [CodePlex.](http://www.codeplex.com/)
