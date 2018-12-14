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
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.Initialize
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Initialize Method

Sets the properties for this scheduler instance.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideSubInitialize ( _
    connectionStringAsString, _
    credentialAsCredential, _
    jobNameAsString, _
    priorityAsInteger, _
    propertiesAsDictionary(OfString, String) _
)
'Usage
DiminstanceAsSchedulerDimconnectionStringAsStringDimcredentialAsCredentialDimjobNameAsStringDimpriorityAsIntegerDimpropertiesAsDictionary(OfString, String)

instance.Initialize(connectionString, _
    credential, jobName, priority, properties)
```

``` csharp
publicabstractvoidInitialize(
    stringconnectionString,
    Credentialcredential,
    stringjobName,
    intpriority,
    Dictionary<string, string> properties
)
```

``` c++
public:
virtualvoidInitialize(
    String^ connectionString, 
    Credential^ credential, 
    String^ jobName, 
    intpriority, 
    Dictionary<String^, String^>^ properties
) abstract
```

``` fsharp
abstractInitialize : 
        connectionString:string * 
        credential:Credential * 
        jobName:string * 
        priority:int * 
        properties:Dictionary<string, string> ->unit
```

``` jscript
publicabstractfunctionInitialize(
    connectionString : String, 
    credential : Credential, 
    jobName : String, 
    priority : int, 
    properties : Dictionary<String, String>
)
```

#### Parameters

  - connectionString  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string that is used to connect to the scheduler.  

<!-- end list -->

  - credential  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .Credential](credential-class-microsoft-web-media-transformmanager.md)  
    The [Credential](credential-class-microsoft-web-media-transformmanager.md) object that is required in order to access scheduler resources.  

<!-- end list -->

  - jobName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the job.  

<!-- end list -->

  - priority  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The priority of the job.  

<!-- end list -->

  - properties  
    Type: [System.Collections.Generic. . :: . .Dictionary](https://msdn.microsoft.com/en-us/library/xfhwa508\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\)), [String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\> ) \> ) \>  
    If the scheduler is an HPDC scheduler, a list of properties to set.  

## Remarks

The HPDC scheduler supports properties such as minimum CPUs (cores, nodes, or sockets), minimum memory, and node groups. The local scheduler does not support these properties.

## See Also

#### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

