---
title: "Understanding IIS Request Restrictions on Windows Client OS"
author: atsushina
description: "IIS on Windows client returns 403.9 error message Access Forbidden: Too many users are connected"
ms.date: 04/09/2016
ms.assetid: 47e92ace-e368-4af1-b1ed-0a474172a177
msc.type: authoredcontent
---

# IIS Request Restrictions on Windows Client OS

IIS on Windows XP:

* Can quickly exceed it's connection limit.
* Has a maximum of 10 concurrent connections before an [HTTP 403.9](https://en.wikipedia.org/wiki/HTTP_403) error message is returned. HTTP 403.9 returns Access Forbidden: Too many users are connected.

The major limitation on Windows Client OS for IIS 7.x and later is the number of concurrent requests IIS can execute. This limitation is fundamentally different from the Windows XP connection limit. The HTTP 403.9 error is unlikely to occur when concurrent requests are limited. Requests that cannot be handled because the concurrent request limit is reached are queued.

If the request queue overflows, a [500 Internal Server Error](https://developer.mozilla.org/docs/Web/HTTP/Status/500) is returned. The request queue can handle thousands of requests by default. Too many concurrent requests doesn't generate an error, but generally slows response time.

Windows Server OS doesn't have these request restrictions.

The maximum concurrent requests IIS 7.x and later allows on Windows Client OS SKUs:

Windows 10 – IIS 10.0 Concurrent Requests Limit

|  Edition  |  limit  |
| ----------------- | ------------ |
|  Home |  3  |
|  Professional |  10  |
|  Enterprise |  10  |

Windows 10 IoT – IIS 10.0 Concurrent Requests Limit

|  Edition  |  limit  |
| ----------------- | ------------ |
|  Enterprise 2016  |  10  |
|  Enterprise 2019  |  10  |

Windows 8.1 – IIS 8.5 Concurrent Requests Limit

|  Edition  |  limit  |
| ----------------- | ------------ |
|  Basic  |  3  |
|  Professional |  10  |
|  Enterprise |  10  |

Windows 8 – IIS 8 Concurrent Requests Limit

|  Edition  |  limit  |
| ----------------- | ------------ |
|  Basic  |  3  |
|  Professional |  10  |
|  Enterprise |  10  |

Windows 7 - IIS 7.5 Concurrent Requests Limit

|  Edition  |  limit  |
| ----------------- | ------------ |
|  Home Starter  |  1  |
|  Basic  |  1  |
|  Home Premium  |  3  |
|  Professional |  10  |
|  Ultimate |  10  |
|  Enterprise |  10  |

Windows Vista - IIS 7.0 Concurrent Requests Limit

|  Edition  |  limit  |
| ----------------- | ------------ |
|  Home Basic  |  3  |
|  Home Premium |  3  |
|  Professional |  10  |
|  Ultimate |  10  |
|  Enterprise |  10  |
