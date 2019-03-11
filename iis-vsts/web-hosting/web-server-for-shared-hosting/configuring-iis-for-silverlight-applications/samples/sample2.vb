Const ADS_PROPERTY_UPDATE = 2  
'
if WScript.Arguments.Count < 2 then
 WScript.Echo "Usage: " + WScript.ScriptName + " extension mimetype"
 WScript.Quit
end if 
'
'Get the mimemap object.  
Set MimeMapObj = GetObject("IIS://LocalHost/MimeMap")  
'
'Get the mappings from the MimeMap property.  
aMimeMap = MimeMapObj.GetEx("MimeMap")  
'
' Add a new mapping.  
i = UBound(aMimeMap) + 1  
Redim Preserve aMimeMap(i)  
Set aMimeMap(i) = CreateObject("MimeMap")  
aMimeMap(i).Extension = WScript.Arguments(0)  
aMimeMap(i).MimeType = WScript.Arguments(1)  
MimeMapObj.PutEx ADS_PROPERTY_UPDATE, "MimeMap", aMimeMap  
MimeMapObj.SetInfo  
'
WScript.Echo "MimeMap successfully added: "
WScript.Echo "    Extension: " + WScript.Arguments(0)
WScript.Echo "    Type:      " + WScript.Arguments(1)