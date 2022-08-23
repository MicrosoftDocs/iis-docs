---
title: "PowerShell Snap-in: Configuring SSL with the IIS PowerShell Snap-in"
author: rick-anderson
description: "To enable SSL three steps are involved: Acquiring and installing a certificate Creating an SSL binding in IIS Assigning the certificate to the IP:Port of the..."
ms.date: 07/02/2008
ms.assetid: a553c218-5c5f-47ce-b72e-7e6a8ac53394
msc.legacyurl: /learn/manage/powershell/powershell-snap-in-configuring-ssl-with-the-iis-powershell-snap-in
msc.type: authoredcontent
---
# PowerShell Snap-in: Configuring SSL with the IIS PowerShell Snap-in

by IIS Team

To enable SSL three steps are involved:

1. Acquiring and installing a certificate
2. Creating an SSL binding in IIS
3. Assigning the certificate to the IP:Port of the IIS binding

and optionally:

- Enforcing SSL on your web-site

## Acquiring and Installing a Certificate

Acquiring certificates is a tricky business. The users of your web-site have to trust the certificate and that's why you have to get it from a trusted Certificate Authority. For testing purposes you can make your own certificate however. For this walkthrough we will use a so-called self-signed certificate. The tool that helps us creating a self-signed certificate is called MAKECERT and is part of the Visual Studio SDK Tools. The following MAKECERT command will create a self-signed certificate and automatically install it in the "my" Windows Certificate Store:

[!code-console[Main](powershell-snap-in-configuring-ssl-with-the-iis-powershell-snap-in/samples/sample1.cmd)]

You can look at the certificates in the certificate store using the certificate provider:

[!code-powershell[Main](powershell-snap-in-configuring-ssl-with-the-iis-powershell-snap-in/samples/sample2.ps1)]

> [!NOTE]
> Your certificate thumbprint will be different!

Now lets use the IIS PowerShell Snap-in to create an SSL binding and associate it with the certificate we just created

## Creating an SSL Binding

We are adding the SSL binding to the Default Web Site using one of the task-based cmdlets called New-WebBinding:

[!code-powershell[Main](powershell-snap-in-configuring-ssl-with-the-iis-powershell-snap-in/samples/sample3.ps1)]

You can look at the binding collection using the following command: 

[!code-powershell[Main](powershell-snap-in-configuring-ssl-with-the-iis-powershell-snap-in/samples/sample4.ps1)]

[!code-console[Main](powershell-snap-in-configuring-ssl-with-the-iis-powershell-snap-in/samples/sample5.cmd)]

## Assigning the Certificate to the IP:Port of the IIS Binding

Now it gets a bit tricky because SSL settings get stored in the HTTP.SYS configuration store and the naming conventions are a bit different.

1. In HTTP.SYS you have to use 0.0.0.0 to specify all IP addresses; in IIS you use an asterisk (\*).
2. In IIS you use ":" to separate the binding. Because PowerShell sees a colon as a drive indicator an exclamation mark is used instead:

You can CD into the IIS:\SslBindings directory and query the existing SSL bindings. The directory will be empty on an IIS default install:

[!code-powershell[Main](powershell-snap-in-configuring-ssl-with-the-iis-powershell-snap-in/samples/sample6.ps1)]

Now you can use the certificate hash we got in step one and associate it with all IP addresses (0.0.0.0) and the SSL port 443:

[!code-powershell[Main](powershell-snap-in-configuring-ssl-with-the-iis-powershell-snap-in/samples/sample7.ps1)]

The previous command generated the following SSL Binding:

[!code-console[Main](powershell-snap-in-configuring-ssl-with-the-iis-powershell-snap-in/samples/sample8.cmd)]

SSL is ready to go now and you can browse to your site by entering `https://localhost`.

## Summary

It is fairly straightforward process to set up SSL with PowerShell. You need to get a certificate, create an SSL binding in IIS and then use the IP and Port of the IIS binding to create a SSL binding in HTTP.SYS.
