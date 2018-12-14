---
title: RewriteTemplateFeature.ShowMessage Method (String, String, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton) (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: ShowMessage Method (String, String, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton)
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ShowMessage(System.String,System.String,System.Windows.Forms.MessageBoxButtons,System.Windows.Forms.MessageBoxIcon,System.Windows.Forms.MessageBoxDefaultButton)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.showmessage(v=VS.90)
ms:contentKeyID: 46408206
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ShowMessage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ShowMessage Method (String, String, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton)

Shows a message box with the features specified by the parameters.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
ProtectedFunctionShowMessage ( _
    textAsString, _
    captionAsString, _
    buttonsAsMessageBoxButtons, _
    iconAsMessageBoxIcon, _
    defaultButtonAsMessageBoxDefaultButton _
) AsDialogResult
'Usage
DimtextAsStringDimcaptionAsStringDimbuttonsAsMessageBoxButtonsDimiconAsMessageBoxIconDimdefaultButtonAsMessageBoxDefaultButtonDimreturnValueAsDialogResultreturnValue = Me.ShowMessage(text, _
    caption, buttons, icon, defaultButton)
```

``` csharp
protectedDialogResultShowMessage(
    stringtext,
    stringcaption,
    MessageBoxButtonsbuttons,
    MessageBoxIconicon,
    MessageBoxDefaultButtondefaultButton
)
```

``` c++
protected:
DialogResultShowMessage(
    String^ text, 
    String^ caption, 
    MessageBoxButtonsbuttons, 
    MessageBoxIconicon, 
    MessageBoxDefaultButtondefaultButton
)
```

``` jscript
protectedfunctionShowMessage(
    text : String, 
    caption : String, 
    buttons : MessageBoxButtons, 
    icon : MessageBoxIcon, 
    defaultButton : MessageBoxDefaultButton
) : DialogResult
```

#### Parameters

  - text  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string value that contains the message box text.  

<!-- end list -->

  - caption  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string value that contains the message box caption.  

<!-- end list -->

  - buttons  
    Type: [System.Windows.Forms. . :: . .MessageBoxButtons](https://msdn.microsoft.com/en-us/library/a29zcz90\(v=vs.90\))  
    A [MessageBoxButtons](https://msdn.microsoft.com/en-us/library/a29zcz90\(v=vs.90\)) object that specifies the message box buttons.  

<!-- end list -->

  - icon  
    Type: [System.Windows.Forms. . :: . .MessageBoxIcon](https://msdn.microsoft.com/en-us/library/bathdwt4\(v=vs.90\))  
    A [MessageBoxIcon](https://msdn.microsoft.com/en-us/library/bathdwt4\(v=vs.90\)) object.  

<!-- end list -->

  - defaultButton  
    Type: [System.Windows.Forms. . :: . .MessageBoxDefaultButton](https://msdn.microsoft.com/en-us/library/tesaa7ka\(v=vs.90\))  
    A [MessageBoxDefaultButton](https://msdn.microsoft.com/en-us/library/tesaa7ka\(v=vs.90\)) object that specifies the message box default button.  

#### Return Value

Type: [System.Windows.Forms. . :: . .DialogResult](https://msdn.microsoft.com/en-us/library/5ahe29t9\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[ShowMessage Overload](rewritetemplatefeature-showmessage-method-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

