# Understanding IIS Request Restrictions on Windows Client OS

You might have run into the IIS connection limit on Windows XP. IIS 5.1 on Windows XP allowed 10 concurrent connections before it displayed a 403.9 error message (Access Forbidden: Too many users are connected). Not too user friendly.

The only restrictions we have on Windows Client OS for IIS 7.x and later is the number of concurrent requests IIS will execute.

This is fundamentally different from the Windows XP connection limit. By limiting concurrent requests you will probably never see an error message.

Request that cannot be handled because the concurrent request limit is reached will still be queued.

There is only a problem if the request queue overflows - a "500 Server Busy" error. The request queue is pretty big though. Thousands of requests by default. The net effect is that the execution of too many concurrent requests will not generate an error but it might slow your server down for a little bit.

Windows Server OS doesn't have any request restrictions.

Here is how many concurrent requests IIS 7.x and later allows on Windows Client OS SKUs:

Windows 10 – IIS 10.0 Concurrent Requests Limit
|  Edition  |  limit  |
| :---- | ----: |
|  Home |  3  |
|  Professional |  10  |
|  Enterprise |  10  |

Windows 10 IoT – IIS 10.0 Concurrent Requests Limit
|  Edition  |  limit  |
| :---- | ----: |
|  Enterprise 2016  |  10  |
|  Enterprise 2019  |  10  |

Windows 8.1 – IIS 8.5 Concurrent Requests Limit
|  Edition  |  limit  |
| :---- | ----: |
|  Basic  |  3  |
|  Professional |  10  |
|  Enterprise |  10  |

Windows 8 – IIS 8 Concurrent Requests Limit
|  Edition  |  limit  |
| :---- | ----: |
|  Basic  |  3  |
|  Professional |  10  |
|  Enterprise |  10  |

Windows 7 - IIS 7.5 Concurrent Requests Limit
|  Edition  |  limit  |
| :---- | ----: |
|  Home Starter  |  1  |
|  Basic  |  1  |
|  Home Premium  |  3  |
|  Professional |  10  |
|  Ultimate |  10  |
|  Enterprise |  10  |

Windows Vista - IIS 7.0 Concurrent Requests Limit
|  Edition  |  limit  |
| :---- | ----: |
|  Home Basic  |  3  |
|  Home Premium |  3  |
|  Professional |  10  |
|  Ultimate |  10  |
|  Enterprise |  10  |
