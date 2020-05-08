---
title: "How to Get Started Extending Module Properties for IIS 7.0 in IIS Manager"
author: rick-anderson
description: "The administration tool for IIS 7 and above is an extensible platform which developers can use to plug in their own features and manage custom settings. Any..."
ms.date: 11/24/2007
ms.assetid: a4fa174e-fedb-425f-9b18-ff8a92160576
msc.legacyurl: /learn/develop/extending-the-management-ui/how-to-get-started-extending-module-properties-for-iis-in-iis-manager
msc.type: authoredcontent
---
How to Get Started Extending Module Properties for IIS 7.0 in IIS Manager
====================
by [Janani Ravi](https://twitter.com/LoonyJanani)

## Abstract

The administration tool for IIS 7 and above is an extensible platform which developers can use to plug in their own features and manage custom settings. Any added features are integrated into the tool and appear along with the IIS and ASP.NET features as first class citizens.

This document shows how to access configuration settings for a custom section and how to manipulate them by developing a page derived from the ModulePropertiesPage base class in the Microsoft.Web.Management.Client.Win32 namespace. This uses a property grid to view and change the settings. The following articles provide the background for this document: "Creating a simple UI module", "Adding Configuration Functionality to IIS Admin Tool Extensions" and "Extending the IIS Schema and Accessing the Custom Sections Using Microsoft.Web.Administration APIs" .

## Introduction

This document describes how a developer can extend the IIS administration tool (InetMgr) in order to develop a feature which plugs into the tool. The InetMgr is designed to have distributed client-server architecture with the ModuleProvider and the ModuleService as the principle components on the server-side and the Module and the ModuleServiceProxy as the chief components on the client-side.

There are several base classes in the Microsoft.Web.Management namespace which allow users to develop dialog pages, list pages, property pages, etc. in order to display and manipulate settings. This document focuses on creating a page derived from the ModulePropertiesPage which uses a property grid to view and manipulate the administration settings. Examples of existing property pages in the IIS Manager tool are the pages to manipulate the ASP settings, CGI settings etc.

This document contains:

- Overview of how to extend the IIS schema to create a custom configuration section
- Setting up the ModuleProvider and the ModuleService used to manipulate the server's settings. In this example, we manipulate properties in the configuration files.
- Setting up the Module and registering the properties page. This displays the client UI.
- Developing the actual property page deriving from the ModulePropertiesPage base class.

## Extending the IIS Schema

Extending the schema involves adding a simple .xml file in the `%SystemRoot%\system32\inetsrv\config\schema` directory on your machine. The IIS\_schema.xml file is already present in this directory and can be used as an example to set up your own schema. Create a file named CUSTOM\_schema.xml and set it up as shown in the example below. In this case, the custom section (called "myCustomSection") has three properties of type boolean, string, and integer. The default values for these properties are specified in the schema as shown.

[!code-xml[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample1.xml)]

Register the section in the applicationHost.config. This involves adding just one line in the applicationHost.config as shown in the example below.

> [!NOTE]
> Since the path to our section is system.webServer/myCustomSection, we must register the section under the system.webServer group, which is an existing group for IIS sections.

[!code-xml[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample2.xml)]

## Creating the ModuleProvider and ModuleService

The CustomModuleProvider derived from the ModuleProvider class provides the entry point for registering the extensibility module with the administration tool. It specifies the following: the scope at which the feature is available (server, site or application); the ModuleService which is associated with this feature; and, the client side Module for this feature.

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample3.cs)]

The CustomModuleProvider must be registered in the administration.config under `%SystemRoot%\system32\inetsrv\config`. Specify the complete assembly qualified type name of the ModuleProvider. The administration.config is a special file used by the InetMgr. On startup, InetMgr uses this file to determine what features must be displayed.

[!code-xml[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample4.xml)]

> [!NOTE]
> If you only include the entry in the &lt;moduleProviders&gt; list, the UI feature appears only at the server level. Since we specified that the feature will appear at the Site and Application level as well, we must add the entry to the `<modules>` list. This indicates to InetMgr that this feature is valid for the site and application levels as well. (This gives users the flexibility to change where the feature is displayed without changing any code.)

The CustomModuleService derives from the ModuleService base class and performs the actual server administration. In this case, it has methods to read the configuration section and its properties, and to update the section with the new properties set by the user.

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample5.cs)]

The GetCustomSettings uses a property bag (a generic dictionary that holds parameters and which can be serialized) to return the values of the custom configuration section. The UpdateCustomSettings updates the value for these settings and ManagementUnit.Update() saves the configuration file.

The ModifiedKeys property of the updatedSettings property bag contains those keys whose values the user has changed using the UI (thus, we update only those properties which are different from the settings which already exist in the configuration file). The articles explains later how we get the PropertyBag to recognize that it has to track changes and populate the ModifiedKeys. The methods called from the client proxies are marked using the ModuleServiceMethod attributes.

The CustomGlobals class contains integers which act as keys to index into the property bag.

[!code-console[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample6.cmd)]

## Creating the Module and ModuleServiceProxy

The CustomModule derives from the Module class and provides the entry point for the client side code. The Initialize method on the CustomModule registers the CustomPage and displays the property grid to manipulate the settings. In this case, the CustomPage is registered in the Server category (which indicates in which group the feature appears on the Home Page of the tool).

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample7.cs)]

The CustomModuleProxy derives from ModuleServiceProxy and is called the method stub, which is the component used on the client-side in order to invoke methods on the server-side. The proxy methods correspond to those methods on the ModuleService which have been marked with the [ModuleServiceMethod] attribute.

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample8.cs)]

## Creating the Property Grid Page

With the other components set up, we now develop the class derived from the ModulePropertiesPage, which sets up a property grid. The grid allows the user to view and change the configuration settings.

Define a class which exposes all the properties which you want on the page:

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample9.cs)]

This derives from the base class PropertyGridObject. It implements the ICustomTypeDescriptor interface, which allows you to provide dynamic type information for this object (for example, specify special attributes for certain properties at runtime). However, in this example, we do not use any of the functionality provided by this base class.

Set up a class which derives from the ModulePropertiesPage.

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample10.cs)]

Override the GetProperties method of the ModulePropertiesPage base class used to retrieve the settings from the server. This is called in two cases:

- When first navigating to the page
- When clicking the refresh button on the page

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample11.cs)]

This method runs asynchronously on a background thread, so the best practice is not to access any UI elements in this method. It returns a property bag with the latest settings from the server.

Override the ProcessProperties method. This method is used to set and display the current settings specified in the PropertyBag argument passed to it.

This is called when we want to update the property grid with the latest settings. The property grid is updated in the following cases:

- When first retrieving settings from the server (on navigating to this page)
- When updating the server (the user hits Apply Changes)
- When cancelling any changes made in the UI and want to restore the original settings (the user hits Cancel Changes)

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample12.cs)]

Implement the UpdateProperties method. This method makes the service call to update the settings on the server and shows any errors which occurred during the update. It returns a property bag containing the newly updated settings, indicating to the base class the newest set of values from the server.

We create a clone of the property bag and use the clone to store all the changes the user made. We want to preserve the original settings that exist in config in case the user hits "Cancel Changes". The base class takes care of preserving the bag and you only need to ensure that the all the user operations are performed on the cloned bag. By cloning the bag, you also indicate that you want to track the changes made to the clone. The clone populates the ModifiedProperties with the keys that have been changed (we used this at the server side to make changes to configuration).

The ClearDirty method is to indicate that there are no changes on the page, i.e., it is not dirty and that the Apply and Cancel changes links should be disabled.

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample13.cs)]

Override the OnException method to handle errors in any special way. In this example, we simply show the error in a message box.

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample14.cs)]

Here is a snippet showing the framework of the entire class:

[!code-csharp[Main](how-to-get-started-extending-module-properties-for-iis-in-iis-manager/samples/sample15.cs)]
