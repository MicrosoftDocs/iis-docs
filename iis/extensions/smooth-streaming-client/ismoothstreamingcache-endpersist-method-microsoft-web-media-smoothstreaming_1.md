---
title: ISmoothStreamingCache.EndPersist Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: EndPersist Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.EndPersist(System.IAsyncResult)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache.endpersist(v=VS.95)
ms:contentKeyID: 46307667
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.EndPersist
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.EndPersist
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ISmoothStreamingCache.EndPersist Method

A [AsyncCallback](https://msdn.microsoft.com/library/ckbe7yh5\(v=vs.95\)) delegate method to complete the operation started by the [BeginPersist](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Function EndPersist ( _
    ar As IAsyncResult _
) As Boolean
'Usage

Dim instance As ISmoothStreamingCache
Dim ar As IAsyncResult
Dim returnValue As Boolean

returnValue = instance.EndPersist(ar)
```

```csharp
bool EndPersist(
    IAsyncResult ar
)
```

```cpp
bool EndPersist(
    IAsyncResult^ ar
)
```

``` fsharp
abstract EndPersist : 
        ar:IAsyncResult -> bool 
```

```jscript
function EndPersist(
    ar : IAsyncResult
) : boolean
```

### Parameters

  - ar  
    Type: [System.IAsyncResult](https://msdn.microsoft.com/library/ft8a6455\(v=vs.95\))  
    An [IAsyncResult](https://msdn.microsoft.com/library/ft8a6455\(v=vs.95\)) object.

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
Returns true if successful, otherwise false.

## Examples

The following code shows an implementation of the EndPersist(IAsyncResult) method.

``` 
    public bool EndPersist(IAsyncResult ar)
    {
        ar.AsyncWaitHandle.WaitOne();

        if (((CacheAsyncResult)ar).Result != null)
        {
            IsolatedStorageFile isoFileArea = IsolatedStorageFile.GetUserStoreForApplication();

            if (((CacheResponse)(((CacheAsyncResult)ar).Result)).Response.Length < isoFileArea.AvailableFreeSpace)
            {
                string fileGuid = Guid.NewGuid().ToString();
 
                if (!keyUrls.ContainsValue(fileGuid) && !keyUrls.ContainsKey(((CacheAsyncResult)ar).strUrl))
                {
                        
                    IsolatedStorageFileStream isoFile = isoFileArea.CreateFile(fileGuid);

                    ((CacheResponse)(((CacheAsyncResult)ar).Result)).WriteTo(isoFile);
                    isoFile.Close(); 

                    keyUrls.Add(((CacheAsyncResult)ar).strUrl, fileGuid);
                    // Save key/value pairs for playback after application restarts.
                    IsolatedStorageSettings.ApplicationSettings.Add(((CacheAsyncResult)ar).strUrl, fileGuid);
                    IsolatedStorageSettings.ApplicationSettings.Save();

                    return true;
                }
            }
        }
        return false;
    }
```

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ISmoothStreamingCache Interface](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

