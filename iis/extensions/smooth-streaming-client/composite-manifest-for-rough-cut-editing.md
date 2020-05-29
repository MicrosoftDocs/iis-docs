---
title: Composite Manifest for Rough Cut Editing
TOCTitle: Composite Manifest for Rough Cut Editing
ms:assetid: 50fe2563-f99a-4393-8a07-6a5437ae47ba
ms:mtpsurl: https://msdn.microsoft.com/library/Ff402314(v=VS.95)
ms:contentKeyID: 46359324
ms.date: 05/31/2012
mtps_version: v=VS.95
---

# Composite Manifest for Rough Cut Editing

The composite manifest combines clips from one or more client manifests to support two scenarios:

- Highlights from a single Smooth Streaming presentation extracted and sequenced in a single stream.

- Selections from more than one Smooth Streaming presentation combined and sequenced in a single stream.

The composite manifest contains StreamIndex segments from client manifest .ismc files that are modified as demonstrated in this topic. The file name extension of the composite manifest is .csm.

When the Smooth Streaming Media Element uses a composite manifest as its source, it plays the video/audio content as a single stream. The user can fast forward or rewind across all the segments and seek to any points in the stream. Timeline markers can be added to include other information in the stream.

> [!NOTE]  
> The examples in this topic extend features that are demonstrated in the topic [Silverlight Applications](silverlight-applications.md). For more information, see all topics under [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md).

## Composite Manifest Structure

The composite manifest schema includes the SmoothStreamingMedia element and StreamIndex elements for video and audio streams that are similar to the elements of a normal client manifest, but the c element that represents content fragments uses a new timestamp attribute, t, instead of the number n and duration d attributes of the client manifest. The composite manifest has only the timestamp attribute t, which represents the start time of each content fragment.

The composite manifest schema also adds the Clip element, which contains one or more StreamIndex elements as shown in the following example.

```xml
<?xml version="1.0" encoding="utf-8"?>
<SmoothStreamingMedia>
  <Clip >
    <StreamIndex Type="Video">
        <QualityLevel />
      <c t="2000000000" />
      <c t="2020000000" />
      <c t="2040000000" />
      <c t="2060000000" />
      <c t="2080000000" />
      <c t="2100000000" d="101405895"/>
    </StreamIndex>
  </Clip>
  <Clip >
    <StreamIndex Type="audio">
        <QualityLevel />
      <c t="2000000000" />
      <c t="2020136054" />
      <c t="2040453514" />
      <c t="2061003174" />
      <c t="2080507936" />
      <c t="2101405895" d="101405895"/>
    </StreamIndex>
  </Clip>
<SmoothStreamingMedia>
```

> [!CAUTION]  
> A composite manifest that contains only one video chunk and one audio chunk in each clip will not run.

## Clip Element

A Clip element in the .csm file specifies each segment of the composite manifest. The Clip element contains a Url attribute that identifies the source of the Clip content and ClipBegin and ClipEnd attributes that indicate the beginning time and duration measured in ticks. Each tick represents 100 nanoseconds.

```xml
<?xml version="1.0" encoding="utf-8"?>
<SmoothStreamingMedia
  MajorVersion="1"
  MinorVersion="0"
  Duration="5964583334">
  <Clip Url="http://a-mikedo-1/BigBuckBunny.ism/Manifest" ClipBegin="140000000" ClipEnd="200968708">
    <StreamIndex
```

The beginning and ending times are derived from the number n and duration d attributes of c elements in the client manifest as explained under the next heading.

## Time t Attribute Calculation

Each Clip element requires both video and audio StreamIndex elements that contain c elements similar to the c elements in the client manifest. The attributes of c elements in the client manifest .ismc file specify sequence number n and duration d as shown in the following example.

```
<c
  n="2"
  d="20000000" />
```

In the composite manifest .csm file, a new attribute t specifies start time of each segment of audio and video data. The final c element contains an additional duration d attribute, as shown in the following example.

```
<c t="2000000000" />
<c t="2020000000" />
<c t="2040000000" />
<c t="2060000000" />
<c t="2080000000" />
<c t="2100000000" d="101405895"/>
```

Calculation of the t attribute for each video and audio segment from the duration attributes d in the .ismc manifest uses the formula:

```
t attribute of nth video/audio chunk t[n] = t[n-1]+d[n-1], where t[0] = 0.
```

More explicitly:

```
t of 1st video segment t[0] = 0;
t of 2nd video chunk t[1] = t[0]+d[0] = 0+20000000 = 20000000;
t of 3rd video chunk t[2] = t[1]+d[1] = 20000000+20000000 = 40000000;
…
```

The audio chunk's time stamp is calculated exactly in the same way as the video.

```
t of 1st audio chunk t[0] = 0;
t of 2nd audio chunk t[1] = t[0]+d[0] = 0+15000000 = 15000000;
t of 3rd audio chunk t[2] = t[1]+d[1] = 15000000+18000000 = 33000000;
…
```

It is evident from these examples that implementation of composite manifests requires repetitious calculations with long integers.

After you calculate the start times, t, from the .ismc manifest, combine the Clip elements in the composite .csm manifest. The following example shows three Clip elements in a complete implementation of the composite manifest.

```xml
<?xml version="1.0" encoding="utf-8"?>
<SmoothStreamingMedia
  MajorVersion="1"
  MinorVersion="0"
  Duration="5964583334">
  <Clip Url="http://a-mikedo-1/BigBuckBunny.ism/Manifest" ClipBegin="140000000" ClipEnd="200968708">
    <StreamIndex
      Type="video"
      Subtype="WVC1"
      Chunks="299"
      Url="QualityLevels({bitrate})/Fragments(video={start time})">
      <QualityLevel
        Bitrate="2436000"
        FourCC="WVC1"
        Width="1280"
        Height="720"
        CodecPrivateData="250000010FD3BE27F1678A27F859E80450824A56DCECC00000010E5A67F840" />
      <QualityLevel
        Bitrate="1636000"
        FourCC="WVC1"
        Width="960"
        Height="544"
        CodecPrivateData="250000010FD3B21DF10F8A1DF843E8045081B1ECFCD0C00000010E5A67F840" />
      <QualityLevel
        Bitrate="1233000"
        FourCC="WVC1"
        Width="848"
        Height="480"
        CodecPrivateData="250000010FCBA61A70EF8A1A783BE8045081A5A05E11C00000010E5A67F840" />
      <QualityLevel
        Bitrate="866000"
        FourCC="WVC1"
        Width="624"
        Height="352"
        CodecPrivateData="250000010FCB9A1370AF8A13782BE80450819A6D4211C00000010E5A67F840" />
      <QualityLevel
        Bitrate="608000"
        FourCC="WVC1"
        Width="480"
        Height="272"
        CodecPrivateData="250000010FCB920EF0878A0EF821E8045081128DDCC5C00000010E5A67F840" />
      <QualityLevel
        Bitrate="427000"
        FourCC="WVC1"
        Width="424"
        Height="240"
        CodecPrivateData="250000010FCB8C0D30778A0D381DE80450810D074127400000010E5A67F840" />
      <QualityLevel
        Bitrate="300000"
        FourCC="WVC1"
        Width="320"
        Height="176"
        CodecPrivateData="250000010FC38809F0578A09F815E804508089275B8D400000010E5A67F840" />
      <c t="140000000" />
      <c t="160000000" />
      <c t="180000000" />
      <c t="200000000" d="60000000"/>
    </StreamIndex>
    <StreamIndex
      Type="audio"
      Subtype="WmaPro"
      Chunks="299"
      Url="QualityLevels({bitrate})/Fragments(audio={start time})">
      <QualityLevel
        Bitrate="64000"
        WaveFormatEx="6201020044AC0000451F0000CF05100012001000030000000000000000000000E00042C0" />
      <c t="140000000" />
      <c t="161610884" />
      <c t="181376870" />
      <c t="200968707" d="60968707"/>
    </StreamIndex>
  </Clip>
  <Clip Url="http://a-mikedo-1/BigBuckBunny.ism/Manifest" ClipBegin="2000000000" ClipEnd="2101405896">
    <StreamIndex
      Type="video"
      Subtype="WVC1"
      Chunks="299"
      Url="QualityLevels({bitrate})/Fragments(video={start time})">
      <QualityLevel
        Bitrate="2436000"
        FourCC="WVC1"
        Width="1280"
        Height="720"
        CodecPrivateData="250000010FD3BE27F1678A27F859E80450824A56DCECC00000010E5A67F840" />
      <QualityLevel
        Bitrate="1636000"
        FourCC="WVC1"
        Width="960"
        Height="544"
        CodecPrivateData="250000010FD3B21DF10F8A1DF843E8045081B1ECFCD0C00000010E5A67F840" />
      <QualityLevel
        Bitrate="1233000"
        FourCC="WVC1"
        Width="848"
        Height="480"
        CodecPrivateData="250000010FCBA61A70EF8A1A783BE8045081A5A05E11C00000010E5A67F840" />
      <QualityLevel
        Bitrate="866000"
        FourCC="WVC1"
        Width="624"
        Height="352"
        CodecPrivateData="250000010FCB9A1370AF8A13782BE80450819A6D4211C00000010E5A67F840" />
      <QualityLevel
        Bitrate="608000"
        FourCC="WVC1"
        Width="480"
        Height="272"
        CodecPrivateData="250000010FCB920EF0878A0EF821E8045081128DDCC5C00000010E5A67F840" />
      <QualityLevel
        Bitrate="427000"
        FourCC="WVC1"
        Width="424"
        Height="240"
        CodecPrivateData="250000010FCB8C0D30778A0D381DE80450810D074127400000010E5A67F840" />
      <QualityLevel
        Bitrate="300000"
        FourCC="WVC1"
        Width="320"
        Height="176"
        CodecPrivateData="250000010FC38809F0578A09F815E804508089275B8D400000010E5A67F840" />
      <c t="2000000000" />
      <c t="2020000000" />
      <c t="2040000000" />
      <c t="2060000000" />
      <c t="2080000000" />
      <c t="2100000000" d="101405895"/>
    </StreamIndex>
    <StreamIndex
      Type="audio"
      Subtype="WmaPro"
      Chunks="299"
      Url="QualityLevels({bitrate})/Fragments(audio={start time})">
      <QualityLevel
        Bitrate="64000"
        WaveFormatEx="6201020044AC0000451F0000CF05100012001000030000000000000000000000E00042C0" />
      <c t="2000000000" />
      <c t="2020136054" />
      <c t="2040453514" />
      <c t="2061003174" />
      <c t="2080507936" />
      <c t="2101405895" d="101405895"/>
    </StreamIndex>
  </Clip>
  <Clip Url="http://a-mikedo-1/BigBuckBunny.ism/Manifest" ClipBegin="4000000000" ClipEnd="4101572790">
    <StreamIndex
      Type="video"
      Subtype="WVC1"
      Chunks="299"
      Url="QualityLevels({bitrate})/Fragments(video={start time})">
      <QualityLevel
        Bitrate="2436000"
        FourCC="WVC1"
        Width="1280"
        Height="720"
        CodecPrivateData="250000010FD3BE27F1678A27F859E80450824A56DCECC00000010E5A67F840" />
      <QualityLevel
        Bitrate="1636000"
        FourCC="WVC1"
        Width="960"
        Height="544"
        CodecPrivateData="250000010FD3B21DF10F8A1DF843E8045081B1ECFCD0C00000010E5A67F840" />
      <QualityLevel
        Bitrate="1233000"
        FourCC="WVC1"
        Width="848"
        Height="480"
        CodecPrivateData="250000010FCBA61A70EF8A1A783BE8045081A5A05E11C00000010E5A67F840" />
      <QualityLevel
        Bitrate="866000"
        FourCC="WVC1"
        Width="624"
        Height="352"
        CodecPrivateData="250000010FCB9A1370AF8A13782BE80450819A6D4211C00000010E5A67F840" />
      <QualityLevel
        Bitrate="608000"
        FourCC="WVC1"
        Width="480"
        Height="272"
        CodecPrivateData="250000010FCB920EF0878A0EF821E8045081128DDCC5C00000010E5A67F840" />
      <QualityLevel
        Bitrate="427000"
        FourCC="WVC1"
        Width="424"
        Height="240"
        CodecPrivateData="250000010FCB8C0D30778A0D381DE80450810D074127400000010E5A67F840" />
      <QualityLevel
        Bitrate="300000"
        FourCC="WVC1"
        Width="320"
        Height="176"
        CodecPrivateData="250000010FC38809F0578A09F815E804508089275B8D400000010E5A67F840" />
      <c t="4000000000" />
      <c t="4020000000" />
      <c t="4040000000" />
      <c t="4060000000" />
      <c t="4080000000" />
      <c t="4100000000" d="100000000"/>
    </StreamIndex>
    <StreamIndex
      Type="audio"
      Subtype="WmaPro"
      Chunks="299"
      Url="QualityLevels({bitrate})/Fragments(audio={start time})">
      <QualityLevel
        Bitrate="64000"
        WaveFormatEx="6201020044AC0000451F0000CF05100012001000030000000000000000000000E00042C0" />
      <c t="4000000000" />
      <c t="4020593197" />
      <c t="4040272108" />
      <c t="4061170068" />
      <c t="4080674829" />
      <c t="4101572789" d="100774604"/>
    </StreamIndex>
  </Clip>
</SmoothStreamingMedia>
```

> [!NOTE]  
> Chunks must be specified in two-second intervals that correspond to IFrame start times or the critical first segment of an IFrame could be missed. A chunk that does not pass the first segment will be skipped.

## IIS Configuration to Support Composite Manifest

Composite manifests require IIS configuration details as described in the following headings.

### Configure IIS MIME type for .csm extension

Add a MIME type entry for the .csm file name extension on the IIS server that serves .csm files. The MIME type for the .csm is text/xml. You can add the MIME type from IIS Manager, or you can edit the ApplicationHost.config file to add the following line:

```
<mimeMap fileExtension="".csm"" mimeType=""text/xml" />
```

### Configure SmoothHandler mapping to process HTTP HEAD requests

The SmoothHandler handler mapping of HTTP Head requests can be verified and/or set from either IIS Manager or in the ApplicationHost.config file. Under the verbs tab in the Request Restrictions dialog box of the Handler Mapping editor, set the verbs: GET,HEAD, without a space between them.

You can also use the command line option to set the GET and HEAD verbs:

```
appcmd set config/section:handlers/[name='SmoothHandler'].verb:GET,HEAD
```

For more information, see the [IIS Media Services Readme](https://go.microsoft.com/fwlink/?linkid=184078).

### Allow HEAD requests in the ClientAccessPolicy.xml

The client access policy file should also be modified to allow HEAD requests. Add one of the following lines: `http-methods="*"` or `http-methods="GET,HEAD,POST"`.

The complete file is shown below.

```xml
<?xml version="1.0″ encoding="utf-8″?>
<access-policy>
  <cross-domain-access>
    <policy>
      <allow-from http-methods="*" http-request-headers="*">
        <domain uri="*"/>
      </allow-from>
      <grant-to>
        <resource path="/" include-subpaths="true"/>
      </grant-to>
    </policy>
  </cross-domain-access>
</access-policy>
```

For more information about client access policy, see [Test and Debug Applications](test-and-debug-applications.md).

## See Also

### Concepts

[Timeline Markers and Events](timeline-markers-and-events.md)

### Other Resources

[IIS Media Services Readme](https://go.microsoft.com/fwlink/?linkid=184078)
