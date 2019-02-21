---
title: CircularList(T) Class (Microsoft.Web.Media.Diagnostics)
TOCTitle: CircularList(T) Class
ms:assetid: T:Microsoft.Web.Media.Diagnostics.CircularList`1
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ff728278(v=VS.90)
ms:contentKeyID: 31469297
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.CircularList`1
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.CircularList`1
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CircularList(T) Class

(Deprecated. Do not use) Implements a circular list. The caller defines maximum length when the list is constructed. When the list reaches the maximum, adding additional elements will cause the oldest element to be removed.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  [System.Collections.Generic.List](https://msdn.microsoft.com/library/6sh2ey19)\< (Of \< ( \<'T\> ) \> ) \>  
    Microsoft.Web.Media.Diagnostics..::..CircularList\<(Of \<(\<'T\>)\>)\>  

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class CircularList(Of T) _
    Inherits List(Of T)
'Usage

  Dim instance As CircularList(Of T)
```

```csharp
  public class CircularList<T> : List<T>
```

```cpp
  generic<typename T>
public ref class CircularList : public List<T>
```

```jscript
  JScript does not support generic types or methods.
```

#### Type Parameters

  - T  
    The type of this generic list.

The CircularList\<(Of \<(\<'T\>)\>)\> type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[CircularList< (Of < ( <'T> ) > ) >](circularlist-t-constructor-microsoft-web-media-diagnostics_1.md)|(Deprecated. Do not use) Initializes a new instance of the CircularList<(Of <(<'T>)>)> class.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Capacity](https://msdn.microsoft.com/library/y52x03h2)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Count](https://msdn.microsoft.com/library/27b47ht3)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Item](https://msdn.microsoft.com/library/0ebtbkkc)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Add](circularlist-t-add-method-microsoft-web-media-diagnostics_1.md)|(Deprecated. Do not use) Adds an object to the end of the CircularList<(Of <(<'T>)>)>.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[AddRange](https://msdn.microsoft.com/library/z883w3dc)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[AsReadOnly](https://msdn.microsoft.com/library/e78dcd75)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[BinarySearch(T)](https://msdn.microsoft.com/library/w4e7fxsh)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[BinarySearch(T, IComparer< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/ftfdbfx6)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[BinarySearch(Int32, Int32, T, IComparer< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/a1s5syxa)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Clear](https://msdn.microsoft.com/library/dwb5h52a)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Contains](https://msdn.microsoft.com/library/bhkz42b3)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ConvertAll< (Of < <' (TOutput> ) > > )](https://msdn.microsoft.com/library/73fe8cwf)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[CopyTo(array<T> [] () [] [])](https://msdn.microsoft.com/library/t69dktcd)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[CopyTo(array<T> [] () [] [], Int32)](https://msdn.microsoft.com/library/4df7xky9)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[CopyTo(Int32, array<T> [] () [] [], Int32, Int32)](https://msdn.microsoft.com/library/3eb2b9x8)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Exists](https://msdn.microsoft.com/library/bfed8bca)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Find](https://msdn.microsoft.com/library/x0b5b5bc)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[FindAll](https://msdn.microsoft.com/library/fh1w7y8z)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[FindIndex(Predicate< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/x1xzf2ca)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[FindIndex(Int32, Predicate< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/efasdh0s)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[FindIndex(Int32, Int32, Predicate< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/7eb596wz)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[FindLast](https://msdn.microsoft.com/library/5kthb929)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[FindLastIndex(Predicate< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/xzs5503w)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[FindLastIndex(Int32, Predicate< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/0b9t5061)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[FindLastIndex(Int32, Int32, Predicate< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/860a771k)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ForEach](https://msdn.microsoft.com/library/bwabdf9z)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetEnumerator](https://msdn.microsoft.com/library/b0yss765)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetRange](https://msdn.microsoft.com/library/21k0e39c)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IndexOf(T)](https://msdn.microsoft.com/library/e4w08k17)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IndexOf(T, Int32)](https://msdn.microsoft.com/library/s8t42k5w)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IndexOf(T, Int32, Int32)](https://msdn.microsoft.com/library/dy8zse0c)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Insert](https://msdn.microsoft.com/library/sey5k5z4)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[InsertRange](https://msdn.microsoft.com/library/884ee1fz)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[IsFull](circularlist-t-isfull-method-microsoft-web-media-diagnostics_1.md)|(Deprecated. Do not use) Boolean value that indicates whether the list is full.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[LastIndexOf(T)](https://msdn.microsoft.com/library/dsxfcba1)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[LastIndexOf(T, Int32)](https://msdn.microsoft.com/library/s088xd6w)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[LastIndexOf(T, Int32, Int32)](https://msdn.microsoft.com/library/haast0bw)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Remove](https://msdn.microsoft.com/library/cd666k3e)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[RemoveAll](https://msdn.microsoft.com/library/wdka673a)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[RemoveAt](https://msdn.microsoft.com/library/5cw9x18z)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[RemoveRange](https://msdn.microsoft.com/library/y33yd2b5)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Reverse() () () ()](https://msdn.microsoft.com/library/b0axc2h2)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Reverse(Int32, Int32)](https://msdn.microsoft.com/library/hf2ay11y)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Sort() () () ()](https://msdn.microsoft.com/library/b0zbh7b6)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Sort(IComparer< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/234b841s)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Sort(Comparison< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/w56d4y5z)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Sort(Int32, Int32, IComparer< (Of < <' (T> ) > > ))](https://msdn.microsoft.com/library/8ce6t5ad)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToArray](https://msdn.microsoft.com/library/x303t819)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TrimExcess](https://msdn.microsoft.com/library/ms132207)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TrueForAll](https://msdn.microsoft.com/library/kdxe4x4w)|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|


## Explicit Interface Implementations

||Name|Description|
|--- |--- |--- |
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IList.Add|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IList.Contains|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|ICollection.CopyTo|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IEnumerable< (Of < <' (T> ) > > ).GetEnumerator|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IEnumerable.GetEnumerator|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IList.IndexOf|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IList.Insert|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IList.IsFixedSize|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|ICollection< (Of < <' (T> ) > > ).IsReadOnly|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IList.IsReadOnly|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|ICollection.IsSynchronized|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IList.Item|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|IList.Remove|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|ICollection.SyncRoot|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19)< (Of < ( <'T> ) > ) >.)|


## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

