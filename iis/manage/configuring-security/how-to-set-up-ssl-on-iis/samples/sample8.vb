'''''''''''''''''''''''''''''''''''''''''''''
' ADD SSL BINDING TO SITE
'''''''''''''''''''''''''''''''''''''''''''''

Set oBinding = oIIS.Get("BindingElement").SpawnInstance_
oBinding.BindingInformation = "*:443:"
oBinding.Protocol = "https"

Set oSite = oIIS.Get("Site.Name='Default Web Site'")
arrBindings = oSite.Bindings

ReDim Preserve arrBindings(UBound(arrBindings) + 1)
Set arrBindings(UBound(arrBindings)) = oBinding

oSite.Bindings = arrBindings
Set oPath = oSite.Put_