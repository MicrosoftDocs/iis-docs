---
title: Settings Element
TOCTitle: Settings Element
ms:assetid: 584b7887-da08-4964-bed5-e0399719ed89
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh206009(v=VS.90)
ms:contentKeyID: 35990943
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Settings Element

Represents all available settings for a Live Smooth Streaming publishing point instance.

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
      <ServerConnections
        <SendEndOfStreamOnStop />
      </ServerConnections>
      <PullFrom> | <PushTo>
        <PublishingPoints />
      </PullFrom> | </PushTo>
      <Modules>
        <Module />
      </Modules>
    </Settings>

### Child Elements

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="title-element.md">Title Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="sourcetype-element.md">SourceType Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="estimatedduration-element.md">EstimatedDuration Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="autostart-element.md">AutoStart Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="autorestartonencoderreconnect-element.md">AutoRestartOnEncoderReconnect Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="lookaheadchunks-element.md">LookAheadChunks Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="archive-element.md">Archive Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="clientconnections-element.md">ClientConnections Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="serverconnections-element.md">ServerConnections Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="pullfrom-element.md">PullFrom Element</a></p></td>
</tr>
<tr class="odd">
<td><p><a href="pushto-element.md">PushTo Element</a></p></td>
</tr>
<tr class="even">
<td><p><a href="modules-element.md">Modules Element</a></p></td>
</tr>
</tbody>
</table>


### Parent Element

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="smoothstreaming-element.md">SmoothStreaming Element</a></p></td>
</tr>
</tbody>
</table>


### Example

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

