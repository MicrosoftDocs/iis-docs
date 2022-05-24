---
title: InputStream Element
description: Describes the InputStream element and details the element's attributes, child elements, and parent element.
TOCTitle: InputStream Element
ms:assetid: 8c8fdfa3-cb65-4c5c-ae53-e86c981ca857
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547050(v=VS.90)
ms:contentKeyID: 37836891
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# InputStream Element

Provides summary information about a Smooth Stream input stream.

```xml
<InputStream id=identifier>
  <State />
  <ArchiveFileName />
  <Sources>
    <Source>
      <Properties>
        <Property />
      </Properties>
    </Source>
  </Sources>
  <Sinks>
    <Sink>
      <Properties>
        <Property />
      </Properties>
    </Sink>
  </Sinks>
  <Tracks>
    <Track>
      <Name />
      <EncodedBitRate />
      <IncomingBitRate />
      <IncomingFragmentWaitTime />
      <IncomingFragmentTimeStamp />
      <IncomingFragmentDuration />
      <RequestRate />
    </Track>
  </Tracks>
</InputStream>
```

### Attributes

|Attribute|Description|
|--- |--- |
|id|Required. Specifies an identifier for the input stream.|

### Child Elements

[State Element (InputStream)](state-element-inputstream.md)  
[ArchiveFileName Element](archivefilename-element.md)  
[Sources Element (Sources)](sources-element-sources.md)  
[Sinks Element](sinks-element.md)  
[Tracks Element](tracks-element.md)

### Parent Element

[InputStreams Element](inputstreams-element.md)
