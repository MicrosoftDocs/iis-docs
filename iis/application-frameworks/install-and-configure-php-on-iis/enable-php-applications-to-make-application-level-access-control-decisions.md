---
title: "Enable PHP Applications to Make Application-Level Access Control Decisions"
author: rick-anderson
description: "You can expose key access control information to a PHP application to facilitate application-level access control, if desired. The Microsoft ® .NET extensibi..."
ms.date: 11/15/2009
ms.assetid: 56ad831c-305b-46fb-aa92-71784fa1bd3a
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/enable-php-applications-to-make-application-level-access-control-decisions
msc.type: authoredcontent
---
# Enable PHP Applications to Make Application-Level Access Control Decisions

by Tali Smith

## Introduction

You can expose key access control information to a PHP application to facilitate application-level access control, if desired. The Microsoft® .NET extensibility in Internet Information Services 7 (IIS 7) and above makes it very easy to add custom authentication or authorization features or to complement existing access control features with custom functionality.

For example, you can:

- Use Membership and Roles APIs to manage the use and role stores in a consistent way, regardless of the underlying provider storage.
- Provide custom credential store support for Forms Authentication by writing a custom Membership provider.
- Provide custom role store support for Role Manager by writing a custom Role provider.

PHP can integrate with the IIS security model by executing PHP scripts while impersonating the authenticated user provided by IIS, but the authenticated user must be a Windows® user and the access control lists (ACLs) for the PHP application content must grant access for each impersonated user. The ACLs must be managed throughout the lifetime of the application and, in many cases, managed when moving the application between servers.

With IIS and FastCGI, PHP can use an execution model that simplifies security management. The PHP scripts can be executed using the identity of the application pool to which the application belongs. This model has the following advantages:

- The content can grant access for a single identity, the identity of the application pool. Alternatively, if you do not want application pool isolation, you can give access to the IIS\_IUSRS group, which allows all IIS application pools on any IIS machine to have access. This significantly simplifies deployment and ongoing management of the application.
- All access security can be managed at the application level using application authorization features; it can be applied uniformly to parts of the application that do not correspond to physical resources and therefore cannot have ACL-based permissions.
- No impersonation needs to take place, which may improve performance.

Note that this security model may not be appropriate if:

- You isolate multiple applications from each other within a single application pool, by impersonating a specific user for each.
- You secure application content by using ACLs for each user and impersonating that user to access application content. Or, you use application features or libraries that use the impersonated user to authenticate their actions.
- The application content is on a Universal Naming Convention (UNC) share, and is configured with fixed credentials for the application's virtual directories.

IIS access control features help create flexible and manageable access control solutions for PHP applications and the PHP-specific integration that can enable PHP applications to make application-level access control decisions.

## Configure Basic Authentication

1. Start **IIS Manager** (Inetmgr.exe).
2. Expand the server node, and then expand the **Sites** node.
3. In the tree view on the left, click on the Web site that hosts the application you want to secure.
4. Under the **IIS** feature group, double-click **Authentication**. Here you can see the available authentication methods, which correspond to the installed authentication modules. By default, Anonymous Authentication is enabled
5. Right-click **Anonymous Authentication**, and then click **Disable**.
6. Right-click **Basic Authentication**, and then click **Enable**.  

    [![Screenshot of the I I S Manager Authentication page. In the server node, Sites is expanded. In the Authentication pane under Name, Basic Authentication is selected.](enable-php-applications-to-make-application-level-access-control-decisions/_static/image2.jpg)](enable-php-applications-to-make-application-level-access-control-decisions/_static/image1.jpg)

    *Figure 1: Authentication page*
7. In the tree view on the left, click the same Web site that you clicked in Step 3.
8. In the **Actions** pane, click **Restart**.
9. Close IIS Manager. Note that only the built-in authentication schemes are visible in the Authentication feature. Third-party custom authentication schemes need to be configured separately, but the Authentication feature may still be used to disable the built-in authentication methods.

## Configure Forms Authentication

Basic authentication can be an insecure way of providing authentication over the Internet, because the browser sends the password in clear text. To prevent password disclosure, you should only use basic authentication over Secure Sockets Layer (SSL) connections. Basic authentication requires that the user log in with a local Windows account or a domain account stored in Windows Active Directory®. Because of this, users authenticated with basic authentication can be impersonated if desired.

Forms Authentication is a Microsoft® ASP.NET authentication feature that can be used for any application content on IIS by taking advantage of the ASP.NET Integrated mode engine. Before using Forms Authentication, be sure that ASP.NET is installed on the server and the PHP application is using an application pool configured to run in Integrated mode (default). For many Internet sites, the ASP.NET Forms Authentication may be a better option, for the following reasons:

- It allows the application to provide the login experience as a seamless part of the application.
- It supports arbitrary credential stores, including built-in support for Microsoft® SQL Server® databases and Windows accounts. Numerous open-source credential store providers are available, or custom ones can be provided by the application.
- It provides enhanced functionality for secure authentication ticket management.

To configure Forms Authentication:

1. Start **IIS Manager** (Inetmgr.exe).
2. Expand the server node, and then expand the **Sites** node.
3. In the tree view on the left, click on the Web site that hosts the application you want to secure.
4. Under the **IIS** feature group, double-click **Authentication**.
5. Right-click **Forms Authentication**, and then click **Enable**.
6. Right-click **Anonymous Authentication**, and then click **Enable**.
7. Disable all other authentication methods. Anonymous authentication is required for Forms Authentication to authenticate users requesting the login page.  

    [![Screenshot of the I I S Manager. The Sites node is expanded and Access Controls Lab is selected. In the Authentication pane, Forms Authentication is selected.](enable-php-applications-to-make-application-level-access-control-decisions/_static/image4.jpg)](enable-php-applications-to-make-application-level-access-control-decisions/_static/image3.jpg)

    *Figure 2: Forms Authentication and Anonymous Authentication enabled*
8. In the tree view on the left, click on the Web site that hosts the application you want to secure.
9. Under the **IIS** feature group, double-click **Modules**.
10. Double-click the **FormsAuthentication** module, and then clear the **Invoke only for requests to ASP.NET applications or managed handlers** check box.  

    [![Screenshot of the Edit Managed Module dialog box. In the Name box, Forms Authentication is written. In the Type box, System dot Web dot Security dot Forms Authentication Module is written.](enable-php-applications-to-make-application-level-access-control-decisions/_static/image6.jpg)](enable-php-applications-to-make-application-level-access-control-decisions/_static/image5.jpg)

    *Figure 3: Enabling Forms Authentication for all requests*
11. Click **OK**. This allows the Forms Authentication module to provide authentication services for all requests, regardless of the application content being requested. This enables your PHP application to take advantage of Forms Authentication.

You can edit a number of configuration options that control the behavior of the Forms Authentication module (see docs at [https://msdn.microsoft.com/library/1d3t3c61.aspx](https://msdn.microsoft.com/library/1d3t3c61.aspx)):

- The default login page URL.
- The timeout and automatic renewal time period for the authentication ticket.
- Whether to use cookieless (URL-based) or cookie-based authentication tickets, or auto-detect cookie support.
- Whether Forms Authentication requires SSL (recommended).
- The encryption levels of the authentication ticket.

You can also configure the credential store for use with Forms Authentication by selecting the appropriate Membership provider. By default, you can use either the SQL Server-based Membership provider (configured to use the local SQL Server Express instance by default), or the Active Directory membership provider (configured to use the local Windows account store by default). However, you can also download and use third-party membership providers, or develop your own membership provider to work with your application's existing credential store.

## Configure Authorization

IIS URL Authorization is a new authorization mechanism that enables the application to create declarative authorization rules within the application itself. These rules can grant or deny access to parts of the application based on the authenticated user and the user's role memberships. The IIS URL Authorization feature is a separate feature from the ASP.NET URL Authorization feature. It is similar in functionality but supports a slightly different configuration syntax and is available even if ASP.NET is not installed. Either feature can be used to provide configuration-based user and role authorization for PHP applications.

### Configure URL Authorization

1. Start **IIS Manager** (Inetmgr.exe).
2. Expand the server node, and then expand the **Sites** node.
3. In the tree view on the left, click on the click on the Web site that hosts the application you want to secure.
4. Double-click **Authorization Rules**.
5. Click **Add Deny Rule**, and then select **All anonymous users**.  

    [![Screenshot of the Add Deny Authentication Rule Dialog box. All Anonymous users is selected.](enable-php-applications-to-make-application-level-access-control-decisions/_static/image8.jpg)](enable-php-applications-to-make-application-level-access-control-decisions/_static/image7.jpg)

    *Figure 4: Add an authorization rule to deny anonymous users*
6. Click **OK**.
7. In the tree view on the left, click the click on the Web site that hosts the application you want to secure name.
8. In the **Actions** pane, click **Restart**.
9. Close IIS Manager. This denies access to the application for anonymous users. This causes requests to the application to be rejected, and it allows Forms Authentication to redirect users to the login page so that they may log in.

### Configure Role-Based Authorization

URL Authorization allows you to create Allow or Deny rules that apply to:

- Anonymous users.
- A specific user.
- A user in one or more roles.

Role-based rules can be a great way to manage permissions for a large group of users.

When using roles, the role membership information is provided by the Roles module. The Roles module uses a provider model for obtaining roles for a particular user, similar to the Membership provider model.

1. Start **IIS Manager** (Inetmgr.exe).
2. Expand the server node, and then expand the **Sites** node.
3. In the tree view on the left, click the click on the Web site that hosts the application you want to secure.
4. Under **ASP.NET**, double-click **.NET Roles**.
5. In the **Actions** pane, click **Enable**.  

    [![Screenshot of the I I S Manager dot NET Roles pane. The Sites node is expanded. Access Controls Lab is selected.](enable-php-applications-to-make-application-level-access-control-decisions/_static/image10.jpg)](enable-php-applications-to-make-application-level-access-control-decisions/_static/image9.jpg)

    *Figure 5: Enable .NET roles*
6. In the **Actions** pane, click **Add**.
7. In the **Name** box, type **Admin**  

    [![Screenshot of the dot Net Roles pane. The Add dot NET Role dialog box is shown. In the Name box Admin is written.](enable-php-applications-to-make-application-level-access-control-decisions/_static/image12.jpg)](enable-php-applications-to-make-application-level-access-control-decisions/_static/image11.jpg)

    *Figure 6: Add a .NET role*
8. Click **OK**.
9. In the tree view on the left, click the click on the Web site that hosts the application you want to secure.
10. Under **ASP.NET**, double-click **.NET Users**.
11. In the **Actions** pane, click **Add**.
12. Type the *user credentials*, and then click **Next**.
13. Select the **Admin** role check box to add the new user to that role.
14. Click **Finish**.
15. In the tree view on the left, click the Web click on the Web site that hosts the application you want to secure, used in step 9.
16. Under the **IIS** feature group, double-click **Modules**.
17. Double-click the **RoleManager** module, clear the **Invoke only for requests to ASP.NET applications or managed handlers** check box, and then click **OK**.
18. Double-click the **DefaultAuthentication** module, clear the **Invoke only for requests to ASP.NET applications or managed handlers** check box, and then click **OK**.
19. In the tree view on the left, click the **Admin** sub-directory under the click on the Web site that hosts the application you want to secure, used in steps 9 and 15.
20. Double-click **Authorization Rules**.
21. Remove all existing rules by clicking each rule and then clicking **Remove**.
22. In the **Confirm Remove** dialog box, click **Yes**.
23. Click **Add Allow Rule**, and then select **Specified roles or user groups**.
24. Type **admin** in the associated textbox, and then click **OK**.  

    [![Screenshot of the Authorization Rules pane in I I S Manager. The Access Controls Lab node is expanded and admin is selected. In the Module and Roles columns Allow and Admin are highlighted.](enable-php-applications-to-make-application-level-access-control-decisions/_static/image14.jpg)](enable-php-applications-to-make-application-level-access-control-decisions/_static/image13.jpg)

    *Figure 7: Add allow rule for administrator role*
25. Close IIS Manager.

## Integrating PHP with IIS 7.0 and Above

IIS 7 and above provides rich authentication and authorization options that a PHP application can use directly, without needing to provide any custom code. However, there are times when the application needs to perform further authorization at a more granular level than a resource. Or, other times, the application may want to customize the behavior or rendering of the page based on the identity of the user. IIS makes this possible by providing the authenticated user identity information to the PHP page through server variables.

You can use the following server variables to inspect the authenticated user and/or make decisions about the authenticated identity:

- LOGON\_USER – the authenticated user's name. Empty if the authenticated user is anonymous.
- AUTH\_TYPE – the authentication scheme that was used to authenticate the user.

## Links for Further Information

- [PHP on Windows Training Kit](https://www.microsoft.com/downloads/details.aspx?FamilyID=c8498c9b-a85a-4afa-90c0-593d0e4850cb&amp;DisplayLang=en)
