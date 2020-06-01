---
title: Query Publishing Point State
TOCTitle: Query Publishing Point State
ms:assetid: 60bb6b60-4909-416d-9183-1afede0cb26c
ms:mtpsurl: https://msdn.microsoft.com/library/Hh206010(v=VS.90)
ms:contentKeyID: 35990944
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Query Publishing Point State

The Query Publishing Point State operation retrieves the state for a publishing point.

## Restrictions

None. Publishing points can be in any state while performing this operation.

## Publishing point state after successful operation

This operation does not change the publishing point state.

## Request

The Query Publishing Point State request may be specified as follows:

|Method|URI|
|--- |--- |
|GET|http(s)://\<hostname>/\<filepath>/state|

### URI Parameters

The following table lists URL template segments and parameters.

|Parameter|Description|Example|
|--- |--- |--- |
|hostname|The host name.|Contoso.com|
|filepath|The path of the publishing point file.|MyVideos/bunny.isml|

### Request Body

None.

## Response

The response includes an HTTP status code and a response body.

### Status Code

A successful operation returns status code 200 (OK). For more information about error status codes, see [Service Management Status and Error Codes](service-management-status-and-error-codes.md).

### Response Body

The following example shows the format of the response body after the operation has finished. For information of element values and attribute values, see [SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md).

```xml
<?xml version="1.0" encoding="UTF-8"?>
<entry xmlns="http://www.w3.org/2005/Atom">
  <id>unique ID</id>
  <title>Title</title>
  <author>
    <name />
  </author>
  <updated>time-stamp</updated>
  <link href="http://host-name/.isml-file-path/state" rel="self" type="application/atom+xml" title="State" />
  <link href="http://host-name/.isml-file-path/settings" rel="related" type="application/atom+xml" title="Settings" />

  <content type="application/xml">
    <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
      <State>
        <Value>state-value</Value>
      </State>
    </SmoothStreaming>
  </content>
</entry>
```

The following example shows a response body.

```xml
<?xml version="1.0" encoding="UTF-8"?>
<entry xmlns="http://www.w3.org/2005/Atom">
  <id>http://contoso.com/test1.isml/state</id>
  <title>Bunny</title>
  <author>
    <name />
  </author>
  <updated>2011-06-13T22:08:57.044Z</updated>
  <link href="http://contoso.com/test1.isml/state" rel="self" type="application/atom+xml" title="State" />
  <link href="http://contoso.com/test1.isml/settings" rel="related" type="application/atom+xml" title="Settings" />
  <content type="application/xml">
    <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
      <State>
        <Value>Idle</Value>
      </State>
    </SmoothStreaming>
  </content>
</entry>
```

## Authorization

The authenticated user must have read access to the publishing point .isml file.
