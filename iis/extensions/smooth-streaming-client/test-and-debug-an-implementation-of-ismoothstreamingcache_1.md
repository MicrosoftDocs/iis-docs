---
title: Test and Debug an Implementation of ISmoothStreamingCache
TOCTitle: Test and Debug an Implementation of ISmoothStreamingCache
ms:assetid: 84c92472-1f5c-4763-ab21-93f264951129
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Gg296363(v=VS.95)
ms:contentKeyID: 46359321
ms.date: 05/31/2012
mtps_version: v=VS.95
---

# Test and Debug an Implementation of ISmoothStreamingCache

Testing and debugging an implementation of [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) requires monitoring both the data transferred from the IIS server that delivers media data and monitoring data storage on the client computer. You can use the Visual Studio debugger to get information about data transfer and storage. For more information about the debugger and related tools, see [Test and Debug Applications](test-and-debug-applications.md), [Process Explorer](http://go.microsoft.com/fwlink/?linkid=251078), and [Fiddler Web Debugging Proxy](http://go.microsoft.com/fwlink/?linkid=251077).

## Data Transfer and Storage

An implementation of [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) gets data from an IIS server and stores it on the client computer using isolated storage (an instance of System.IO.IsolatedStorage.IsolatedStorage). To find out if a cache implementation is working, you have to be able to monitor data responses from the IIS server. When the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) requests a manifest or media stream, the client application first checks the cache. If the cache has the data, the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) uses cached data and does not download it from the IIS server.

### Monitoring Data Transfer

To monitor the data coming from the server, you can use the [Fiddler Web Debugging Proxy tool](http://go.microsoft.com/fwlink/?linkid=251077). Fiddler registers requests made by the client to the server and responses from the server, which lets you see whether the application is getting data from the server or from the cache. It can be difficult to determine whether data is coming from the [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) implementation or from the browser cache. To clear the browser cache, use the browser's commands for deleting temporary files. (For example, in Internet Explorer, display the **Internet Options** dialog box and use the options under **Browsing history** to clear cached data.) Alternatively, use the equivalent options in Fiddler.

### Monitoring Data Storage

If you are testing using the Visual Studio Development Server or attaching to an application process with the debugger, you can find out where System.IO.IsolatedStorage.IsolatedStorage data is persisted on the client machine by setting a breakpoint after instantiating the storage area. In the sample described in [Cache Plug-in Implementation of ISmoothStreamingCache](cache-plug-in-implementation-of-ismoothstreamingcache_1.md), the isoFileArea variable contains an instance of System.IO.IsolatedStorage.IsolatedStorageIsolatedStorageFile. The instance contains a non-public member named m\_AppFilesPath that contains the path to isolated storage, which might look like the following:

C:\\\\Users\\\\\<user\>\\\\AppData\\\\LocalLow\\\\Microsoft\\\\Silverlight\\\\is\\\\siwpqwtx.ghf\\\\uebwgqqu.y1o\\\\1\\\\s\\\\ruirx0qntpbcitbe4gz01u2nspbj5sb3bewdo4z1wzlqbfbz35aaadba\\\\f

By watching this location as the application runs, you can verify that data is being stored in the cache or removed from it.

If you are using the cache implementation of [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) described in [Cache Plug-in Implementation of ISmoothStreamingCache](cache-plug-in-implementation-of-ismoothstreamingcache_1.md), you can use the debugger to watch the isoFileArea variable, which has public members named Quota, UsedSpace, and AvailableFreeSpace.

If the application is running outside the debugger, the path to isolated storage files can be obtained by using the [Process Explorer utility](http://technet.microsoft.com/en-us/sysinternals/bb896653.aspx).

The [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method gets the URL of each data chunk from the request parameter. The actual data of the request is obtained from the response parameter. The response is written to a file in isolated storage when the [EndPersist(IAsyncResult)](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md) method runs. If Fiddler is running, you can watch the requests that the application makes to the server and the results of the requests. After data has been persisted in the cache, subsequent requests to the server should not be made because the data is obtained by the [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) method from the cache. As noted, the browser might cache the data. Fiddler has a **Clear-Cache** option that can be used to clear the cache, or you can use the browser's commands to delete browsing history.

The isolated storage folder should contain one manifest file and a number of data files; the exact number depends on media bandwidth for each media selection. All the files are named using GUIDs. The files are tracked in a dictionary object and in the System.IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings property of the Silverlight application. When there is data in the cache, the URL/file name pairs are read into the dictionary object named keyUrls as the application starts.

If the capacity of the IsolatedStorage object's allocation is too low, there might not be enough capacity to store all the files for a lengthy media selection. A button that can be enabled in the XAML source to increase the quota by calling the System.IO.IsolatedStorage.IsolatedStorageFile.IncreaseQuotaTo method. The method increases the quota by 1 megabyte each time the button is clicked. There is no equivalent method available in the API that can be used to reduce the quota. To reduce the quota, you have to delete the storage and reinitialize it.

The quantities to watch are the values of System.IO.IsolatedStorage.IsolatedStorageFile.UsedSize and System.IO.IsolatedStorage.IsolatedStorageFile.AvailableFreeSpace. Calling System.IO.IsolatedStorage.IsolatedStorageFile.DeleteFile on each file in isolated storage will clear data that has been persisted by the [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) implementation. The clear-cache method also clears the dictionary object and the System.IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings instance that contains URL/file name pairs used to track files in the cache. When the cache is cleared, the System.IO.IsolatedStorage.IsolatedStorageFile.UsedSize and System.IO.IsolatedStorage.IsolatedStorageFile.AvailableFreeSpace members will adjust accordingly.

You can also remove isolated-storage capacity from the Silverlight UI. The Silverlight configuration dialog box provides the option to delete the isolated storage. In the **Application Storage** tab of the dialog box, delete the quota for the appropriate Web site.


> [!NOTE]  
> On playback, the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) instance can ignore cache requests that take too long to process. Data will be retrieved from the server but persisted in the cache for future requests.


## See Also

#### Concepts

[Cache Plug-in Implementation of ISmoothStreamingCache](cache-plug-in-implementation-of-ismoothstreamingcache_1.md)

#### Other Resources

[System.IO.IsolatedStorage Namespace](http://go.microsoft.com/fwlink/?linkid=204798)

