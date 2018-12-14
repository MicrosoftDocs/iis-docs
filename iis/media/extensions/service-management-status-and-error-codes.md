---
title: Service Management Status and Error Codes
TOCTitle: Service Management Status and Error Codes
ms:assetid: b6cd719c-0af5-416c-a92d-3953670974d8
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh204601(v=VS.90)
ms:contentKeyID: 35968610
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Service Management Status and Error Codes

REST API operations for the Service Management API return standard HTTP status codes, as defined in the [HTTP/1.1 Status Code Definitions](http://www.w3.org/protocols/rfc2616/rfc2616-sec10.html). API operations may also return additional error information that is defined by the management service. This additional error information is returned in the response body.

The body of the error response uses the following basic format:

    <?xml version="1.0" encoding="UTF-8"?>
    <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
      <Error>
        <ErrorCode>error-code</ErrorCode>
        <ErrorMessage>error-message</ErrorMessage>
        <InternalError>optional-internal-error-code</InternalError>
      </Error>
    </SmoothStreaming>

The internal error element is optional and is sometimes empty.

The following example shows an error response.

    <?xml version="1.0" encoding="UTF-8"?>
    <SmoothStreaming xmlns="http://schemas.microsoft.com/iis/media/2011/03/streaming/management">
      <Error>
        <ErrorCode>0x8088002E</ErrorCode>
        <ErrorMessage>The publishing point was not found.</ErrorMessage>
        <InternalError>0x80070002</InternalError>
      </Error>
    </SmoothStreaming>

The following table describes errors returned by the management service. If other errors occur, they are returned with the HTTP "Internal Server Error (500)" status code.

<table>
<colgroup>
<col style="width: 25%" />
<col style="width: 25%" />
<col style="width: 25%" />
<col style="width: 25%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Error code</p></th>
<th><p>HResult</p></th>
<th><p>Status code</p></th>
<th><p>Message</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>MPE_MGMT_METHOD_NOT_ALLOWED</p></td>
<td><p>0x80880020L</p></td>
<td><p>Method Not Allowed (405)</p></td>
<td><p>The HTTP method for the request is not allowed for the requested resource.</p></td>
</tr>
<tr class="even">
<td><p>MPE_MGMT_CONTENT_TYPE_NOT_SUPPORTED</p></td>
<td><p>0x80880021L</p></td>
<td><p>Unsupported Media Type (415)</p></td>
<td><p>The Content Type header value of the request is either missing or not supported.</p></td>
</tr>
<tr class="odd">
<td><p>MPE_MGMT_AUTHENTICATION_IS_REQUIRED</p></td>
<td><p>0x80880022L</p></td>
<td><p>Unauthorized (401)</p></td>
<td><p>All requests to the management APIs must be authenticated. Please install and enable an appropriate IIS authentication module for this website.</p></td>
</tr>
<tr class="even">
<td><p>MPE_MGMT_ACCESS_DENIED</p></td>
<td><p>0x80880023L</p></td>
<td><p>Unauthorized (401)</p></td>
<td><p>The authenticated user does not have the access level that is required in order to complete this operation.</p></td>
</tr>
<tr class="odd">
<td><p>MPE_MGMT_INVALID_SCHEMA</p></td>
<td><p>0x80880024L</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The resource is not valid according to its schema. For information about valid resource representations, please see the documentation for the supported schemas.</p></td>
</tr>
<tr class="even">
<td><p>MPE_MGMT_INVALID_XML</p></td>
<td><p>0x80880025L</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The resource representation is not valid XML. Please make sure the resource representation is a valid XML document.</p></td>
</tr>
<tr class="odd">
<td><p>MPE_MGMT_INVALID_DATA</p></td>
<td><p>0x80880026L</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The resource contains one or more elements that contain invalid data. For information about valid resource representations, please see the documentation for the supported schemas.</p></td>
</tr>
<tr class="even">
<td><p>MPE_MGMT_STATE_TRANSITION_NOT_SUPPORTED</p></td>
<td><p>0x80880027L</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The requested publishing point state is an internal state only and cannot be set via an API call. For information about valid state transitions, please refer to the API documentation.</p></td>
</tr>
<tr class="odd">
<td><p>MPE_MGMT_STATE_TRANSITION_INVALID</p></td>
<td><p>0x80880028L</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The publishing point cannot change from its current state to the requested one. For information about valid state transitions, please refer to the API documentation.</p></td>
</tr>
<tr class="even">
<td><p>MPE_MGMT_PUBLISHING_POINT_IN_USE</p></td>
<td><p>0x80880029L</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The requested operation cannot be completed while the publishing point is in use. Please make sure the publishing point is in &quot;Idle&quot; state before attempting this operation.</p></td>
</tr>
<tr class="odd">
<td><p>MPE_MGMT_PUBLISHING_POINT_LOCKED</p></td>
<td><p>0x8088002AL</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The requested operation could not be completed because a conflicting operation was in progress. Please try again.</p></td>
</tr>
<tr class="even">
<td><p>MPE_MGMT_PUBLISHING_POINT_ALREADY_EXISTS</p></td>
<td><p>0x8088002BL</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The publishing point already exists.</p></td>
</tr>
<tr class="odd">
<td><p>MPE_MGMT_SLUG_HEADER_REQUIRED</p></td>
<td><p>0x8088002CL</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The HTTP request must contain a Slug header that contains the path for the new publishing point file.</p></td>
</tr>
<tr class="even">
<td><p>MPE_MGMT_SLUG_HEADER_INVALID</p></td>
<td><p>0x8088002DL</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The path for the publishing point file in the Slug header is not valid.</p></td>
</tr>
<tr class="odd">
<td><p>MPE_MGMT_PUBLISHING_POINT_NOT_STARTED</p></td>
<td><p>0x8088002FL</p></td>
<td><p>Bad Request (400)</p></td>
<td><p>The publishing point is not started.</p></td>
</tr>
<tr class="even">
<td><p>MPE_MGMT_PUBLISHING_POINT_NOT_FOUND</p></td>
<td><p>0x8088002EL</p></td>
<td><p>Not Found (404)</p></td>
<td><p>The publishing point was not found.</p></td>
</tr>
</tbody>
</table>

