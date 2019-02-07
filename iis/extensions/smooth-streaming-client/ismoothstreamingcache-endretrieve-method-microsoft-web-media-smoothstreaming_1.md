---
title: ISmoothStreamingCache.EndRetrieve Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: EndRetrieve Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.EndRetrieve(System.IAsyncResult)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache.endretrieve(v=VS.95)
ms:contentKeyID: 46307671
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.EndRetrieve
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.EndRetrieve
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ISmoothStreamingCache.EndRetrieve Method

Ends an asynchronous cache response retrieval started by the [BeginRetrieve](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) method.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Function EndRetrieve ( _
    ar As IAsyncResult _
) As CacheResponse
'Usage

Dim instance As ISmoothStreamingCache
Dim ar As IAsyncResult
Dim returnValue As CacheResponse

returnValue = instance.EndRetrieve(ar)
```

``` csharp
CacheResponse EndRetrieve(
    IAsyncResult ar
)
```

``` c++
CacheResponse^ EndRetrieve(
    IAsyncResult^ ar
)
```

``` fsharp
abstract EndRetrieve : 
        ar:IAsyncResult -> CacheResponse 
```

``` jscript
function EndRetrieve(
    ar : IAsyncResult
) : CacheResponse
```

#### Parameters

  - ar  
    Type: [System.IAsyncResult](https://msdn.microsoft.com/en-us/library/ft8a6455\(v=vs.95\))  
    An [IAsyncResult](https://msdn.microsoft.com/en-us/library/ft8a6455\(v=vs.95\)) object.

#### Return Value

Type: [Microsoft.Web.Media.SmoothStreaming.CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)  
An [IAsyncResult](https://msdn.microsoft.com/en-us/library/ft8a6455\(v=vs.95\)) object.

## Remarks

The method will block until done if necessary and may be called on any thread. Simple cache objects must return as quickly as possible. If the caching object takes more than approximately 100 milliseconds, it is likely that the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) will ignore the response.

## Examples

The following code shows an implementation of the EndRetrieve(IAsyncResult) method.

``` 
    public CacheResponse EndRetrieve(IAsyncResult ar)
    {
        ar.AsyncWaitHandle.WaitOne();

        CacheResponse response = null;

        if (keyUrls.ContainsKey(((CacheAsyncResult)ar).strUrl))
        {
            IsolatedStorageFile isoFileArea = IsolatedStorageFile.GetUserStoreForApplication();
            string filename = keyUrls[((CacheAsyncResult)ar).strUrl];

            if (!string.IsNullOrEmpty(filename) && isoFileArea.FileExists(filename))
            {
                IsolatedStorageFileStream stream = 
                    isoFileArea.OpenFile(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                response = new CacheResponse(stream);                    
            }
        }

        if (response != null)
            return response;
        else
            return response = new CacheResponse(0, null, null, null,
                System.Net.HttpStatusCode.NotFound, "Not Found", TimeManager.Now);
    }
```

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[ISmoothStreamingCache Interface](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

