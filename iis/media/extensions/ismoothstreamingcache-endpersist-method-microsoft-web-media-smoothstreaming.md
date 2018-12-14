﻿---
title: ISmoothStreamingCache.EndPersist Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: EndPersist Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.EndPersist(System.IAsyncResult)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache.endpersist(v=VS.90)
ms:contentKeyID: 31469250
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.EndPersist
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.EndPersist
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EndPersist Method

A [AsyncCallback](https://msdn.microsoft.com/en-us/library/ckbe7yh5\(v=vs.90\)) delegate method to complete the operation started by the [BeginPersist](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
FunctionEndPersist ( _
    arAsIAsyncResult _
) AsBoolean
'Usage
DiminstanceAsISmoothStreamingCacheDimarAsIAsyncResultDimreturnValueAsBooleanreturnValue = instance.EndPersist(ar)
```

``` csharp
boolEndPersist(
    IAsyncResultar
)
```

``` c++
boolEndPersist(
    IAsyncResult^ ar
)
```

``` jscript
functionEndPersist(
    ar : IAsyncResult
) : boolean
```

#### Parameters

  - ar  
    Type: [System. . :: . .IAsyncResult](https://msdn.microsoft.com/en-us/library/ft8a6455\(v=vs.90\))  
    An [IAsyncResult](https://msdn.microsoft.com/en-us/library/ft8a6455\(v=vs.90\)) object.  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
Returns true if successful, otherwise false.  

## Remarks

A [Silverlight IIS Smooth Streaming Offline Cache Sample](http://www.iis.net/community/default.aspx?tabid=34&g=6&i=2013) that demonstrates implementation of [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) is available on the IIS Website.

For documentation of the sample, see [Cache Plug-in Implementation of ISmoothStreamingCache](cache-plug-in-implementation-of-ismoothstreamingcache_1.md).

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

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ISmoothStreamingCache Interface](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
