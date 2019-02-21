---
title: Cache Plug-in Implementation of ISmoothStreamingCache
TOCTitle: Cache Plug-in Implementation of ISmoothStreamingCache
ms:assetid: 6f24c4c0-5aef-4f24-ba9f-d0ed902e68a7
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Gg296362(v=VS.90)
ms:contentKeyID: 32879083
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- csharp
---

# Cache Plug-in Implementation of ISmoothStreamingCache

The IIS Smooth Streaming Client provides the [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) interface to support offline scenarios. An implementation of the cache is started by assigning it to the [SmoothStreamingCache](smoothstreamingmediaelement-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) class. When the cache is started and the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance downloads a manifest or data chunk, the [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) and [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) methods provide options to save data for future use and to use cached data instead of downloading from the network. When the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance requires a chunk or manifest, it first calls [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) to determine whether the assigned cache has the data. If the cache has the data, a data chunk from the cache is used. Otherwise, the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance downloads the data using HTTP. After the response is downloaded, the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance calls [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) to save the downloaded chunk.

The cache implementation is independent of any particular codec requirements. The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance makes the same requests to the cache that it would to the IIS server. A cache implementation can have a downloader that reads the client manifest and mimics the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object by making requests to the server and storing the responses in the cache. When the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance makes requests to the cache, the cache responds with the pre-downloaded data that has been serialized in the cache.

## Implementation of ISmoothStreamingCache

This topic shows how to create an class that implements the [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) interface for IIS Smooth Streaming Client offline scenarios. A downloadable version of this code is available from the IIS.net Web site: [Silverlight IIS Smooth Streaming Offline Cache Sample](http://go.microsoft.com/fwlink/?linkid=204769). The application persists data in an instance of System.IO.IsolatedStorage.IsolatedStorage and uses URL/file name pairs in the IsolatedStorageSettings.ApplicationSettings object to track manifests and data chunks that have been saved to the cache. The URL/file name pairs stored in the IsolatedStorageSettings.ApplicationSettings object are read into a dictionary object when the cache is instantiated, and the dictionary pairs are used to identify data files in the cache.

The sample demonstrates implementations of the four methods of [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md):

  - [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md)

  - [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md)

  - [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md)

  - [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md)

When an [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) object is started and a request for data is issued, the Silverlight Smooth Streaming Client will call each of the methods in the order: BeginRetrieve, EndRetrieve, BeginPersist, EndPersist.

On the first pass, before the cache has any data, the calls to [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) and [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) return a null [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) object. The application then calls [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) to cache the data for future use as required for the offline scenario. The [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md) method parses the response data returned from the server, and if there is enough available storage, the data is stored in an System.IO.IsolatedStorage.IsolatedStorage instance.

If [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) and [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md) have previously run successfully, the cache will already have data when a request is made. Instead of making a call to the IIS server, [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) processes (and [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) returns) a non-null [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) object to be played back by the application instance of [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md).

The following code shows a complete implementation of the class that implements [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md). The code is discussed in sections that follow the example.

```csharp
    public class ISO_StorageCache : ISmoothStreamingCache
    {
        // Dictionary to track URL/filename pairs of data in cache.
        public Dictionary<string, string> keyUrls = new Dictionary<string, string>(50);

        public ISO_StorageCache()
        {
            IsolatedStorageFile isoFileArea = IsolatedStorageFile.GetUserStoreForApplication(); 

            foreach (System.Collections.Generic.KeyValuePair<string, object> pair in IsolatedStorageSettings.ApplicationSettings)
            {
                if (!keyUrls.ContainsValue((string)pair.Value) && isoFileArea.FileExists((string)pair.Value))
                    keyUrls.Add(pair.Key, ((string)pair.Value));
            }
        }

        public IAsyncResult BeginRetrieve(CacheRequest request, AsyncCallback callback, object state)
        {
            CacheResponse response = null;
            CacheAsyncResult ar = new CacheAsyncResult();
            ar.strUrl = request.CanonicalUri.ToString();
            ar.Complete(response, true);
            return ar; 
        }        

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

        public IAsyncResult BeginPersist(CacheRequest request, CacheResponse response, AsyncCallback callback, object state)
        {
            state = false;
            CacheAsyncResult ar = new CacheAsyncResult();

            if (!keyUrls.ContainsKey(request.CanonicalUri.ToString()))
            {
                //state = true;
                ar.strUrl = request.CanonicalUri.ToString();
                ar.Complete(response, true);
                return ar;
            }

            ar.Complete(null, true);
            return ar;
        }

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
    }
```

### BeginRetrieve Method

The following code shows the implementation of [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) used by this cache implementation.

```csharp
public IAsyncResult BeginRetrieve(CacheRequest request, AsyncCallback callback, object state)
{
    CacheResponse response = null;
    CacheAsyncResult ar = new CacheAsyncResult();
    ar.strUrl = request.CanonicalUri.ToString();
    ar.Complete(response, true);
    return ar; 
}
```

The request parameter of the [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) method contains the URL that the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance has requested. In order for the method to retrieve a data file from the cache, this URL has to match a key in the keysUrls member variable. The keysUrls member is a dictionary object that contains the URLs and file names used to track data files in the cache. The code in [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) assigns the URL of the request to the strURL member of an instance of CacheAsynResult so that it can be passed to [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md). If the URL matches a key in the keysUrls dictionary, the [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) method gets the corresponding data file. The CacheAsyncResult class implements \[T:System:IAsyncResult\] for this application. For more information about CacheAsyncResult, see [IAsyncResult Implementation](cache-plug-in-implementation-of-ismoothstreamingcache_1.md) later in this document.

### EndRetrieve Method

The [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) method gets the URL of the request from the CacheAsyncResult instance returned by [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md). It is important to wait for [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) to complete before processing the data, as shown by the call to ar.AsyncWaitHandle.WaitOne. If there is data, it will be returned to the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance. If the cache does not have the data, [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) returns a [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) instance and a System.Net.HttpStatusCode.NotFound value, as shown at the end of the following implementation of [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md).

```csharp
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

The first time [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) and [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) are called, the cache will not contain data, and the block of code contained by the first if statement of the [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) method is skipped. The [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) object will remain null, and [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) will return an empty [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) object with a System.Net.HttpStatusCode.NotFound exception.

If the cache contains data for the requested media chunk or manifest, the value in strUrl will match one of the URL/file name pairs in the keyUrls dictionary object. When processing enters the first if block, data is persisted as shown in the discussion of [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md) later in this document.

Silverlight applications use the System.IO.IsolatedStorage.IsolatedStorage class to persist application data because online applications do not have read/write access to storage on users’ computers. The code gets the storage area and file that contain the data identified by the keyUrls\[((CacheAsyncResult)ar).strUrl\] value. Casting is required in order to get the URL string from the asynchronous result.

Code in the second if block verifies that the file name matches an existing file in isolated storage. When this block runs, the code reads the System.IO.IsolatedStorage.IsolatedStorageFileStream object into a new [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) object named response.

After the code in the second if block runs, the [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) object (response) contains data, and the method returns the response object to the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance either as manifest information or as an audio or video chunk.

### BeginPersist Method

The [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method begins the process that adds data to the cache. When an implementation of [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) is assigned to the [SmoothStreamingCache](smoothstreamingmediaelement-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object, the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object calls the [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method right after calling the [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) method.

```csharp
    public IAsyncResult BeginPersist(CacheRequest request, CacheResponse response, AsyncCallback callback, object state)
    {
        CacheAsyncResult ar = new CacheAsyncResult();
        state = false;

        if (!keyUrls.ContainsKey(request.CanonicalUri.ToString()))
        {
            state = true;
            ar.strUrl = request.CanonicalUri.ToString();
            ar.Complete(response, (bool)state);
            return ar;
        }

        ar.Complete(null, true);
        return ar;
    }
```

This implementation of [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) creates a new instance of CacheAsyncResult that will be passed to [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md). If the request.CanonicalUri value does not match a key in the dictionary of URLs already in the cache, the URL is assigned to the strUrl property of the CacheAsyncResult object and returned to be processed further by [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md).

The response parameter of [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) contains the data to persist. This data is supplied as the first argument of the CacheAsyncResult.Complete method. The second argument is null because the [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method is always called synchronously by [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md).

### EndPersist Method

The [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md) method waits for the [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method to complete. Both [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) and [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md) are blocking calls. You can call them at any time and they return only when the operation is completed.

The first if condition determines whether the CacheAsyncResult contains data. If it does, the next line of code gets the System.IO.IsolatedStorage.IsolatedStorageFile object named isoFileArea with which the application persists data.

```csharp
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

The values in the second if block require casting to get the length of the response data (((CacheResponse)(((CacheAsyncResult)ar).Result)).Response.Length). If the response data fits in the application's isolated storage area, a new IsolatedStorage.IsolatedStorageFileStream object is created and assigned a name using a GUID in order to ensure uniqueness. The code opens an IsolatedStorage.IsolatedStorageFileStream instance and writes the response data to a file. A URL/file name pair is added to the keyUrls dictionary to identify the data for a subsequent call to the [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) method.

### IAsyncResult Implementation

The following code shows an implementation of [IAsyncResult](https://msdn.microsoft.com/library/ft8a6455). An instance of this class is passed from the [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) method to [EndRetrieve(IAsyncResult)](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md) and from the [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method to [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md).

``` 
    public class CacheAsyncResult : IAsyncResult
    {
        public string strUrl { get; set; }

        public object AsyncState { get; private set; }

        public WaitHandle AsyncWaitHandle { get { return _completeEvent; } }

        public bool CompletedSynchronously { get; private set; }

        public bool IsCompleted { get; private set; }

        // Contains the output result of the GetChunk API
        public Object Result { get; private set; }

        internal TimeSpan Timestamp { get; private set; }

        // Callback function when GetChunk is completed. Used in asynchronous mode only.
        // Null for synchronous mode.
        private AsyncCallback _callback;

        // Event is used to signal the completion of the operation
        private ManualResetEvent _completeEvent = new ManualResetEvent (false);

        // Called when the operation is completed
        public void Complete(Object result, bool completedSynchronously)
        {
            Result = result;
            CompletedSynchronously = completedSynchronously;

            IsCompleted = true;
            _completeEvent.Set();

            if (null != _callback) { ;  }
        }
```

For the complete application that demonstrates how to use this implementation of [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md), you can download the [Silverlight IIS Smooth Streaming Offline Cache Sample](http://code.msdn.microsoft.com/smoothstreaming/release/projectreleases.aspx?releaseid=3867) from the Code Gallery Web site.

## See Also

### Concepts

[Test and Debug an Implementation of ISmoothStreamingCache](test-and-debug-an-implementation-of-ismoothstreamingcache_1.md)

### Other Resources

[System.IO.IsolatedStorage Namespace](http://go.microsoft.com/fwlink/?linkid=204798)

