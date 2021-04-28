---
title: "Integrate the Windows Web Application Gallery into a Control Panel"
author: rick-anderson
description: "The Windows ® Web Application Gallery (WAG) lets application developers reach a wide audience of users and gives Web site builders an easy way to discover an..."
ms.date: 03/18/2009
ms.assetid: 18743857-2074-4bed-84d6-2ffab07a5ab7
msc.legacyurl: /learn/develop/windows-web-application-gallery/integrate-the-windows-web-application-gallery-into-a-control-panel
msc.type: authoredcontent
---
# Integrate the Windows Web Application Gallery into a Control Panel

by IIS Team

> [!NOTE]
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

## Introduction

The Windows® Web Application Gallery (WAG) lets application developers reach a wide audience of users and gives Web site builders an easy way to discover and install freely available applications on Internet Information Services (IIS). Hosters and control panel vendors can use the guidance in this article to provide their users with access to the applications in the Web Application Gallery.

The Gallery provides a dynamic feed that keeps your control panels up to date automatically. You can integrate the Web Application Gallery into your existing control panel solution, providing users with a simple installation path for the applications available in the Gallery.

This article describes how to integrate the Windows Web Application Gallery applications in your application. Post any questions about the Gallery or about working with the Gallery feed or the Microsoft®Web Deployment Tool (MS Deploy) API to the [Web Application Gallery: Developers &amp; Integrators Forum](https://forums.iis.net/1158.aspx "Web Application Gallery : Developers &amp; Integrators").

## Before You Begin

To integrate the WAG into your control panel solution, you need the following:

- **Web Application Gallery Feed.**  
 This is an extended ATOM XML feed that contains all the information needed to download and install the applications available in the WAG. You can use the Microsoft® Web Platform Installer API to load and manipulate the content in the feed (recommended) or manually download and parse the feed XML content. This article provides information on the feed‘s location and XML content.
- **Web Platform Installer API (WebPI API).** The [Web Platform Installer tool](https://www.microsoft.com/web/downloads/platform.aspx) uses a new API to access the feed content. This is a public API available to developers: [Microsoft Web Platform Installer](https://msdn.microsoft.com/library/microsoft.web.platforminstaller.aspx). We highly recommend you use this API to access the feed‘s content instead of manipulating the feed XML directly. It provides:  

    - Abstraction from the details of the XML elements format and semantics.
    - Intuitive classes and methods.
    - Access to the list of applications and their tags to aid classification.
    - Easy detection of missing application dependencies.
- **Web Deployment API.** The [Web Platform Installer tool](https://www.microsoft.com/web/downloads/platform.aspx) uses a new API to manage the application packages, you can find its documentation at: [Microsoft Web Deployment](https://msdn.microsoft.com/library/microsoft.web.deployment.aspx). It is a public API available to developers. It allows your application to read and set parameter values and deploy applications including their associated database to the target servers.
- **Sample Application.**  
 A sample application, [Sample App](integrate-the-windows-web-application-gallery-into-a-control-panel/_static/integrate-the-windows-web-application-gallery-into-a-control-panel-607-sample1.zip), is provided. It uses the WebPI API to access and manipulate the WAG XML feed, and it uses the Web Deployment API to manage the application package, its parameters, and deployment.

This link downloads a compressed (Zip) file. Extract the contents of the compressed file, browse to the ControlPanelAppRtwAPI folder, and copy the content into your project or site.

Note that the Zip file is formatted as a Web Deployment Tool package; this means that you can use the MS Deploy tool or the "Import Application" functionality in IIS Manager to deploy the application into the "Default Web Site." This Zip file package format is used by all applications in the Windows Application Gallery.

Note also that you can manipulate the feed XML directly instead of using the WebPI API; however, this is discouraged since changes to the feed file may have unexpected results in your code.

Post any feedback or questions about the sample application to the [Web Application Gallery: Developers &amp; Integrators Forum](https://forums.iis.net/1158.aspx "Web Application Gallery : Developers &amp; Integrators").

## Set Up the Environment

The sample application illustrates some techniques that you may want to use with your own control panel application. Note, however, that the sample application should not be deployed in a production environment.

The sample application includes instructions for configuring your environment for its use. Those instructions should be used as your general guide for setting up the users and privileges needed for running a control-panel style application with MS Deploy.

## Set Up the Web Management Service (WMSVC)

Install and configure WMSVC. This service is used both to host the deployment handler that installs applications and to authorize site owners to install in their Web sites.

1. In the **Start** menu, click **Server Manager**.
2. In the tree view on the left, select the **Roles** node.
3. Scroll down to find and select the **Web Server (IIS)** role.
4. Click **Add Role Services**, and select the **Management Service** component.
5. Once the Management Service is installed, start **IIS Manager**.
6. Select the **Server** node.
7. Scroll down and locate the **Management Service** icon, and double-click on it.
8. Select the **Enable Remote Connections** check box.
9. In the **Task** pane, click **Start** to start the service.

## Set Up the Web Deployment Handler

Install and configure the deployment handler.

1. Use the [Web Platform Installer](https://www.microsoft.com/web/downloads/platform.aspx) to download and install Web Deployment Tool 1.0. under the **What's New** tab in the **New** **Web Platform Extensions** section.
2. During installation, select either **Custom** or **Complete**.
3. If you selected Custom, be sure that you select the **Web Management Service Integration** component.
4. The deployment handler uses rules to authorize users to perform actions during installation. For example, a common action is running a database script. This action should run as the low-privileged database account that the user already has. Some actions require higher privileges than the site owner has, such as marking a folder as an application. For this task, the handler can be configured to elevate to a higher privileged account. You should create an account that has access just to perform this action.
5. Allow a user to write to **ApplicationHost.config**, the IIS configuration file, to mark folders as applications.  

    - Create a custom user to mark folders as applications.  

        [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample1.cmd)]
    - Grant the user read permission to   

        [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample2.cmd)]
    - Grant the user modify permission to  

        [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample3.cmd)]

        [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample4.cmd)]
6. Add a set of rules to allow customers to deploy content, applications, and databases by opening the **Administration.config** file and navigating to this section:  

    [!code-xml[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample5.xml)]
7. To allow site owners to create applications, set access control lists (ACLs), and deploy database data, you must add the following rules to the **Administration.config** file within the `<management>` section. Make sure to change the `<runAs>` element to contain the user credentials you created in step 5 above. Notice that you can add these rules [programmatically using MWA](../../publish/using-web-deploy/configure-the-web-deployment-handler.md).  

    [!code-xml[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample6.xml)]
8. In the **Administration.config** file, find the element **"&lt;sectionGroup name="management"&gt;"** inside **"&lt;sectionGroup name="system.webServer"&gt;"**, verify that the following element is listed in it: **"&lt;section name="delegation" overrideModeDefault="Deny" allowDefinition="MachineToWebRoot" /&gt;"**. If not, add it.
9. Restart **WMSVC**.
10. If you are using a remote Universal Naming Convention (UNC) share for content, follow the permission specified in [Configuring Share and NTFS Permissions](../../web-hosting/configuring-servers-in-the-windows-web-platform/configuring-share-and-ntfs-permissions.md), with the following exception: for the path \\server\share$ (share), set "Domain Users" to "Full Control" instead of "Change." If you are using shared configuration, apply the [update](https://support.microsoft.com/kb/969912) to ensure that WMSVC allows connections when Shared Configuration is enabled in Windows Server® 2008.

## Set Up the Sample Application

Create a Web site, application pool, and custom identity to host the code for the sample application.

## Set Up the Site

1. Create a physical directory for the sample application Web site with the following command:  

    [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample7.cmd)]
2. Create a new user account that will be used to run the sample application and install the applications. Run the following from an elevated command prompt:  

    [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample8.cmd)]
3. Grant access to the user account:  

    [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample9.cmd)]
4. Create a new Web site to host the sample application.
5. Start **IIS Manager**, and browse to the **Web Sites** node.
6. Right-click on the **Web Sites** node, and then select **Add Web Site**.
7. Create a new Web site called **ControlPanel**. This automatically creates an associated application pool called ControlPanel.
8. Open **IIS Manager**, and browse to the **Application Pools** node.
9. Right-click on the application pool **ControlPanel**, and then select **Advanced Settings**.
10. Under the **Process Model** header, click on the **Identity Network Service**.
11. Set the identity network service to a custom account, and then enter the *credentials* for the user created in step 2, ControlPanelAppId.  

    For dependency checking in the sample application to work correctly, you must use an account that has administration privilege on the computer because dependency checking requires access to the registry and directories that is only available to administrators. Alternately, you can comment out the dependency checking code.
12. Copy the contents of the sample application into the physical path you selected when creating the Web site.
13. Make sure the application is running under [Full Trust](https://msdn.microsoft.com/library/tkscy493.aspx). [You can enable it in the App Web.config](https://msdn.microsoft.com/library/wyts434y.aspx) file or, if not allowed, the administrator can add it to the root Web.config file.

## Use the Default SSL Certificate for WMSVC

By default, the WMSVC service installs a self-signed Secure Sockets Layer (SSL) certificate. Ideally, a fully trusted certificate is installed for the WMSVC, but for testing purposes, use this default certificate with the sample application.

1. In the sample application, open the file **Global.asax**.
2. Look for the **Application\_Start** function, and uncomment the line:  

    [!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample10.cs)]

    to

    [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample11.cmd)]
3. Save the file.

## Create a Customer Site and Authorize the Site Owner

Create a Web site for a site owner and authorize the site owner to both connect using remote management in IIS Manager and install application packages using the sample application.

1. Start **IIS Manager**.
2. Browse to the **Web Sites** node.
3. Create a new Web site called **MySite**, or use one that has already been provisioned.
4. Create a new site owner account called **MySiteUser**, or use one that has already been provisioned.  

    [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample12.cmd)]
5. Select the Web site called **MySite**.
6. In the **Features View**, double-click **IIS Manager Permissions**.
7. On the **IIS Manager Permissions** page, in the **Actions** pane, click **Allow User**.
8. In the **Allow User** dialog box, add a Windows user.
9. Click **Select** to open the **Users** dialog box.
10. Type **mysiteuser**, and then click **OK**.
11. Click **OK** to close the **Allow User** dialog box.  

    See [Allow an IIS Manager User Account to Connect to a Site or an Application (IIS 7)](https://technet.microsoft.com/library/cc770968.aspx) for additional information.

## Test the Installation of an Application Package

1. Start **IIS Manager**.
2. Browse to the **Web Sites** node.
3. Select the Web site **ControlPanel**.
4. In the **Task** pane, click **Browse**.
5. Click on the application package that you want to install.
6. Type **mysite** for the site name, type **mysiteuser** for the username, and type the *password* for this account.
7. Supply other information requested, and click **Install**.

## Manipulate the Feeds

The Gallery feed is provided as an extended ATOM feed. The [product list](https://www.microsoft.com/web/webpi/2.0/WebProductList.xml) contains the components of the Microsoft Web Platform and the [application list](https://www.microsoft.com/web/webpi/2.0/WebApplicationList.xml) contains many popular open-source applications. Feeds are used in the sample application to:

- Generate the list of applications to install.
- Get the download information for a package.
- Get dependency information on any of the applications.

## Download the Application List Feed

Before you can parse the feed, you must download it locally. The sample application uses the [WebClient.DownloadFile](https://msdn.microsoft.com/library/ez801hhe(VS.80).aspx) method to download the feed (see the application list URL above) and save it in a temporary file obtained through [Path.GetTempFileName](https://msdn.microsoft.com/library/system.io.path.gettempfilename.aspx). These calls are made in **GetXmlLocationFromFeed** (see **Reload** method in the file "ControlPanelAppRtwAPI\App\_Code\Packges.cs").

## Use the WebPI API to Parse the Application Feed

Also in **Reload**, you find calls to the [Microsoft.Web.PlatformInstaller.ProductManager](https://msdn.microsoft.com/library/microsoft.web.platforminstaller.productmanager.aspx) class. This class provides the functionality for managing the data in the feeds (application and product lists).

### Initialize the ProductManager Object

The following code initatiates and intializes a ProductManager object:

[!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample13.cmd)]

### Extract the Installer Information for Each Application

When building your user interface, you have the choice of which fields from the ATOM feed you want to display. A minimalist approach would be to just display the applications' names, taken from the title element. You can also create a much richer UI by taking advantage of the graphic elements, such as the icon and screenshot, and incorporating other metadata from the feed.

To display the application information and to create the links to each installation package, the sample application uses the [Microsoft.Web.PlatformInstaller.Installer](https://msdn.microsoft.com/library/microsoft.web.platforminstaller.installer.aspx) object for each of the applications. (See **Reload** method for reference.)

1. Within a foreach loop, examine each [Microsoft.Web.PlatformInstaller.Product](https://msdn.microsoft.com/library/microsoft.web.platforminstaller.product.aspx) object contained in the Microsoft.Web.PlatformInstaller.ProductManager.Products collection. Identify those that are marked as applications:  

    [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample14.cmd)]
2. Still within the foreach loop, get the installer for the application and access the particular object properties needed for the user interface and installation process. The most important of them all is the [InstallerFile.InstallerUrl.AbsoluteUri](https://msdn.microsoft.com/library/microsoft.web.platforminstaller.installerfile.installerurl.aspx), which contains the location for downloading the Web Deploy package for the application:  

    [!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample15.cmd)]
3. You can then add each of the package objects to your own packages collections and display them in your UI.

## The Application Entry XML

Applications are listed as entries within the feed identified with the attribute **type="application"**. A sample application entry from the feed looks like:

[!code-html[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample16.html)]

## Reading the List of Applications Directly from the XML Feed

You can access the XML from the feed directly, but this is not the recommended approach. The following example illustrates how you could access key application elements:

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample17.cs)]

## Identifying Missing Dependencies Using the WebPI API

An important step within the sample application is to identify all the missing dependencies in the target server where the application will be installed. The sample apllication collects this information and displays it as an error if the user tries to install an application package for which dependencies are missing. For this purpose, the Web.PlatformInstaller provides the [Microsoft.Web.PlatformInstaller.Product.GetMissingDependencies](https://msdn.microsoft.com/library/microsoft.web.platforminstaller.product.getmissingdependencies.aspx) method, which returns a collection of missing products.

Before this method is called, you must create an instance of ProductManager and initialize it with the Products List feed (not the Application feed). The following code snippet is an example on how to check for missing dependencies. You can find this code in the ControlPanelAppRtwAPI\App\_Code\Package.cs file of the sample application.

Note that the call to GetMissingDependencies only works correctly if it is made within the context of a user with administrative rights to the computer because it needs access to the registry and directories only available to administrators.

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample18.cs)]

Control panel applications should ensure that the corresponding dependencies for a particular package are available in the target server before proceeding with the installation process. If this functionality is not available, there is a risk of failure once the user tries to execute the application after a successful installation. In the absence of this dependency check, hosters would have to monitor the feed applications and their dependencies to ensure that target servers are properly set up.

Note that the GetMissingDependencies method looks for dependencies within the scope of the bit size of the running process. If it is a 32-bit process, it looks for 32-bit dependencies, and for 64-bit process, it looks for 64-bit dependencies. This is important if you are running on a 64-bit computer under 32-bit mode application pools.

## Tracking Application/Product Dependencies

The best approach to identifying missing dependencies within your solution is to use WebPI API. However, you can use the following steps if you wish to review the feed XML and identify which dependencies are needed for each application.

One of the most important elements within the **WebApplicationList.xml** feed file is the &lt;dependency&gt; element. This element describes the dependencies needed for a particular application package to work properly.

The product list feed **WebProductList.xml** is the root feed. It not only contains references to the product information (Web Platform components) but also points to a child feed **WebApplicationList.xml**. The **WebApplicationList.xml** contains the references to the applications packages, and each application package entry contains a set of dependency references to product packages defined in **WebProductList.xml**. The following example shows how this relationship is implemented:

1. The WebProductList.xml contains a link to the WebApplicationList.xml:  

    [!code-html[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample19.html)]
2. The WebApplicationList.xml contains references to application packages contained within &lt;entry&gt; elements. Each package entry contains a list of dependencies. For example, the dependency element for a PHP application that also uses MySQL such as WordPress is:  

    [!code-xml[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample20.xml)]

   The &lt;dependency&gt; element means the beginning of the dependency list. The &lt;and&gt; element means that all the dependency elements listed inside are required by the application.
3. Note the idref="PHPApp" and idref="MySQLApp" properties. They refer to another &lt;dependency&gt; element with corresponding "id" value that defines the actual dependencies. For example, if you examine the WebApplicationList.xml file for the "PHPApp" dependency element, you find the set of PHPApp dependencies:  

    [!code-xml[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample21.xml)]
4. The `<productId>` element contains the reference to the corresponding product in the parent feed WebProductList.xml. For example:  

    - ID = WDeployNoSMO, corresponds to Web Deploy without SMO
    - ID= PHP, corresponds to the PHP engine (currently: 5.2.11)

   Notice that the &lt;or&gt; entry means that the dependency is for one or the other or both.
5. The product entries in the WebProductList.xml contain a &lt;discoveryHint&gt; element that shows what to look for to find out if the product already exist in the target machine or not. For example, in the case of product id "MySQLConnector":  

    [!code-xml[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample22.xml)]
6. The &lt;or&gt; element means that at least one of &lt;discoveryHint&gt; elements must be satisfied.

## Filter the List of Applications Using the Web PI API

You can provide your users with a UI that lets them sort the applications based on information provided in the Applications List feed. You can filter applications by using the keywords associated with each application under the element &lt;keywords&gt;.

In the Application Entry example above, you can see:

[!code-xml[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample23.xml)]

The following code snippet illustrates how you can filter applications by their keywords:

[!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample24.cmd)]

This example uses the Web.PlatformInstaller API to load the Application List feed and then list each application ordered by keyword. The [ProductManager.Keywords](https://msdn.microsoft.com/library/microsoft.web.platforminstaller.productmanager.keywords.aspx) collection lists all the available keywords from the loaded feed.

The following example lists all applications that have the "PHP" keyword followed by the applications that have the "ASPNET" keyword.

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample25.cs)]

## Download a Web Deploy Package

When the user selects an application, you need to download the Web Deploy package to a location on the server where the application will be installed. The package is available via HTTP. Its location is in the feed as the data within the &lt;installer&gt; element. For example:

[!code-xml[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample26.xml)]

The sample applications use the WebClient.DownloadFile method to download the package file; after downloading the sample applications, verify the hash and display the parameters required by the package.

## Use the SHA1 Hash to Verify the Package

The `<sha1>` element in the example contains the SHA1 hash of the package to download and acts as a signature for the package. You can use this hash to verify that the downloaded package is indeed the one you expect. The sample application collects this value for every application in the feed XML file and uses the value to verify the hash of the downloaded package.

The following code snippet from the sample application illustrates this verification:

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample27.cs)]

## Handle Package Parameters

Most packages contain parameters that are required to install them in a given environment. As part of the control panel design, you can choose what types of parameters you can compute and set and which ones require input from the user.

## Collecting the Parameters Defined in the Package

The Web Deployment API allows you to retrieve the parameters from a package by accessing a collection within the Web Deploy [**DeploymentObject**](https://msdn.microsoft.com/library/microsoft.web.deployment.deploymentobject.aspx).

The code snippet below is taken from the sample applications and shows one method of generating the parameters as a collection called "\_parameters" to be used later.

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample28.cs)]

The sample applications use a "ReadOnlyCollection" called "Parameters" to bind the "\_parameters" data list from the example above to the UI fields in a ListView control inside the Install.aspx file:

[!code-console[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample29.cmd)]

## Using the Parameter Names and Tags

A typical package requests the following parameter names:

- **Application Path**. This is the Web server path for the application in the form of "Web Site/Application" (for example, "Default Web Server/application\_name").
- **Application Database Information**. This is the database information required for the application to communicate with the database, typically consisting of four parameters:  

    - **Database Server**. The host name or IP address of the database server.
    - **Database Name**. The name of the database.
    - **Database Username**. The ID used by the application for communicating with the database.
    - **Database Password**. The password for the database username.
- **Database Administrator information**. These are the credentials required for creating the database and user listed above.

These parameter names are recommended, but not required. The control panel can tell which parameters are parts of the database connection by referring to the **tags** that are included with the parameters.

The following tags can be used with parameters to tell the UI how to display and use the parameters:

- **iisApp**. This identifies a parameter as the application path for installation. The defaultValue should be displayed unless you already know which site will be used for application installation. The defaultValue is usually set to a value such as "Default Web Site/application1" (this is not enforced). For example, if the user logs in and you determine they own "MySite.com," you can parse the defaultValue to get "/application1," and append this to the hosted site name.
- **Hidden**. This identifies a parameter that is set programmatically rather than through user input. For example, the "Connection String" has a default value that is computed from the values of other parameters. The portions of the entry within the {}s are replaced with the values of those parameters.
- **SQLConnectionString or MySQLConnectionString**. These parameters are used for constructing a connection string for connecting to the database.
- **SQL or MySQL**. These parameters are used in relation to a specific database. An application package can work with either SQL or MySQL as the database. Parameters can be tagged with one or both of these. The UI can let the user to choose which database to use. All parameters that have a ConnectionString tag also have the corresponding database tag.
- **Password**. This identifies a field that is used as a password that is already known. The UI obfuscates the value.
- **New**. When used along with the password tag, this identifies a field that is used to set a new password. The UI obfuscates the value, and asks the user to confirm it. For example, New, Password.
- **dbUsername, dbUserPassword, dbAdminUsername, dbAdminUserPassword**. Some UIs that install application packages handle the database creation themselves. If the user has already created a database, the UIs seamlessly hide and correctly fill in the administrative credentials to avoid making the user enter data twice. The tags identify the parameters to modify if the UI handles database creation.
- **dbServer**. This is used to identify a parameter that can be filled in with a database server name.
- **dbName.** This is used to identify a parameter that can be filled in with the name of a database.

You can retrieve these tags through the **DeploymentSyncParameter.Tags** property; it is a comma-delimited string containing the tags associated to the parameter.

Some parameters have default values that can be retrieved from the **syncParameters** collection. You have the choice of using those defaults, prompting the user for new values with the defaults in the forms, or ignoring them, as appropriate for your environment.

## Using the Parameter Validation Data

There is validation data you can use to help you build the appropriate UI. Each [DeploymentSyncParameter](https://msdn.microsoft.com/library/microsoft.web.deployment.deploymentsyncparameter.aspx) has a DeploymentSyncParameterValidation object that identifies the parameter as having one or more of the following types of data:

- **AllowEmpty**. The parameter allows an empty value.
- **Boolean**. The parameter only allows "true" or "false."
- **Enumeration**. The parameter only allows values specified within the DeploymentSyncParameterValidation.ValidationString. This is a comma-delimited string.
- **RegularExpression**. The parameter only allows strings that match the specified regular expression within DeploymentSyncParameterValidation.ValidationString.

The sample application uses this data to setup the UI input controls appropriately. For example, locate the following code snippet within either sample application and note the definitions of IsBooleam(), SplitValidationValues(), AllowEmpty(), and HasReg():

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample30.cs)]

## Deploy an Application

Once you have gathered all of the data for the parameters, it is time to install the application. Working with your DeploymentObject, you can apply the set parameters and install the application. The API steps to do this are outlined below.

## Initialize the DeploymentObject

You must tell the DeploymentObject how to install the application. For example:

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample31.cs)]

In the example, the ComputerName is the Universal Resource Identifier (URI) for the MS Deploy agent. The UserName and Password are the credentials for the ID that has the authority to use the agent.

## Set the Parameters

Each of the parameters in the original application package must have a value. If a parameter has a DefaultValue, you do not need to specify a new value at this point. All other parameters require values.

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample32.cs)]

The Web site and application that MS Deploy uses to install the application is specified with the Application Path parameter.

## Installing the Application

The application is installed using the DeploymentObject.SyncTo() method. The sample application call to SyncTo follows:

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample33.cs)]

In the code snippet:

- **DeploymentWellKnownProvider.Auto** specifies that the MS Deploy auto provider be used to install the application. This provider examines the package manifest, contents, and parameter values to decide which resources need to be deployed.
- **destinationOptions** specifies the target computer, the credentials, and type of authentication to be used during the installation.

## Change the Target Server

The sample application assumes that the target server is the "localhost." Note that inside the Package.cs file, in the installation method, the code specifies localhost, the SiteName that you enter in the corresponding UI field:

[!code-csharp[Main](integrate-the-windows-web-application-gallery-into-a-control-panel/samples/sample34.cs)]

If you created a site called "MySite" (as in the example above), you must type **mysite** in the **Site Name** UI field.

## Provide the User with the Application Location

When the installation is complete, your control panel should provide a link to the application for the user. The base of this URL should be determined from the Web site setup. An application may have a StartPage element defined within its entry in the ATOM feed. If there is a StartPage element, its value should be appended to the link presented to the user.

## Links for Further Information

**Microsoft® Developer Network (MSDN®):** 

- [Microsoft Web Deployment namespace](https://msdn.microsoft.com/library/microsoft.web.deployment.aspx)

**Forums:** 

- [Web Application Gallery: Users](https://forums.iis.net/1159.aspx)
- [Web Application Gallery: Developers &amp; Integrators](https://forums.iis.net/1158.aspx)
- [Web Platform Installer](https://forums.iis.net/1155.aspx)

**Articles:** 

- [Application Packaging Guide for the Windows Web Application Gallery](package-an-application-for-the-windows-web-application-gallery.md)
- [Web Application Gallery Overview](introducing-the-windows-web-application-gallery.md)
- [Web Application Gallery Principles](windows-web-application-gallery-principles.md)
- [Best Practices: Running PHP Applications on IIS](introducing-the-windows-web-application-gallery.md)
- [Best Practices: Running ASP.NET Applications on IIS](../../application-frameworks/building-and-running-aspnet-applications/index.md)
