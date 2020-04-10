---
title: Service Management Status and Error Codes
TOCTitle: Service Management Status and Error Codes
ms:assetid: b6cd719c-0af5-416c-a92d-3953670974d8
ms:mtpsurl: https://msdn.microsoft.com/library/Hh204601(v=VS.90)
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

|Error code|HResult|Status code|Message|
|--- |--- |--- |--- |
|MPE_MGMT_METHOD_NOT_ALLOWED|0x80880020L|Method Not Allowed (405)|The HTTP method for the request is not allowed for the requested resource.|
|MPE_MGMT_CONTENT_TYPE_NOT_SUPPORTED|0x80880021L|Unsupported Media Type (415)|The Content Type header value of the request is either missing or not supported.|
|MPE_MGMT_AUTHENTICATION_IS_REQUIRED|0x80880022L|Unauthorized (401)|All requests to the management APIs must be authenticated. Please install and enable an appropriate IIS authentication module for this website.|
|MPE_MGMT_ACCESS_DENIED|0x80880023L|Unauthorized (401)|The authenticated user does not have the access level that is required in order to complete this operation.|
|MPE_MGMT_INVALID_SCHEMA|0x80880024L|Bad Request (400)|The resource is not valid according to its schema. For information about valid resource representations, please see the documentation for the supported schemas.|
|MPE_MGMT_INVALID_XML|0x80880025L|Bad Request (400)|The resource representation is not valid XML. Please make sure the resource representation is a valid XML document.|
|MPE_MGMT_INVALID_DATA|0x80880026L|Bad Request (400)|The resource contains one or more elements that contain invalid data. For information about valid resource representations, please see the documentation for the supported schemas.|
|MPE_MGMT_STATE_TRANSITION_NOT_SUPPORTED|0x80880027L|Bad Request (400)|The requested publishing point state is an internal state only and cannot be set via an API call. For information about valid state transitions, please refer to the API documentation.|
|MPE_MGMT_STATE_TRANSITION_INVALID|0x80880028L|Bad Request (400)|The publishing point cannot change from its current state to the requested one. For information about valid state transitions, please refer to the API documentation.|
|MPE_MGMT_PUBLISHING_POINT_IN_USE|0x80880029L|Bad Request (400)|The requested operation cannot be completed while the publishing point is in use. Please make sure the publishing point is in "Idle" state before attempting this operation.|
|MPE_MGMT_PUBLISHING_POINT_LOCKED|0x8088002AL|Bad Request (400)|The requested operation could not be completed because a conflicting operation was in progress. Please try again.|
|MPE_MGMT_PUBLISHING_POINT_ALREADY_EXISTS|0x8088002BL|Bad Request (400)|The publishing point already exists.|
|MPE_MGMT_SLUG_HEADER_REQUIRED|0x8088002CL|Bad Request (400)|The HTTP request must contain a Slug header that contains the path for the new publishing point file.|
|MPE_MGMT_SLUG_HEADER_INVALID|0x8088002DL|Bad Request (400)|The path for the publishing point file in the Slug header is not valid.|
|MPE_MGMT_PUBLISHING_POINT_NOT_STARTED|0x8088002FL|Bad Request (400)|The publishing point is not started.|
|MPE_MGMT_PUBLISHING_POINT_NOT_FOUND|0x8088002EL|Not Found (404)|The publishing point was not found.|
