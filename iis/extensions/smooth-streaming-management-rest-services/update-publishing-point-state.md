---
title: Update Publishing Point State
TOCTitle: Update Publishing Point State
ms:assetid: eacf7023-807d-461a-82e0-f4b3bde8def6
ms:mtpsurl: https://msdn.microsoft.com/library/Hh206014(v=VS.90)
ms:contentKeyID: 35990948
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Update Publishing Point State

The Update Publishing Point State operation updates the state of an existing publishing point.

The state value in the XML represents the state for the publishing point to transition to; any transition name or names should not be used. For example, to change the state from Started to Stopped, the state value should be Stopped. The transition name Stopping is not used.

You can set the publishing point state to Idle, Started, or Stopped. Stopping and ShuttingDown are transition states. Started and Error are automatic states — that is, states that the publishing point automatically transitions to.

## Request

The Update Publishing Point State request may be specified as follows:

|Method|URI|
|--- |--- |
|PUT|http(s)://<hostname>/<filepath>/state|

### URI Parameters

URL template segments and parameters.

|Parameter|Description|Example|
|--- |--- |--- |
|hostname|The host name.|Contoso.com|
|filepath|The path of the publishing point file.|MyVideos/bunny.isml|

### Request Headers

The following table describes required and optional request headers.

|Request Header|Description|Format|
|--- |--- |--- |
|Content-Type|Required. Should be set to application/atom+xml.|Content-Type: application/atom+xml|

### Request Body

> [!TIP]  
> The id, title, and author elements are not required for the HTTP POST operation. These elements are required by the [Atom syndication format](http://tools.ietf.org/html/rfc4287) of the IETF.
> The content type element should be set to application/atom+xml.

The following example shows the format of the request body. For information of element values and attribute values, see [SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md).

    <?xml version="1.0" encoding="UTF-8"?>
    <entry xmlns="http://www.w3.org/2005/Atom">
      <id>unique-ID</id>
      <title>title</title>
      <author>
        <name />
      </author>
      <updated>time-stamp</updated>
      <content type="application/xml">
        <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
          <State>
            <Value>Idle|Started|Stopped</Value>
          </State>
        </SmoothStreaming>
      </content>
    </entry>

The following example shows a request body.

    <?xml version="1.0" encoding="UTF-8"?>
    <entry xmlns="http://www.w3.org/2005/Atom">
      <id>http://contoso.com/bunny.isml/state</id>
      <title>Bunny</title>
      <author>
        <name />
      </author>
      <updated>2011-06-01T17:45:21.963Z</updated>
      <link href="http://contoso.com/bunny.isml/state" rel="self" type="application/atom+xml" title="State" />
      <link href="http://contoso.com/bunny.isml/settings" rel="related" type="application/atom+xml" title="Settings" />
      <content type="application/xml">
        <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
          <State>
            <Value>Idle</Value>
          </State>
        </SmoothStreaming>
      </content>
    </entry>

## Response

The response is an HTTP status code.

### Status Code

A successful operation returns status code 200 (OK). For information about error status codes, see [Service Management Status and Error Codes](service-management-status-and-error-codes.md).

### Response Body

None when the operation is successful; otherwise, error information.

## Authorization

The authenticated user must have write access to the publishing point .isml file.
