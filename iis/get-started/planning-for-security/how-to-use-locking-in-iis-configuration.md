---
title: "How to Use Locking in IIS 7.0 Configuration | Microsoft Docs"
author: rick-anderson
description: "This document explains how to lock and unlock configuration on the server. You will learn what settings the application-level configuration files can overrid..."
ms.author: iiscontent
manager: soshir
ms.date: 11/22/2007
ms.topic: article
ms.assetid: e4e4adc6-2b26-431a-aead-f7632ccc8f07
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/planning-for-security/how-to-use-locking-in-iis-configuration
msc.type: authoredcontent
---
How to Use Locking in IIS 7.0 Configuration
====================
by [Saad Ladki](https://twitter.com/saadladki)

## Abstract

This document explains how to lock and unlock configuration on the server. You will learn what settings the application-level configuration files can override and how to use the **&lt;location&gt;** element to lock entire sections.

You will experiment with more granular locking of configuration settings, within sections, such as:

- Locking specific elements and attributes
- Locking everything *except* specific elements or attributes
- Locking specific collection directives such as the **&lt;add&gt;**, **&lt;remove&gt;**, and **&lt;clear&gt;** directives
- Locking specific elements in collections

After reading this document, you will know how to manage different features of configuration locking by directly editing XML elements in configuration files (the programmatic interface to perform these tasks follows the XML structure very closely).

This document focuses intentionally only on editing XML elements in the configuration files, instead of showing ways to accomplish the same tasks using the administration API, scripts, or the user interface (UI).

This article contains:

- [Introduction](#Introduction)
- [Task 1: Locking a Section Using a &lt;location&gt; Tag](#Task1)
- [Task 2: Locking Specific Elements and Attributes](#Task2)
- [Task 3: Locking Everything Except Specific Attributes](#Task3)
- [Task 4: Locking Some Collection Directives](#Task4)
- [Task 5: Locking Specific Elements in a Collection](#Task5)
- [Summary](#Summary)

<a id="Introduction"></a>

## Introduction

IIS 7.0 and above allows locking and unlocking configuration settings in various levels and scopes. Locking down configuration means that it cannot be overridden (or set at all) at lower levels in the hierarchy. Unlocking configuration can only be done at the level where it was locked. This is useful, for example, when creating different configuration for different sites or paths, and only some of sites and paths are allowed to override it. Locking can be done at the section level or for specific elements, attributes, collection elements and collection directives within sections.

<a id="Task1"></a>

## Task 1: Locking a Section Using a &lt;location&gt; Tag

In this task, you learn how to use the **&lt;location&gt;** tag to lock (or unlock) entire configuration sections at the global level so that they cannot be overridden at application levels of the configuration hierarchy.

> [!NOTE]
> By default, most IIS sections in applicationHost.config are locked down, and none of the .NET framework are locked (including the ASP.NET sections in the &lt;system.web&gt; section group in machine.config and root web.config).

Using a text editor such as Notepad, open the applicationHost.config file in the following location:

[!code-console[Main](how-to-use-locking-in-iis-configuration/samples/sample1.cmd)]

Review the &lt;configSections&gt; section at the very top of the file &acirc;&euro;&ldquo; it has metadata about the configuration sections in this file, like names for sections, containing section groups, and whether or not they are locked.

Locked sections are specified by the "overrideModeDefault" attribute, which is either "Allow" or "Deny". Very few sections are not locked by default, as specified by this line for example:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample2.xml)]

Here, we deal with the **&lt;windowsAuthentication&gt;** section. It is locked by default.

To unlock the entire section for all applications on the server, move its content from its current location in the file to the bottom of the file and put it inside a **&lt;location overrideMode="Allow"&gt;** element. Remember also to have the section groups surrounding it: &lt;system.webServer&gt;, then &lt;security&gt; and then &lt;authentication&gt;. The end result should look like this:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample3.xml)]

The section is now unlocked for all applications. You can specify a path on the location tag, so that the section will be unlocked only for this path. The default path, if not specified (as in the previous step), is path="." (or path="" ,the same thing), which means "this current level". In this case, since this is applicationHost.config, the current level means the global level. You can also use location tags anywhere in the namespace hierarchy, e.g. in a web.config at the vdir level, to lock configuration from this point downwards.

Here is an example of how to unlock this section only for the "AdminSuperTrusted" site. That means that web.config files at that site can override the settings in this section; but, for all other sites on the box, it is locked at the global level and cannot be overridden.

In this example, you must leave the contents of the section in their original place in applicationHost.config, and then specify the section in the location tag with a specific path:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample4.xml)]

Returning to the third example above, the section is unlocked for all applications in all sites (location path="."). Check that the primary &lt;authentication&gt; section group (the one outside of the &lt;location&gt; element, above in the file) does not contain a &lt;windowsAuthenitcation&gt; section. A section cannot appear in the same file both outside a location tag and inside a &lt;location path="."&gt; tag; this is considered invalid configuration.

To test whether or not a section is locked, go to [http://localhost/app](http://localhost/app) in the browser.

If the section is locked, the browser displays an error because the web.config file at the application level has the &lt;windowsAuthentication&gt; section in it. This means the web.config tries to override &lt;windowsAuthentication&gt; for its level. However, because that section is now locked at the global level, the configuration in the web.config file is not valid.

Change the location tag to have overrideMode="Deny". This locks down the section again. Experiment with other sections, such as the ASP.NET sections in machine.config or root web.config. Try to lock them down at the global level, and override them at the web.config level.

<a id="Task2"></a>

## Task 2: Locking Specific Elements and Attributes

Building on the previous task, locate the &lt;windowsAuthentication&gt; section inside the &lt;location&gt; tag. Set the location tag to unlock the section: overrideMode="Allow". We only will not lock specific parts of the section.

Set the **enabled** attribute to true, then lock it by setting lockAttributes="enabled".

This prevents an application-level configuration file from changing the value of the **&lt;windowsAuthentication&gt;** section's **enabled** attribute.

If you want to lock other attributes, add them to the **lockAtrtibutes** value separated by commas, as in the following example:

[!code-console[Main](how-to-use-locking-in-iis-configuration/samples/sample5.cmd)]

You can also lock all attributes using "\*", as in this example:

[!code-console[Main](how-to-use-locking-in-iis-configuration/samples/sample6.cmd)]

The section should now look like the following:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample7.xml)]

In the web.config file for your application, try to override settings in the **&lt;windowsAuthentication&gt;** section.

In the browser, request the page to verify that you can override all settings except the ones you locked&acirc;&euro;&rdquo;in this case: the **enabled** attribute.

> [!NOTE]
> Simply specifying the attribute in the web.config file causes a configuration failure, even if the attribute you set in the Web.config file has the same value as in the ApplicationHost.config file. Setting a locked attribute to any value is considered an attempt to override the attribute and therefore fails. (Also note that attributes are different than elements&acirc;&euro;&rdquo;in the next task you will lock an element.)

Remove the **lockAttributes** attribute.

Set lockElements="providers" to lock the **&lt;providers&gt;** element within the section.

If you have other elements to lock, you can add them separated by commas, like this:

[!code-console[Main](how-to-use-locking-in-iis-configuration/samples/sample8.cmd)]

The section should now look like the following:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample9.xml)]

In the application Web.config file, override the **&lt;providers&gt;** element by setting it or by trying to add to, remove from, or clear the collection.

In the browser, request the page and note that an error displays. In the web.config file, override other elements or attributes such as the **enabled** attribute. Browse to the page and note that no error is displayed.

Remove the **lockElements** attribute.

<a id="Task3"></a>

## Task 3: Locking Everything Except Specific Attributes

In this task, you learn how to lock all elements or attributes in a section except specific ones that you define. This is useful in cases in which you are not sure what properties the section has or will have in the future, and you want to lock everything except the properties you explicitly set to be unlocked.

Building on the previous task, locate the &lt;windowsAuthentication&gt; section in the location tag.

Set the **lockAllElementsExcept** or **lockAllAttributesExcept** attributes to a comma-delimited list of elements or attributes to lock. For example, the section might look like the following:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample10.xml)]

Or like this:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample11.xml)]

In this specific section, there are currently no other attributes or elements. If you want to test the effect of setting the **lockAllElementsExcept** or **lockAllAttributesExcept** attributes, add the same attributes to other sections that have a richer set of attributes.

<a id="Task4"></a>

## Task 4: Locking Some Collection Directives

In this task, you learn how to lock the **&lt;add&gt;** and **&lt;remove&gt;** directives on a collection, so that at the application level, configuration file elements can be added but not removed.

Building on the previous task, locate the &lt;windowsAuthentication&gt; section in the location tag.

Set the **lockElements** attribute in the **&lt;providers&gt;** collection to **remove,clear**.

When you are finished, the section looks like the following:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample12.xml)]

In the application's web.config file, create a **&lt;remove&gt;** element that removes the NTLM element from the collection.

When finished, the web.config file looks like the following:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample13.xml)]

In the browser, request [http://localhost/app](http://localhost/app).

<a id="Task5"></a>

## Task 5: Locking Specific Elements in a Collection

In this task, you learn how to lock specific collection elements. Developers can still add elements to the collection at lower (application) levels of the hierarchy, and they can still remove non-locked elements from the collection. However, they cannot remove the elements you specifically locked. The collection cannot be cleared, because clearing means removing all elements from the collection.

Building on previous tasks, locate the &lt;windowsAuthentication&gt; section in the location tag.

In the **&lt;providers&gt;** collection, in the **&lt;add&gt;** element for the NTLM provider, set the **lockItem** to "true."

When you are finished, the section looks like the following:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample14.xml)]

In the application web.config file, create a **&lt;remove&gt;** element that removes the NTLM element from the collection.

When finished, the Web.config file looks like the following:

[!code-xml[Main](how-to-use-locking-in-iis-configuration/samples/sample15.xml)]

In the browser, request [http://localhost/app](http://localhost/app) -- the request fails.

<a id="Summary"></a>

## Summary

In this document, you learned how to lock configuration settings. You can lock an entire section, either by using a **&lt;location&gt;** element or by setting a tag's **lockItem** attribute to true. Locking can be more flexible and granular if you use the **lockAttributes**, **lockElements**, **lockAllAttributesExcept**, **lockAllElementsExcept**, or **lockItem** settings on collection elements, and if you use the **lockElements** settings on collections to specify particular collection directives (**&lt;add&gt;**, **&lt;remove&gt;**, or **&lt;clear&gt;**). Locking can occur at any level of the hierarchy, not only in ApplicationHost.config. Locking takes effect from that level downwards.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1043.aspx)