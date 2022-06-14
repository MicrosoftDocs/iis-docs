---
title: Statistics Element
description: Describes statistic elements, provide the element's syntax, and outlines various child elements and parent elements.
TOCTitle: Statistics Element
ms:assetid: f864df2f-3a35-4571-a312-0a716c092aaf
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547075(v=VS.90)
ms:contentKeyID: 37836916
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Statistics Element

Represents the running statistics for an active Live Smooth Streaming publishing point instance.

```xml
<Statistics>
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
  <OutputStreams>
    <OutputStream>
      <LastOutputFragmentTimestamp />
    </OutputStream>
  </OutputStreams>
</Statistics>
```

### Child Elements

[InputStreams Element](inputstreams-element.md)  
[OutputStreams Element](outputstreams-element.md)

### Parent Element

[SmoothStreaming Element](smoothstreaming-element.md)
