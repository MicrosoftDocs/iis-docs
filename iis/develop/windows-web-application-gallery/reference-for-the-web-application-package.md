---
title: "Reference for the Web Application Package"
author: rick-anderson
description: "Every application in the Web Application Gallery has at least two XML files that enable the Web Platform Installer (Web PI) to use the Web Deployment Tool (W..."
ms.date: 11/15/2009
ms.assetid: d0b0d1dc-ce47-409b-8dec-4153f08f483e
msc.legacyurl: /learn/develop/windows-web-application-gallery/reference-for-the-web-application-package
msc.type: authoredcontent
---
# Reference for the Web Application Package

by Tali Smith

> [!NOTE]
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

Every application in the Web Application Gallery has at least two XML files that enable the Web Platform Installer (Web PI) to use the Web Deployment Tool (WDT) to deploy the application on Windows® operating systems. These files are the Manifest.xml and Parameters.xml files. In addition, many applications add a SQL script to be run by the WDT as part of the pre-setup installation. PHP applications also include a Web.config file.

## Manifest.xml

The Manifest.xml file (or the manifest) is the main file that tells the WDT what to do with an application. It is an XML file made up of "providers". Each of the providers can be modified by user input, which is described in the Parameters.xml file. There should generally be at least one parameter for each provider in the manifest.

The available providers include:

- **iisapp** - This is the only required provider in the manifest. The iisapp element has a single required attribute - "path". The path specifies the sub folder within the application package (compressed [Zip] file) that contains the files and directories required for running the application. When the application is installed, the contents of the specified folder are placed in the root of the Web site application folder.
- **dbfullsql** - This provider identifies a connection to a Microsoft® SQL Server® or Microsoft® SQL Server® Express database instance. The "path" attribute is required and identifies a SQL script to be executed against the database. The credentials and database information required to connect to the database are provided by the user through the parameters. The default behavior of this provider is to treat each SQL file as if it were a single database transaction which can be committed or rolled-back as needed. If the contents of your script maintain their own transactions, or have components which must run outside of a transaction, you can specify a "transacted" attribute and set its value to "false".
- **dbmysql** - This provider identifies a connection to a MySQL database engine. The "path" attribute is required and identifies a SQL script to be executed against the database. The credentials and database information required to connect to the database are provided by the user through the parameters. If your SQL scripts contain stored procedures which require you to define a different command delimiter from the MySQL default of a semicolon (;), you can specify the new delimiter with the optional "commandDelimiter" attribute. If you specify a commandDelimiter, you can have it removed from the SQL by specifying a "removeCommandDelimiter" attribute and setting its value to "true". Use removeCommandDelimiter if you are using a delimiter other than a semicolon (;).
- **setacl** - This provider is used to apply an access control list (ACL) to a file or directory. ACLs are used to define the access and permissions that a user or an application has on a file or directory. By default, everything installed by the WDT is installed without changing permissions. In most cases, this means that files will be readable by PHP (and Microsoft® ASP.NET), but not writable. If your application needs additional permissions, you can use this provider to set them.
- **alias** - Alias is used when you need to copy a file from the application package to another name or location. Typically this is used for applications that provide sample configuration files. Prior to the WDT, these applications often required the user to copy the sample file and edit it by hand. With the alias provider, you can have the WDT make the copy and use the parameters to fill in any necessary values.

## Parameters.xml

The Parameters.xml file defines the WDT and Web PI interactions with the user. Parameters.xml is an XML file made up of "parameters", presented to the user as a form that needs to be filled out to customize the application installation for the user's environment. Each parameter represents a data item that the WDT needs to collect to perform the installation. These parameters can be used to modify the attributes of a manifest provider or to replace targeted text in any file in the application distribution, or they can be used as components of the value of other parameters.

The parameters have a number of attributes, including:

- **name** - This is a required attribute which uniquely identifies the parameter within the scope of the Parameters.xml file. It is also used as the parameter's variable name.
- **friendlyName** - The friendlyName is used by most user interfaces (UIs) as the name above the form element that the parameter defines. If there is no friendlyName defined, the UIs will default to the parameter name.
- **description** - The description provides the caption for the form elements. These are most often used to provide instructions to the user about what is expected for the parameter and how it will be used.
- **defaultValue** - For parameters that are shown to the user, the defaultValue gets placed in the form as a suggestion for the value of the parameter. For parameters that are hidden from the user (see the description of the "hidden" tag below), the defaultValue is used to calculate the value for the parameter.
- **tags** - Tags are a comma-separated list of words or phrases that provide extra information for the WDT and Web PI to categorize a parameter.

If your parameter is tagged with one of the ten well-known tags from the table below, the UI will automatically provide a friendlyName and description for the parameter. If you specify these elements, you override the defaults. Do not override the defaults unless there is a significant reason to do so. Common parameter tags include:

- MySqlConnectionString
- SqlConnectionString
- DbAdminPassword
- DbAdminUsername
- DbName
- DbServer
- DbUsername
- DbUserPassword
- IisApp
- SetAcl

In addition, each parameter can have sub elements that perform various functions.

### ParameterEntry types

There are four distinct ParameterEntry types available to specify parameter substitutions, each providing a different way of identifying the target. Three attributes are required for each instance:

- **type**—specifies the mechanism for identifying the target of the parameter replacement.
- **scope**—identifies the file or component that will be searched for the target.
- **match**—specifies the search parameters for identifying the target

Each ParameterEntry type has a specific format for defining the scope and the match attributes. The combination of all three elements should always identify at least one match within the application package. You may have as many ParameterEntrys as you need for your application; for more than one type of substitution or more than one target for the substitutions (for example, if two different files both need the substitution), you will need a distinct ParameterEntry element for each one.

### TextFile ParameterEntry types

With the TextFile type, the scope is a [regular expression](/dotnet/standard/base-types/regular-expression-language-quick-reference) used to identify a file or set of files to target. The match is a regular expression that represents the string to be replaced. The WDT applies the parameter substitution to all strings that are found by the match in all of the files identified by the scope. When defining regular expressions for TextFile ParameterEntry types, it is important to make sure that you limit both your match and your scope to the most precise expressions you can define.

TextFile gives you the most reliable method for identifying targets within a file when you have complete control over the source and you are able to define the strings to be targeted. If you do not have complete control over the source, you can use the TextFilePosition parameterEntry type to uniquely identify the target. This most commonly happens with configuration files that have other aspects of the application that expect specific data in both modified and unmodified versions of the file.

For example, you could specify that a database user name needs to be placed within a SQL script that was written for use with the WDT. The WDT would look for the string "PlaceholderForDbUsername" and substitute the user's parameter input for that string:

[!code-xml[Main](reference-for-the-web-application-package/samples/sample1.xml)]

### XmlFile

Many applications use XML files for data or configuration. All Microsoft® .NET applications, and many PHP applications, use a Web.config file for storing Web site and application configuration information. When identifying a target within a XML file, the most reliable mechanism to use is an XPath query.

The scope for an XmlFile entry type is defined the same way as for TextFile, using a [regular expression](/dotnet/standard/base-types/regular-expression-language-quick-reference) to identify the target file(s). The match is specified as an [XPath query](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/ms256471(v=vs.100)). An XmlFile entry will replace every existence of a matching XPath in a file. This will frequently mean that you need a detailed XPath query to make sure you replace only the targeted match.

For example, an application might have a SQL connectionString in a Web.config file. There may be more than one connectionString in the file to allow for different database types:

[!code-xml[Main](reference-for-the-web-application-package/samples/sample2.xml)]

You could use the generated connection string parameter in the following example to replace the value in the configuration file with the values that the user entered. In this case, the XPath query searches from the root of the XML file following the element path in the query for the first "add" element under the "connectionStrings" element under the "configuration" element with an attribute of "name" that equals "SqlServerDbConnection". It then replaces the value of the "connectionString" attribute of that element with the parameterized value.

[!code-xml[Main](reference-for-the-web-application-package/samples/sample3.xml)]

For more information, see the [XPath Syntax](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/ms256471(v=vs.100)) article.

### ProviderPath

The ProviderPath type is used for applying parameters to providers specified in the Manifest.xml file. When you are developing your application package, you cannot know all of the specifics about your users' system environments. So when you specify each of the providers, you associate defaults for each one that matches the expectations of the provider type. There will frequently be one ParameterEntry element in the Parameters.xml file for each directive in the Manifest.xml file.

The scope of a ProviderPath entry refers to the type of provider being parameterized. The match specifies a regular expression that uniquely identifies the value of the "path" attribute for that provider element. The table below describes the substitutions for each of the providers that are allowed in the manifest.

| Provider | Element that the parameter is applied to | Default Value | Replacement Value |
| --- | --- | --- | --- |
| iisApp | path | The specified path, which matches the name of the folder in the package that contains the application's files and folders | The path is replaced with the file system path to the directory where the application's files and folders will be installed. This is usually specified as the parameter named "Application Path" with a "iisApp" as one of the tags. |
| setAcl | path | The specified path, which matches the path to the file or folder in the package to which the ACL is applied | The path is replaced with the value for the parameter that identifies the setAcl provider. SetAcl parameters usually have "hidden" as one of their tags. The values are constructed by setting a defaultValue which uses the "Application Path" parameter with the rest of the path to the file or directory appended. |
| dbFullSql and dbMySql | connectionString - unspecified attribute | The specified path, which matches the path and name of the SQL file to execute as part of the installation | The connectionString is replaced with one constructed in the Parameters.xml file. This parameter is usually hidden and built from other parameters that identify the database and the credentials for connecting to it. The WebPI and the WDT will provide an intelligent UI for building connection strings when all of the relevant parameters are specified. If there is no matching parameter, the connectionString will remain blank, which will mean the database connection will be made to the system's defaults. |

### TextFilePosition ParameterEntry type

There may be times when using a regular expression to replace a text string in a file may not be precise enough. For example, there may be a string that you want to replace in one portion of the file but not in another. Or you may not be able to use a regular expression to uniquely identify the string to be changed. For those situations, you can use the TextFilePosition ParameterEntry type.

The scope for a TextFilePositionEntry type is defined the same way as for TextFile, using a [regular expression](https://docs.microsoft.com/dotnet/standard/base-types/regular-expression-language-quick-reference) to identify the target file(s). The match is specified as a series of three integers separated by semicolons (;). The first integer specifies the line number in the file. The second integer specifies the number of characters from the beginning of the line. The third integer specifies the number of characters to replace. You do need to be careful when specifying your target, as the parameter replacement will extend beyond the end of a line if the match numbers specify a target that would include end-of-line characters within the target length.

For example, you could specify that the database user name from the TextFile example also needs to be included in a configuration file. The target in this file cannot be uniquely identified with a regular expression. Using TextFilePosition, we can target the specific string in the file based on its location instead of its content.

[!code-xml[Main](reference-for-the-web-application-package/samples/sample4.xml)]

## Parameter Tags

Parameter Tags are used to tell various UIs how to display and use parameters. Some of these tags are mandatory in certain situations. The descriptions that follow specify when specific tags are mandatory and how the tags should be used.

- **iisapp**- This identities a parameter as the application path to install the application. The defaultValue will be displayed by most installers. The defaultValue should be set to something like "Default Web Site/application1", where "Default Web Site" is the default Web site for the server and "application1" is the subdirectory under that Web site. Web PI and other installers will use this data to suggest a Web site location for the installation when they don't already know where the user wants to install the application. This is a required tag. There must be at least one parameter that has this tag and that specifies the iisApp provider as its target.

    > [!NOTE]
    > On IIS 5.1, the Web site portion of this will always be "Default Web Site". The user will be able to select a directory under the default for the Web site to keep applications separate.

- **Hidden**- A Hidden parameter is not shown to the user as part of the installation UI. A Hidden parameter must have a defaultValue set. These parameters are used either to set a hard-coded default value or to set a computed default value. Hard-coded defaults are sometimes used when establishing a parameter for future use. Computed values are used to construct a parameter's value from other parameters. When constructing computed values, you can refer to other parameters by putting the other parameter name surrounded by {}s in the place you want the value. Please refer to the "Connection String" parameter in the example for a common usage of this tag.
- **SQL or MySQL**- These parameters are used in relation to a specific database. If the manifest contains parameters for both SQL and MySQL, the UI can choose which database to use and the user will only be presented with parameters relevant for that database.
- **Password**- This identifies a field that will be used as a password that is already known. The UI will hide the value of that password.
- **New**- When used together with the Password tag, this identifies a field that will be used to set a new password. The UI will hide the value of the password and ask the user to confirm it (for example, "New,Password").
- **dbUsername, dbUserPassword, dbAdminUsername, dbAdminPassword, dbServer, dbName**- Some UIs that install application packages will handle the database creation themselves. In the case where the user already has a database created, the UIs will seamlessly hide and fill in the administrative credentials correctly to avoid requiring the user to enter data two times. These tags identify the parameters that must be modified if the UI will handle database creation.

    > [!NOTE]
    > If there is a SQL or MySQL provider in the Manifest.xml, then there must be six parameters in the Parameters.xml file, and each parameter must have one of these tags.

- **SQLConnectionString, MySQLConnectionString**- This identifies that a field (usually a Hidden one) is being used as a connection string to a database. Some UIs will use the connection string in conjunction with the dbXxxx tags above to display a specific dialog box.
- **Validate**- Validate is only allowed when specified with one of the connection string tags. Validate specifies a connection string that must be valid for the installation to succeed and for any SQL scripts to run as part of the installation. UIs will have a choice on how they want to implement this function. The Web PI will validate the database credentials before allowing the user to proceed through the rest of the installation.
- **VistaDB, SQLite, FlatFile** - These tags identify a parameter that is used with these flat file data types. There is no corresponding provider in the Manifest.xml file for these. The WebPI and other UIs will recognize these tags in the Parameters.xml file. If there is more than one type of database tag (for example, SQL, MySQL, SQLite, and VistaDB all in the same Parameters.xml file), the UI will present the user with a choice of database engines for the application. When the user selects the database engine, all parameters that are tagged for a different engine and not the selected one will be bypassed.

## Parameter Validation

There are several types of parameter validation that are available. If none of these are specified, the user is presented with a simple text box to enter the parameter's value:

- **AllowEmpty** - Most UIs will require a value for all parameters that are not hidden. You can specify a validation type of "AllowEmpty" to instruct the UI that a blank or empty value is acceptable. AllowEmpty can be used in conjunction with any of the other parameter validation types, or on its own. The syntax for AllowEmpty is:

[!code-xml[Main](reference-for-the-web-application-package/samples/sample5.xml)]

- **Boolean**- Boolean parameters are simple True / False questions. Depending on the UI, the user might be presented with a check box or two option buttons to select their choice. Booleans replace values in the same way as other parameters. For Booleans, the replacement value is either "True" or "False". If you need to have Boolean values other than "True" or "False", use an enumeration with only two values. The syntax for Booleans is: 

    [!code-xml[Main](reference-for-the-web-application-package/samples/sample6.xml)]

- **Enumeration**- Enumeration allows you to limit the user's input to a list of discrete possible values. Most UIs will implement this as a drop-down list box, where the user will have the ability to choose one value from the list. Any whitespace in the validationString will be included as part of the possible values. Therefore, there should be no whitespace on either side of a comma, unless you want that whitespace to be included in the parameter substitution. The syntax for Enumeration is:

    [!code-xml[Main](reference-for-the-web-application-package/samples/sample7.xml)]

    Currently, there is no way to escape a comma (,) so that it may be included as part of one of the values of an enumeration.

- **Regular Expression**- With Regular Expression validation, the user is presented with a simple text box the way a non-validated parameter would be. Then, when the user goes to submit the form and move on to the next part of the installation, the entry in the text box will be compared to the validationString in the RegularExpression. For more information about specifying a regular expression, see [Regular Expression Language - Quick Reference](https://docs.microsoft.com/dotnet/standard/base-types/regular-expression-language-quick-reference) or the [Regular Expressions Info Web site](http://www.regular-expressions.info/tutorial.html). The syntax for Regular Expression validation is:

    [!code-xml[Main](reference-for-the-web-application-package/samples/sample8.xml)]

    For Regular Expressions, even if you specify a RegEx that allows for empty values, most UIs will require a value anyway. To specify that a value can be blank, or empty, add 'allowEmpty' to the type of the 'parameterValidation', as in the example below:

    [!code-xml[Main](reference-for-the-web-application-package/samples/sample9.xml)]

The regular expressions in the two previous examples are explained here:

- `.+` - Specifies that the parameter entry *must* contain at least one of any type of character. Alternatively, use **".\*"** to specify that the parameter entry *may* contain at least one of any type of character, which means that it can be empty.
- `^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$` - This is a simple e-mail address validation expression. It does not catch every incorrect address, but it catches most. This regular expression does not allow blank or empty parameters. However, since "allowEmpty" was included in the "type" attribute, empty parameters will be accepted.

## Database Credentials Validation

If your application package contains a SQL Server or MySQL database provider, you can specify a set of database credentials to be validated by the UI prior to other steps in the installation process. Web PI will validate the tagged connection string when all of the parameters have been filled out for the application and the user presses the Next button. This validation consists of Web PI using the provided credentials to connect to the specified database and server. If the validation fails, the user will be informed and returned to the previous screen to update the database parameters as needed. Other UIs will provide some mechanism, such as a validate button or a validation dialog, to perform a similar function. The parameter to use for the validation is identified with the "Validate" tag.

## Parameter Internationalization

Web PI and the Web Deployment Tool are available in versions localized for ten languages, including English and the following:

- Japanese
- Spanish
- German
- French
- Italian
- Korean
- Russian
- Chinese (China)
- Chinese (Taiwan)

If Web PI detects that the user's system default location is something other than "en", the user will be presented with parameters using the user's system locale, for every parameter that has a translation available.

The WDT has translations for the "friendlyName" for each parameter, which is used as the parameter's caption. The WDT also has translations for the "description" for each parameter, which is displayed below the caption to inform the user of the purpose of the parameter.

Certain parameters are translated automatically into one of those languages based on the user's system language. The parameters that are automatically translated are ones that have one of the tags in the table below. Note that if there is a "description" or "friendlyName" attribute present in the parameter, the translation of that parameter will not occur.

- MySqlConnectionString
- SqlConnectionString
- DbAdminPassword
- DbAdminUsername
- DbName
- DbServer
- DbUsername
- DbUserPassword
- IisApp
- SetAcl

For the ten well-known parameters above, best practice is to use the parameter descriptions and friendly names that the WDT automatically generates. This leads to a more consistent experience for users and lets your application take advantage of additional languages as they are added. If necessary, specify your own translations for any of those parameters or for any parameters that do not have a default translation. This is done by providing alternate descriptions and friendlyNames in the parameter elements of the Parameters.xml file. The default description for a parameter is provided as one of the attributes of the parameter element, while the translations are provided as distinct elements. For example:

[!code-xml[Main](reference-for-the-web-application-package/samples/sample10.xml)]

In the example, note:

- The UI displays the description where the "culture" attribute matches the system locale. If there is no specific match, the UI will display the default description.
- When only the language is specified (as in the case of "de" above), all cultures that include "de" as their language component will use that translation (for example, "de-DE" and "de-AT").
- iisApp is one of the 10 automatically translated parameters; do not specify translations for this parameter unless the default translations were insufficient for your needs.
- Specify translations for both the "friendlyName" and the "description". If you do not specify a friendlyName, the UI will use the parameter name in all cases.

For a table of common International Organization for Standardization (ISO) culture codes, see the [Table of Language Culture Names, Codes, and ISO Values Method [C++]](https://docs.microsoft.com/previous-versions/commerce-server/ee825488(v=cs.20)).

## xxxx.sql

An application package can have any number of SQL scripts that will be executed as part of the installation package. These SQL scripts can contain any valid commands for the specified database engine, including all DDL, DML, and stored procedures. For details about the WDT interaction with the database, see the article "[Database Notes for packaging applications for use with the Web Application Gallery](database-notes-for-packaging-applications-for-use-with-the-web-application-gallery.md)."

## Web.config

A Web.config file can be placed at any level in an application's directory tree. To learn more about the Web.config file, see the [IIS 7.0 Configuration Reference](../../configuration/index.md).

## Integration Samples

Samples of Web App Gallery integration are available for reference.

> [!NOTE]
> *This article is based on information from "[Application Packaging Guide for the Windows Web Application Gallery](package-an-application-for-the-windows-web-application-gallery.md)" by the IIS team, published on September 24, 2009*.

## See also

- [Regular Expression Language - Quick Reference](https://docs.microsoft.com/dotnet/standard/base-types/regular-expression-language-quick-reference)
- [XPath syntax](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/ms256471(v=vs.100))
- [Table of Language Culture Names, Codes, and ISO Values Method [C++]](https://docs.microsoft.com/previous-versions/commerce-server/ee825488(v=cs.20))
- [Web App Gallery Integration Samples](http://www.iis.net/learn/develop/windows-web-application-gallery)
- [IIS 7.0 Configuration Reference](../../configuration/index.md)
- [Database Notes for packaging applications for use with the Web Application Gallery](database-notes-for-packaging-applications-for-use-with-the-web-application-gallery.md)
