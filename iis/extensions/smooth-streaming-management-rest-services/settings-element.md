---
title: Settings Element
TOCTitle: Settings Element
ms:assetid: 584b7887-da08-4964-bed5-e0399719ed89
ms:mtpsurl: https://msdn.microsoft.com/library/Hh206009(v=VS.90)
ms:contentKeyID: 35990943
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Settings Element

Represents all available settings for a Live Smooth Streaming publishing point instance.

```xml
<Settings>
  <Title />
  <SourceType />
  <EstimatedDuration />
  <AutoStart />
  <AutoRestartOnEncoderReconnect />
  <LookAheadChunks />
  <Archive>
    <SegmentLength />
    <Path />
  </Archive>
  <ClientConnections>
    <WindowLength />
    <LiveCacheLength />
    <ClientManifestVersion />
  </ClientConnections>
  <ServerConnections>
    <SendEndOfStreamOnStop />
  </ServerConnections>
  <PullFrom> | <PushTo>
    <PublishingPoints />
  </PullFrom> | </PushTo>
  <Modules>
    <Module />
  </Modules>
</Settings>
```

### Child Elements

[Title Element](title-element.md)  
[SourceType Element](sourcetype-element.md)  
[EstimatedDuration Element](estimatedduration-element.md)  
[AutoStart Element](autostart-element.md)  
[AutoRestartOnEncoderReconnect Element](autorestartonencoderreconnect-element.md)  
[LookAheadChunks Element](lookaheadchunks-element.md)  
[Archive Element](archive-element.md)  
[ClientConnections Element](clientconnections-element.md)  
[ServerConnections Element](serverconnections-element.md)  
[PullFrom Element](pullfrom-element.md)  
[PushTo Element](pushto-element.md)  
[Modules Element](modules-element.md)

### Parent Element

[SmoothStreaming Element](smoothstreaming-element.md)

### Example

```xml
<?xml version="1.0" encoding="UTF-8" ?>
  <entry xmlns="http://www.w3.org/2005/Atom">
  <id>http://shl-s08r2:443/bunny.isml/settings</id>
  <title>bunny</title>
    <author>
    <name />
  </author>
  <updated>2011-05-26T17:05:24Z</updated>
  <link href="https://shl-s08r2:443/bunny.isml/settings" rel="self" type="application/atom+xml" title="Publishing Point Settings" />
  <link href="https://shl-s08r2:443/bunny.isml/state" rel="related" type="application/atom+xml" title="Publishing Point State" />
    <content type="application/xml">
      <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
        <Settings>
        <Title>bunny</Title>
        <SourceType>Push</SourceType>
        <AutoStart>true</AutoStart>
        <AutoRestartOnEncoderReconnect>false</AutoRestartOnEncoderReconnect>
        <LookAheadChunks>2</LookAheadChunks>
          <Archive enabled="true">
          <Path useEventIdOnPath="false" />
        </Archive>
          <ClientConnections enabled="true">
          <ClientManifestVersion>2.0</ClientManifestVersion>
        </ClientConnections>
          <ServerConnections enabled="true">
          <SendEndOfStreamOnStop>true</SendEndOfStreamOnStop>
        </ServerConnections>
      </Settings>
    </SmoothStreaming>
  </content>
</entry>
```
