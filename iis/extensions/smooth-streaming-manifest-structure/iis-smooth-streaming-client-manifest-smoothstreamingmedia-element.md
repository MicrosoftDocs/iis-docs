---
title: IIS Smooth Streaming Client Manifest - SmoothStreamingMedia Element
TOCTitle: <SmoothStreamingMedia>
ms:assetid: 958229a6-94d5-4fd5-929b-163a7d1e76bb
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee673438(v=VS.90)
ms:contentKeyID: 26179481
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Client Manifest - SmoothStreamingMedia Element

Specifies metadata for this Smooth Streaming media presentation.

    <SmoothStreamingMedia 
          MajorVersion="0" 
          MinorVersion="0" 
          Duration="0" 
          TimeScale="0"
          IsLive="0"
          LookaheadCount="0"
          DVRWindowLength="0">
    </SmoothStreamingMedia>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|--- |--- |
|**MajorVersion**|(Required) Specifies the Client Manifest Major Version.|
|**MinorVersion**|(Required)Specifies the Client Manifest Minor Version.|
|**TimeScale**|(Optional) Specifies timescale for the entire presentation as a number of unites that pass in one second. The recommended value is 10,000,000 which maps to increments of 100ns. 10,000,000 is the default if this attribute is omitted.|
|**Duration**|(Required) Specifies overall presentation duration of the media in increments of the TimeScale attribute. Duration should be set to 0 for live presentations whose approximate duration is not known in advance.|
|**IsLive**|(Optional) Specifies when the attribute value is, "**true**" (case-insensitive) that this manifest describes a live presentation that is still in progress. When this attribute is set to "**true**" the duration is interpreted as an approximation, and it is permissible for the presentation to end before or after the expected duration (for instance, if a sports event goes into "overtime"). For On-Demand presentations, this attribute should be omitted.|
|**LookaheadCount**|(Optional) Specifies the number of fragments in a lookahead.|
|**DVRWindowLength**|(Optional) Specifies the length of the trailing window for a 24/7 broadcast.|


### Child Elements

|Element|Description|
|--- |--- |
|**StreamIndex**|Specifies the metadata for one type of track (audio, video, or text).|
|**Protection**|Container for content protection playback info.|


### Parent Elements

None

## Example

The following is an example of a Live Server Manifest.

    <?xml version="1.0" encoding="UTF-8"?>
    <SmoothStreamingMedia MajorVersion="2" 
          MinorVersion="0" Duration="2300000000" TimeScale="10000000">
       <CustomAttributes>
           <Attribute Name = "timeScaleZeroPoint" Value = "..." />
       </CustomAttributes>
       <Protection>
          <ProtectionHeader SystemID="{9A04F079-9840-4286-AB92E65BE0885F95}">
          Base-64 Encoded Data
          </ProtectionHeader>
       </Protection>
       <!-- <StreamIndex Type="video"> 
             describes the video streams available at each quality level-->
       <StreamIndex
         Type = "video"
         Chunks = "115"
         QualityLevels = "6"
         MaxWidth = "720"
         MaxHeight = "480"
         TimeScale="10000000"
         Url="QualityLevels({bitrate},{CustomAttributes})/Fragments(video={start_time})"
          Name = "video">
         <QualityLevel Index="0" Bitrate="1536000" FourCC="WVC1" 
            MaxWidth="720" MaxHeight="480"
            CodecPrivateData = "270000010FCBEE1670EF8A16783BF180C9089CC4AFA11C0000010E1207F840" > 
             <CustomAttributes>
                <Attribute Name = "hardwareProfile" Value = "10000" />
             </CustomAttributes>
          </QualityLevel>
          <QualityLevel Index="1" Bitrate="1536000" FourCC="WVC1"    
                        MaxWidth="720" MaxHeight="480" 
                        CodecPrivateData = "270000010FCBEE1670EF8A16783BF180C9089CC4AFA11C0000010E1207F840" > 
             <CustomAttributes>
                <Attribute Name = "hardwareProfile" Value = "1000" />
             </CustomAttributes>
          </QualityLevel>
          <QualityLevel Index="2" Bitrate="1024000" FourCC="WVC1" 
             MaxWidth="720" MaxHeight="480"
             CodecPrivateData = "270000010FCBEE1670EF8A16783BF180C9089CC4AFA11C0000010E1207F840"> 
             <CustomAttributes>
                <Attribute Name = "hardwareProfile" Value = "1000" />
             </CustomAttributes>
          </QualityLevel>
       <!-- Additional quality levels, up to a total of ‘QualityLevels’     
            attribute, last one below -->
          <QualityLevel Index="5" Bitrate="307200" FourCC="WVC1" 
             MaxWidth="720" MaxHeight="480" 
             CodecPrivateData = "270000010FCBEE1670EF8A16783BF180C9089CC4AFA11C0000010E1207F840"> 
             <CustomAttributes>
                <Attribute Name = "hardwareProfile" Value = "1000" />
             </CustomAttributes>
          </QualityLevel>
          <!-- fragment boundary definitions: specify the duration of
               each fragment in TimeScale increments (default is 100nsec) -->
           <c n="0" d="19680000"> 
           <!-- fragment boundary definitions: specify the duration
                of each fragment in TimeScale increments (default is    
                100nsec) -->
        
                       <f i="0" s="1525" q="2122"/> 
                       <f i="1" s="1406" q="1640"/> 
                       <f i="2" s="1217" q="875"/> 
                       <f i="3" s="1107" q="1428"/> 
                       <f i="4" s="607" q="928"/> 
                       <f i="5" s="407" q="428"/>
          </c>
          <c n="1" d="8980000"> 
                       <f i="0" s="1525" q="2122"/> 
                       <f i="1" s="1406" q="1640"/>
                       <f i="2" s="1217" q="875"/>
                       <f i="3" s="1107" q="1428"/>
                       <f i="4" s="607" q="928"/>
                      <f i="5" s="407" q="428"/>
          </c>
          ... <!-- fragment definitions omitted -->
          <c n="114" d="50680000"> 
                       <f i="0" s="1525" q="2122"/> 
                       <f i="1" s="1406" q="1640"/> 
                       <f i="2" s="1217" q="875"/> 
                       <f i="3" s="1107" q="1428"/> 
                       <f i="4" s="607" q="928"/> 
                       <f i="5" s="407" q="428"/> 
                    </c>
          <!-- end fragment definitions -->
    </StreamIndex>
    <!-- a stream of pictures designed to provide film-strip navigation
        (Zoetrope) around the presentation -->
    <StreamIndex 
      Type = "video" 
      ParentStreamIndex = "video"
      Subtype = "ZOET" 
      FourCC = "JPEG"
      MaxWidth = "100"
      MaxHeight = "100"
      Url = "QualityLevels({bitrate})/Fragments(zoetrope={start_time})" 
      Name="zoetrope">
      <QualityLevel Index = "0" Bitrate = "0" />
      <!-- this data is much sparser - every 10 seconds or so -->
      <c t = "0"/>
      <c t = "100000000" />
      <c t = "200000000" />
      <!-- additional data omitted for clarity -->
    </StreamIndex>
    
    <StreamIndex Type = "text" ParentStreamIndex = "video" 
       ManifestOutput = "true" Subtype = "CTRL" 
       Url = "QualityLevels({bitrate})/Fragments(control={start_time})" 
       Name = "control">
       <QualityLevel Index = "0" Bitrate = "0" />
       <c t = "0">
        <!-- data is a Base64-encoded version of:
        <AdInsert Type = "midroll" Duration = "30s" Time = "250000000"/>-->
          <f i = "0"> PEFkSW5zZXJ0IFR5cGUgPSAibWlkcm9sbCIgRHVyYXRpb24gPSAiMzBzIiBUaW1l
    ID0gIjI1MDAwMDAwMCIgLz4=
          </f>
       </c>
    </StreamIndex>
       <!-- <StreamIndex Type="audio"> describes the audio streams 
         available at each bitrate-->
    
    <StreamIndex
       Type = "audio"
       Chunks = "147"
       Language = "eng"
       QualityLevels = "1"
       TimeScale="10000000"
       Url = "QualityLevels({bitrate},{CustomAttributes})/Fragments(audio={start_time})" 
       >
    
       <QualityLevel Index="0" Bitrate="94208" FourCC="WMA2"   
           SamplingRate="48000" Channels="2" BitsPerSample="16"
           PacketSize="1115" HardwareProfile="1000"
           CodecPrivateData= 6101020044AC0000853E00009D0B10000A00008800000F0000000000"/>
    
    
       <!-- fragment boundary definitions: specify the duration of
            each fragment in TimeScale increments -->
       <c n="0" d="18770000"><f i="0" s="45"/></c>
       <c n="1" d="18840000"><f i="0" s="41"/></c>
       <c n="146" d="9290000"><f i="0" s="41"/></c>
       <!-- end fragment boundary definitions -->
    </StreamIndex>
    
       <!-- Additional audio and video feeds can be made available by
         adding <StreamIndex Type="audio" Name="..."> and 
           <StreamIndex Type="video" Name="...">
         tags to this manifest and adding an additional Name attribute 
         that discriminates for the default video/audio feed. E.g.:
           <StreamIndex Type="video" Name="alternate-angle"> ... 
       -->
    
    <!-- specifies a script-stream [Type="Text" Subtype="SCMD"]
    The absence of a Url attribute and presence of a <Content    >
    element indicates that the content is embedded in the manifest
    rather than requested in fragments from the server
    -->
    <StreamIndex Type="text" Subtype="CAPT" Name="captions ">
       <QualityLevel Index = "0" FourCC = "DFXP" />
       <c t = "0" />
       <c t = "20000000" />
       <c t = "40000000" />
       <!-- additional fragments omitted for clarity -->
    </StreamIndex>
    
    <StreamIndex Type="text" Subtype="SCMD" Language="en-us" 
       TimeScale="10000000" >
       <Content>
          <ScriptCommand Time="REFERENCE_TIME" 
             Type="Some string" Command="some string"/> 
          <ScriptCommand Time="REFERENCE_TIME2" 
             Type="Some string2" Command="some string2"/> 
       </Content>
    </StreamIndex>
    
    <!-- specifies markers/chapters [Type="Text" Subtype="CHAP"]
    The absence of a Url attribute and presence of a <Content    >
    element indicates that the content is embedded in the manifest
    rather than requested in fragments from the server
    -->
    
    <StreamIndex Type="text" Subtype="CHAP" Language="eng" 
       TimeScale="10000000">
       <Content>
          <Marker Time="REFERENCE_TIME" Value="some string" />
          <Marker Time="REFERENCE_TIME" Value="some string" />
       </Content>
    </StreamIndex>
    </SmoothStreamingMedia>

## See Also

### Concepts

[IIS Smooth Streaming Client Manifest Format](iis-smooth-streaming-client-manifest-format.md)

