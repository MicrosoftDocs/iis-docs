---
title: Query Publishing Point Settings
TOCTitle: Query Publishing Point Settings
ms:assetid: b26b9f05-4350-456f-8aee-33aaec45b193
ms:mtpsurl: https://msdn.microsoft.com/library/Hh206012(v=VS.90)
ms:contentKeyID: 35990946
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Query Publishing Point Settings

The Query Publishing Point Settings operation retrieves settings for a specific publishing point. All available settings are retrieved in a single call in order to allow for symmetric create and update calls that configure the whole publishing point in single request.

## Restrictions

None. Publishing points can be in any state while performing this operation.

## Publishing point state after successful operation

This operation does not change the publishing point state.

## Request

The Query Publishing Point Settings request may be specified as follows:

|Method|URI|
|--- |--- |
|GET|http(s)://<hostname>/<filepath>/settings|

### URI Parameters

The following table lists URL template segments and parameters.

|Parameter|Description|Example|
|--- |--- |--- |
|hostname|The host name.|Contoso.com|
|filepath|The path of the publishing point file.|media/bunny.isml|

### Request Body

None.

## Response

The response includes an HTTP status code and a response body.

### Status Code

A successful operation returns status code 200 (OK). For information about error status codes, see [Service Management Status and Error Codes](service-management-status-and-error-codes.md).

### Response Body

The following example shows the format of the response body. For information of element values and attribute values, see [SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md).

```xml
<?xml version="1.0" encoding="UTF-8"?>
<entry xmlns="http://www.w3.org/2005/Atom">
  <id>unique-ID</id>
  <title>title</title>
  <author>
    <name />
  </author>
  <updated>2011-06-16T18:32:46Z</updated>
  <link href="http://host-name/.isml-file-path/settings" rel="self" type="application/atom+xml" title="Settings" />
  <link href="http://host-name/.isml-file-path/state" rel="related" type="application/atom+xml" title="State" />
  <content type="application/xml">
    <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
      <Settings>
        <Title>title</Title>
        <SourceType>Push|Pull</SourceType>
        <AutoStart>true|false</AutoStart>
        <AutoRestartOnEncoderReconnect>true|false</AutoRestartOnEncoderReconnect>
        <LookAheadChunks>look-ahead-chunks</LookAheadChunks>
        <Archive enabled="true|false">
          <Path useEventIdOnPath="true|false" />
        </Archive>
        <ClientConnections enabled="true|false">
          <ClientManifestVersion>client-manifest-version</ClientManifestVersion>
        </ClientConnections>
        <ServerConnections enabled="true|false">
          <SendEndOfStreamOnStop>true|false</SendEndOfStreamOnStop>
        </ServerConnections>
      </Settings>
    </SmoothStreaming>
  </content>
</entry>
```

The following example shows a response body.

```xml
<?xml version="1.0" encoding="UTF-8"?>
<entry xmlns="http://www.w3.org/2005/Atom">
  <id>http://contoso.com/bunny.isml/settings</id>
  <title>Bunny</title>
  <author>
    <name />
  </author>
  <updated>2011-06-16T18:32:46Z</updated>
  <link href="http://contoso.com/bunny.isml/settings" rel="self" type="application/atom+xml" title="Settings" />
  <link href="http://contoso.com/bunny.isml/state" rel="related" type="application/atom+xml" title="State" />
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
      </Settings>
    </SmoothStreaming>
  </content>
</entry>
```

## Authorization

The authenticated user must have read access to the .isml file.
