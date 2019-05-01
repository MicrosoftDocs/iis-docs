---
title: "Web Playlists for IIS 7.0 - Extending Output Formats using XSLT"
author: rick-anderson
description: "Web Playlists for Internet Information Services (IIS) 7.0 and above supports Extensible Stylesheet Language Transformations (XSLT) style sheets that filter o..."
ms.date: 09/12/2008
ms.assetid: 3898c37b-ef52-4a73-af40-564c410906d9
msc.legacyurl: /learn/media/web-playlists/web-playlists-for-iis-extending-output-formats-using-xslt
msc.type: authoredcontent
---
Web Playlists for IIS 7.0 - Extending Output Formats using XSLT
====================
by [Vishal Sood](https://twitter.com/vishalsood)

Web Playlists for Internet Information Services (IIS) 7.0 and above supports Extensible Stylesheet Language Transformations (XSLT) style sheets that filter or customize the XML data in the Web Playlists HTTP response to clients. For example, you can create an XSLT style sheet that transforms the Web Playlists response so that the data is rendered by players that do not support the ASX format. Another example is where you can create an XSLT style sheet that transforms the Web Playlists response to a Web feed format, such as Atom or RSS. You can create and manage XSL Transformations on the **Output Formats** feature page in Web Playlists.

In this article, we enable Web Playlists to output ATOM Web feed format, in addition to the default ASX format, and allow the client making the request to choose the appropriate format.

## Prerequisites

- This walkthrough assumes reader's familiarity with XSL Transformation (XSLT) style sheets. It does not discuss in depth the syntax and technical aspects of writing an XSLT style sheet.
- Web Playlists in IIS Media Services 2.0 should be installed. For more information, see the **Installation Notes** section in the [IIS Media Services Readme](../iis-media-services/iis-media-services-readme.md).

## What is an XSL Transform?

As defined by the [W3C specification](http://www.w3.org/Style/XSL/):

*"XSL is a family of recommendations for defining XML document transformation and presentation. It consists of three parts:  
  
[XSL Transformations](http://www.w3.org/TR/xslt)(XSLT) - a language for transforming XML  
the [XML Path Language](http://www.w3.org/TR/xpath) (XPath) - an expression language used by XSLT to access or refer to parts of an XML document. (XPath is also used by the XML Linking specification.)  
[XSL Formatting Objects](http://www.w3.org/TR/xsl) (XSL-FO) - an XML vocabulary for specifying formatting semantics*

*An XSLT stylesheet specifies the presentation of a class of XML documents by describing how an instance of the class is transformed into an XML document that uses a formatting vocabulary, such as (X)HTML or XSL-FO. For a more detailed explanation of how XSL works, see the [What Is XSL](http://www.w3.org/Style/XSL/WhatIsXSL.html) page."*

## Writing an XSL Transform

Writing an XSLT is similar to writing any XML file. You can easily do this in your favorite editor. Expression Web and Visual Studio provide you with intelli-sense and allow you create XSLT files.

### Creating an XSLT In Visual Studio

In **File** &gt; **New File**, chose **XSLT** as shown in the following figure:

[![](web-playlists-for-iis-extending-output-formats-using-xslt/_static/image2.bmp)](web-playlists-for-iis-extending-output-formats-using-xslt/_static/image1.bmp)

### Writing the ATOM XSLT

#### Step 1: Create a blank XSLT file named atom.xslt

In Visual Studio, create a new XSLT file and name it **atom.xslt** (The name need not be this, but I will use it in the rest of the walkthrough as well).

#### Step 2: Familiarize yourself with ASX format

By default, Web Playlists returns an ASX XML output. Therefore, the atom.xslt file will actually transform ASX output into ATOM. To start writing atom.xslt, you should be familiar with the ASX format. An example is included below, but for more details on ASX outputted by Web Playlists, refer to the [Creating a Simple Playlist](web-playlists-for-iis-7-creating-a-simple-playlist.md) walkthrough.

**ASX Example**


[!code-xml[Main](web-playlists-for-iis-extending-output-formats-using-xslt/samples/sample1.xml)]


#### Step 3: Write the XSL transform for ATOM

XSLT syntax is outside the scope of this walkthrough, but I have included a sample XSLT. You can also download it here: [atom.zip](web-playlists-for-iis-extending-output-formats-using-xslt/_static/web-playlists-for-iis---extending-output-formats-using-xslt-502-atom1.zip).

> [!NOTE]
> This code is intended as an example to help you get started. Feel free to modify it. This is not a supported sample and there may be bugs in it.

### Configuring Web Playlists for ATOM output

The next step to start getting ATOM Web feed output from Web Playlists is to configure the same on your Web Server. Here are steps needed to do that.

#### Step 1: Upload atom.xslt to the Web server on a path under your site root

For this walkthrough, I am assuming the file is uploaded to the site root (for example, **/atom.xslt**).

#### Step 2: Configure the output format in IIS Manager

In IIS Manager, click the **Playlists** icon on your site, and then click **Configure Output Formats**. Then, in the **Add Output Format** dialog box, add the entry for the new output format.

> [!IMPORTANT]
> In **XSLT path**, give the path to your XSLT file, relative to the site root (for example, starting with the "/" character); otherwise, Web Playlists will not accept the path.

[![](web-playlists-for-iis-extending-output-formats-using-xslt/_static/image4.bmp)](web-playlists-for-iis-extending-output-formats-using-xslt/_static/image3.bmp)

### Accessing the new output format on the client

The new output format is accessed by using the following syntax:

> http://<em>site</em>/*playlist*<em>name</em>.isx **?format=&lt;*formatname*&gt;** (for example, <http://contoso.com/file.isx> **?format=atom**)


The &lt;*formatname*&gt; is the format name that you specified in IIS Manager while configuring this output format.

### Testing the ATOM output

ATOM is a well known format so it is easy to test.

#### Test 1: Using a Web browser

Most Web browsers can render ATOM output natively. See the following figure:

[![](web-playlists-for-iis-extending-output-formats-using-xslt/_static/image6.bmp)](web-playlists-for-iis-extending-output-formats-using-xslt/_static/image5.bmp)

#### Test 2: Using an ATOM Feed Validator

There are many feed validators available. I use [http://www.feedvalidator.com](http://www.feedvalidator.com/). If your playlist passes the ATOM validation, the validator gives you a pretty icon that you can share on your Web site. See the following figure:

[![](web-playlists-for-iis-extending-output-formats-using-xslt/_static/image8.bmp)](web-playlists-for-iis-extending-output-formats-using-xslt/_static/image7.bmp)

## Summary

In this walkthrough, we learned how to make Web Playlists respond to client requests in the form of an ATOM feed. Web Playlists has many interesting scenarios. I encourage you to share any XSLT style sheets you write with us and keep looking on [my blog](https://blogs.iis.net/vsood) for more samples.