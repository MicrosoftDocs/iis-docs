---
title: Create a New Publishing Point
TOCTitle: Create a New Publishing Point
ms:assetid: 30f3f6e1-214b-4e8f-8e81-1c1a62182c18
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh206008(v=VS.90)
ms:contentKeyID: 35990942
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Create a New Publishing Point

The Create a New Publishing Point operation creates a new publishing point on the current Web site. If the specified path doesn’t exist it will be created as part of the publishing point creation.

## Restrictions

The publishing point must not exist prior to the operation.

## Publishing point state after successful operation

This operation does not change the publishing point state.

## Request

The Create a New Publishing Point request may be specified as follows:

|Method|URI|
|--- |--- |
|POST|http(s)://<hostname>/services/smoothstreaming/publishingpoints.isml/settings|


### URI Parameters

The following table lists URL template segments and parameters.

|Parameter|Description|Example|
|--- |--- |--- |
|hostname|The host name.|Contoso.com|


### Request Headers

The following table describes required and optional request headers.

|Request Header|Description|Format|
|--- |--- |--- |
|Slug|Required. Specifies the path for the file to be created. For more information about the Slug header, see the Slug header section in the IETF’s [The Atom Syndication Format](http://bitworking.org/projects/atom/rfc5023.html).|Slug: /<path>/<filename.isml>|

### Request Body

The following example shows the format of the request body. For information of element values and attribute values, see [SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md).

    <?xml version="1.0" encoding="UTF-8"?>
    <entry xmlns="http://www.w3.org/2005/Atom">
      <id>unique-ID</id>
      <title>title</title>
      <updated>time-stamp</updated>  
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

The following example shows a request body.

    <?xml version="1.0" encoding="UTF-8"?>
    <entry xmlns="http://www.w3.org/2005/Atom">
      <id>http://contoso.com/media/bunny.isml/settings</id>
      <title>Bunny</title>
      <updated>2011-05-31T21:32:26Z</updated>
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

## Response

The response includes an HTTP status code and a response body.

### Status Code

A successful operation returns status code 201 (Created). For information about error status codes, see [Service Management Status and Error Codes](service-management-status-and-error-codes.md).

### Response Body

The response body is the same as the request body unless an invalid input element value or attribute value is changed by the service. The format of the response body is the publishing point settings after the operation is completed. The following example shows the format of a response body.

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

The following example shows a response body.

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
          </Settings>
        </SmoothStreaming>
      </content>
    </entry>

## Authorization

The user must have write access to the specified folder.

## Remarks

None.

## See Also

#### Concepts

[SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md)

