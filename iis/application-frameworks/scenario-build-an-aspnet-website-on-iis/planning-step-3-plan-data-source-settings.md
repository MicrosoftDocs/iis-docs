---
title: "Planning Step 3: Plan Data Source Settings | Microsoft Docs"
author: rmcmurray
description: "In this phase of building your website, consider the data storage needs of your ASP.NET application."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 8dbe77e6-50d7-432c-8946-b1d060c43ac8
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/planning-step-3-plan-data-source-settings
msc.type: authoredcontent
---
Planning Step 3: Plan Data Source Settings
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this phase of building your website, consider the data storage needs of your ASP.NET application. The following sections describe various data-source settings available in IIS:

- [3.1. Data source connection strings](#31)
- [3.2. ASP.NET providers](#32)
- [3.3. .NET profiles](#33)
- [3.4. .NET roles](#34)
- [3.5. .NET users](#35)

<a id="31"></a>
## 3.1. Data source connection strings

A connection string provides the information that an application or provider must have to communicate with a particular database. A connection string usually supplies the server or location of the database server, the particular database to use, and the authentication information. A connection string enables you to connect to databases from managed code applications in a centralized manner.

Adding a configuration setting adds the setting at the local level and to any child levels that inherit the setting.

To add a connection string to IIS, provide the following information:

- Specify a name for the connection string. This name must be the same name you reference in your application code to retrieve data from the database.
- Specify the server the database is on.
- Specify the name of the database.
- Provide the credentials, unless using Windows integrate security.

<a id="32"></a>
## 3.2. ASP.NET providers

ASP.NET 2.0 includes several services that store state in a database or other data store. A provider is a software module that implements a uniform interface between one of these services and a data source. In IIS 7, you can set the default provider for your application. You can also configure the provider properties. For example, **Users** is a provider-based feature where one provider stores the user data in SQL whereas another provider stores the user data in a text file.

Add a provider in IIS when you have an application that uses a provider-based service to store data in a database or other data store. For example, the session state service in ASP.NET is a provider-based service that manages per-user session state by storing it in process (in memory in the application domain of the host application), in memory in an external process (the &quot;state server process&quot;), or in a Microsoft SQL Server database.

Adding a configuration setting adds the setting at the local level and to any child levels that inherit the setting.

To add a provider for your application, provide the following configuration information:

- Select the IIS feature for the provider to provide: .NET Profiles, .NET Roles, or .NET Users.
- Select the provider type.
- Enter a name for the provider.
- If the feature selected is .NET Users, select any of the following provider behaviors that you want:

    - Enable password reset
    - Enable password retrieval
    - Requires question and answer
    - Requires unique email
    - Store password in secure format
- Provide the name of the connection string to the database.
- Enter the name of the application.

<a id="33"></a>
## 3.3. .NET profiles

The .NET profile feature associates information with an individual user and stores the information in a persistent format. .NET profiles let you manage user information without requiring you to create and maintain your own database.

In .NET profile, you can add properties or groups. A property stores information that is unique to a user, such as the user name. You can then use the information you have stored to present the user with a personalized version of your application. A group organizes related properties together. For example, the different properties of a user's address information can be grouped together in an Address group.

If you decide to add profile properties or groups for your ASP.NET application, provide the following information:

- For each profile property, provide the property name, data type (such as string or Boolean), a default value, a serialization option (string, XML, binary, or provider specific), whether it is read-only, and whether it is available for anonymous users.
- For each profile group, provide the group name.

<a id="34"></a>
## 3.4. .NET roles

Roles give you an easy way to manage access rules for groups of users. You create users and then assign the users to roles (in Windows, you assign users to groups). For example, you can create a set of pages that you want to restrict to certain users and store those pages in a folder by themselves. Then you can use IIS 8 to define rules that grant and deny access to restricted folders. If an unauthorized user tries to view a restricted page, the user either sees an error or is redirected to a page that you specify.

Roles do not work with anonymous users who access a site, application, or file.

Add roles when you have security settings that you want to apply to a group of users who differ from all existing groups.

If you decide to define roles for your application, provide a name for each role.

**Important**: To configure roles for your application, you must have previously configured a .NET roles provider.

<a id="35"></a>
## 3.5. .NET users

Associating user identities with an application helps you manage authentication, authorization, and other security-related operations for that application.

Add a user when you want to use IIS to define a user name, e-mail address, password, and security question for initiating an automatic account reset if a user loses or forgets their password. If the **.NET Roles** feature is enabled, you can add users to roles as you create them.

If you decide to configure users for your application, provide the following information for each user:

- User Name (must be unique).
- E-mail (must use standard format: name@domain.com).
- Password (must be a strong password).
- Question (enter a custom question or select from the list).
- Answer to the foregoing question.
- Roles the user is assigned to.

**Important**: To configure users for your application, you must have previously configured a .NET users provider.