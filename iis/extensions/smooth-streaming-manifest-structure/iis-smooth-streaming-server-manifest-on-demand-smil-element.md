---
title: IIS Smooth Streaming Server Manifest (On-Demand) - smil Element
TOCTitle: <smil>
ms:assetid: 1f93add4-d463-4503-8c9f-063beac6bbb2
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee230810(v=VS.90)
ms:contentKeyID: 22049438
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand) - smil Element

The smil element is the root container used by SMIL 2.0.

    <smil xmlns="http://www.w3.org/2001/SMIL20/Language">
    </head>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

#### Attributes

|Attribute|Description|
|--- |--- |
|xmlns|Specifies the value of the XML namespace used by the presentation. The value must be <a href="http://www.w3.org/2001/smil20/language">http://www.w3.org/2001/SMIL20/Language</a>. Instead of the default namespace, a named namespace may be used, in which case all the tags described below must have the namespace prefix that maps to this XML namespace. This attribute is required.|

#### Child Elements

|Element|Description|
|--- |--- |
|**head**|The head element is a container for presentation-level metadata.|
|**body**|The body element is a container for track information and references to other media.|


#### Parent Elements

None

## Example

The following is an example of an On-Demand Server Manifest.

    <smil xmlns="http://www.w3.org/2001/SMIL20/Language">
      <head>
        <meta name="title" content="{content title}"/>
        <meta name="clientManifestRelativePath" 
              content="{media_name}.ismc" />
        <meta name="module" content="smoothStreaming" />
      </head>
      <body>
        <switch>
          <video src="{media_name}_1000_1500k.ismv" 
                 systemBitrate="1500000" >
            <param name="trackID" value="1" valuetype="data" />
            <param name="hardwareProfile" value="10000" valuetype="data" />
          </video>
          <video src="{media_name}_100_1500k.ismv" 
                 systemBitrate="1500000" >
            <param name="trackID" value="1" valuetype="data"/>
            <param name="hardwareProfile" value="1000" 
              valuetype="data" />
          </video>
          <audio src="{media_name}_1000_1500k.ismv" systemBitrate="128000" 
                 systemLanguage="en" >
            <param name="trackID" value="2" valuetype="data"/>
          </audio>
          <audio src="{media_name}_128k-aud-deu.isma" 
                 systemBitrate="128000" systemLanguage="de" >
            <param name="trackID" value="1" valuetype="data"/>
            <param name="trackName" value="audio-de" valuetype="data"/>
          </audio>
          <video src="{media_name}_1000k.ismv" systemBitrate="1000000" >
            <param name="trackID" value="1" valuetype="data"/>
          </video>
          <audio src="{media_name}_96k.isma" systemBitrate="96000" 
                 systemLanguage="en" >
            <param name="trackID" value="2" valuetype="data"/>
          </audio>
          <!-- ... additional bitrates omitted -->
          <video src="{media_name}_1000_300k.ismv" systemBitrate="300000" > 
            <param name="hardwareProfile" value="1000" valuetype="data" />
            <param name="trackID" value="1" valuetype="data"/>
          </video>
          <video src="{media_name}_100_300k.ismv" systemBitrate="300000" >
            <param name="hardwareProfile" value="100" valuetype="data" />
            <param name="trackID" value="1" valuetype="data"/>
          </video>
          <audio src="{media_name}_100_300k.ismv" systemBitrate="64000" 
                 systemLanguage="en " >
            <param name="trackID" value="2" valuetype="data"/>
          </audio>
          <textstream src="{media_name}_1200k.ismv" systemBitrate="700000" 
                systemLanguage="en">
               <param name="trackID" value="3" valuetype="data" />
               <param name="trackName" value="scmd" valuetype="data" />
          </textstream>
          <!-- ... additional textstream tracks omitted -->
        </switch>
      </body>
    </smil>

## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (On-Demand) - head Element](iis-smooth-streaming-server-manifest-on-demand-head-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - body Element](iis-smooth-streaming-server-manifest-on-demand-body-element.md)

#### Concepts

[IIS Smooth Streaming Server Manifest (On-Demand)](iis-smooth-streaming-server-manifest-on-demand.md)

