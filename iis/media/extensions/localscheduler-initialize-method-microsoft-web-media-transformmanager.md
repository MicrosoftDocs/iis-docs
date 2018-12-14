---
title: LocalScheduler.Initialize Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.Initialize(System.String,Microsoft.Web.Media.TransformManager.Credential,System.String,System.Int32,System.Collections.Generic.Dictionary{System.String,System.String})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.initialize(v=VS.90)
ms:contentKeyID: 35520730
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.Initialize
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.Initialize
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Initialize Method

Sets the name, priority, and properties for this scheduler instance.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesSubInitialize ( _
    connectionStringAsString, _
    credentialAsCredential, _
    jobNameAsString, _
    priorityAsInteger, _
    propertiesAsDictionary(OfString, String) _
)
'Usage
DiminstanceAsLocalSchedulerDimconnectionStringAsStringDimcredentialAsCredentialDimjobNameAsStringDimpriorityAsIntegerDimpropertiesAsDictionary(OfString, String)

instance.Initialize(connectionString, _
    credential, jobName, priority, properties)
```

``` csharp
publicoverridevoidInitialize(
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
) override
```

``` fsharp
abstractInitialize : 
        connectionString:string * 
        credential:Credential * 
        jobName:string * 
        priority:int * 
        properties:Dictionary<string, string> ->unitoverrideInitialize : 
        connectionString:string * 
        credential:Credential * 
        jobName:string * 
        priority:int * 
        properties:Dictionary<string, string> ->unit
```

``` jscript
publicoverridefunctionInitialize(
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
    A list of properties to set.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/df5tffh6(v=vs.90)">DirectoryNotFoundException</a></td>
<td><p>The method was unable to find the root folder.</p></td>
</tr>
<tr class="even">
<td><a href="https://msdn.microsoft.com/en-us/library/dzyy5k3x(v=vs.90)">FileNotFoundException</a></td>
<td><p>The method was unable to find a file in the root folder.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

