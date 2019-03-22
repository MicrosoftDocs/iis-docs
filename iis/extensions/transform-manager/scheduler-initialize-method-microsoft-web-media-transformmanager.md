---
title: Scheduler.Initialize Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.Initialize(System.String,Microsoft.Web.Media.TransformManager.Credential,System.String,System.Int32,System.Collections.Generic.Dictionary{System.String,System.String})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.scheduler.initialize(v=VS.90)
ms:contentKeyID: 35521123
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.Initialize
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.Initialize
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Initialize Method

Sets the properties for this scheduler instance.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Sub Initialize ( _
    connectionString As String, _
    credential As Credential, _
    jobName As String, _
    priority As Integer, _
    properties As Dictionary(Of String, String) _
)
'Usage

  Dim instance As Scheduler
Dim connectionString As String
Dim credential As Credential
Dim jobName As String
Dim priority As Integer
Dim properties As Dictionary(Of String, String)

instance.Initialize(connectionString, _
    credential, jobName, priority, properties)
```

```csharp
  public abstract void Initialize(
    string connectionString,
    Credential credential,
    string jobName,
    int priority,
    Dictionary<string, string> properties
)
```

```cpp
  public:
virtual void Initialize(
    String^ connectionString, 
    Credential^ credential, 
    String^ jobName, 
    int priority, 
    Dictionary<String^, String^>^ properties
) abstract
```

``` fsharp
  abstract Initialize : 
        connectionString:string * 
        credential:Credential * 
        jobName:string * 
        priority:int * 
        properties:Dictionary<string, string> -> unit 
```

```jscript
  public abstract function Initialize(
    connectionString : String, 
    credential : Credential, 
    jobName : String, 
    priority : int, 
    properties : Dictionary<String, String>
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string that is used to connect to the scheduler.  

<!-- end list -->

  - credential  
    Type: [Microsoft.Web.Media.TransformManager.Credential](credential-class-microsoft-web-media-transformmanager.md)  
    The [Credential](credential-class-microsoft-web-media-transformmanager.md) object that is required in order to access scheduler resources.  

<!-- end list -->

  - jobName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the job.  

<!-- end list -->

  - priority  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The priority of the job.  

<!-- end list -->

  - properties  
    Type: [System.Collections.Generic.Dictionary](https://msdn.microsoft.com/library/xfhwa508)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf), [String](https://msdn.microsoft.com/library/s1wwdcbf)\> ) \> ) \>  
    If the scheduler is an HPDC scheduler, a list of properties to set.  

## Remarks

The HPDC scheduler supports properties such as minimum CPUs (cores, nodes, or sockets), minimum memory, and node groups. The local scheduler does not support these properties.

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

