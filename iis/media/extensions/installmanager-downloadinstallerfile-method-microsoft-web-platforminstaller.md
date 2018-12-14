---
title: InstallManager.DownloadInstallerFile Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: DownloadInstallerFile Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.InstallManager.DownloadInstallerFile(Microsoft.Web.PlatformInstaller.InstallerContext,System.String@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installmanager.downloadinstallerfile(v=VS.90)
ms:contentKeyID: 22049747
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallManager.DownloadInstallerFile
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallManager.DownloadInstallerFile
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DownloadInstallerFile Method

Downloads the installer file using the current installer context.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionDownloadInstallerFile ( _
    currentInstallAsInstallerContext, _
    <OutAttribute> ByReffailureReasonAsString _
) AsBoolean
'Usage
DiminstanceAsInstallManagerDimcurrentInstallAsInstallerContextDimfailureReasonAsStringDimreturnValueAsBooleanreturnValue = instance.DownloadInstallerFile(currentInstall, _
    failureReason)
```

``` csharp
publicboolDownloadInstallerFile(
    InstallerContextcurrentInstall,
    outstringfailureReason
)
```

``` c++
public:
boolDownloadInstallerFile(
    InstallerContext^ currentInstall, 
    [OutAttribute] String^% failureReason
)
```

``` jscript
publicfunctionDownloadInstallerFile(
    currentInstall : InstallerContext, 
    failureReason : String
) : boolean
```

#### Parameters

  - currentInstall  
    Type: [Microsoft.Web.PlatformInstaller. . :: . .InstallerContext](installercontext-class-microsoft-web-platforminstaller.md)  
    An [InstallerContext](installercontext-class-microsoft-web-platforminstaller.md) instance that contains information about the installation file to download and associated context.  

<!-- end list -->

  - failureReason  
    Type: String%  
    Upon failure, this value contains a description of the reason for the download failure.  

#### Return Value

Type: Boolean  
true if the download completed successfully, otherwise false. Additionally, if this method returns false, the failureReason parameter contains a description of the reason for the failure.  

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
<td>[ArgumentNullException]</td>
<td><p>currentInstall is null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic)</p></td>
</tr>
<tr class="even">
<td>[InvalidOperationException]</td>
<td><p>currentInstall.Installer or currentInstall.Installer.InstallerFile is null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic)</p></td>
</tr>
</tbody>
</table>


## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallManager Class](installmanager-class-microsoft-web-platforminstaller.md)

[InstallManager Members](installmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

