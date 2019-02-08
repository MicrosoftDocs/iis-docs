---
title: Enumerate Web Site Publishing Points with Details
TOCTitle: Enumerate Web Site Publishing Points with Details
ms:assetid: 369a196a-7a42-49f6-828d-83e6ad8f348f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh239764(v=VS.90)
ms:contentKeyID: 35957231
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Enumerate Web Site Publishing Points with Details

The Enumerate Web Site Publishing Points with Details operation enumerates all publishing points on the current Web site. Details for the publishing points are included in the feed.

## Restrictions

None. Publishing points can be in any state while performing this operation.

## Publishing point state after successful operation

This operation does not change the publishing point state.

## Request

The Enumerate Web Site Publishing Points with Details request may be specified as follows:

|Method|URI|
|--- |--- |
|GET|http(s)://<hostname>/services/smoothstreaming/publishingpoints.isml/settings|


### URI Parameters

The following table lists URL template segments and parameters.

|Parameter|Description|Example|
|--- |--- |--- |
|hostname|The host name.|Contoso.com|

### Request Body

None.

## Response

The response includes an HTTP status code and a response body.

### Status Code

A successful operation returns status code 200 (OK). For information about error status codes, see [Service Management Status and Error Codes](service-management-status-and-error-codes.md).

### Response Body

The following example shows the format of the response body after the operation is completed. For information of element values and attribute values, see [SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md).

    <?xml version="1.0" encoding="UTF-8"?>
    <feed xmlns="http://www.w3.org/2005/Atom">
      <author>
        <name></name>
      </author>
      <title>Publishing Point Collection</title>
      <updated>time-stamp</updated>
      <entry>
        <id>unique-ID</id>
        <title>title</title>
        <updated>time-stamp</updated>
        <link href="http://host-name/.isml-file-path/settings" rel="self" type="application/atom+xml" title="Settings" />
        <link href="http://host-name/.isml-file-path/state" rel="related" type="application/atom+xml" title="State" />
        <content type="application/xml">
          <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
            <Settings>
              <Title>title</Title>
              <SourceType>Push|Pull</SourceType>
              <AutoStart>true|false</AutoStart>
              <AutoRestartOnEncoderReconnect>false</AutoRestartOnEncoderReconnect>
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
        <!-- Addition Entries -->
    </feed>

The following example shows a response body.

    <?xml version="1.0" encoding="UTF-8"?>
    <feed xmlns="http://www.w3.org/2005/Atom">
      <author>
        <name></name>
      </author>
      <title>Publishing Point Collection</title>
      <updated>2011-06-16T18:32:48.158Z</updated>
      <entry>
        <id>http://contoso.com/TestElephant/settings</id>
        <title>Bunny</title>
        <updated>2011-06-16T18:32:47Z</updated>
        <link href="http://contoso.com/TestElephant/settings" rel="self" type="application/atom+xml" title="Settings" />
        <link href="http://contoso.com/TestElephant/state" rel="related" type="application/atom+xml" title="State" />
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
      <entry>
        <id>http://contoso.com/testBunny.isml/settings</id>
        <title>Bunny</title>
        <updated>2011-06-16T18:32:46Z</updated>
        <link href="http://contoso.com/testBunny.isml/settings" rel="self" type="application/atom+xml" title="Settings" />
        <link href="http://contoso.com/testBunny.isml/state" rel="related" type="application/atom+xml" title="State" />
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
    </feed>

## Authorization

Only elements that the authenticated user has read access to for the publishing point are returned in the feed. Elements that the user does not have read access to are silently ignored and no error is returned.

## See Also

#### Concepts

[SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md)

