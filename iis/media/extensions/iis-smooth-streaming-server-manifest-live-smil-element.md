---
title: IIS Smooth Streaming Server Manifest (Live) - smil Element
TOCTitle: <smil>
ms:assetid: 94f059c2-010a-44d9-b0b8-9fd61f09048b
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee673437(v=VS.90)
ms:contentKeyID: 26179480
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (Live) - smil Element

The smil element is the root container used by SMIL 2.0.

    <smil xmlns="http://www.w3.org/2001/SMIL20/Language">
    </head>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

#### Attributes

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Attribute</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>xmlns</p></td>
<td><p>Specifies the value of the XML namespace used by the presentation. The value must be <a href="http://www.w3.org/2001/smil20/language">http://www.w3.org/2001/SMIL20/Language</a>. Instead of the default namespace, a named namespace may be used, in which case all the tags described below must have the namespace prefix that maps to this XML namespace. This attribute is required.</p></td>
</tr>
</tbody>
</table>


#### Child Elements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Element</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>head</p></td>
<td><p>The head element is a container for presentation-level metadata.</p></td>
</tr>
<tr class="even">
<td><p>body</p></td>
<td><p>The body element is a container for track information and references to other media.</p></td>
</tr>
</tbody>
</table>


#### Parent Elements

None

## Example

The following is an example of a Live Server Manifest.

    <?xml version="1.0" encoding="utf-16"?>
    <smil xmlns="http://www.w3.org/2001/SMIL20/Language">
       <head>
         <meta name="Meta Data" content="Common meta data" />
       </head>
       <body>
          <switch>
             <video src = "Stream" systemBitrate="1450000">
                <param name="trackID" value="2" valuetype="data" />
                <param name="FourCC" value="WVC1" valuetype="data" />
                <param name="MaxWidth" value="640" valuetype="data" />
                <param name="MaxHeight" value="480" valuetype="data" />
                <param name="CodecPrivateData" value="250000010FD37E27F1678A27F859E80490824C4ADF5DC00000010E5A67F840" valuetype="data" />
             </video>
             <video src = "Stream" systemBitrate="1050000">
                <param name="FourCC" value="WVC1" valuetype="data" />
                <param name="trackID" value="2" valuetype="data" />
                <param name="MaxWidth" value="640" valuetype="data" />
                <param name="MaxHeight" value="480" valuetype="data" />
                <param name="CodecPrivateData" value="250000010FD37E27F1678A27F859E80490824C4ADF5DC00000010E5A67F840" valuetype="data" />
             </video>
             <audio src = "Stream" systemBitrate="94208">
                <param name="trackID" value="1" valuetype="data" />
                <param name="Subtype" value="WMAPRO" valuetype="data" />
                <param name="CodecPrivateData" value="6101020044AC0000853E00009D0B10000A00008800000F0000000000" valuetype="data" />
                <param name="SamplingRate" value = "48000" valuetype="data"/>
                <param name="BitsPerSample" value = "16" valuetype="data" />
                <param name="PacketSize" value = "1115" valuetype="data" />
             </audio>
          </switch>
       </body>
    </smil>

## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (Live) - head Element](iis-smooth-streaming-server-manifest-live-head-element.md)

[IIS Smooth Streaming Server Manifest (Live) - body Element](iis-smooth-streaming-server-manifest-live-body-element.md)

#### Concepts

[IIS Smooth Streaming Live Server Manifest Format](iis-smooth-streaming-live-server-manifest-format.md)

