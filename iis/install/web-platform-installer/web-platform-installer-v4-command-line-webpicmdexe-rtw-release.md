---
title: "Web Platform Installer v5.1 Command Line (WebPICMD.exe) - RTW release"
author: chrissfanos
description: "The Web Platform Installer v5.1 (WebPI) command line tool is now available as part of the WebPI MSI! We've added a bunch of new features and fix several issues..."
ms.date: 08/27/2012
ms.assetid: d0440577-9e53-4202-9df3-199bc567e1c1
msc.legacyurl: /learn/install/web-platform-installer/web-platform-installer-v4-command-line-webpicmdexe-rtw-release
msc.type: authoredcontent
---
# Web Platform Installer v5.1 Command Line (WebPICMD.exe) - RTW release

by [Chris Sfanos](https://github.com/chrissfanos)

## WebPI Command line

The Web Platform Installer v5.1 (WebPI) command line tool is now available as part of the WebPI MSI! We've added a bunch of new features and fix several issues, and now it's ready for it's full release

For those of you who aren't familiar with WebPI, it's a great little tool for deploying your favorite open-source applications and all the necessary platform components required to get you up and running quickly and seamlessly. Over the years, we've heard a lot of feedback from the community about fully supporting a command line version of the tool - users want to script installs and automate deployment of servers.

## Downloading WebPI

You can download WebPI v5 RTW (and the included WebPICMD.exe) from the links below:

**By downloading and using the Web Platform Installer (WebPI), you agree to the *[license terms](https://go.microsoft.com/fwlink/?LinkId=251729)* and *[privacy statement](https://go.microsoft.com/fwlink/?LinkId=251732)* for WebPI. This installer will contact Microsoft over the Internet to retrieve product information. Some of the Microsoft software obtained through WebPI may use Microsoft's Customer Experience Improvement Program (CEIP). To view which software uses CEIP, see [*here*](https://go.microsoft.com/fwlink/?LinkId=262873)**

WebPI v5.1 x86: [https://download.microsoft.com/download/8/4/9/849DBCF2-DFD9-49F5-9A19-9AEE5B29341A/WebPlatformInstaller_x86_en-US.msi](https://download.microsoft.com/download/8/4/9/849DBCF2-DFD9-49F5-9A19-9AEE5B29341A/WebPlatformInstaller_x86_en-US.msi)

WebPI v5.1 x64: [https://download.microsoft.com/download/8/4/9/849DBCF2-DFD9-49F5-9A19-9AEE5B29341A/WebPlatformInstaller_x64_en-US.msi](https://download.microsoft.com/download/8/4/9/849DBCF2-DFD9-49F5-9A19-9AEE5B29341A/WebPlatformInstaller_x64_en-US.msi)

## Setting up WebPICMD.exe

Just run the installer and that's it - you'll find WebPICMD.exe in the `%programfiles%\microsoft\web platform installer` directory

## Using WebPICMD.exe

WebPICMD.exe has three main modes of operation that you can use - you specify the mode with the first switch on the command line.

The three modes are:

1. /List: Used to display the list of products available, installed and return information about the various XML feeds
2. /Install: Used to install products or applications to your machine
3. /Offline [NEW!] Creates an offline cached copy of a specified set of products and applications so you can install while offline

Let's walk through each mode and describe the command line options in more detail and give a few examples to help you get started!

### /List mode

Here's the full set of list mode parameters:

/List /ListOption:[All | Available | Feeds | Installed | Languages]

##### Let's try looking at the "All" option

Ex: &gt;WebPICMD.exe /List /ListOption:All

This returns the list of installed products as well as the list of available products and applications for your machine

##### Curious as to what feeds WebPICMD.exe is loading? Let's try the "Feeds" option

Ex: &gt;WebPICMD.exe /List /ListOption:Feeds

This returns the 5 feeds that WebPI is currently loading and the URL where the live

##### Curious as to what languages WebPICMD.exe supports? Let's try the "Languages" option

Ex: &gt;WebPICMD.exe /List /ListOption:Languages

This returns the list of languages and their associated language IDs

### /Install mode

Install mode is just that - it allows you to select a set of products and/or an application that you want to install. This is great if you need to configure a set of machines with the same set of products - WebPICMD.exe will handle only installing the items that you need and you don't have to run the UX each time!

#### Installing Products

Here's how installing Products works - you just specify the /Products switch and then a comma delimited set of product IDs (not sure which ID to use? Use the **/List /ListOption:Available** to see all the available products for your machine

Ex: &gt;WebPICMD.exe /Install /Products:MVC3,WebMatrix

In the above example, we are installing MVC3 and WebMatrix. WebPICMD.exe will calculate all the required dependencies for both products and install all of them in advance of installing MVC3 and WebMatrix. It's that easy!

> [!NOTE]
> If you are scripting this out in PowerShell, you'll need to put quotes (" ") around the productIDs (so in the example above, it would look like:

Ex: &gt;WebPICMD.exe /Install /Products:"MVC3,WebMatrix"

#### Installing Applications

Here's the full set of install mode parameters:

*Required*

/Install /Application:&lt;ID or Title&gt;

Here's how installing Applications works - you just specify the /Application switch and then product ID (or title) of the application.

Ex: &gt;WebPICMD.exe /Install /Application:DotNetNuke

This example installs DotNetNuke - the install will be required to answer all the application parameters inputs during the installation process

##### Optional Parameters for /Install

The /Install mode has several optional parameters for automating the installation

/XML:&lt;FilePath&gt; Absolute path or URL for the XML feed - this overrides the main WebProductList.xml feed

/Feeds:&lt;Custom Feed URI&gt; Comma separated list of custom XML feeds that you want to load in addition to the main WebPI feeds

/Language:&lt;languageID&gt; Language of installers to be used.

/Log:&lt;LogPath&gt; Path to log the results of your installation

/SQLPassword:&lt;password&gt; When installing SQL Express, allows you to pass the desired SA password to set

/MySQLPassword:&lt;password&gt; When installing MySQL, allows you to pass the desired root password to set

/SuppressReboot Suppress any required reboots - the user will need to reboot manually

/ForceReboot Reboot automatically without prompting the user

/AcceptEULA Suppress I Accept/I Decline. Using this switch *is the same as accepting ALL EULAs*

/IISExpress Install applications to IIS Express (WebMatrix) - default is to always install to IIS

@[Paramfile.app] Per application answer file

Now let's take a look at a few more examples of /Install using some of the optional parameters

##### Installing SQL Express and passing the SA password

Ex: &gt;WebPICMD.exe /Install /Products:SQLExpress /SQLPassword:ILoveaGoodPassword!

##### Installing WebMatrix while Accepting the EULA and installing in Russian

Ex: &gt;WebPICMD.exe /Install /Products:WebMatrix /AcceptEula /Language:ru

##### Installing an application to WebMatrix

Ex: &gt;WebPICMD.exe /Install /Application:DotNetNuke /IISExpress

### /Offline mode [NEW!]

Offline mode is a brand new feature (so treat it gently) that provides the ability to create an offline cache of products or applications and automatically updated XML feeds to refer to the newly downloaded versions (instead of the live versions). We also download icons so the experience offline is seamless for the user

Here's how the offline mode works in a nutshell:

1. Run WebPICMD.exe and specify the products you want to make available offline
2. WebPICMD.exe calculates ALL the possible dependencies (independent of what is installed on your machine today) and builds a complete install plan
3. WebPICMD.exe then downloads all the installers as well as the WebPI XML feeds and stores them locally
4. Finally, WebPICMD.exe parses the newly downloaded feeds and: 1) removes all the products not currently available offline and 2) replaces the URLs of the offline products with the new local URI

I'll cover the available options in the current release and then discuss at set of known issues/improvements we'd like to make going forward :-)

#### Creating an offline cache of products

Here's the full set of offline mode parameters:

*Required*

/Offline /Products:[All | productID] /Path:&lt;offline-directory-location]

(you can also do a comma delimited list of products)

**A word of warning about the "All" option**: It does what it says - it will create an offline cache with *everything* in the WebPI feed. That's a lot of stuff. And it's probably going to take a long while. Use it with great care.

Now let's see it in action:

Ex: `> WebPICMD.exe /Offline /Products:WebMatrix,SQLExpress /Path:c:\OfflineCache`

The above will create an offline cache at `c:\offlineCache` that contains WebMatrix and all it's possible dependencies!

##### Optional Parameters for /Offline

The /Offline mode has several optional parameters

/XML:&lt;FilePath&gt; Absolute path or URL for the XML feed - this overrides the main WebProductList.xml feed

/Feeds:&lt;custom feed URI&gt; List of URIs to load in addition to the main WebPI feed for creating offline cache with your own products

/Language:&lt;languageId&gt; Languages you want to download (default: English only)

/Url:&lt;url path&gt; Substitute a URL path (instead of a file path) when creating the updated install locations in the feed

Now let's take a look at a few more examples of /Offline using some of the optional parameters

##### Setting up the offline cache on a file share

Ex: &gt;WebPICMD.exe /Offline /Products:WebMatrix,MVC3 /Path:\\testserver\public

In the above example, we created our offline cache on a public server that we can share out with other users

##### Setting up the offline cache that includes your own products

Ex: `> WebPICMD.exe /Offline /Products:SQLExpress,MyCompanyProduct /Feeds:c:\myproductfeed.xml /Path:c:\MyOfflineCache`

Now I can add my own products to the cache for use offline

#### More details about the offline cache

The offline cache sets up a directory structure as described below that contains everything you need to take your installation offline, including a copy of WebPICMD.exe itself. I'll describe the directories, what's inside them and talk a little bit more about how you might want to use it

/Offline creates four directories when setting up an offline cache:

/bin Contains WebPICMD.exe and the Microsoft.Web.PlatformInstaller.dll

/feeds Contains the modified feeds (shadow-&lt;originalfeedname&gt;.xml) as well as a subdirectory of original feeds

/installers Contains subdirectories for each installer that is part of the offline cache

/resources Contains the /icons and associated subdirectories for each product and their WebPI icon

#### Take the offline cache on the road with you ... or give it to a friend

One of the key features we wanted to enable for the Offline cache was the ability to put your cache "on a stick" and pass it around to your friends or coworkers. That's why we have the /bin directory and more importantly, why we introduced the concept of "relativeURLs" in the feed. If you open the modified XML file and find the first product entry, you'll see an &lt;installerURL&gt; element that contains the full path to the offline cached version of the installer. But you'll also notice the new &lt;relativeInstallerURL&gt; attribute - this new attribute is a relative path to the installer based on the known directory structure.

What does that mean? If you copy the full directory structure (let's say it was on c:\) to a USB key and hand it over to a friend and they fire it up, the full path won't be valid anymore (their USB key will be g: or some other drive). But the relativeURL doesn't care - it works off the relative paths and installs will still work. So your friend can use it with WebPICMD.exe!

#### Enabling WebPI (UX) to use a custom "main" feed

One of the great opportunities for the offline cache is to point the WebPI UX version to the new feed and offer it to users who do not have internet access. These users will only see the products available offline and can have a complete and seamless experience. To enable this, please do the following:

1. Click the Options link in the WebPI UX
2. Browse/enter the full path to the offline feed in the **Primary Feed** (not Custom Feed) box
3. Click OK - that's it!

#### Future features for offline and your feedback

This is the first preview release of the new /Offline cache support and therefore it's not feature complete - below are a list of some features we are considering. We'd like to hear from you though - are these features important? What other features should be add?

What do you think? Our friends on the WebMatrix team are sharing their UserVoice site to help us collect feedback - you can access that site here: [http://webmatrix.uservoice.com/forums/128313-webmatrix-suggestions](http://webmatrix.uservoice.com/forums/128313-webmatrix-suggestions)

#### Wrap up

If you've made it this far - thanks! We hope you find WebPICMD.exe useful - we are excited about the new features and look forward to delivering upcoming versions with the help of your feedback!

Thanks

WebPICMD.exe Team
