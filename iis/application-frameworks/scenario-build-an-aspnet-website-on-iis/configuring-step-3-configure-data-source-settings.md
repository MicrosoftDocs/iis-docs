---
title: "Configuring Step 3: Configure Data Source Settings | Microsoft Docs"
author: rmcmurray
description: "In this phase of building your ASP.NET website, you configure the data source settings that are available in IIS."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: fdbc37f8-a540-409b-8aeb-a87ace6b7994
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-3-configure-data-source-settings
msc.type: authoredcontent
---
Configuring Step 3: Configure Data Source Settings
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this phase of building your ASP.NET website, you configure the data source settings that are available in IIS.

<a id="31"></a>
## 3.1. Data Source Connection Strings

 This section describes how to create a database connection string in IIS using either the IIS Manager UI or the command line.

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following design decisions about the need to add a connection string:

1. Specify a name for the connection string.
2. Specify the server the database is on.
3. Specify the name of the database.
4. Provide the credentials, unless using Windows integrate security.

### To create a database connection string by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Connection Strings**.
3. On the **Connection Strings** page, click **Add** in the **Actions** pane.
4. In the **Add Connection String** dialog box, type a name for the connection string, such as MyConnection, in the **Name** text box.
    > [!NOTE]
    > The name that you enter in IIS Manager is the same name that you reference in your application code to retrieve data by using this connection string.
5. With the **SQL Server** option selected, type the name of the server that hosts the database in the **Server** text box and type the name of the database in the **Database** text box.
6. Under **Credentials**, choose one of the following:

    - Select **Use Windows Integrated Security**.
    - Select **Specify credentials** and click **Set**. Type a user name and password for an account that can connect to the server and database in the **User name** and **Password** text boxes. Then type the same password in the **Confirm password** text box, and click **OK**.
7. Click **OK**.

### To create a database connection string by using the command line

To create a database connection string, use the following syntax:

`appcmd set config /commit:MACHINE /section:connectionStrings /+"[connectionString='string', name='string', providerName='string']"`

The variable `connectionString='string'` is the connection string value, the variable `name='string'` is the key to use to access the connection string value, and the variable `providerName='string'` is the name of the ADO.NET provider to use to access the underlying data store. For example, to create a connection string for an application that uses the Northwind database, type the following at the command prompt, and then press Enter:

`appcmd set config /commit:MACHINE /section:connectionStrings /+"[connectionString='Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Northwind;', name='Northwind', providerName='System.Data.SqlClient ']"`

<a id="32"></a>
## 3.2. ASP.NET Providers

This section describes how to add a .NET provider to IIS using either the IIS Manager UI or the command line.

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following design decisions about adding a .NET provider to IIS:

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

### To add a provider by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Providers**.
3. On the **Providers** page, under **Feature**, select one of the following features:

    - **.NET Roles**: to configure the provider to provide an interface between the ASP.NET role management service (the &quot;role manager&quot;) and role data sources.
    - **.NET Users**: to configure the provider to provide an interface between the ASP.NET membership service and membership data sources.
    - **.NET Profile**: to configure the provider to provide an interface between the ASP.NET profile service and profile data sources.
4. In the **Actions** pane, click **Add**.
5. In the **Add Provider** dialog box, select a provider type from the **Type** drop-down list.
6. In the **Name** text box, type a name for the provider.
7. If the **.NET Users** feature was selected in step #3, in the **Profile properties** section, under **Behavior**, set the value of one or more of the following behaviors to **True** to enable the behavior:

    - **EnablePasswordReset**: indicates whether passwords can be reset by using the provider *ResetPassword* method. The default setting is **False**.
    - **EnablePasswordRetrieval**: indicates whether passwords can be retrieved by using the provider *GetPassword* method. The default setting is **False**. 
	    > [!IMPORTANT]
        > Some providers, such as the Active Directory provider, do not support the retrieval of passwords. For these providers, the value of the **enablePasswordRetrieval** attribute is always **False** and cannot be changed in configuration.
    - **RequiresQuestionAndAnswer**: indicates whether a password answer is supplied when the program calls the provider *GetPassword* and *ResetPassword* methods. The default setting is **False**.
    - **RequiresUniqueEmail**: indicates whether each registered user must have a unique e-mail address. The default setting is **False**.
    - **StorePasswordInSecureFormat**: indicates whether passwords are hashed. The default setting is **False**.
8. Under **Data**, type the name of the connection string that is used to connect to the database in the **ConnectionStringName** text box. (Note: This is the same connection string that was configured under the **Connection Strings** feature. For more information about how to configure connection strings, see [Configuring Connection Strings in IIS 7](https://technet.microsoft.com/en-us/library/cc754382.aspx). If the *WindowsTokenRoleProvider* was selected in step #5 of this procedure, a connection string name is optional.)
9. Optionally, in the **Profile properties** section, under **General**, type the virtual path of the application in the **ApplicationName** text box. If you do not specify a value in the **ApplicationName** text box, the membership API defaults to HttpContext.Current.Request.ApplicationPath. This path can be determined only at runtime.
10. Optionally, in the **Profile properties** section, under **General**, type a description of the provider in the **Description** text box.
11. Click **OK**.

### To add a provider by using the command line

To add a .NET role provider, use the following syntax:

`appcmd set config /commit:MACHINE /section:roleManager /+"providers.[name='string', type='string', connectionStringName='string', applicationName='string']"`

The variable `name='string'` is the name of the provider. The variable `type='string'` is the provider type. The variable `connectionStringName='string'` is the name of the connection string that is used to connect to the database. The variable `applicationName='string'` is optional and is the virtual path of the application. For example, to configure an ASP.NET application to use the `SqlRoleProvider` class to store and retrieve role information, type the following at the command prompt, and then press Enter:

`appcmd set config /commit:MACHINE /section:roleManager /+"providers.[name='SqlProvider', type='System.Web.Security.SqlRoleProvider', connectionStringName='SqlServices', applicationName='SampleApplication']"`

To add a .NET user provider, use the following syntax:

`appcmd set config /commit:MACHINE /section:membership /+"providers.[name='string', type='string', connectionStringName='string', applicationName='string', enablePasswordReset='true|false', enablePasswordRetrieval='true|false', requiresQuestionAndAnswer='true|false', requiresUniqueEmail='true|false', storePasswordInSecureFormat='true|false']"`

This syntax consists of the following items:

- The variable `name='string'` is the name of the provider.
- The variable `type='string'` is the provider type.
- The variable `connectionStringName='string'` is the name of the connection string that is used to connect to the database.
- The variable `applicationName='string'` is optional and is the virtual path of the application.
- The variable `enablePasswordReset=true` enables password reset by using the provider *ResetPassword* method. The default setting is `false`.
- The variable `enablePasswordRetrieval=true` enables password retrieval by using the provider *GetPassword* method. The default setting is `false`.
- The variable `requiresQuestionAndAnswer=true` requires that a password answer must be supplied when the program calls the provider *GetPassword* and *ResetPassword* methods. The default setting is `false`.
- The variable `requiresUniqueEmail=true` requires that each registered user has a unique e-mail address. The default setting is `false`.
- The variable `storePasswordInSecureFormat=true` requires that all passwords must be hashed. The default setting is `false`.

For example, to configure an ASP.NET application to use the `SqlMembershipProvider` class to store and retrieve user information, type the following at the command prompt, and then press Enter:

`appcmd set config /commit:MACHINE /section:membership /+"providers.[name='SqlProvider', type='System.Web.Security.SqlMembershipProvider', connectionStringName='SqlServices', applicationName='/', enablePasswordRetrieval='False', enablePasswordReset='True', requiresQuestionAndAnswer='True']"`

To add a .NET profile provider, use the following syntax:

`appcmd set config /commit:MACHINE /section:profile /+"providers.[name='string', type='string', connectionStringName='string', applicationName='string']"`

The variable `name='string'` is the name of the provider. The variable `type='string'` is the provider type. The variable `connectionStringName='string'` is the name of the connection string that is used to connect to the database. The variable `applicationName='string'` is optional and is the virtual path of the application. For example, to configure an ASP.NET application to use the `SqlProfileProvider` class to store and retrieve profile information, type the following at the command prompt, and then press Enter:

`appcmd set config /commit:MACHINE /section:profile /+"providers.[name='SqlProvider', type='System.Web.Profile.SqlProfileProvider', connectionStringName='SqlServices', applicationName='SampleApplication']"`

<a id="33"></a>
## 3.3. .NET Profiles

This section describes how to add a profile property and a profile group.

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following design decisions about profile properties and groups to IIS:

- For each profile property, provide the property name, data type (such as string or Boolean), a default value, a serialization option (string, XML, binary, or provider specific), whether it is read-only, and whether it is available for anonymous users.
- For each profile group, provide the group name.

### To add a .NET profile property by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **.NET Profile**.
3. In the **Actions** pane, click **Add Property** to add a .NET profile property or, to add a .NET profile property to a group, select the group to which you want to add the .NET profile property, and then click **Add Property To Group**.
4. In the **Add .NET Profile Property** dialog box, type a name for the .NET profile property in the **Name** text box.
5. Under **Data Type**, select one of the following data types:

    - **System.Boolean**: to configure the .NET profile property to have a value of either **True** or **False**.
    - **System.Char**: to configure the .NET profile property to contain Unicode Characters.
    - **System.DateTime**: To configure the .NET profile property to contain dates and times with values that range from 12:00:00 midnight, January 1, 0001 Anno Domini (A.D.) or Common Era (C.E.) through 11:59:59 P.M., December 31, 9999 A.D. (C.E.)
    - **System.Decimal**: to configure .NET profile property to contain decimal numbers that range from positive 79,228,162,514,264,337,593,543,950,335 to negative 79,228,162,514,264,337,593,543,950,335. The **Decimal** value type is appropriate for financial calculations that require many significant integral and fractional digits and no round-off errors.
    - **System.Double**: To configure the .NET profile property to contain a double-precision 64-bit number with values that range from negative 1.79769313486232e308 to positive 1.79769313486232e308, as well as positive or negative zero, **PositiveInfinity**, **NegativeInfinity**, and Not-a-Number (NaN). For more information about the **Double** value type, see [Double Structure](https://go.microsoft.com/fwlink/?LinkId=118777).
    - **System.Int32**: to configure the .NET profile property to contain a signed integer with a value that ranges from negative 2,147,483,648 through positive 2,147,483,647.
    - **System.Int64**: to configure the .NET profile property to contain an integer with a value that ranges from negative 9,223,372,036,854,775,808 through positive 9,223,372,036,854,775,807.
    - **System.Single**: To configure the .NET profile property to contain a single-precision 32-bit number with values that range from negative 3.402823e38 to positive 3.402823e38, as well as positive or negative zero, **PositiveInfinity**, **NegativeInfinity**, and Not-a-Number (NaN). For more information about the **Single** value type, see [Single Structure](https://go.microsoft.com/fwlink/?LinkId=118779).
    - **System.String**: To configure the .NET profile property to be a sequential collection of **Char** structures that represents a string of text. This setting is the default.
6. In the **Default value** text box, type a value that the property will be initialized with.
7. Under **Serialization option**, select one of the following serialization formatters:

    - **String**: Select this option when the settings property is serialized as plaintext. This setting is the default.
    - **XML**: Select this option to serialize only public properties and fields. XML serialization does not preserve type fidelity. This option is useful when you want to provide or consume data without restricting the application that uses the data. Because XML is an open standard, it is an attractive choice for sharing data on the Web.
    - **Binary**: Select this option to preserve type fidelity. Binary serialization is useful for preserving the state of an object between different invocations of an application. For example, you can share an object between different applications by serializing it to the Clipboard. You can serialize an object to a stream, to a disk, to memory, over the network, and so on.
    - **Provider Specific**: Select this option when the settings provider has implicit knowledge of the property or its type and can pick an appropriate serialization mechanism. This option is often used for custom serialization.
8. Check the **Read only** box to configure the .NET profile property so that it cannot be modified.
9. Check the **Available for anonymous users** box to make the .NET profile property available for unauthenticated users.
10. Click **OK**.

### To add a .NET profile property by using the command line

To add a .NET Profile property, use the following syntax:

`appcmd set config /commit:MACHINE /section:profile /+"properties.[name='string', type='string', defaultValue='string', serializeAs='String|Xml|Binary|ProviderSpecific', readOnly='true|false', allowAnonymous='true|false']"`

The variable `name='string'` is the name of the profile property. The variable `type='string'` is the data type. The variable `defaultValue='string'` is the value with which the profile property is initialized. The variable `serializeAs='String|Xml|Binary|ProviderSpecific'` sets the serialization formatter. The variable `readOnly=true` configures the .NET profile property so that it cannot be modified. The default value is `false`. The variable `allowAnonymous=true` makes the .NET profile property available for unauthenticated users. The default value is `false`. For example, to specify a profile property that holds a recent search list collection, type the following at the command prompt, and then press Enter:

`appcmd set config /commit:MACHINE /section:profile /+"properties. [name='RecentSearchList', type='System.Collections.Specialized.StringCollection', serializeAs='Xml', allowAnonymous='true']"`

### To add a .NET profile group by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **.NET Profile**.
3. In the **Actions** pane, click **Add Group**.
4. In the **Add Group** dialog box, type a name for the .NET profile group in the **Name** text box, and then click **OK**.

<a id="34"></a>
## 3.4. .NET Roles

This section describes how to add a .NET role by using the IIS Manager UI.

### To add a .NET role by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **.NET Roles**.
3. In the **Actions** pane, click **Add**.
4. In the **Add .NET Role** dialog box, type the name of the role in the **Name** text box, and then click **OK**.

<a id="35"></a>
## 3.5. .NET Users

This section describes how to configure .NET users by using the IIS Manager UI.

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following design decisions for each user you want to add to IIS:

- User Name
- E-mail
- Password
- Question
- Answer
- Role or roles

### To add a .NET user by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **.NET Users**.
3. In the **Actions** pane, click **Add**.
4. In the **.NET User Account Details** dialog box, enter the following information:

    - User Name (must be unique).
    - E-mail (must use standard format: name@domain.com).
    - Password (must be a strong password).
    - Confirm Password (must match the password).
    - Question (enter a custom question or select from the list).
    - Answer to the question.
5. Click **Next** to select roles for this user. If you have not enabled **.NET Roles**, click **Finish**.
6. In the **.NET User Roles** dialog box, optionally select available roles from the **Roles** box, and then click **Finish**.