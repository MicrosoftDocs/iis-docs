---
title: ManifestPropertiesDictionary Class (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestPropertiesDictionary Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestpropertiesdictionary(v=VS.90)
ms:contentKeyID: 35520691
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ManifestPropertiesDictionary Class

Provides properties that can be used for task definitions and job templates. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  [System.Collections.Generic.Dictionary](https://msdn.microsoft.com/library/xfhwa508)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
    Microsoft.Web.Media.TransformManager..::..ManifestPropertiesDictionary  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<CollectionDataContractAttribute> _
Public Class ManifestPropertiesDictionary _
    Inherits Dictionary(Of String, ManifestProperty)
'Usage

  Dim instance As ManifestPropertiesDictionary
```

```csharp
[CollectionDataContractAttribute]
public class ManifestPropertiesDictionary : Dictionary<string, ManifestProperty>
```

```cpp
[CollectionDataContractAttribute]
public ref class ManifestPropertiesDictionary : public Dictionary<String^, ManifestProperty^>
```

``` fsharp
[<CollectionDataContractAttribute>]
type ManifestPropertiesDictionary =  
    class
        inherit Dictionary<string, ManifestProperty>
    end
```

```jscript
  public class ManifestPropertiesDictionary extends Dictionary<String, ManifestProperty>
```

The ManifestPropertiesDictionary type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestPropertiesDictionary() () () ()](manifestpropertiesdictionary-constructor-microsoft-web-media-transformmanager_1.md)|Initializes a new instance of the ManifestPropertiesDictionary class.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ManifestPropertiesDictionary(XElement)](manifestpropertiesdictionary-constructor-xelement-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ManifestPropertiesDictionary class using the specified properties.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Comparer](https://msdn.microsoft.com/library/ms132092)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Count](https://msdn.microsoft.com/library/zhcy256f)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Item](https://msdn.microsoft.com/library/9tee9ht2)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Keys](https://msdn.microsoft.com/library/yt2fy5zk)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Namespace](manifestpropertiesdictionary-namespace-property-microsoft-web-media-transformmanager.md)|Gets or sets the value from the namespace attribute of the XML element.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Prefix](manifestpropertiesdictionary-prefix-property-microsoft-web-media-transformmanager.md)|Gets or sets the value from the prefix attribute of the XML element.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Values](https://msdn.microsoft.com/library/ekcfxy3x)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Add](https://msdn.microsoft.com/library/k7z0zy8k)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Clear](https://msdn.microsoft.com/library/b5txwy7s)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ContainsKey](https://msdn.microsoft.com/library/kw5aaea4)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ContainsValue](https://msdn.microsoft.com/library/a63811ah)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetEnumerator](https://msdn.microsoft.com/library/9c6ftx8b)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|GetObjectData|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|OnDeserialization|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Remove](https://msdn.microsoft.com/library/kabs04ac)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[TryGetValue](https://msdn.microsoft.com/library/bb347013)|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|

## Fields

||Name|Description|
|--- |--- |--- |
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[PropertiesElementName](manifestpropertiesdictionary-propertieselementname-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used with task definitions and job templates. The value is "properties".|


## Explicit Interface Implementations

||Name|Description|
|--- |--- |--- |
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|ICollection< (Of < <' (KeyValuePair< (Of < <' (TKey, TValue> ) > > )> ) > > ).Add|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|IDictionary.Add|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|ICollection< (Of < <' (KeyValuePair< (Of < <' (TKey, TValue> ) > > )> ) > > ).Contains|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|IDictionary.Contains|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|ICollection< (Of < <' (KeyValuePair< (Of < <' (TKey, TValue> ) > > )> ) > > ).CopyTo|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|ICollection.CopyTo|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|IEnumerable< (Of < <' (KeyValuePair< (Of < <' (TKey, TValue> ) > > )> ) > > ).GetEnumerator|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|IEnumerable.GetEnumerator|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|IDictionary.GetEnumerator|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|IDictionary.IsFixedSize|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|ICollection< (Of < <' (KeyValuePair< (Of < <' (TKey, TValue> ) > > )> ) > > ).IsReadOnly|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|IDictionary.IsReadOnly|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|ICollection.IsSynchronized|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|IDictionary.Item|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|IDictionary< (Of < <' (TKey, TValue> ) > > ).Keys|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|IDictionary.Keys|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|ICollection< (Of < <' (KeyValuePair< (Of < <' (TKey, TValue> ) > > )> ) > > ).Remove|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Hh145009.privmethod(en-us,VS.90).gif "Private method")|IDictionary.Remove|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|ICollection.SyncRoot|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|IDictionary< (Of < <' (TKey, TValue> ) > > ).Values|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|
|![Explicit interface implemetation](images/Ff729529.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Hh125593.privproperty(en-us,VS.90).gif "Private property")|IDictionary.Values|(Inherited from [Dictionary](https://msdn.microsoft.com/library/xfhwa508)< (Of < ( <'[String](https://msdn.microsoft.com/library/s1wwdcbf), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)> ) > ) >.)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

