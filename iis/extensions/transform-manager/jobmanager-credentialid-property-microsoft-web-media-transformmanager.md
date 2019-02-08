---
title: JobManager.CredentialId Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: CredentialId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.CredentialId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.credentialid(v=VS.90)
ms:contentKeyID: 35520896
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_CredentialId
- Microsoft.Web.Media.TransformManager.JobManager.CredentialId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.CredentialId
- Microsoft.Web.Media.TransformManager.JobManager.get_CredentialId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CredentialId Property

Gets a GUID that identifies the credential that is associated with this job definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property CredentialId As String
    Get
'Usage

  Dim instance As JobManager
Dim value As String

value = instance.CredentialId
```

``` csharp
  public string CredentialId { get; }
```

``` c++
  public:
property String^ CredentialId {
    String^ get ();
}
```

``` fsharp
  member CredentialId : string
```

``` jscript
  function get CredentialId () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The GUID that identifies the credential that is associated with this job definition.  

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

