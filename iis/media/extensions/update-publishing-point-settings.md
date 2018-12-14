---
title: Update Publishing Point Settings
TOCTitle: Update Publishing Point Settings
ms:assetid: 9b5fd249-e353-4d94-ac83-08757314881b
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh206011(v=VS.90)
ms:contentKeyID: 35990945
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Update Publishing Point Settings

The Update Publishing Point Settings operation updates the settings for an existing publishing point.

When site global configurations (such as the archiving path) are specified, they are stored in the SMIL manifest for the specified publishing point. Properties cannot be changed after the publishing point is started.

## Restrictions


> [!NOTE]
> <P>Publishing point state must be Idle before you can update publishing point settings.</P>



## Publishing point state after successful operation

Idle. This operation does not change the publishing point state.

## Request

The Update Publishing Point Settings request may be specified as follows:

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Method</p></th>
<th><p>URI</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>PUT</p></td>
<td><p>http(s)://&lt;hostname&gt;/&lt;filepath&gt;/settings</p></td>
</tr>
</tbody>
</table>


### URI Parameters

The following table lists URL template segments and parameters.

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 33%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Parameter</p></th>
<th><p>Description</p></th>
<th><p>Example</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>hostname</p></td>
<td><p>The host name.</p></td>
<td><p>Contoso.com</p></td>
</tr>
<tr class="even">
<td><p>filepath</p></td>
<td><p>The path of the publishing point file.</p></td>
<td><p>testBunny.isml</p></td>
</tr>
</tbody>
</table>


### Request Headers

The following table describes required and optional request headers.

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 33%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Request Header</p></th>
<th><p>Description</p></th>
<th><p>Format</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Content-Type</p></td>
<td><p>The content-type must be set to applications/atom+xml</p></td>
<td><p>Content-Type: application/atom+xml</p></td>
</tr>
</tbody>
</table>


### Request Body

The following example shows the format of the request body. For information of element values and attribute values, see [SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md).

    <?xml version="1.0" encoding="UTF-8"?>
    <entry xmlns="http://www.w3.org/2005/Atom">
      <id>unique-ID</id>
      <title>title</title>
      <updated>time-stamp</updated>
      <link href="http(s)://host-name/.isml-file-path/settings" rel="self" type="application/atom+xml" title="Settings" />
      <link href="http(s)://host-name/.isml-file-path/state" rel="related" type="application/atom+xml" title="State" />
      <content type="application/xml">
        <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
          <Settings>
            <Title>title</Title>
            <SourceType>Push</SourceType>
            <AutoStart>true|false</AutoStart>
            <AutoRestartOnEncoderReconnect>true|false</AutoRestartOnEncoderReconnect>
            <LookAheadChunks>number-of-look-ahead-chunks</LookAheadChunks>
            <Archive enabled="true|false">
              <Path useEventIdOnPath="true|false" />
            </Archive>
            <ClientConnections enabled="true|false">
              <ClientManifestVersion>client-manifest-version-number</ClientManifestVersion>
            </ClientConnections>
            <ServerConnections enabled="true|false">
              <SendEndOfStreamOnStop>true|false</SendEndOfStreamOnStop>
            </ServerConnections>
            <Modules>
              <Module id="ID" type="sink|source" name="name">
                <HLS>
                  <SegmentLength>segment-length</SegmentLength>
                  <MaxBitRate>maximum-bit-rate</MaxBitRate>
                  <AllowCaching>true|false</AllowCaching>
                  <BackwardCompatible>true|false</BackwardCompatible>
                  <IncludeCodecs>true|false</IncludeCodecs>
                  <Encryption enabled="true">
                    <Key>Encryption-Key</Key>
                  </Encryption>
                  <Encryption enabled="true|false" />
                </HLS>
              </Module>
            </Modules>
          </Settings>
        </SmoothStreaming>
      </content>
    </entry>

The following example shows a request body.

    <?xml version="1.0" encoding="UTF-8"?>
    <entry xmlns="http://www.w3.org/2005/Atom">
      <id>http://contoso.com/media/bunny.isml/settings</id>
      <title>Bunny</title>
      <updated>2011-05-31T21:32:26Z</updated>
      <link href="http://contoso.com/media/bunny.isml/settings" rel="self" type="application/atom+xml" title="Settings" />
      <link href="http://contoso.com/media/bunny.isml/state" rel="related" type="application/atom+xml" title="State" />
      <content type="application/xml">
        <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
          <Settings>
            <Title>Bunny</Title>
            <SourceType>Push</SourceType>
            <AutoStart>false</AutoStart>
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
             <Modules>
              <Module id="hls" type="sink" name="HTTP Live Streaming">
                <HLS>
                  <SegmentLength>PT10S</SegmentLength>
                  <MaxBitRate>3000000</MaxBitRate>
                  <AllowCaching>false</AllowCaching>
                  <BackwardCompatible>true</BackwardCompatible>
                  <IncludeCodecs>false</IncludeCodecs>
                  <Encryption enabled="true">
                    <Key>8C339AD2F44E4B2B72C95888385221BE</Key>
                  </Encryption>
                </HLS>
              </Module>
            </Modules>
          </Settings>
        </SmoothStreaming>
      </content>
    </entry>

## Response

The response is an HTTP status code.

### Status Code

A successful operation returns status code 200 (OK). For more information about error status codes, see [Service Management Status and Error Codes](service-management-status-and-error-codes.md).

### Response Body

None.

## Authorization

The authenticated user must have write access to the .isml file.

