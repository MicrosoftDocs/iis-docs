---
title: Getting Started with IIS Smooth Streaming Management REST Services
TOCTitle: Getting Started with IIS Smooth Streaming Management REST Services
ms:assetid: e1d82b65-f608-40b3-bf3a-ee651029ee38
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh239769(v=VS.90)
ms:contentKeyID: 35957236
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Getting Started with IIS Smooth Streaming Management REST Services

The IIS Smooth Streaming Management REST Services Application Programming Interface (API) is a Representational State Transfer (REST) API that you can use to manage Live Smooth Streaming publishing points in IIS Media Services version 4.1 or later.

The Smooth Streaming Management REST Services API provides programmatic access to much of the functionality available through the Live Smooth Streaming Publishing Points icon in the Media Services area of IIS Manager. Using the Smooth Streaming Management REST Services API, you can create or delete publishing points; enumerate the publishing points on a Web site; query the setting, state, or statistics of a publishing point; or update the state of a publishing point.

XML elements that form the request body and response body of Smooth Streaming REST Services publishing point management are defined in the SmoothStreaming schema, [SmoothStreaming.xsd](https://go.microsoft.com/fwlink/?linkid=231871). For more information see the [SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md).

## Using the IIS Smooth Streaming Management REST Services

The following table lists operations that can be performed using the IIS Smooth Streaming Management REST Services publishing point management.

|Operation|Description|
|--- |--- |
|[Create a New Publishing Point](create-a-new-publishing-point.md)|Creates a new publishing point on the current Web site.|
|[Delete a Publishing Point](delete-a-publishing-point.md)|Deletes an existing publishing point.|
|[Enumerate Web Site Publishing Points](enumerate-web-site-publishing-points.md)|Enumerates all publishing points on the current Web site.|
|[Enumerate Web Site Publishing Points with Details](enumerate-web-site-publishing-points-with-details.md)|Enumerates all publishing points on the current Web site, including publishing point details.|
|[Query Publishing Point Settings](query-publishing-point-settings.md)|Retrieves settings for a specific publishing point.|
|[Query Publishing Point State](query-publishing-point-state.md)|Retrieves the state for a publishing point.|
|[Query Publishing Point Statistics](query-publishing-point-statistics.md)|Retrieves statistics for a specific publishing point.|
|[Update Publishing Point Settings](update-publishing-point-settings.md)|Updates the settings for an existing publishing point.|
|[Update Publishing Point State](update-publishing-point-state.md)|Updates the state of an existing publishing point.|

