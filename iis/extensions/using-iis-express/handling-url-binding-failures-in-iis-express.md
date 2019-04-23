---
title: "Handling URL Binding Failures in IIS Express"
author: vaidy4github
description: "Overview IIS Express was designed to allow the most common web development and testing tasks to be performed without administrative privileges. For example,..."
ms.date: 01/12/2011
ms.assetid: d810838e-8656-42dd-bc86-a636a0340561
msc.legacyurl: /learn/extensions/using-iis-express/handling-url-binding-failures-in-iis-express
msc.type: authoredcontent
---
# Handling URL Binding Failures in IIS Express

by [Vaidy Gopalakrishnan](https://github.com/vaidy4github)

## Overview

IIS Express was designed to allow the most common web development and testing tasks to be performed without administrative privileges. For example, you can run a website locally using a non-reserved port. You can also test your website with SSL using a self-signed test certificate and a port in the range 44300 to 44399. See [Running IIS Express without Administrative Privileges](running-iis-express-without-administrative-privileges.md) for details.

However, you might occasionally need to use IIS Express for testing scenarios that are not enabled by default. For example, although IIS Express is not designed to be a production web server like IIS, you might need to test external access to your website. Similarly, you might want to test your site using SSL or using a specific reserved port number.

By default, if you use IIS Express to test these scenarios, it reports a URL binding failure. This occurs because IIS Express does not have sufficient privileges to perform these types of tasks. You can run IIS Express as an administrator to bypass these restrictions, but this is not a good practice for security reasons.

The correct approach to testing with IIS Express in these scenarios is to configure HTTP.sys to allow IIS Express running under standard permissions to perform the tasks. When your testing is complete, you can revert the configuration. For security reasons, these tasks are restricted to administrators and cannot be performed by standard (non-administrator) users.

## About HTTP.sys

HTTP.sys is an operating system component that handles HTTP and SSL traffic for both IIS and IIS Express. By default, HTTP.sys prevents applications (including IIS Express) from doing the following operations if the application is run by a standard user:

- Using reserved ports such as 80 or 443
- Serving external traffic
- Using SSL

You can configure HTTP.sys to permit these operations for IIS Express. On Windows 7 and Windows Vista, you can configure HTTP.sys using the [netsh.exe](https://docs.microsoft.com/windows/desktop/Http/netsh-commands-for-http) utility. On Windows XP, HTTP.sys can be configured using the [httpcfg.exe](https://docs.microsoft.com/previous-versions/windows/it-pro/windows-server-2003/cc781601(v=ws.10)) command-line utility, which is included with [Windows XP Service Pack 2 Support Tools](https://www.microsoft.com/downloads/en/details.aspx?familyid=49AE8576-9BB9-4126-9761-BA8011FABF38&amp;displaylang=en).

## Using a Reserved Port

By default, you can use IIS Express to run your website using a non-reserved port such as 8080. However, using a reserved port such as 80 or 443 requires work. The steps described below assume you want to support local traffic over port 80.

On Windows 7 or Windows Vista, from an elevated command prompt, run the following command:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample1.cmd)]

This command will allow any user's application (including your own IIS Express instances) to run using port 80 without requiring administrative privileges. To limit this access to yourself, replace "everyone" with your Windows identity.

On Windows XP, you need to run the following command from an elevated command prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample2.cmd)]

After configuring HTTP.sys, you can configure your website to use port 80. This is very straightforward using tools like WebMatrix and Visual Studio 2010 SP1 Beta. You can also manually edit the *applicationhost.config* file to include the following binding in the sites element.

[!code-xml[Main](handling-url-binding-failures-in-iis-express/samples/sample3.xml)]

Your website will now run (locally) using port 80.

When you are done testing your application, you should revert HTTP.sys to its earlier settings.

On Windows 7 or Windows Vista, run the following command from an elevated command prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample4.cmd)]

On Windows XP, run the following command from an elevated prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample5.cmd)]

## Serving External Traffic

To enable your website to serve external traffic, you need to configure HTTP.sys and your computer's firewall. The steps described below assume external traffic will be served on port 8080.

The steps for configuring HTTP.sys for external traffic are similar to setting up a site to use a reserved port. On Windows 7 or Windows Vista, from an elevated command prompt, run the following command:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample6.cmd)]

On Windows XP, run the following command from an elevated command prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample7.cmd)]

After configuring HTTP.sys, you can configure IIS Express to use port 80 by using WebMatrix or Visual Studio 2010 SP1 Beta, or by editing the *applicationhost.config* file to include the following binding in the sites element. (Replace *myhostname* with your computer's domain name).

[!code-xml[Main](handling-url-binding-failures-in-iis-express/samples/sample8.xml)]

You will also need to configure the firewall to allow external traffic to flow through port 8080. The steps will vary depending on which firewall you are using and aren't described here.

When you are done testing your application, revert HTTP.sys to its earlier settings.

On Windows 7 or Windows Vista, run the following command from an elevated command prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample9.cmd)]

On Windows XP, run the following command from an elevated prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample10.cmd)]

## Using a Custom SSL Port

If you want to test SSL access to your site, you can do this with IIS Express by using an SSL port between 44300 and 44399 and using the IIS Express self-signed certificate. Trying to use SSL with a port outside this range results in a URL binding failure when your website is launched under IIS Express.

For general instructions on how to configure HTTP.sys to support SSL, see [How to: Configure a Port with an SSL Certificate](https://docs.microsoft.com/dotnet/framework/wcf/feature-details/how-to-configure-a-port-with-an-ssl-certificate). As an example, imagine that you want to test your website using the URL `https://localhost:443`.

First, determine the SHA1 thumbprint for the IIS Express self-signed certificate. This thumbprint is different for each computer because the IIS Express setup program generates a new certificate when executed. You can determine the SHA1 thumbprint using the Microsoft Management Console (MMC) Certificate snap-in by looking at the computer's Personal certificate store. Alternatively, you can use the .NET [CertMgr.exe](https://docs.microsoft.com/dotnet/framework/tools/certmgr-exe-certificate-manager-tool) utility as shown below. From a command prompt, run the following command.

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample11.cmd)]

This command displays information about all the certificates in the Personal certificate store for the local computer. Search for "IIS Express Development Certificate" in the output to locate the IIS Express self-signed certificate and then note its SHA1 thumbprint.

Next, configure HTTP.sys to associate the self-signed certificate with the URL. On Windows 7 or Windows Vista, start by creating a unique UUID using uuidgen.exe or some other tool. Then run the following command from an elevated prompt, passing the thumbprint to the certhash parameter. (Exclude the spaces when you specify the thumbprint.)

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample12.cmd)]

For the appid parameter, pass the unique UUID you created earlier.

On Windows XP, run the following command from an elevated prompt.

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample13.cmd)]

Since 443 is a reserved port, you will additionally need to configure HTTP.sys to allow IIS Express to use it while running as a standard user. For details, see the Using a Reserved Port section. You won't need to perform this step if you use a non-reserved custom SSL port such as 44500.

On Windows 7 or Windows Vista, run the following command from an elevated prompt.

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample14.cmd)]

On Windows XP, run the following command from an elevated prompt.

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample15.cmd)]

After configuring HTTP.sys, configure your website to use the custom SSL port using WebMatrix or Visual Studio 2010 SP1 Beta, or by adding the following binding in the sites element in the *applicationhost.config* file.

[!code-xml[Main](handling-url-binding-failures-in-iis-express/samples/sample16.xml)]

When you are done testing your website, revert HTTP.sys to its earlier settings. On Windows 7 or Windows Vista, run the following commands from an elevated prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample17.cmd)]

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample18.cmd)]

On Windows XP, run the following commands from an elevated prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample19.cmd)]

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample20.cmd)]

## Using a Custom SSL Certificate

Setting up a custom SSL certificate is very similar to using a custom SSL port. The steps described in this section assume your website is already serving local SSL traffic using port 44300 and the IIS Express self-signed certificate.

First, you need to install the custom SSL certificate on your computer. Use the MMC Certificate snap-in or CertMgr.exe. As you are installing your certificate, note the SHA1 thumbprint value.

The URL `https://localhost:44300` is pre-configured by IIS Express setup to use a self-signed certificate. In order to bind this URL to your custom certificate, you will have to delete the existing association. Skip this step if your hostname and port combination is not associated with an SSL certificate.

On Windows 7 or Windows Vista, run the following command from an elevated prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample21.cmd)]

On Windows XP, run the following command from an elevated prompt:

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample22.cmd)]

The remaining steps are similar to those for configuring a custom SSL port. Create a unique UUID using uuidgen.exe or some other tool.

On Windows 7 or Windows Vista, run the following command from an elevated prompt, passing your custom certificates' thumbprint (remove any spaces first) to the certhash parameter and passing your UUID.

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample23.cmd)]

On Windows XP, run the following command from an elevated prompt.

[!code-console[Main](handling-url-binding-failures-in-iis-express/samples/sample24.cmd)]

## Summary

This article explains the steps required to support some scenarios for IIS Express that aren't enabled by default. Performing them requires you to be an administrator. Even if you don't have administrative privileges, you can still perform the most common web design and development tasks with IIS Express as a standard user.