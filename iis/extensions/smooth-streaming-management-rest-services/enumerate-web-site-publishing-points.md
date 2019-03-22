---
title: Enumerate Web Site Publishing Points
TOCTitle: Enumerate Web Site Publishing Points
ms:assetid: 4f65bb73-3b1f-4845-9427-041456cab8f6
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh239766(v=VS.90)
ms:contentKeyID: 35957233
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Enumerate Web Site Publishing Points

The Enumerate Web Site Publishing Points operation enumerates all publishing points on the current Web site. Details for the publishing points are not present in the feed, but links with related resources are included for discoverability and navigation.

## Restrictions

None. Publishing points can be in any state while performing this operation.

## Publishing point state after successful operation

This operation does not change the publishing point state.

## Request

The Enumerate Web Site Publishing Points request may be specified as follows:

|Method|URI|
|--- |--- |
|GET|http(s)://<hostname>/services/smoothstreaming/publishingpoints.isml|


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

The following example shows the format of the response body after the operation is completed.

    <?xml version="1.0" encoding="UTF-8"?>
    <feed xmlns="http://www.w3.org/2005/Atom">
      <author>
        <name>name</name>
      </author>
      <title>Publishing Point Collection</title>
      <updated>time-stamp</updated>
      <entry>
        <id>unique-ID</id>
        <title>title</title>
        <updated>2011-06-15T18:42:13Z</updated>
        <link href="http://host-name/.isml-file-path/settings" rel="related" type="application/atom+xml" title="Settings" />
        <link href="http://host-name/.isml-file-path/state" rel="related" type="application/atom+xml" title="State" />
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
      <updated>2011-06-15T18:42:17.993Z</updated>
      <entry>
        <id>http://contoso.com/myvideos/bunny.isml/settings</id>
        <title>Big Buck Bunny</title>
        <updated>2011-06-15T18:42:13Z</updated>
        <link href="http://contoso.com/myvideos/bunny.isml/settings" rel="related" type="application/atom+xml" title="Settings" />
        <link href="http://contoso.com/myvideos/bunny.isml/state" rel="related" type="application/atom+xml" title="State" />
      </entry>
      <entry>
        <id>http://contoso.com/myvideos/elephant.isml/settings</id>
        <title>Elephant's Dream</title>
        <updated>2011-06-15T18:42:06Z</updated>
        <link href="http://contoso.com/myvideos/elephant.isml/settings" rel="related" type="application/atom+xml" title="Settings" />
        <link href="http://contoso.com/myvideos/elephant.isml/state" rel="related" type="application/atom+xml" title="State" />
      </entry>
    </feed>

## Authorization

Only elements that the authenticated user has read access to for the publishing point are returned in the feed. Elements that the user does not have read access to are silently ignored and no error is returned.

## See Also

### Concepts

[SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md)

