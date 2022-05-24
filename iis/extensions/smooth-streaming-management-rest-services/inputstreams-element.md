---
title: InputStreams Element
description: Describes the InputStreams element, which provides summary information about live Smooth Streams, and details its child elements and parent elements.
TOCTitle: InputStreams Element
ms:assetid: 3fb98cb2-036a-43e6-939e-ba83892df9ee
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547034(v=VS.90)
ms:contentKeyID: 37836875
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# InputStreams Element

Provides summary information about the Smooth Streams that are received from all live sources, such as encoders or other Live Smooth Streaming publishing points.

```xml
<InputStreams>
  <InputStream>
    <State />
    <ArchiveFileName />
    <Sources>
      <Source />
    </Sources>
    <Sinks>
      <Sink />
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
</InputStreams>
```

### Child Elements

[InputStream Element](inputstream-element.md)

### Parent Element

[Statistics Element](statistics-element.md)
