---
title: "URL Rewrite Module Configuration Reference | Microsoft Docs"
author: ruslany
description: "This article provides an overview of the URL Rewrite Module and explains the configuration concepts that are used by the module. Table Of Contents Functional..."
ms.author: iiscontent
manager: soshir
ms.date: 05/30/2008
ms.topic: article
ms.assetid: 472b62e4-c6a4-4380-bef1-2a0360737491
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/url-rewrite-module/url-rewrite-module-configuration-reference
msc.type: authoredcontent
---
URL Rewrite Module Configuration Reference
====================
by [Ruslan Yakushev](https://github.com/ruslany)

This article provides an overview of the URL Rewrite Module and explains the configuration concepts that are used by the module.

<a id="Functionality_Overview"></a>

## Functionality Overview

The URL Rewrite Module rewrites request URLs to simple, user-friendly, and search-engine friendly addresses that are displayed to users or in Web applications. URL Rewrite uses defined rules to evaluate and then map the request URL to the address defined in the rule before it is processed by an IIS Web server. You can define URL rewriting logic that includes regular expressions and wildcards, and rules can be applied based on the request URL, HTTP headers, and server variables. While the primary purpose of the module is to rewrite request URLs to more friendly URLs, you can also use the module to define rules that perform redirects, send custom responses, or abort requests.

<a id="Rewrite_Rules_Overview"></a>

## Rewrite Rules Overview

A rewrite rule defines the logic of what to compare or match the request URL with, and what to do if the comparison is successful.

Rewrite rules consists of the following parts:

- **Pattern** – The rule pattern is used to specify either the regular expression or a wildcard pattern that is used to match URL strings.
- **Conditions** – The optional conditions collection is used to specify additional logical operations to perform if a URL string matches the rule pattern. Within the conditions, you can check for certain values of HTTP headers or server variables, or verify if the requested URL corresponds to a file or directory on a physical file system.
- **Action** – The action is used to specify what to do if the URL string matches the rule pattern and all the rule conditions are met.

<a id="Rewrite_Rules_Scope"></a>

### Rewrite Rules Scope

Rewrite rules can be defined in two different collections:

- `<globalRules>` – Rules in this collection can be defined only on the server level. Global rules are used to define server-wide URL rewriting logic. These rules are defined within the ApplicationHost.config file, and they cannot be overridden or disabled on any lower configuration levels. Global rules always operate on the absolute URL's path (that is, the requested URI without the server name). These rules are evaluated early in the IIS request-processing pipeline (**PreBeginRequest** event).
- `<rules>` – Rules in this collection are called distributed rules, and they can be defined on any level in the configuration hierarchy. Distributed rules are used to define URL rewriting logic specific to a particular configuration scope. This type of rule can be added on any configuration level by using Web.config files or by using `<location>` tags within ApplicationHost.config or Web.config files. Distributed rules operate on the URL path, relative to the location of the Web.config file where they are defined. In cases where distributed rules are defined inside of a `<location>` tag, they operate on the URL path, relative to the path specified for that `<location>` tag. These rules are evaluated on the BeginRequest event in the IIS pipeline.

<a id="Rules_Evaluation"></a>

### Rules Evaluation

Each configuration level in IIS can have zero or more rewrite rules defined. The rules are evaluated in the same order in which they are specified. The URL Rewrite Module processes the set of rules by using the following algorithm:

1. First, the URL is matched against the pattern of a rule. If it does not match, the URL Rewrite Module immediately stops processing that rule, and goes on to the next rule.
2. If a pattern matches and there are no conditions for the rule, the URL Rewrite Module performs the action specified for this rule and then goes on to the next rule, where it uses the substituted URL as an input for that rule.
3. If a pattern matches and there are conditions for the rule, the URL Rewrite Module evaluates the conditions. If the evaluation is successful, the specified rule action is performed, and then the rewritten URL is used as input to the subsequent rule

A rule may have the **StopProcessing** flag turned on. When the rule action is performed (i.e. the rule matched) and this flag is turned on, it means that no more subsequent rules will be processed and the request will be passed to the IIS request pipeline. By default, this flag is turned off.

<a id="Rules_Inheritance"></a>

### Rules Inheritance

If rules are defined on multiple configuration levels, the URL Rewrite Module evaluates the rules in the following order:

1. Evaluate all the global rules.
2. Evaluate a rule set that includes distributed rules from parent configuration levels as well as rules from the current configuration level. The evaluation is performed in a parent-to-child order, which means that parent rules are evaluated first and the rules defined on a last child level are evaluated last.

<a id="Preserving_Original_URL"></a>

### Preserving Original URL

The URL Rewrite Module preserves the original requested URL path in the following server variables:

- **HTTP\_X\_ORIGINAL\_URL** – this server variable contains the original URL in decoded format;
- **UNENCODED\_URL** – this server variable contains the original URL exactly as it was requested by a Web client, with all original encoding preserved.

<a id="Accessing_URL_Parts_from_a_Rewrite_Rule"></a>

## Accessing URL Parts from a Rewrite Rule

It is important to understand how certain parts of the URL string can be accessed from a rewrite rule.

For an HTTP URL in this form: http(s)://&lt;host&gt;:&lt;port&gt;/&lt;path&gt;?&lt;querystring&gt;

- The &lt;path&gt; is matched against the pattern of the rule.
- The &lt;querystring&gt; is available in the server variable called QUERY\_STRING and can be accessed by using a condition within a rule.
- The &lt;host&gt; is available in the server variable HTTP\_HOST and can be accessed by using a condition within a rule.
- The &lt;port&gt; is available in the server variable SERVER\_PORT and can be accessed by using a condition within a rule.
- Server variables SERVER\_PORT\_SECURE and HTTPS can be used to determine if a secure connection was used. These server variables can be accessed by using a condition within a rule.
- The server variable REQUEST\_URI can be used to access the entire requested URL path, including the query string.

For example, if a request was made for this URL: **[http://www.mysite.com/content/default.aspx?tabid=2&amp;subtabid=3](http://www.mysite.com/content/default.aspx?tabid=2&amp;subtabid=3)**, and a rewrite rule was defined on the site level then:

- The rule pattern gets the URL string **content/default.aspx** as an input.
- The QUERY\_STRING server variable contains **tabid=2&amp;subtabid=3**.
- The HTTP\_HOST server variable contains **www.mysite.com**.
- The SERVER\_PORT server variable contains **80**.
- The SERVER\_PORT\_SECURE server variable contains **0** and HTTPS contains **OFF**.
- The REQUEST\_URI server variable contains **/content/default.aspx?tabid=2&amp;subtabid=3**.
- The PATH\_INFO server variable contains **/content/default.aspx**.

Note that the input URL string passed to a distributed rule is always relative to the location of the Web.config file where the rule is defined. For example, if a request is made for **[http://www.mysite.com/content/default.aspx?tabid=2&amp;subtabid=3](http://www.mysite.com/content/default.aspx?tabid=2&amp;subtabid=3)**, and a rewrite rule is defined in the **/content** directory, then the rule gets this URL string **default.aspx** as an input.

<a id="Rewrite_Rule_Configuration"></a>

## Rewrite Rule Configuration

<a id="Rule_Pattern"></a>

### Rule Pattern

A rewrite rule pattern is used to specify a pattern to which the current URL path is compared. Current, in this context, means the value of the URL path when the rule is applied. If there were any rules that preceded the current rule, they may have matched the original requested URL and modified it. The URL string that is evaluated against the pattern does not include the query string. To include the query string in the rule evaluation you can use the QUERY\_STRING server variable in the rule's condition. For more information, refer to ["Using server variables in rewrite rules"](url-rewrite-module-configuration-reference.md#UsingServerVars).

A pattern is specified within a &lt;match&gt; element of a rewrite rule.

<a id="Rule_pattern_syntax"></a>

#### Rule pattern syntax

Rule pattern syntax can be specified by using the **patternSyntax** attribute of a rule. This attribute can be set to one of the following options:

**ECMAScript** – Perl compatible ([ECMAScript](http://www.ecma-international.org/publications/files/ECMA-ST/Ecma-262.pdf "ECMAScript Standard") standard compliant) regular expression syntax. This is a default option for any rule. This is an example of the pattern format: "^([\_0-9a-zA-Z-]+/)?(wp-.\*)"

**Wildcard** – [Wildcard](https://www.microsoft.com/technet/prodtechnol/WindowsServer2003/Library/IIS/41c238b2-1188-488f-bf2d-464383b1bb08.mspx?mfr=true "Wildcard syntax") syntax used in IIS HTTP redirection module. The following is an example of a pattern in this format: "/Scripts/\*\_in.???", where asterisk ("\*") means "match any number of any characters and capture them in a back-reference" and "?" means match exactly one character (no back-reference is created).

The scope of the **patternSyntax** attribute is per rule, meaning that it applies to the current rule's pattern and to all patterns used within conditions of that rule.

<a id="Rule_pattern_properties"></a>

#### Rule pattern properties

A pattern can be negated by using the **negate** attribute of the &lt;match&gt; element. When this attribute is used, the rule action is performed only if the current URL does **not** match the specified pattern.

By default, case-insensitive pattern matching is used. To enable case sensitivity, you can use the **ignoreCase** attribute of the &lt;match&gt; element of the rule.

<a id="Rule_conditions"></a>

### Rule conditions

Rule conditions allow defining additional logic for rule evaluation, which can be based on inputs other than just a current URL string. Any rule can have zero or more conditions. Rule conditions are evaluated after the rule pattern match is successful.

Conditions are defined within a &lt;conditions&gt; collection of a rewrite rule. This collection has an attribute called **logicalGrouping** that controls how conditions are evaluated. If a rule has conditions, then the rule action is performed only if rule pattern is matched and:

- All conditions were evaluated as true, provided that **logicalGrouping="MatchAll"** was used.
- At least one of the conditions was evaluated as true, provided that **logicalGrouping="MatchAny"** was used.

A condition is defined by specifying the following properties:

- Input string
- Match type

Condition input specifies which item to use as an input for the condition evaluation. Condition input is an arbitrary string that can include server variables and back-references to prior condition patterns and/or to rule patterns.

The match type can be one of the following three options:

- **IsFile** – This match type is used to determine whether the input string contains a physical path to a file on a file system. If a condition input string is not specified, the URL Rewrite Module uses the physical path of the requested file as a default value for the condition input. This match type can be used only for distributed rules.
- **IsDirectory** – This match type is used to determine whether the input string contains a physical path to a directory on a file system. If a condition input string is not specified, the URL Rewrite Module uses the physical path of the requested file as a default value for the condition input. This match type can be used only for distributed rules.
- **Pattern** – This match type is used to express a condition where an arbitrary input string is matched against a regular expression pattern. A condition pattern can be specified by using either regular expression syntax or by using wildcard syntax. The type of pattern to use in a condition depends on the value of the **patternSyntax** flag defined for the rule to which this condition belongs. This condition type has two related attributes that control pattern matching:

    - **pattern** – Use this attribute to specify the actual pattern.
    - **ignoreCase** – Use this attribute to control whether pattern matching for the condition should be case sensitive or case insensitive.

In addition, the result of the condition evaluation can be negated by using the **negate** attribute. This can be used to specify a condition that checks if the requested URL is NOT a file, as in the following example:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample1.xml)]

<a id="Rule_action"></a>

### Rule action

A rewrite rule action is performed when the current URL matches the rule pattern and the condition evaluation succeeded (depending on the rule configuration, either all conditions matched or any one or more of the conditions matched). There are several types of actions available, and the **type** attribute of the &lt;action&gt; configuration element can be used to specify which action the rule performs. The following sections describe different action types and the configuration options related to specific action types.

<a id="Rewrite_action"></a>

#### Rewrite action

A **Rewrite** action replaces the current URL string with a substitution string. A substitution string must always specify the URL path (for example, contoso/test/default.aspx). Note that substitutions that contain a physical path on a file system (for example, `C:\inetpub\wwwroot`) are not supported in IIS.

A **Rewrite** action has the following configuration options:

- **url** – This is the substitution string to use when rewriting the current URL. The substitution URL is a string value that can include the following:

    - Back-references to the condition and rule patterns. (For more information, see the section about how to use back-references.)
    - Server variables. (For more information, see the section about how to use server variables.)
- **appendQueryString** – Specifies whether the query string from the current URL is preserved during substitution. By default, if the value of the **appendQueryString** flag is not specified, it is assumed to be TRUE. This means that the query string from the original URL is appended to the substituted URL.

<a id="Redirect_action"></a>

#### Redirect action

A **Redirect** action instructs the URL Rewrite Module to send a redirect response back to the client. The redirect status code (3xx) can be specified as a parameter for this action. The **Location** field of the response contains the substitution string specified in the rule.

The substitution URL for the redirect rule can be specified in one of the following forms:

- Relative URL path – contoso/test/default.aspx
- Absolute URI – https://example.com/contoso/test/default.aspx

Usage of a **Redirect** action implies that no subsequent rules evaluated for the current URL after redirection is performed.

A **Redirect** action has the following configuration options:

- **url** – Uses a substitution string as a redirection URL. A substitution URL is a string that can include the following:

    - Back-references to the condition and rule patterns. (For more information, see the section about how to use back-references.)
    - Server variables. (For more information, see the section about how to use server variables.)
- **appendQueryString** – Specifies whether the query string from the current URL should be preserved during substitution. By default, if the **AppendQueryString** flag is not specified, it is assumed to be TRUE. This means that the query string from the original URL is appended to the substituted URL.
- **redirectType** – Specifies the status code to use during redirect:

    - 301 – Permanent
    - 302 – Found
    - 303 – See other
    - 307 – Temporary

<a id="CustomResponse_action"></a>

#### CustomResponse action

A **CustomResponse** action causes the URL Rewrite Module to respond to the HTTP client by using a user-specified status code, subcode, and reason. Use of a **CustomResponse** action implies that no subsequent rules are evaluated for the current URL after this action is performed.

CustomResponse action has the following configuration options:

- **statusCode**– Specifies the status code to use in response to the client.
- **subStatusCode** – Specifies the substatus code to use in response to the client.
- **statusReason** – Specifies the reason phrase to use with the status code.
- **statusDescription** – Specifies the one line description to put in the body of the response.

<a id="AbortRequest_action"></a>

#### AbortRequest action

An **AbortRequest** action causes the URL Rewrite Module to drop the HTTP connection for the current request. The action does not have any parameters. Use of this action implies that no subsequent rules are evaluated for the current URL after this action is performed.

<a id="None_action"></a>

#### None action

A **None** action is used to specify that no action is performed.

<a id="UsingServerVars"></a>

## Using server variables in rewrite rules

Server variables provide additional information about current HTTP requests. You can use this information to make rewriting decisions or to compose the rewritten URL. Server variables can be referenced in the following locations within rewrite rules:

- In the condition input string
- In rule substitution strings, specifically:

    - **url** attribute of Rewrite and Redirect action
    - **statusLine** and **responseLine** of a **CustomResponse** action

Server variables can be referenced by using the {VARIABLE\_NAME} syntax. For example, the following condition uses the QUERY\_STRING server variable:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample2.xml)]


Server variables can also be used to access HTTP headers from the current request. Any HTTP header supplied by the current request is represented as a server variable that has a name generated in accordance to this naming convention:

1. All dash ("-") symbols in the HTTP header name are converted to underscore symbols ("\_").
2. All letters in the HTTP header name are converted to capital case.
3. "HTTP\_" prefix is added to the header name.

For example, in order to access the HTTP header "user-agent" from a rewrite rule, you can use the {HTTP\_USER\_AGENT} server variable.

<a id="Using_back-references_in_rewrite_rules"></a>

## Using back-references in rewrite rules

Parts of rules or conditions inputs can be captures in back-references. These can be then used to construct substitution URLs within rules actions or to construct input strings for rule conditions.

Back-references are generated in different ways, depending on which kind of pattern syntax is used for the rule. When an ECMAScript pattern syntax is used, a back-reference can be created by putting parenthesis around the part of the pattern that must capture the back-reference. For example, the pattern **([0-9]+)/([a-z]+)\.html** will capture **07** and **article** in back-references from this requested URL: **07/article.html**. When "Wildcard" pattern syntax is used, the back-references are always created when an asterisk symbol (\*) is used in the pattern. No back-references are created when "?" is used in the pattern. For example the pattern **\*/\*.html** will capture **contoso** and **test** in back-references from this requested URL: **contoso/test.html**.

Usage of back-references is the same regardless of which pattern syntax was used to capture them. Back-references can be used in the following locations within rewrite rules:

- In condition input strings
- In rule actions, specifically:

    - **url** attribute of Rewrite and Redirect action
    - **statusLine** and **responseLine** of a **CustomResponse** action
- In a **key** parameter to the rewrite map

Back-references to condition patterns are identified by {C:N} where N is from 0 to 9. Back-references to rule patterns are identified by {R:N} where N is from 0 to 9. Note that for both types of back-references, {R:0} and {C:0}, will contain the matched string.

For example, in this pattern:


[!code-console[Main](url-rewrite-module-configuration-reference/samples/sample3.cmd)]


For the string: **www.foo.com** the back-references will be indexed as follows:


[!code-json[Main](url-rewrite-module-configuration-reference/samples/sample4.json)]


Within a rule action, you can use the back-references to the rule pattern and to the last matched condition of that rule. Within a condition input string, you can use the back-references to the rule pattern and to the previously matched condition.

The following rule example demonstrates how back-references are created and referenced:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample5.xml)]

<a id="Interaction_with_IIS_Output_Caching"></a>

## Interaction with IIS Output Caching

The URL Rewrite Module controls the IIS output cache behavior in order to:

1. Optimally utilize kernel mode and user mode output caching of responses for rewritten URLs, thus improving performance of the Web application that uses URL Rewrite Module.
2. Prevent caching of responses, when caching logic may be violated due to URL rewriting.

The module controls output caching either by altering certain caching properties or by disabling the caching altogether. The module cannot enable output caching if it has been disabled by IIS configuration or by any other module in the IIS pipeline. The output caching is controlled as follows:

1. The module always sets the user mode cache setting **varyByHeader**="HTTP\_X\_ORIGINAL\_URL". This ensures that when user mode caching is enabled the module takes into account the original URL to construct a key for the cache entry.
2. If a rewrite rule set uses server variables with values that are either constant throughout the life of the process or are derived from the requested URL, the rule set is considered safe for output caching. This means that the URL Rewrite Module will not alter existing caching policy in any way other than setting **varyByHeader** as described in step 1.

    The following server variables, when used in rewrite rules, do not cause any effect on output caching policy:

    "CACHE\_URL",  
"DOCUMENT\_ROOT",  
"HTTP\_URL",  
"HTTP\_HOST",  
"PATH\_INFO",  
"PATH\_TRANSLATED",  
"QUERY\_STRING",  
"REQUEST\_FILENAME",  
"REQUEST\_URI",  
"SCRIPT\_FILENAME",  
"SCRIPT\_NAME",  
"SCRIPT\_TRANSLATED",  
"UNENCODED\_URL",  
"URL",  
"URL\_PATH\_INFO",   
"APP\_POOL\_ID",  
"APPL\_MD\_PATH",  
"APPL\_PHYSICAL\_PATH",  
"GATEWAY\_INTERFACE",  
"SERVER\_SOFTWARE",  
"SSI\_EXEC\_DISABLED"
3. If a rewrite rule set uses any server variable not mentioned in the above list, the rule set is considered unsafe for output caching. This means that the URL Rewrite Module will disable kernel mode caching for all requests whether the request URLs were rewritten or not. In addition, the module will alter the caching policy for user-mode cache by setting the caching property **varyByValue** to contain the concatenated string of all server variables values used in the rule set.

<a id="String_functions"></a>

## String functions

There are three string functions available for changing the values within a rewrite rule action, as well as any conditions:

- **ToLower** - returns the input string converted to lower case.
- **UrlEncode** - returns the input string converted to URL-encoded format. This function can be used if the substitution URL in rewrite rule contains special characters (for example non-ASCII or URI-unsafe characters).
- **UrlDecode** - decodes the URL-encoded input string. This function can be used to decode a condition input before matching it against a pattern.

The functions can be invoked by using the following syntax:


[!code-json[Main](url-rewrite-module-configuration-reference/samples/sample6.json)]


Where "function\_name" can be on eof the following: "ToLower", "UrlEncode", "UrlDecode". "Any\_string" can be either a literal string or a string built by using server variables or back-references. For example, the following are valid invocations of string functions:


[!code-json[Main](url-rewrite-module-configuration-reference/samples/sample7.json)]


The string functions can be used in the following locations within rewrite rules:

- In condition input strings
- In rule substitution strings, specifically: 

    - **url** attribute of **Rewrite** and **Redirect** actions
    - **statusLine** and **responseLine** attributes of a **CustomResponse** action

An example of a rule that uses the **ToLower** function:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample8.xml)]


An example of a rule that uses the **UrlEncode** function:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample9.xml)]


An example of a rule that uses the **UrlDecode** function:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample10.xml)]

<a id="Rewrite_maps"></a>

## Rewrite maps

A rewrite map is an arbitrary collection of name-value pairs that can be used within rewrite rules to generate the substitution URL during rewriting. Rewrite maps are particularly useful when you have a large set of rewrite rules and all of these rules use static strings (that is, when there is no pattern matching used). In those cases, instead of defining a large set of simple rewrite rules, you can put all the mappings into the rewrite map as keys and values between the input URL and the substitution URL. Then, to look up the substitution URL based on the input URL, you will have one rewrite rule that references the rewrite map.

A rewrite map defines a named collection of name-value pair strings, as in the following example:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample11.xml)]


A rewrite map is uniquely identified by its name and can contain zero or more key-value entries. In addition, a rewrite map can specify the default value to use when a key is not found. This is controlled by using the **defaultValue** attribute. By default, an empty string is used as a default value.

There can be any number of rewrite maps on any configuration level, except the file level. Rewrite maps are located within &lt;rewriteMaps&gt; collection element.

Rewrite maps are referenced within a rewrite rule by using the following syntax:


[!code-json[Main](url-rewrite-module-configuration-reference/samples/sample12.json)]


Where the **Key** parameter can be any arbitrary string, and can include back-references to rule or condition patterns. For example, the following are valid uses of a rewrite map:


[!code-json[Main](url-rewrite-module-configuration-reference/samples/sample13.json)]


A reference to a rewrite map gets substituted with the value that was looked up by using the key passed as a parameter within a rewrite map reference. If a key was not found, the default value for that rewrite map is used.

A Rewrite map can be referenced in the following locations within rewrite rules:

- In condition input string
- In rule substitution strings, specifically: 

    - **url** attribute of **Rewrite** and **Redirect** actions
    - **statusLine** and **responseLine** of **CustomResponse** actions

**Example 1**: With a rewrite map defined as follows:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample14.xml)]


And a rewrite rule defined as follows:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample15.xml)]


The requested URL /**diagnostic** will be rewritten as **/default.aspx?tabid=2&amp;subtabid=29**.  
The requested URL /**webcasts** will be rewritten to **/default.aspx?tabid=2&amp;subtabid=24**.  
The requested URL /**php** will be rewritten to **/default.aspx?tabid=7116**.  
The requested URL /**default.aspx** will not be rewritten because the rewrite map does not contain an element with key="/default.aspx"; therefore the rewrite map will return an empty string which will not match the condition pattern, hence the rule action will not be performed.

**Example 2**: With a rewrite map defined as follows:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample16.xml)]


And a rewrite rule defined as follows:


[!code-xml[Main](url-rewrite-module-configuration-reference/samples/sample17.xml)]


The requested URL **/default.aspx?tabid=2&amp;subtabid=29** will be redirected to `http://www.contoso.com/diagnostics`.  
The requested URL **/default.aspx?tabid=2&amp;subtabid=24** will be redirected to `http://www.contoso.com/webcasts`.  
The requested URL **/default.aspx?tabid=7116** will be redirected to `http://www.contoso.com/php`.  
The requested URL /**default.aspx** will not be redirected because rewrite map does not contain an element with key="/default.aspx"; therefore the rewrite map will return an empty string which will not match the condition pattern, hence rule action will not be performed.
