---
title: DeploymentSyncParameterEntry.Match Property  (Microsoft.Web.Deployment)
TOCTitle: Match Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncParameterEntry.Match
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameterentry.match(v=VS.90)
ms:contentKeyID: 20208648
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterEntry.Match
- Microsoft.Web.Deployment.DeploymentSyncParameterEntry.get_Match
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterEntry.get_Match
- Microsoft.Web.Deployment.DeploymentSyncParameterEntry.Match
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Match Property

Gets a string used to determine if the entry matches the criteria of the provider.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyMatchAsString
'Usage
DiminstanceAsDeploymentSyncParameterEntryDimvalueAsStringvalue = instance.Match
```

``` csharp
publicstringMatch { get; }
```

``` c++
public:
propertyString^ Match {
    String^ get ();
}
```

``` jscript
function getMatch () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains match criteria.  

## Remarks

If this entry is an XmlFile()()()() or DeploymentAttribute, this value should be an XPath expression. If this entry is a TextFile()()()(), this value should be a regular expression. If this entry represents a TextFilePosition()()()(), this entry should be a positional parameter string matching the following specification.

line;col;countToReplace

All values must be text values that can be parsed as integers. Values may contain white space around the values. The following represents a valid positional parameter match value: "10;10;1".

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterEntry Class](deploymentsyncparameterentry-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

