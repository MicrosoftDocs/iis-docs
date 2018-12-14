---
title: JobDefinition.CredentialId Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: CredentialId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.CredentialId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.credentialid(v=VS.90)
ms:contentKeyID: 35520921
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.CredentialId
- Microsoft.Web.Media.TransformManager.JobDefinition.set_CredentialId
- Microsoft.Web.Media.TransformManager.JobDefinition.get_CredentialId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.CredentialId
- Microsoft.Web.Media.TransformManager.JobDefinition.get_CredentialId
- Microsoft.Web.Media.TransformManager.JobDefinition.set_CredentialId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CredentialId Property

Gets or sets a GUID that identifies the credential that is associated with this job definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyCredentialIdAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.CredentialId

instance.CredentialId = value
```

``` csharp
[DataMemberAttribute]
publicstringCredentialId { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ CredentialId {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberCredentialId : stringwithget, set
```

``` jscript
function getCredentialId () : Stringfunction setCredentialId (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The GUID that identifies the credential that is associated with this job definition.  

## Remarks

The credential is used by the job manager to access resources for jobs.

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

