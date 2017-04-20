'  File: AddMimeTypes2.vbs 
'  Copyright Microsoft Corp. 2010 
' 
'  This script adds the following Mime types to the root of a local or remote 
'  server. 
' 
'    (0) .svg    image/svg+xml
'    (1) .xht    application/xhtml+xml
'    (2) .xhtml  application/xhtml+xml
'
'  Usage: 
'      cscript AddMimeTypes.vbs [RemoteServerName]
'
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
OPTION EXPLICIT
DIM strServer, objWMIService, objOperatingSystem, colOperatingSystems
DIM osVersion, iisVersion, objMimeMap, objMimeTypes, Mime, i 
DIM objShell, strInetsrvDir, strInetpubScriptsDir
DIM numMimeTypes, numExistingMimes, mimeExists(2)
CONST ADS_PROPERTY_UPDATE = 2
IF WScript.Arguments.Length = 1 THEN
    strServer = WScript.Arguments( 0 )
ELSE
    strServer = "."
END IF
iisVersion = "0"
' What version of Windows and IIS am I using? If I am on IIS 5.x/6 use adsutil.vbs
' If I am on IIS 7 and later use appcmd
SET objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}" _
    + "!\\" + strServer + "\root\cimv2")
SET colOperatingSystems = _
    objWMIService.ExecQuery("Select * from Win32_OperatingSystem")
FOR EACH objOperatingSystem IN colOperatingSystems
    osVersion = objOperatingSystem.Version
    strInetsrvDir = objOperatingSystem.SystemDirectory + "\inetsrv"
    strInetpubScriptsDir = objOperatingSystem.SystemDrive _
        + "\inetpub\AdminScripts"
NEXT    
IF ( 0 = Strcomp(strServer,".") ) THEN
    strServer = "localhost"
END IF
i = InStr(osVersion,"6.")
IF ( i = 1 ) THEN 
    iisVersion = "7"
END IF
i = InStr(osVersion,"5.")    
IF ( i = 1 ) THEN 
    iisVersion = "5"
END IF
i = InStr(osVersion,"5.2")    
IF ( i = 1 ) THEN 
    iisVersion = "6"
END IF
SET objShell = WScript.CreateObject("WScript.Shell")
SELECT CASE iisVersion
    CASE "7" 
        ' Run appcmd
        objShell.Run(strInetsrvDir + _
        "\appcmd.exe set config -section:system.webServer/staticContent /+_""[fileExtension='.svg',mimeType='image/svg%2Bxml']""")
        objShell.Run(strInetsrvDir + _
        "\appcmd.exe set config -section:system.webServer/staticContent /+""[fileExtension='.xht',mimeType='application/xhtml%2Bxml']""")
        objShell.Run(strInetsrvDir + _
        "\appcmd.exe set config -section:system.webServer/staticContent /+""[fileExtension='.xhtml',mimeType='application/xhtml%2Bxml']""")
        
    CASE "6", "5"
        ' Use ADSI to add the MIME types. 
        ' Can't use adsutil because they will destructively overwrite instead of appending
        SET objMimeMap = GetObject( "IIS://" + strServer + "/MimeMap" )
        objMimeTypes = objMimeMap.GetEx("MimeMap")
        ' Check to see if the MIME types already exist
        mimeExists(0)=0
        mimeExists(1)=0
        mimeExists(2)=0
        numExistingMimes=0
        CheckIfMimeTypeExists(objMimeMap)
        numExistingMimes=mimeExists(0)+mimeExists(1)+mimeExists(2)
        IF ( 3 = numExistingMimes ) THEN
            WScript.Echo("All extensions currently have mime types registered. Complete.")
            WScript.Quit
        END IF
        ' For extensions that don't have registered MIME types, add them
        numMimeTypes = UBound(objMimeTypes)
        REDIM PRESERVE objMimeTypes(numMimeTypes+3-numExistingMimes)
        i = numMimeTypes+1
        IF ( 0 = mimeExists(0) ) THEN
            SET objMimeTypes(i) = CreateObject("MimeMap")
            objMimeTypes(i).Extension = ".svg"
            objMimeTypes(i).MimeType = "image/svg+xml"
            i = i+1
        ELSE
            WScript.Echo("Mime type for .svg already exists")
        END IF
        IF ( 0 = mimeExists(1) ) THEN
            SET objMimeTypes(i) = CreateObject("MimeMap")
            objMimeTypes(i).Extension = ".xht"
            objMimeTypes(i).MimeType = "application/xhtml+xml"
            i=i+1
        ELSE
            WScript.Echo("Mime type for .xht already exists")
        END IF    
        IF ( 0 = mimeExists(2) ) THEN
            SET objMimeTypes(i) = CreateObject("MimeMap")
            objMimeTypes(i).Extension = ".xhtml"
            objMimeTypes(i).MimeType = "application/xhtml+xml"
        ELSE
            WScript.Echo("Mime type for .xhtml already exists")    
        END IF
            
        objMimeMap.PutEx ADS_PROPERTY_UPDATE, "MimeMap", objMimeTypes 
        objMimeMap.SetInfo()
    CASE ELSE
        WScript.Echo("Unsupported IIS version")
END SELECT

SUB CheckIfMimeTypeExists(MimeMap)
    objMimeTypes = MimeMap.GetEx("MimeMap")
    FOR EACH Mime IN objMimeTypes
        SELECT CASE LCase(Mime.Extension)
            CASE ".svg"
                mimeExists(0) = 1
            CASE ".xht"
                mimeExists(1) = 1
            CASE ".xhtml"
                mimeExists(2) = 1
        END SELECT
    NEXT  
END SUB