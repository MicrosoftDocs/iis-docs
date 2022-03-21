---
title: "How WebMatrix Verification Works"
author: simtan
description: "After you install the required server components and have validated your server configuration, you supply a sample account to the Microsoft Web Hosting Gall..."
ms.date: 12/12/2010
ms.assetid: 4ed60479-9fb5-4abe-8f3f-649d8a8cdf06
msc.legacyurl: /learn/web-hosting/joining-the-web-hosting-gallery/how-webmatrix-verification-works
msc.type: authoredcontent
---
# How WebMatrix Verification Works

by [Simon Tan](https://github.com/simtan)

## Introduction

After you [install the required server components](install-server-components.md "Install Server Components") and have [validated your server configuration](validate-your-server-configuration.md "Validate your server configuration"), you supply a sample account to the Microsoft Web Hosting Gallery team in the form of a [Profile XML file](generate-a-profile-xml-file.md "Generate a Profile XML file") and a WebMatrix verification test suite is run from our side. The test is composed of publishing a series of web applications to the provided test account and ensuring that they run on your servers.

This document describes the testing process, so that you may also try it for yourself to catch problems early. This process is also known as "client-side validation".

## Applications Tested

The following web applications (mostly from the [Web Application Gallery](https://www.microsoft.com/web/gallery/ "Web Application Gallery")) are published to your servers in sequence:

- Bakery (from a WebMatrix site template)
- [DotNetNuke](https://www.microsoft.com/web/webmatrix/) [using SQL database]
- [WordPress](https://www.microsoft.com/web/webmatrix/)\*
- [nopCommerce](https://www.microsoft.com/web/webmatrix/)
- [Moodle](https://www.microsoft.com/web/webmatrix/)\*
- [Umbraco](https://www.microsoft.com/web/webmatrix/) (requires Full Trust, not recommended for Shared Hosting)
- [mojoPortal](https://www.microsoft.com/web/webmatrix/)
- [Gallery](https://www.microsoft.com/web/webmatrix/)\* [using MySQL database]
- [Joomla!](https://www.microsoft.com/web/webmatrix/)\*
- [Drupal](https://www.microsoft.com/web/webmatrix/)\*
- [BlogEngine.NET](https://www.microsoft.com/web/webmatrix/)
- [ResourceBlender](https://www.microsoft.com/web/webmatrix/)
- [KenticoCMS](https://www.microsoft.com/web/webmatrix/)
- [Atomsite](https://www.microsoft.com/web/webmatrix/)
- [DasBlog](https://www.microsoft.com/web/webmatrix/) (requires Full Trust, not recommended for Shared Hosting)
- [PHPBB](https://www.microsoft.com/web/webmatrix/)\* [using MySQL database]
- [SugarCRM](https://www.microsoft.com/web/webmatrix/)\*

\* These applications are built on PHP/MySQL and are **not required** to pass testing in order for you to obtain the Spotlight status on the Hosting Gallery.

## Test Process

1. **Launch WebMatrix** and click on **My Sites**. We have all of the applications above pre-installed on our test machine, but others may need to install them anew. To do so, please refer to the [app-specific documentation](https://www.microsoft.com/web/webmatrix/ "Installing and Publishing Apps with WebMatrix").  
  
    [![Image of My Sites console in Web Matrix with Acquia Drupal application selected.](how-webmatrix-verification-works/_static/image2.png)](how-webmatrix-verification-works/_static/image1.png)  
  
   Choose one of the applications to test with.
2. Open the **Publish Settings** dialog box.  
  
    [![Screenshot of Publish Settings dialog box with Settings highlighted.](how-webmatrix-verification-works/_static/image4.png)](how-webmatrix-verification-works/_static/image3.png)
3. Choose to **Import** a publishing settings file, and select a \*.publishsettings file that defines the test account.  
  
    [![Image of Publish Settings dialog box displaying Import Publish Settings in the Common Tasks pane highlighted.](how-webmatrix-verification-works/_static/image6.png)](how-webmatrix-verification-works/_static/image5.png)
4. When prompted to use the Web Deploy or FTP protocol, choose **Web Deploy**.  
  
    [![Image of Select Settings dialog box with Web Deploy selected.](how-webmatrix-verification-works/_static/image8.png)](how-webmatrix-verification-works/_static/image7.png)  
  
    **Validate** the connection. This may result in a prompt about unverified certificates, which is fine. (We accept the certificate and continue.)  
  
    [![Screenshot of Publish Settings dialog box with Validate Connection selected and highlighted.](how-webmatrix-verification-works/_static/image10.png)](how-webmatrix-verification-works/_static/image9.png)  
  
   If validate fails in any way, record the error and consider the publish test a failure.
5. Save and close (or Apply and Cancel) the Publish Settings dialog. Check for **Publish Compatibility** before you move on. This has the beneficial side-effect of automatically correcting the .NET App Pool version on the server.  
  
    [![Image of Publish Settings dialog box with Check Compatibility option highlighted in Publish drop down menu.](how-webmatrix-verification-works/_static/image12.png)](how-webmatrix-verification-works/_static/image11.png)  
  
    [![Image of Publish Compatibility note in Web Matrix asking for permission to run test for publish compatibility with Yes and No options.](how-webmatrix-verification-works/_static/image14.png)](how-webmatrix-verification-works/_static/image13.png)  
  
    [![Screenshot of results of checking sites Compatibility with test dot april dot arvixe dot com.](how-webmatrix-verification-works/_static/image16.png)](how-webmatrix-verification-works/_static/image15.png)  
  
   If any of the checks fail, we still **continue through to publishing**.
6. Click **Publish** from the Ribbon. On the Publish Preview screen, ensure that **all items are checked** – especially all **databases** whether they are just SDF files or full SQL databases.  
  
    [![Image of Publish Preview screen displaying all items are checked with Databases selected and highlighted.](how-webmatrix-verification-works/_static/image18.png)](how-webmatrix-verification-works/_static/image17.png)  
  
   Continue and wait for Publishing to complete.  
  
    [![Image of the dialog for Publish operation in progress.](how-webmatrix-verification-works/_static/image20.png)](how-webmatrix-verification-works/_static/image19.png)  
  
   If there are any errors during the generation of the Publish Preview or during the actual Publishing operation, record the error and consider the publish test a failure.
7. At the end of the publish operation, click the destination URL that is provided and check to see if the remote website loads in the browser.  
  
    [![Image of dialog for Publish operation completed with the provided U R L highlighted.](how-webmatrix-verification-works/_static/image22.png)](how-webmatrix-verification-works/_static/image21.png)  
  
   Perform operations such as logging in and playing with things in the application (e.g. creating a blog entry). If any errors are encountered, record the error and consider the publish test a failure.  
  
    [![Screenshot of an online store page as an example for testing the application.](how-webmatrix-verification-works/_static/image24.png)](how-webmatrix-verification-works/_static/image23.png)  
  
   If the application works fine at this point, you have passed testing for this application.
8. Once you've finished testing an application, regardless of whether the publish test passed or failed, you need to clean up the server before attempting another publish. To do this, the control panel associated with the account must be used. The control panel should provide a way to delete databases, sites, and files. Here is the process for any hosting provider using WebsitePanel:

    - ***Resetting Databases***  
  
     The control panel should allow you to navigate to individual SQL Server or MySQL databases to delete them.  

     [![Screenshot of control panel in Hosting Spaces page with Databases selected and S Q L Server 2008 and My S Q L s highlighted.](how-webmatrix-verification-works/_static/image26.png)](how-webmatrix-verification-works/_static/image25.png)  

     [![Image of S Q L Server 2008 databases page displaying Create Database button with Web deploy test highlighted in the Name box.](how-webmatrix-verification-works/_static/image28.png)](how-webmatrix-verification-works/_static/image27.png)  

     [![Image of S Q L Database Properties dialog box displaying Web deploy test selected and Delete button highlighted.](how-webmatrix-verification-works/_static/image30.png)](how-webmatrix-verification-works/_static/image29.png)  
  
     Before deleting the database, note its name. You'll need to recreate a database of the same name immediately afterwards. You'll also need to assign the same database user to it.  
  
     [![Screenshot of S Q L Server 2008 databases with Create Database button highlighted.](how-webmatrix-verification-works/_static/image32.png)](how-webmatrix-verification-works/_static/image31.png)  

     [![Screenshot of S Q L Databases Properties dialog box showing Web deploy test typed in Database name box with Web deploy test selected and highlighted.](how-webmatrix-verification-works/_static/image34.png)](how-webmatrix-verification-works/_static/image33.png)
    - ***Resetting the Site***  
  
     You'll need to remove the website entry off of the control panel and recreate it.  
  
     [![Screenshot of Hosting Spaces control panel displaying web icon selected and Web Sites from the list highlighted.](how-webmatrix-verification-works/_static/image36.png)](how-webmatrix-verification-works/_static/image35.png)  

     [![Screenshot of Web Sites dialog box with m soft dot palm dot arvixe dot com typed and highlighted in Name field.](how-webmatrix-verification-works/_static/image38.png)](how-webmatrix-verification-works/_static/image37.png)  

     [![Image of Web Sites Properties with folder path typed in the path field and Delete button highlighted.](how-webmatrix-verification-works/_static/image40.png)](how-webmatrix-verification-works/_static/image39.png)  
  
     Note the name of the website for restoring later.  
  
     [![Screenshot of Web Sites dialog box with Create Web Site button highlighted.](how-webmatrix-verification-works/_static/image42.png)](how-webmatrix-verification-works/_static/image41.png)  
  
     Recreate the site on the same domain as the one that was deleted.  
  
     [![Image of Add Web Site dialog box with m soft dot palm dot arvixe dot com selected from Domain drop down list and Create Web Site button highlighted.](how-webmatrix-verification-works/_static/image44.png)](how-webmatrix-verification-works/_static/image43.png)  
  
     Note that you'll also have to re-enable Remote Management in order to publish again.  
  
     [![Image of Web Site Properties page displaying Remote Management option selected and Enable button highlighted.](how-webmatrix-verification-works/_static/image46.png)](how-webmatrix-verification-works/_static/image45.png)  
  
     Use the same password as the Web Deploy password in the account settings file.
    - ***Deleting Files***  
  
      The control panel should have a "File Manager" you can use to delete all the files under the site root folder.  
  
     [![Image of File Manager highlighted in control panel of Hosting Space menu.](how-webmatrix-verification-works/_static/image48.png)](how-webmatrix-verification-works/_static/image47.png)  
  
     Usually, all the files you published end up under the site folder in "wwwroot" or something similar. Delete all files underneath that node using the file manager interface.  
  
     [![Screenshot of File Manager interface displaying files under File Name node.](how-webmatrix-verification-works/_static/image50.png)](how-webmatrix-verification-works/_static/image49.png)  

     [![Image of File Manager interface with all files under File Name node selected and the checked box for File Name node highlighted.](how-webmatrix-verification-works/_static/image52.png)](how-webmatrix-verification-works/_static/image51.png)  

     Alternatively, you can use an FTP client like FileZilla to remotely connect to the FTP server (listing the same files) and delete all files that way. If you have IIS Remote Management access, you can also use IIS Manager to connect to the site and delete the content of the site.

That's it! That is the testing process for one application; we repeat this process for each of the applications above.

## Known Issues

- **Default document handling** - Because Web Deploy cannot assign/create entries for Default Documents, the user (and the person testing these applications) may have to go into the control panel to add these entries manually. For example, Wordpress may seem to fail but may only need "index.php" to be added to the list of Default Documents via a control panel before operating fine.
- **Application-specific bugs** - Some applications may require a trailing slash on your Destination URL to work, and some require it **not** to be there. Some applications require Full Trust on the server, while we recommend your accounts run in only Medium trust. These application bugs are not your concern; we continually work with applicaton owners to resolve these issues, with updates published regularly on the [Web Application Gallery](https://www.microsoft.com/web/gallery/ "Web Application Gallery").
